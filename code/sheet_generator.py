#!/usr/bin/env python

"""
Command line arguments:
--config        bestand van projectspecifieke configuratie json bestand
--debug   -d    toon debug info
--info    -i    toon voortgang info
--help    -h    toon help op command line arguments

Gebruik dit door bijvoorbeeld: python sheet_generator.py --config"settings.json"
"""


import yaml, json
from collections import OrderedDict
import sys
import os.path
import config



def writeComponent (f, level, ref):
    if debug==True:
        print ("-- " + ref)
    refList = ref.split("/")
    component =  SWAGGER
    for refPart in refList:
        if refPart != "#":
            component = component.get(refPart)

    if component.get("properties") is not None:
        properties = sorted(component.get("properties").items())
        for property, propertyDef in properties:
            writeProperty(f, level, property, propertyDef)

    elif component.get("allOf") is not None:
        for object in component.get("allOf"):
            if "$ref" in object:
                writeComponent (f, level, object.get("$ref"))

            if "properties" in object:
                properties = sorted(object.get("properties").items())
                for property, propertyDef in properties:
                    writeProperty(f, level, property, propertyDef)


def writeProperty(f, level, property, propertyDef):
    if property in SETTINGS["ignoreList"]:
        return

    if level > 0:
        for i in range (0, level):
            f.write (config.CSV_SEPERATOR)
    f.write (property)
    if propertyDef.get('type') == "array":
        if (
                "$ref" in propertyDef.get('items')
                and propertyDef.get('items').get("$ref") not in SETTINGS["ignoreList"]
                and property not in SETTINGS["ignoreList"] ):
            f.write ("[{}]")
        else:
            f.write ("[]")
    if propertyDef.get('type') == "object":
        f.write ("{}")
    if propertyDef.get('type') == "boolean":
        f.write ("(?)")
    if "$ref" in propertyDef:
        if propertyDef.get('$ref').find('Enum')>0:
            f.write ("()")
        else:
            f.write ("{}")
    if "enum" in propertyDef:
        f.write ("()")
    for i in range (0, SETTINGS.get("maxLevels") - level):
        f.write (config.CSV_SEPERATOR)
    f.write ("\n")

    if (
            "$ref" in propertyDef
            and propertyDef.get("$ref") not in SETTINGS["ignoreList"]
            and property not in SETTINGS["ignoreList"] ):
        writeComponent (f, level+1, propertyDef.get("$ref"))

    if "properties" in propertyDef:
        # writeComponent (f, level+1, propertyDef.get("properties"))
        properties = sorted(propertyDef.get("properties"))
        for subProperty, subPropertyDef in properties:
            writeProperty(f, level+1, subProperty, subPropertyDef)

    if propertyDef.get('type') == "array":
        if (
                "$ref" in propertyDef.get('items')
                and propertyDef.get('items').get("$ref") not in SETTINGS["ignoreList"]
                and property not in SETTINGS["ignoreList"] ):
            writeComponent (f, level+1, propertyDef.get("items").get("$ref"))




# read command line arguments
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
        print (' --info    -i    toon voortgangs info')
        print (' --debug   -d    toon debug info')
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
    print ("Geef een correcte locatie op voor de te genereren sheets in sheetFolder.")
    print (SETTINGS.get("projectFolder") + SETTINGS.get("sheetFolder"))
    sys.exit()




#read source API specifications file into a Dict
SWAGGER = yaml.full_load(open(SETTINGS.get("projectFolder") + SETTINGS.get("sourceYaml")))

#read all paths in de API specifications
for path, pathDefinition in SWAGGER.get("paths").items():
    for method, method_definition in pathDefinition.items():
        if method_definition.get("operationId") in SETTINGS["ignoreList"]:
            continue

        if info==True:
            print (method_definition.get("operationId"))

        f = open (SETTINGS.get("projectFolder") + SETTINGS.get("sheetFolder") + method_definition.get("operationId") + ".csv", "w")
        f.write(';'*SETTINGS.get("maxLevels") + "\n")
        writeComponent (
            f,
            0,
            method_definition.get("responses").get("200").get("content").get("application/hal+json").get("schema").get("$ref")
        )
        f.close()
