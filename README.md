# Haal Centraal BRK bevragen

![lint oas](https://github.com/VNG-Realisatie/Haal-Centraal-BRK-bevragen/workflows/lint-oas/badge.svg)
![generate postman collection](https://github.com/VNG-Realisatie/Haal-Centraal-BRK-bevragen/workflows/generate-postman-collection/badge.svg)

API voor het zoeken en raadplegen van gegevens uit de Basisregistratie Kadaster (BRK).

## Haal Centraal BRK bevragen v1.5 is live!

BRK bevragen levert nu ook:
* gesplitste zakelijke rechten en de houders van deze rechten. 
* een indicatie sluimerend op appartementsrechten als deze niet vervallen maar gesplitst zijn.
* altijd gesplitstZakelijkRecht bij een Kadastraal onroerende zaak, ook als daar niet om gevraagd wordt.

Bekijk de [release notes](https://vng-realisatie.github.io/Haal-Centraal-BRK-bevragen/releasenotes).

## Direct aan de slag?

* Bekijk de specificaties met [Swagger UI](https://vng-realisatie.github.io/Haal-Centraal-BRK-bevragen/swagger-ui) of [Redoc](https://vng-realisatie.github.io/Haal-Centraal-BRK-bevragen/redoc)
* Lees de [Getting started](https://vng-realisatie.github.io/Haal-Centraal-BRK-bevragen/getting-started)
* Download de [technische specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-BRK-bevragen/blob/master/specificatie/genereervariant/openapi.yaml)
* Download [client code](https://github.com/VNG-Realisatie/Haal-Centraal-BRK-bevragen/tree/master/code)
* [Vraag een API-key aan](https://formulieren.kadaster.nl/aanmelden_brk_bevragen) voor toegang tot de testomgeving.

## Doorontwikkeling van de BRK bevragen API

Komende periode wordt de API uitgebreid met andere erfpachters. Dat zijn de eigenaren van de appartementsrechten die uit erfpacht zijn ontstaan. Ook worden sluimerende appartementsrechten zichtbaar gemaakt (v1.5).
We doen ons uiterste best om de API evolvable door te ontwikkelen en geen breaking changes te introduceren.

* Bekijk de [voortgang van issues en user stories](https://github.com/VNG-Realisatie/Haal-Centraal-BRK-bevragen/issues?q=is%3Aissue+label%3A%22v2.0%22+label%3A%22User+Story%22)
* Bekijk de specificaties in ontwikkeling met [Swagger UI](https://vng-realisatie.github.io/Haal-Centraal-BRK-bevragen/swagger-ui-io) of [Redoc](https://vng-realisatie.github.io/Haal-Centraal-BRK-bevragen/redoc-io)

## Bronnen

* [Productvisie Haal Centraal](https://vng-realisatie.github.io/Haal-Centraal)
* [API Design Visie](https://github.com/Geonovum/KP-APIs/tree/master/Werkgroep%20Design%20Visie)
* [REST API Design Rules](https://docs.geostandaarden.nl/api/API-Designrules/)
* [Landelijke API strategie voor de overheid](https://geonovum.github.io/KP-APIs/)
* [Stelselcatalogus](https://www.stelselcatalogus.nl/registraties/BRK/)

## Contact

* Product Owner: Cathy Dingemanse, cathy.dingemanse@denhaag.nl

## Licentie

Copyright &copy; VNG Realisatie 2020
Licensed under the [EUPL](https://github.com/VNG-Realisatie/Haal-Centraal-BRK-bevragen/blob/master/LICENCE.md)
