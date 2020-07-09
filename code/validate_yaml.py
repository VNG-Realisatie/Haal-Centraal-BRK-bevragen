#!/usr/bin/env python
"""
Met dit programmaatje kun je een API definitie (Open API Specification 3.0 in
yaml) controleren.
Hiermee wordt geen controle uitgevoerd op voldoen aan OAS 3.0
specificaties. Daarvoor zijn er al voorzieningen beschikbaar, bijvoorbeeld op
SwaggerHub.com of swagger-cli.
Doel is het controleren op basis van aanvullende afspraken over de vormgeving
van de API specificaties.
Getest wordt alleen deze yaml. Externe regerenties worden niet getest.

Er wordt getest op:
- endpoint url is geldige url template
- query parameters in lower case (lower-kebab-case)
- schema componenten zijn in UpperCamelCase
- geen gebruik oneOf
- allOf begint met $ref, gevolgd door object met ten minste 1 property
- properties zijn in camelCase
- properties in een object zijn geen object ($ref naar object mag wel)

Bij de opdracht moet het pad naar het te controleren Open API Specificatie
yaml-bestand worden meegegeven.
Bijvoorbeeld python validate_yaml.py "../specificatie/BRK-Bevragen/openapi.yaml"

"../specificatie/BRK-Bevragen/openapi.yaml"
"../specificatie/BAG-Bevragen/openapi.yaml"
"../specificatie/Bevraging-Ingeschreven-Persoon/openapi.yaml"
"../specificatie/Bewoning/openapi.yaml"
"""

import yaml
import re
import sys
import os.path


def valid_url_template(string, valid_yaml):
    if not re.search("^(\/[a-z]+(\/{[a-z][a-zA-Z]*[a-z]})?)+$", string):
        print "Geen geldige uri template:", string
        logfile.write( "Geen geldige uri template: " + string + '\n' )
        return False
    return valid_yaml

def valid_lower_kebab_case(string, valid_yaml):
    # we staan ook underscores toe (in parameters), hoewel dat eigenlijk niet
    # hoort in lower-kebab-case
    if not re.search("^[a-z]+(([a-z\-\_]+)*)$", string):
        print "Geen lower-kebab-case:", string
        logfile.write( "Geen lower-kebab-case: " + string + '\n' )
        return False
    return valid_yaml

def valid_camel_case(string, valid_yaml):
    if not re.search("^[a-z\_][a-z0-9]+(([A-Z][a-z0-9]+)*)$", string):
        print "Geen camelCase:",string
        logfile.write( "Geen camelCase: " + string + '\n' )
        return False
    return valid_yaml


def valid_upper_camel_case(string, valid_yaml):
    if not re.search("^(([A-Z][a-zA-Z0-9_]+[a-z0-9])+)$", string):
        print "Geen UpperCamelCase:",string
        logfile.write( "Geen UpperCamelCase: " + string + '\n' )
        return False
    return valid_yaml


def valid_inheritance(component_name, component_schema, valid_yaml):
    if len(component_schema.get("allOf"))!=2:
        print "Een allOf moet bestaan uit exact 2 elementen ($ref + object):", component_name
        logfile.write( "Een allOf moet bestaan uit exact 2 elementen ($ref + object): " + component_name + '\n' )
        return False

    if not "$ref" in component_schema.get("allOf")[0]:
        print "Een allOf moet overerfen uit een component met een $ref:", component_name
        logfile.write( "Een allOf moet overerfen uit een component met een $ref: " + component_name + '\n' )
        return False

    if "$ref" in component_schema.get("allOf")[1]:
        print "Een allOf mag niet overerfen met een $ref uit meer dan 1 component:", component_name
        logfile.write( "Een allOf mag niet overerfen met een $ref uit meer dan 1 component: " + component_name + '\n' )
        return False

    if not "properties" in component_schema.get("allOf")[1]:
        print "Een allOf moet ten minste 1 property toevoegen aan de component waaruit overorven wordt:", component_name
        logfile.write( "Een allOf moet ten minste 1 property toevoegen aan de component waaruit overorven wordt: " + component_name + '\n' )
        return False

    return valid_yaml


