#!/usr/bin/env python

"""
Command line arguments:
--debug   -d    toon debug info
--help    -h    toon help op command line arguments
--source  -s    geef pad naar API specificaties yaml bestand.
                Bijvoorbeeld -s"../specificatie/openapi.yaml"
--target  -t    Geef pad van map waar gegenereerde csv bestanden geplaatst moeten worden.
                Bij voorbeeld -t"../test/cases/"

Gebruik dit door bijvoorbeeld: python sheet_generator.py -s"../specificatie/BRK-Bevragen/genereervariant/openapi.yaml" -t"../test/cases"
"""


import yaml
from collections import OrderedDict
import sys
import os.path


IGNORELIST = {
    '#/components/schemas/Datum_onvolledig',
    '#/components/schemas/Waardetabel',
    '#/components/schemas/Waardelijst',
    '#/components/schemas/HalCollectionLinks',
    '#/components/schemas/HalLink',
    '#/components/schemas/Href',
    '_embedded' }

MAX_LEVELS = 6
SEPERATOR = ";"
FOLDER_SEPERATOR = "/" #for Linux and Mac. Would be "\" for Windows?




def writeComponent (f, level, ref):
    if debug==True:
        print "-- " + ref
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
    if property in IGNORELIST:
        return

    if level > 0:
        for i in range (0, level):
            f.write (SEPERATOR)
    f.write (property)
    if propertyDef.get('type') == "array":
        if (
                "$ref" in propertyDef.get('items')
                and propertyDef.get('items').get("$ref") not in IGNORELIST
                and property not in IGNORELIST ):
            f.write ("[{}]")
        else:
            f.write ("[]")
    if propertyDef.get('type') == "object":
        f.write ("{}")
    if "$ref" in propertyDef:
        if propertyDef.get('$ref').find('_enum')>0:
            f.write ("()")
        else:
            f.write ("{}")
    if "enum" in propertyDef:
        f.write ("()")
    for i in range (0, MAX_LEVELS - level):
        f.write (SEPERATOR)
    f.write ("\n")

    if (
            "$ref" in propertyDef
            and propertyDef.get("$ref") not in IGNORELIST
            and property not in IGNORELIST ):
        writeComponent (f, level+1, propertyDef.get("$ref"))

    if "properties" in propertyDef:
        # writeComponent (f, level+1, propertyDef.get("properties"))
        properties = sorted(propertyDef.get("properties"))
        for subProperty, subPropertyDef in properties:
            writeProperty(f, level+1, subProperty, subPropertyDef)

    if propertyDef.get('type') == "array":
        if (
                "$ref" in propertyDef.get('items')
                and propertyDef.get('items').get("$ref") not in IGNORELIST
                and property not in IGNORELIST ):
            writeComponent (f, level+1, propertyDef.get("items").get("$ref"))



# read command line arguments
debug = False
source = "openapi.yaml"
target = ""

for argument in sys.argv:
    if (argument=="--debug" or argument=="-d"):
        debug = True
    elif (argument=="--help" or argument=="-h"):
        print 'Command line arguments:'
        print ' --debug   -d    toon debug info'
        print ' --help    -h    toon help op command line arguments'
        print ' --source  -s    geef pad naar API specificaties yaml bestand. Bijvoorbeeld -s"../specificatie/openapi.yaml"'
        print ' --target  -t    geef pad van map waar gegenereerde csv bestanden geplaatst moeten worden, bijvoorbeeld -t"../test/cases"'
        sys.exit()
    elif (argument[:8]=="--source"):
        source = argument[8:]
    elif (argument[:2]=="-s"):
        source = argument[2:]
    elif (argument[:8]=="--target"):
        target = argument[8:]
    elif (argument[:2]=="-t"):
        target = argument[2:]

if (target[-1:])!=FOLDER_SEPERATOR:
    target += FOLDER_SEPERATOR

if (not os.path.isfile(source)):
    print "Geef een correcte locatie op voor de API specificaties. Opgegeven of default bestand", source,"is niet gevonden."
    print "Gebruik --source of -s gevolgd door het pad naar het bestand."
    sys.exit()

if (not os.path.isdir(target)):
    print "Geef een correcte locatie op waar de gegenereerde bestanden geplaatst moeten worden. Opgegeven of default bestand", source,"is niet gevonden."
    print "Gebruik --target of -t gevolgd door het pad naar de map."
    sys.exit()

SOURCE_YAML = source
TARGET_FOLDER = target

#read source API specifications file into a Dict
SWAGGER = yaml.full_load(open(SOURCE_YAML))

#read all paths in de API specifications
for path, pathDefinition in SWAGGER.get("paths").items():
    for method, method_definition in pathDefinition.items():
        if debug==True:
            print method_definition.get("operationId")
        f = open (TARGET_FOLDER + method_definition.get("operationId") + ".csv", "w")
        f.write(';'*MAX_LEVELS + "\n")
        writeComponent (
            f,
            0,
            method_definition.get("responses").get("200").get("content").get("application/hal+json").get("schema").get("$ref")
        )
        f.close()
