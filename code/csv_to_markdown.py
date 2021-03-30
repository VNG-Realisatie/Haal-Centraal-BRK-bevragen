#!/usr/bin/env python

"""
Maakt markdown tabellen van gegeneeerde csv bestanden

Command line arguments:
--debug   -d    toon debug info
--info    -i    toon voortgang info
--help    -h    toon help op command line arguments
--source  -s    geef pad naar csv bestanden.
                Bijvoorbeeld -s"../test/cases"
--target  -t    Geef pad van map waar het gegenereerde md bestand geplaatst moeten worden.
                Bij voorbeeld -t"../test/cases/README.md"

Gebruik dit door bijvoorbeeld: python csv_to_markdown.py -s"../test/cases" -t"../test/cases/README.md"
"""


import yaml
import yamlordereddictloader
from collections import OrderedDict
import sys
import os.path



SEPERATOR = "|"
SOURCE_YAML = '../specificatie/genereervariant/openapi.yaml'

INTRO = '# Testgevallen\n\n' \
        'Hier staan per operatie de beschikbare testgevallen waarbij per property is aangegeven of het testgeval hierop een waarde heeft.\n\n' \
        'De bovenste rij van elke tabel bevat de identificaties van de test-resources.\n' \
        'De linker kolom(men) bevatten de namen van properties van de resource.\n' \
        'Aan het einde van een propertynaam toegevoegde\n' \
        '- "{}" betekent dat dit property een object (gegevensgroep) is.\n' \
        '- "[]" betekent dat dit property een array is.\n' \
        '- "[{}]" betekent dat dit property een array van objecten is.\n' \
        '- "()" betekent dat dit property een enumeratie is.\n' \
        '\n' \
        'Bij een testgeval betekent\n' \
        '- "X" dat dit testgeval een waarde heeft voor het betreffende gegeven.\n' \
        '- Een getal dat het aantal items van het gegeven het testgeval heeft.\n' \
        '- Tekst dat dit de enumeratiewaarde is van het gegeven bij dit testgeval.\n\n' \
        '**Operaties:**\n\n'

TABLE_HEADER = '## '




# read command line arguments
debug = False
info = False
sourcePath = "../test/cases/"
targetFileName = "../test/cases/README.md"

for argument in sys.argv:
    if (argument=="--debug" or argument=="-d"):
        debug = True
        info = True
    elif (argument=="--info" or argument=="-i"):
        info = True
    elif (argument=="--help" or argument=="-h"):
        print 'Command line arguments:'
        print ' --info    -i    toon voortgangs info'
        print ' --debug   -d    toon debug info'
        print ' --help    -h    toon help op command line arguments'
        print ' --source  -s    geef pad naar API specificaties yaml bestand. Bijvoorbeeld -s"../specificatie/openapi.yaml"'
        print ' --target  -t    geef pad van map waar gegenereerde csv bestanden geplaatst moeten worden, bijvoorbeeld -t"../test/cases"'
        sys.exit()
    elif (argument[:8]=="--source"):
        sourcePath = argument[8:]
    elif (argument[:2]=="-s"):
        sourcePath = argument[2:]
    elif (argument[:8]=="--target"):
        targetFileName = argument[8:]
    elif (argument[:2]=="-t"):
        targetFileName = argument[2:]


if (not os.path.isdir(sourcePath)):
    print "Geef een correcte locatie op voor de csv bestanden. Opgegeven map", source,"is niet gevonden."
    print "Gebruik --source of -s gevolgd door het pad naar het bestand."
    sys.exit()


targetFile = open(targetFileName, "w")

targetFile.write(INTRO)


SWAGGER = yaml.load(open(SOURCE_YAML), Loader=yamlordereddictloader.Loader)

for path, pathDefinition in SWAGGER.get("paths").items():
    for method, method_definition in pathDefinition.items():
        if method=='get':
            operationId = method_definition.get("operationId")
            if os.path.isfile(sourcePath + operationId + ".csv"):
                targetFile.write('- [' + operationId + '](#' + operationId + ')\n')

for path, pathDefinition in SWAGGER.get("paths").items():
    for method, method_definition in pathDefinition.items():
        if method=='get':
            operationId = method_definition.get("operationId")

            #read sheet file
            if os.path.isfile(sourcePath + operationId + ".csv"):
                if info:
                    print operationId

                targetFile.write('\n' + TABLE_HEADER + operationId + '\n\n')

                csvFile = open(sourcePath + operationId + ".csv", "r")

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