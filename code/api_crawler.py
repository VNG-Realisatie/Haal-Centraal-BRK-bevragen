#!/usr/bin/env python
from __future__ import print_function # nodig voor print functie die werkt in Python 3 en in Python 2
from functools import reduce

"""
Met dit script worden csv bestanden (die eerder zijn gemaakt met
sheet_generator.sh) gevuld met indicaties voor het voorkomen van een waarde voor
velden bij gevonden testgevallen.
Er wordt begonnen met testgevallen in {testcasesFilename} die de uri's bevat van
testgevallen. Vanuit deze berichten worden ook relaties in _links gevolgd om
gerelateerde testgevallen te onderzoeken.
De gegenereerde csv's kunnen worden ingelezen in bijvoorbeeld MS Excel. Elke rij
is een veld (property), elke kolom een testgeval. Wanneer in een kolom bij een
veld een "X" staat, heeft dit testgeval een waarde op dit veld, dus komt dit
veld (property) voor in de betreffende resource.

Command line arguments:
--config        bestand van projectspecifieke configuratie json bestand
--debug   -d    toon debug info
--info    -i    toon voortgang info
--help    -h    toon help op command line arguments

"""


import yaml, json
import re
import requests
import sys
import os.path
import config




def logLine(*logItems):  
    print (" ".join([str(item) for item in logItems]))
    logfile.write(" ".join([str(item) for item in logItems]) + '\n')


def callApi(uri):
    # send the request to uri and return the json response
    # uri   string      relative url, like "/resourcename/12345"
    # returns json object from response body

    response = requests.get(SETTINGS.get("baseUrl") + uri, headers=REQUEST_HEADERS)

    if response.status_code == 200:
        return response.json()
    else:
        logLine ("ERROR: request failed")
        logLine (uri, response.status_code, response.text)


def getOperationId(uri):
    # returns the operation id for the request taken from the request uri
    # uri   string      relative url, like "/resourcename/12345"

    for operationId in templates:
        if re.match(templates[operationId], uri) is not None:
            return operationId


def getValuesByPath(propertyName, propertyList, valueSource):
    value = valueSource.get(propertyName)

    if debug==True:
        logLine ("getValuesByPath:", propertyName, propertyList, "~~~> value:", value)

    if propertyList.index(propertyName)<(len(propertyList)-1):
        nextProperty = propertyList[propertyList.index(propertyName)+1]
    else:
        nextProperty = None

    if value is None:
        return []
    elif type(value)==type([]):
        valueList = []
        for valueItem in value:
            if nextProperty is not None:
                theValue = getValuesByPath(nextProperty, propertyList[propertyList.index(nextProperty):], valueItem)
                
                if type(theValue)==type([]):
                    valueList.extend(theValue)
                else:
                    valueList.append(theValue)
            else:
                valueList.append(valueItem)

        return valueList
    else:
        if nextProperty is not None:
            return getValuesByPath(nextProperty, propertyList[propertyList.index(nextProperty):], value)
        else:
            return value


def expandTemplatedUri(uri, response):
    if debug==True:
        logLine ("expandTemplatedUri:", uri)

    propertyValue=response
    while (uri.find('{')>-1):
        propertyPath = uri[uri.find('{')+1:uri.find('}')]
        propertyList = propertyPath.split(".")
        propertyValue = getValuesByPath(propertyList[0], propertyList, response)

        if type(propertyValue)==type([]):
            if len(propertyValue)==0:
                return None

            for valueItem in propertyValue:
                if debug==True:
                    logLine ("-- templated array:", uri, valueItem)

                addNewLink(uri.replace('{' + propertyPath + '}', valueItem), response)

            uri = uri.replace('{' + propertyPath + '}', valueItem)
        else:
            uri = uri.replace('{' + propertyPath + '}', propertyValue)

    return uri


def addNewLink(uri, response):
    if debug==True:
        logLine ("addNewLink", uri)

    if (uri.find('{')>-1):
        uri = expandTemplatedUri(uri, response)

    if uri not in links and uri is not None and not uri.startswith("http"):
        links.append(uri)
        if info==True:
            logLine ("-- Nieuw testgeval:", uri)
    #else:
    #    logLine ("------",expandedUri, "bestaat al")