logfile = open("validatie.log", "w")

if len(sys.argv)<2:
    print "Geef het pad op naar de te controleren Open API Specificaties yaml"
    logfile.write( "Geef het pad op naar de te controleren Open API Specificaties yam\n" )
    sys.exit()

if len(sys.argv)>2:
    print "Geef exact 1 argument mee met daarin het pad op naar de te controleren Open API Specificaties yaml"
    logfile.write( "Geef exact 1 argument mee met daarin het pad op naar de te controleren Open API Specificaties yaml\n" )
    sys.exit()

if not os.path.isfile(sys.argv[1]):
    print "Bestand", sys.argv[1], "is niet gevonden"
    logfile.write( "Bestand" + sys.argv[1] + "is niet gevonden\n" )
    sys.exit()


# dictionairy die de volledige Open API Specification 3.0 definitie van de API bevat
SWAGGER = yaml.load(open(sys.argv[1]), yaml.FullLoader)

valid_yaml = True

print "Controleren van bestand",sys.argv[1]
logfile.write( "Controleren van bestand " + sys.argv[1] + '\n' )

# paths
if "paths" in SWAGGER:
    for path, pathDefinition in SWAGGER.get("paths").items():
        valid_yaml = valid_url_template(path, valid_yaml)

        for method, method_definition in pathDefinition.items():
            if "parameters" in method_definition:
                for parameter_definition in method_definition.get("parameters"):
                    if "name" in parameter_definition and "in" in parameter_definition and parameter_definition.get("in")=="query":
                        valid_yaml = valid_lower_kebab_case(parameter_definition.get("name"), valid_yaml)

#components parameters
if "components" in SWAGGER and "parameters" in SWAGGER.get("components"):
    for component_name, component_schema in SWAGGER.get("components").get("parameters").items():
        if "in" in component_schema and component_schema.get("in")=="query" and "name" in component_schema:
            valid_yaml = valid_lower_kebab_case(component_schema.get("name"), valid_yaml)

# components schemas
if "components" in SWAGGER and "schemas" in SWAGGER.get("components"):
    for component_name, component_schema in SWAGGER.get("components").get("schemas").items():
        valid_yaml = valid_upper_camel_case(component_name, valid_yaml)

        if "oneOf" in component_schema:
            print "Er is oneOf gebruikt:", component_name
            logfile.write( "Er is oneOf gebruikt:" + component_name + '\n')
            valid_yaml = False

        if "anyOf" in component_schema:
            print "Er is anyOf gebruikt:", component_name
            logfile.write( "Er is anyOf gebruikt:" + component_name + '\n')
            valid_yaml = False

        if "allOf" in component_schema:
            valid_yaml = valid_inheritance(component_name, component_schema, valid_yaml)

            if len(component_schema.get("allOf"))==2 and "properties" in component_schema.get("allOf")[1]:
                for property_name, property_def in component_schema.get("allOf")[1].get("properties").items():
                    valid_yaml = valid_camel_case(property_name, valid_yaml)

        if "properties" in component_schema:
            for property_name, property_def in component_schema.get("properties").items():
                valid_yaml = valid_camel_case(property_name, valid_yaml)

                if not re.search("^.*HalCollectie$", component_name):
                    if "properties" in property_def:
                        print "Er is een object in een object gedefinieerd. Gebruik hiervoor $ref in:",component_name+"."+property_name
                        logfile.write( "Er is een object in een object gedefinieerd. Gebruik hiervoor $ref in:" + component_name+"."+property_name + '\n')
                        valid_yaml = False

                    if "items" in property_def:
                        if "properties" in property_def.get("items"):
                            print "Er is een object in een array gedefinieerd. Gebruik hiervoor $ref in:",component_name+"."+property_name
                            logfile.write( "Er is een object in een array gedefinieerd. Gebruik hiervoor $ref in:" + component_name+"."+property_name + '\n')
                            valid_yaml = False

if valid_yaml==True:
    print "Geen fouten of aandachtspunten gevonden in de specificaties"
    logfile.write( "Geen fouten of aandachtspunten gevonden in de specificaties\n")

logfile.close()
