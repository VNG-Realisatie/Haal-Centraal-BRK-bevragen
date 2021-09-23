#!/usr/bin/env python

"""
Maakt markdown tabellen van gegeneeerde csv bestanden

Command line arguments:
--config        bestand van projectspecifieke configuratie json bestand
--debug   -d    toon debug info
--info    -i    toon voortgang info
--help    -h    toon help op command line arguments

Gebruik dit door bijvoorbeeld: python csv_to_markdown.py --config"settings.json" --info
"""


import yaml, json
import yamlordereddictloader
from collections import OrderedDict
import sys
import os.path
import config


"""
config.MD_SEPERATOR = "|"
SOURCE_YAML = '../../specificatie/genereervariant/openapi.yaml'

INTRO = '# Testgevallen\n\n' \
        'Hier staan per operatie de beschikbare testgevallen waarbij per property is aangegeven of het testgeval hierop een waarde heeft.\n\n' \
        'De bovenste rij van elke tabel bevat de identificaties van de test-resources.\n' \
        'De linker kolom(men) bevatten de namen van properties van de resource.\n' \
        '\n' \
        'Bij een testgeval betekent\n' \
        '- "X" dat dit testgeval een waarde heeft voor het betreffende gegeven.\n' \
        '- Een getal dat het aantal items van het gegeven in het testgeval bevat.\n' \
        '- Tekst dat dit de enumeratiewaarde is van het gegeven bij dit testgeval.\n\n' \
        '**Operaties:**\n\n'

config.MD_TABLE_HEADER = '## '

SETTINGS.get("ignoreList") = { 'zoekActueleWozobjecten' }
"""


# read command line arguments
debug = False
info = False

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
        print (' --source  -s    geef pad naar API specificaties yaml bestand. Bijvoorbeeld -s"../specificatie/openapi.yaml"')
        print (' --target  -t    geef pad van map waar gegenereerde csv bestanden geplaatst moeten worden, bijvoorbeeld -t"../test/cases"')
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

if (not os.path.isdir(SETTINGS.get("projectFolder") + SETTINGS.get("sheetFolder"))):
    print ("Geef een correcte locatie op voor de sheets in sheetFolder.")
    print (SETTINGS.get("projectFolder") + SETTINGS.get("sheetFolder"))
    sys.exit()

if (not os.path.isfile(SETTINGS.get("projectFolder") + SETTINGS.get("testcasesFilename"))):
    print ("Geef een correcte locatie op voor de testgevallen in testcasesFilename.")
    sys.exit()

if (not os.path.isfile(SETTINGS.get("projectFolder") + SETTINGS.get("sourceYaml"))):
    print ("Geef een correcte locatie op voor de API specificaties in sourceYaml.")
    sys.exit()


targetFile = open(SETTINGS.get("projectFolder") + SETTINGS.get("markdownFilename"), "w")

targetFile.write(config.INTRO)


SWAGGER = yaml.load(open(SETTINGS.get("projectFolder") + SETTINGS.get("sourceYaml")), Loader=yamlordereddictloader.Loader)

# add contents list
for path, pathDefinition in SWAGGER.get("paths").items():
    for method, method_definition in pathDefinition.items():
        if method_definition.get("operationId") in SETTINGS.get("ignoreList"):
            continue
        
        if method=='get':
            operationId = method_definition.get("operationId")
            if os.path.isfile(SETTINGS.get("projectFolder") + SETTINGS.get("sheetFolder") + operationId + ".csv"):
                targetFile.write('- [' + operationId + '](#' + operationId + ')\n')

# add testcases table for every operation/sheet
for path, pathDefinition in SWAGGER.get("paths").items():
    for method, method_definition in pathDefinition.items():
        if method_definition.get("operationId") in SETTINGS.get("ignoreList"):
            continue

        if method=='get':
            operationId = method_definition.get("operationId")

            #read sheet file
            if os.path.isfile(SETTINGS.get("projectFolder") + SETTINGS.get("sheetFolder") + operationId + ".csv"):
                if info:
                    print (operationId)

                targetFile.write('\n' + config.MD_TABLE_HEADER + operationId + '\n\n')

                csvFile = open(SETTINGS.get("projectFolder") + SETTINGS.get("sheetFolder") + operationId + ".csv", "r")

                cases = csvFile.readlines()

                isTitle = True

                for l in cases:
                    targetFile.write('|' + l.replace(';', '|'))

                    if isTitle is True:
                        targetFile.write('|--- ' * l.count(';') + '|\n')
                        targetFile.write

                    isTitle = False
                    
                csvFile.close()

targetFile.close()