def addLinks(propertyName, propertyValue, response):
    if propertyValue is None:
        logLine (propertyName,'has no value')
        return
    #logLine ("--", propertyName, propertyValue)

    if type(propertyValue)==type([]):
        for link in propertyValue:
            addNewLink(link.get('href'), response)
    else:
        addNewLink(propertyValue.get('href'), response)


def getPropertyFromLine(line):
    # get property name and type
    # line      string      a line from the sheet csv file, like "propertyname;;;value1;value2"
    # returns a dict with properties "name" and "type", line { "name": "propertyName", "type": "array" }
    # type is one of ["array", "object", "enum", "boolean", "property"]

    propertyName = line.lstrip(';')
    if propertyName.find('[{}]')>0:
        #property is an array of objects
        propertyName = propertyName[:propertyName.find('[{}]')]
        propertyType = 'array'
    elif propertyName.find('{}')>0:
        #property is an object
        propertyName = propertyName[:propertyName.find('{}')]
        propertyType = 'object'
    elif propertyName.find('()')>0:
        #property is an enumeration
        propertyName = propertyName[:propertyName.find('()')]
        propertyType = 'enum'
    elif propertyName.find('(?)')>0:
        #property is an enumeration
        propertyName = propertyName[:propertyName.find('(?)')]
        propertyType = 'boolean'
    elif propertyName.find('[]')>0:
        #property is an array
        propertyName = propertyName[:propertyName.find('[]')]
        propertyType = 'array'
    else:
        #property is a simple type
        propertyName = propertyName[:propertyName.find(';')]
        propertyType = 'property'

    return { "name": propertyName, "type": propertyType }


def getResponsePart(response, level, stack):
    """
    returns a property stack[level] as its value or object in the response

    response    dict        json object of the response body
    level       int         path level of the current property, line group.subgroup.property has level 2
    stack       list        all property names for the path to the current property, like ["group", "subgroup", "property"]
    """

    responsePart = response
    if level>0:
        for l in range (0, level):
            #logLine (l, stack[l])
            responsePart = responsePart.get(stack[l])
            if responsePart is None:
                break

            if type(responsePart)==type([]):
                # reduce the responsePart to one (1) item containing all properties that have a value in at least one of the items in the list
                # this will make sure that the sheet will show what properties of objects in a list have at least one value
                # this will not show if different items in the list have different enumeration values, only the first enumeration value found is shown
                responsePart = reduce(minimal_existing, responsePart)

    return responsePart


def minimal_existing (a0, a1):
    #if the first item doesn't have a property, but the second item does, then add this property to the first item

    for attr, value in a1.items():
        if not a0.has_key(attr):
            # if any of the items in the current item has a property not yet in the reduced dict, add that property to the reduced dict
            a0[attr] = value
    
    return a0


def setResponseValues(sheet, response, operationId, title):
    """
    Adds the response values in the sheet

    sheet           list        list (array) contain all responses for an operation
    response        dict        response json object
    operationId     string      operationId as defined in the OAS
    title           string      title for the response column
    """

    if debug==True:
        logLine ("setResponseValues", title)

    # stack is a list that is used to hold all properties in the path to a property being read at a time
    stack = [None] * SETTINGS.get("maxLevels")
    sheetFile = open(SETTINGS.get("projectFolder") + SETTINGS.get("sheetFolder") + operationId + ".csv", "w")

    #write title (identification from uri) in a new column at the end of the first line
    sheet[0] = sheet[0][:-1] + title + ';' + sheet[0][-1:]
    sheetFile.write(sheet[0])

    for i, line in enumerate(sheet):
        if debug==True:
            logLine (line)

        level = len(line) - len(line.lstrip(';'))
        if i==0:
            #skip title row
            continue

        property = getPropertyFromLine(line)
        propertyName = property["name"]
        propertyType = property["type"]

        stack[level] = propertyName

        responsePart = getResponsePart(response, level, stack)

        if (responsePart is not None and propertyName in responsePart):
            if propertyType == 'array':
                exists = str(len(responsePart.get(propertyName)))
            elif propertyType == 'object':
                exists = 'X'
            elif propertyType == 'enum':
                exists = responsePart.get(propertyName)
            elif propertyType == 'boolean':
                exists = str(responsePart.get(propertyName))
            else:
                exists = 'X'

            if level>0 and stack[level-1]=='_links':
                addLinks(propertyName, responsePart.get(propertyName), response)
        else:
            exists = ''

        sheet[i] = sheet[i][:-1] + exists + ';' + sheet[i][-1:]

        sheetFile.write(sheet[i])



    sheetFile.close()
    return sheet


