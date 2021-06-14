#!/usr/bin/env python
 
FOLDER_SEPERATOR = "/" #for Linux and Mac. Would be "\" for Windows?
CSV_SEPERATOR = ";"
MD_SEPERATOR = "|"
MD_TABLE_HEADER = '## '

CRAWLERLOGFILE = 'api_crawler.log'

APIKEY_HEADER = "X-API-KEY"

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




