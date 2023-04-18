---
layout: page-with-side-nav
title: Haal Centraal BRK bevragingen
---

# Haal Centraal BRK bevragen

![lint oas](https://github.com/VNG-Realisatie/Haal-Centraal-BRK-bevragen/workflows/lint-oas/badge.svg)
![generate postman collection](https://github.com/VNG-Realisatie/Haal-Centraal-BRK-bevragen/workflows/generate-postman-collection/badge.svg)

API voor het zoeken en raadplegen van gegevens uit de Basisregistratie Kadaster (BRK).

## Haal Centraal BRK bevragen v1.5 is live!

BRK bevragen levert nu ook:
* gesplitste zakelijke rechten en de houders van deze rechten. 
* een indicatie sluimerend op appartementsrechten als deze niet vervallen maar gesplitst zijn.
* altijd gesplitstZakelijkRecht bij een Kadastraal onroerende zaak, ook als daar niet om gevraagd wordt.

Bekijk de [release notes](./releasenotes).

## Direct aan de slag?

* Bekijk de specificaties met [Swagger UI](./swagger-ui) of [Redoc](./redoc)
* Lees de [Getting started](./getting-started)
* Download de [technische specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-BRK-bevragen/blob/master/specificatie/genereervariant/openapi.yaml){:target="_blank" rel="noopener"}
* Download [client code](https://github.com/VNG-Realisatie/Haal-Centraal-BRK-bevragen/tree/master/code){:target="_blank" rel="noopener"}
* [Vraag een API-key aan](https://formulieren.kadaster.nl/aanmelden_brk_bevragen){:target="_blank" rel="noopener"} voor toegang tot de testomgeving.

## Doorontwikkeling van de BRK bevragen API

Komende periode wordt de API niet actief doorontwikkeld, bugs worden wel opgelost. Mis je iets? Geef dat wel aan ons door! Per 1 juli gaan we weer aan de slag, onder andere met het toevoegen van historie.

## Bronnen

* [API Design Visie](https://github.com/Geonovum/KP-APIs/tree/master/Werkgroep%20Design%20Visie){:target="_blank" rel="noopener"}
* [REST API Design Rules](https://docs.geostandaarden.nl/api/API-Designrules/){:target="_blank" rel="noopener"}
* [Landelijke API strategie voor de overheid](https://geonovum.github.io/KP-APIs/){:target="_blank" rel="noopener"}
* [Stelselcatalogus](https://www.stelselcatalogus.nl/registraties/BRK/){:target="_blank" rel="noopener"}

## Contact

* Productregiseur: Arjen Brienen, [standaarden.ondersteuning@VNG.NL](mailto:standaarden.ondersteuning@VNG.NL)
* Designer: Johan Boer, [johan.boer@vng.nl](mailto:johan.boer@vng.nl)
* Designer: Robert Melskens, [robert.melskens@vng.nl](mailto:robert.melskens@vng.nl)

## Licentie

Copyright &copy; VNG Realisatie 2020
Licensed under the [EUPL](https://github.com/VNG-Realisatie/Haal-Centraal-BRK-bevragen/blob/master/LICENCE.md){:target="_blank" rel="noopener"}