def getApiResponse(uri):
    # Call API with uri and save response values in sheets

    operationId = getOperationId(uri)
    response = callApi(uri)
    if response is not None:
        if debug==True:
            logLine (uri, operationId)

        # title is calculated as the parameter parts of the uri, like uri "/resourcename/12345/subresource/678" will give title "12345/678"
        sheets[operationId] = setResponseValues(sheets[operationId], response, operationId, '/'.join(uri.split('/')[2::2]))




debug = False
info = False
settingsFileName = ""

for argument in sys.argv:
    if (argument[:8]=="--config"):
        settingsFileName = argument[8:]
    if (argument=="--debug" or argument=="-d"):
        debug = True
        info = True
    elif (argument=="--info" or argument=="-i"):
        info = True
    elif (argument=="--help" or argument=="-h"):
        print ('Command line arguments:')
        print ('--config         bestand van projectspecifieke configuratie json bestand')
        print (' --debug   -d    toon debug info')
        print (' --info    -i    toon voortgangs info')
        print (' --help    -h    toon help op command line arguments')
        sys.exit()


if settingsFileName!="":
    with open(settingsFileName) as settingsFile:
        SETTINGS = json.load(settingsFile)
else:
    print ("Geef het gewenste config bestand op met parameter --config.")
    sys.exit()

if (not os.path.isdir(SETTINGS.get("projectFolder"))):
    print ("Geef een correcte projectFolder in het config bestand.")
    sys.exit()

if (not os.path.isfile(SETTINGS.get("projectFolder") + SETTINGS.get("sourceYaml"))):
    print ("Geef een correcte locatie op voor de API specificaties in sourceYaml.")
    sys.exit()

if (not os.path.isdir(SETTINGS.get("projectFolder") + SETTINGS.get("sheetFolder"))):
    print ("Geef een correcte locatie op voor de sheets in sheetFolder.")
    print (SETTINGS.get("projectFolder") + SETTINGS.get("sheetFolder"))
    sys.exit()

if (not os.path.isfile(SETTINGS.get("projectFolder") + SETTINGS.get("testcasesFilename"))):
    print ("Geef een correcte locatie op voor de testgevallen in testcasesFilename.")
    sys.exit()


REQUEST_HEADERS = { config.APIKEY_HEADER : str(SETTINGS.get("apiKey")) }

logfile = open(config.CRAWLERLOGFILE, "w")

# read path templates and sheets
templates = {}
sheets = {}
SWAGGER = yaml.full_load(open(SETTINGS.get("projectFolder") + SETTINGS.get("sourceYaml")))
for path, pathDefinition in SWAGGER.get("paths").items():
    for method, method_definition in pathDefinition.items():
        if method=='get':
            operationId = method_definition.get("operationId")
            templates[operationId] = '^' + re.sub("{[^}]+}", "[^\/]+", path.replace('/', '\/')) + '$'

            #read sheet file
            if os.path.isfile(SETTINGS.get("projectFolder") + SETTINGS.get("sheetFolder") + operationId + ".csv"):
                f = open(SETTINGS.get("projectFolder") + SETTINGS.get("sheetFolder") + operationId + ".csv", "r")
                sheets[operationId] = f.readlines()
                f.close()

#read file with list of testdata uri
with open(SETTINGS.get("projectFolder") + SETTINGS.get("testcasesFilename")) as testuri_file:
    links = json.load(testuri_file)

for uri in links:
    if info==True:
        logLine (uri)

    getApiResponse(uri)

logfile.close()
