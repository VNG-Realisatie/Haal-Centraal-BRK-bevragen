 
# Haal Centraal BRK bevragen v1.0.0 IS LIVE!
BRK-bevragen is een Haal Centraal API voor het zoeken en raadplegen van gegevens in de basisregistratie Kadaster voor alle binnengemeentelijke afnemers in NL, maar ook waterschappen, belastingsamenwerkingen en andere overheden. 

Meld je aan bij het kadaster om [aan te sluiten](https://formulieren.kadaster.nl/aanmelden_brk_bevragen), of voor [toegang tot de testomgeving](https://formulieren.kadaster.nl/aanmelden_brk_bevragen). 

Let op! Voor 1 juli wordt v1.1 verwacht met daarin de volgende (breaking!) changes:
* 	NEN3610 wordt uit de identificatie gehaald, domein wordt toegevoegd als property van de resource
*  RSIN wordt geleverd ipv KPID als die er is, met een link naar de kadasterpersoon (zie #480)
*  Templating wordt toegevoegd voor interne links 
*  Nummeraanduiding object is in v1.0.0 verwijderd en wordt toegevoegd met koppelingswijze administratief /geometrisch.

Daarna wordt de API uitgebreid met beperkingen, hypotheken, beslagen en historie. We doen ons uiterste best om GEEN breaking changes te introduceren!

## Getting started
Wil je een aansluiting ontwikkelen? Dan is de [getting started](https://github.com/VNG-Realisatie/Haal-Centraal-BRK-bevragen/blob/master/docs/getting-started-brkbevragen.md) een goed begin. De API is technisch gespecificeerd in Open API specificaties (zie hieronder bij documentatie).

# Planning Haal Centraal
https://eu-rm.roadmunk.com/publish/29a13c572a0dfc79f1d0386fc572e15383afe11f

## Documentatie
* [Productvisie](https://github.com/VNG-Realisatie/BRK-bevragingen/blob/master/docs/productvision.md)
* [Definition of Ready](https://github.com/VNG-Realisatie/BRK-bevragingen/blob/master/docs/definition_of_ready.md)
* [Definition of Done](https://github.com/VNG-Realisatie/BRK-bevragingen/blob/master/docs/definition_of_done.md)
* Hoe u kunt [bijdragen](https://github.com/VNG-Realisatie/Tutorial/blob/master/CONTRIBUTING.md)
* [Omgangsvormen](https://github.com/VNG-Realisatie/Tutorial/blob/master/CODE_OF_CONDUCT.md)

* BRK bevragen: [Technische specificaties van de **resolved** versie](https://github.com/VNG-Realisatie/Haal-Centraal-BRK-bevragen/tree/master/specificatie/BRK-Bevragen/genereervariant) (Open API Specificaties), [Technische specificaties van de **unresolved** versie](https://github.com/VNG-Realisatie/Haal-Centraal-BRK-bevragen/tree/master/specificatie/BRK-Bevragen) (Open API versie) en ook in [Swagger-formaat](https://petstore.swagger.io/?url=https://raw.githubusercontent.com/VNG-Realisatie/BRK-Bevragingen/master/specificatie/BRK-Bevragen/genereervariant/openapi.yaml)

* BRK Waardelijsten: [Technische specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-BRK-bevragen/tree/master/specificatie/Waardelijsten) (Open API Specificaties) en ook in [Swagger-formaat](https://petstore.swagger.io/?url=https://raw.githubusercontent.com/VNG-Realisatie/BRK-Bevragingen/master/specificatie/Waardelijsten/openapi.yaml)

* Ontwerpkeuzes staan in het document [Design decisions](https://github.com/VNG-Realisatie/BRK-bevragingen/blob/master/docs/design_decisions.md)

## Bronnen
* [API strategie en URI strategie](https://aandeslagmetdeomgevingswet.nl/digitaal-stelsel/documenten/documenten/api-uri-strategie/)

## Contactpersonen:
* Product Owner: Cathy Dingemanse, cathy.dingemanse@denhaag.nl
* Berichtontwerper: Johan Boer johan.boer@vng.nl

## Licentie
Copyright &copy; VNG Realisatie 2018
Licensed under the [EUPL](https://github.com/VNG-Realisatie/Haal-Centraal-BRK-bevragen/blob/master/LICENCE.md)
