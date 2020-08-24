
# Haal Centraal BRK bevragen v1.1 IS LIVE!
BRK-bevragen is een Haal Centraal API voor het zoeken en raadplegen van gegevens in de basisregistratie Kadaster voor alle binnengemeentelijke afnemers in NL, maar ook waterschappen, belastingsamenwerkingen en andere overheden.

Meld je aan bij het kadaster om [aan te sluiten](https://formulieren.kadaster.nl/aanmelden_brk_bevragen), of voor [toegang tot de testomgeving](https://formulieren.kadaster.nl/aanmelden_brk_bevragen).

Komende periode wordt de API uitgebreid met beperkingen, hypotheken, beslagen (v1.2) en historie vanaf oktober 2018 (v1.3). We doen ons uiterste best om de API evolvable door te ontwikkelen en geen breaking changes te introduceren.

## Getting started
Wil je een aansluiting ontwikkelen? Dan is de [getting started](./docs/getting-started.md) een goed begin. De API is technisch gespecificeerd in Open API specificaties (zie hieronder bij documentatie).

# Planning Haal Centraal
https://eu-rm.roadmunk.com/publish/29a13c572a0dfc79f1d0386fc572e15383afe11f

## Documentatie
* [Technische specificaties van de **resolved** versie](./specificatie/genereervariant) (Open API Specificaties), [Technische specificaties van de **unresolved** versie](./specificatie) (Open API versie)
* Specificaties van de actuele productie versie in [Swagger-formaat](https://petstore.swagger.io/?url=https://raw.githubusercontent.com/VNG-Realisatie/BRK-Bevragingen/v1.1.0/specificatie/genereervariant/openapi.yaml)

* Specificaties van de develop versie in [Swagger-formaat](https://petstore.swagger.io/?url=https://raw.githubusercontent.com/VNG-Realisatie/Haal-Centraal-BRK-bevragen/develop/specificatie/genereervariant/openapi.yaml)

* Specificaties van versie 1.2 in ontwikkeling in Swagger-formaat, per nieuw feature:
  * [Stukken en stukdelen](https://petstore.swagger.io/?url=https://raw.githubusercontent.com/VNG-Realisatie/Haal-Centraal-BRK-bevragen/feature/stukken/specificatie/genereervariant/openapi.yaml)
  * [Hypotheken](https://petstore.swagger.io/?url=https://raw.githubusercontent.com/VNG-Realisatie/Haal-Centraal-BRK-bevragen/feature/hypotheken/specificatie/genereervariant/openapi.yaml)
  * [Beslagen](https://petstore.swagger.io/?url=https://raw.githubusercontent.com/VNG-Realisatie/Haal-Centraal-BRK-bevragen/feature/beslagen/specificatie/genereervariant/openapi.yaml)
  * [Privaatrechtelijke beperkingen](https://petstore.swagger.io/?url=https://raw.githubusercontent.com/VNG-Realisatie/Haal-Centraal-BRK-bevragen/feature/privaat-rechtelijke-beperkingen/specificatie/genereervariant/openapi.yaml)
  * [Publiekrechtelijke beperkingen](https://petstore.swagger.io/?url=https://raw.githubusercontent.com/VNG-Realisatie/Haal-Centraal-BRK-bevragen/feature/publiek-rechtelijke-beperkingen/specificatie/genereervariant/openapi.yaml)

* Specificaties van versie 1.3 in ontwikkeling in Swagger-formaat, per nieuw feature:
  * [Publiekrechtelijke beperkingen zoeken op geo locatie of contour](https://petstore.swagger.io/?url=https://raw.githubusercontent.com/VNG-Realisatie/Haal-Centraal-BRK-bevragen/feature/zoeken_-publiekrechtelijkebeperkingen/specificatie/openapi.yaml)


* Ontwerpkeuzes staan in het document [Design decisions](./docs/design_decisions.md)
* [Productvisie](./docs/productvision.md)
* [Definition of Ready](./docs/definition_of_ready.md)
* [Definition of Done](./docs/definition_of_done.md)
* Hoe u kunt [bijdragen](https://github.com/VNG-Realisatie/API-Kennisbank/blob/master/CONTRIBUTING.md)
* [Omgangsvormen](https://github.com/VNG-Realisatie/API-Kennisbank/blob/master/CODE_OF_CONDUCT.md)



## Bronnen
* [API strategie en URI strategie](https://aandeslagmetdeomgevingswet.nl/digitaal-stelsel/documenten/documenten/api-uri-strategie/)

## Contactpersonen:
* Product Owner: Cathy Dingemanse, cathy.dingemanse@denhaag.nl
* Berichtontwerper: Johan Boer johan.boer@vng.nl

## Licentie
Copyright &copy; VNG Realisatie 2018
Licensed under the [EUPL](../LICENCE.md)
