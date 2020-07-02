#!/usr/bin/env python

"""
Met dit script worden csv bestanden (die eerder zijn gemaakt met
sheet_generator.sh) gevuld met indicaties voor het voorkomen van een waarde voor
velden bij gevonden testgevallen.
Er wordt begonnen met testgevallen in TESTCASES_FILENAME die de uri's bevat van
testgevallen. Vanuit deze berichten worden ook relaties in _links gevolgd om
gerelateerde testgevallen te onderzoeken.
De gegenereerde csv's kunnen worden ingelezen in bijvoorbeeld MS Excel. Elke rij
is een veld (property), elke kolom een testgeval. Wanneer in een kolom bij een
veld een "X" staat, heeft dit testgeval een waarde op dit veld, dus komt dit
veld (property) voor in de betreffende resource.

Command line arguments:
--debug   -d    toon debug info
--help    -h    toon help op command line arguments
--apikey  -k    geef de api key (required).
                Bijvoorbeeld -k9a8d9a8s7d98a7sd voor apikey="9a8d9a8s7d98a7sd"
"""


import yaml, json
import re
import requests
import sys


SOURCE_YAML = '../specificatie/BRK-Bevragen/openapi.yaml'
SHEET_FOLDER = '../test/cases/'
TESTCASES_FILENAME = '../test/cases/testcases.json'
SEPERATOR = ";"
MAX_LEVELS = 6
BASE_URL = "https://api.test.kadaster.nl/esd/gemeenten/brk/esd/gemeenten/brk"




def callApi(uri):
    response = requests.get(BASE_URL + uri, headers=REQUEST_HEADERS)

    if response.status_code == 200:
        return response.json()
    else:
        print "ERROR: request failed"
        print uri, response.status_code, response.text


def getOperationId(uri):
    for operationId in templates:
        if re.match(templates[operationId], uri) is not None:
            return operationId


def expandTemplatedUri(uri, response):
    if debug==True:
        print "expandTemplatedUri:", uri
    while (uri.find('{')>-1):
        idProperty = uri[uri.find('{')+1:uri.find('}')]
        #print "---expand:", uri, idProperty
        idValue=response.get(idProperty) # assumes templated property is at highest level of response
        if type(idValue)==type([]):
            for value in idValue:
                if debug==True:
                    print "-- templated array:", uri, value
                addNewLink(uri.replace('{' + idProperty + '}', value), response)
            uri = uri.replace('{' + idProperty + '}', value)
        else:
            uri = uri.replace('{' + idProperty + '}', idValue)

    return uri


def addNewLink(uri, response):
    if debug==True:
        print "addNewLink", uri
    if (uri.find('{')>-1):
        uri = expandTemplatedUri(uri, response)

    if uri not in links:
        links.append(uri)
        if debug==True:
            print "-- Nieuw testgeval:", uri
    #else:
    #    print "------",expandedUri, "bestaat al"


def addLinks(propertyName, propertyValue, response):
    if propertyValue is None:
        print propertyName,'has no value'
        return
    #print "--", propertyName, propertyValue

    if type(propertyValue)==type([]):
        for link in propertyValue:
            addNewLink(link.get('href'), response)
    else:
        addNewLink(propertyValue.get('href'), response)


def getPropertyFromLine(line):
    # get property name and type
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
    responsePart = response
    if level>0:
        for l in range (0, level):
            #print l, stack[l]
            responsePart = responsePart.get(stack[l])
            if responsePart is None:
                break

            if type(responsePart)==type([]):
                responsePart = responsePart[0] # only first item in arrays is used

    return responsePart


def setResponseValues(sheet, response, operationId, title):
    stack = [None] * MAX_LEVELS
    sheetFile = open(SHEET_FOLDER + operationId + ".csv", "w")

    #write identification from uri to title
    sheet[0] = sheet[0][:-1] + title + ';' + sheet[0][-1:]
    sheetFile.write(sheet[0])

    for i, line in enumerate(sheet):
        if debug==True:
            print line
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
    operationId = getOperationId(uri)
    response = callApi(uri)
    if response is not None:
        if debug==True:
            print uri, operationId
        sheets[operationId] = setResponseValues(sheets[operationId], response, operationId, uri.split('/')[-1])




debug = False
apikey = None
for argument in sys.argv:
    if (argument=="--debug" or argument=="-d"):
        debug = True
    elif (argument=="--help" or argument=="-h"):
        print 'Command line arguments:'
        print ' --debug   -d    toon debug info'
        print ' --help    -h    toon help op command line arguments'
        print ' --apikey  -k    geef de api key (verplicht), bijvoorbeeld -k9a8d9a8s7d98a7sd sets apikey="9a8d9a8s7d98a7sd"'
        sys.exit()
    elif (argument[:8]=="--apikey"):
        apikey = argument[8:]
    elif (argument[:2]=="-k"):
        apikey = argument[2:]

if (apikey is None):
    print "Geef de API-key op met argument -k of --apikey gevolgd door de te gebruiken key"
    sys.exit()

REQUEST_HEADERS = { "apikey": apikey }

# read path templates and sheets
templates = {}
sheets = {}
SWAGGER = yaml.full_load(open(SOURCE_YAML))
for path, pathDefinition in SWAGGER.get("paths").items():
    for method, method_definition in pathDefinition.items():
        if method=='get':
            operationId = method_definition.get("operationId")
            templates[operationId] = '^' + re.sub("{[^}]+}", "[^\/]+", path.replace('/', '\/')) + '$'

            #read sheet file
            f = open(SHEET_FOLDER + operationId + ".csv", "r")
            sheets[operationId] = f.readlines()
            f.close()

#read file with list of testdata uri
with open(TESTCASES_FILENAME) as testuri_file:
    links = json.load(testuri_file)

for uri in links:
    getApiResponse(uri)
