# Getting Started

## ZoekenPersoon API
De 'ZoekenPersoon' API is gespecificeerd met behulp van de OpenAPI specifications (OAS).

### OAS specificatie
De (resolved) OAS specificatie is te downloaden van de Haal-Centraal-BRK-bevragen github repository - /specificatie/Zoek-kadasterpersoon/openapi.yaml

### URI
De API lab versie is te benaderen via de volgende url: https://api.test.kadaster.nl/esd/gemeenten/brk/

### ApiKey
Om de api te kunnen bevragen is een apikey nodig. Voor de API lab is een algemene apiKey beschikbaar. 
Deze is ook alleen maar geldig op de API lab en zal na het API lab gedisabled worden.
De apiKey kan opgevraagd worden bij de mensen van het BRK team.

### Werking
De werking van de API is het makkelijkst te testen met behulp van [Postman](https://www.getpostman.com/).
De openapi.yaml specficatie kun je importeren als project, waarna je de verschillende requests kunt doen.
LET OP: je moet de apiKey als header meegeven met als key=apiKey en als value de apiKey zelf.

### Nog niet gerealiseerd
De volgende functies zijn nog niet gerealiseerd voor het API lab.
- Foutafhandeling. Alle foutsituaties geven een http 404 error response terug
- Zoeken op geboortedatum, rechtsvorm, statutaire zetel
- Fuzzy search op combinatie van voornamen / tussenvoegsel / geslachtsnaam

### Testgevallen

#### Endpoint /kadasterpersonen?q={zoekterm}&zoektype=[np|nnp]
Om informatie over een kadasterpersoon op te vragen op basis van een zoekterm en optioneel een zoektype. 

De zoekterm kijkt of opgegeven zoekterm voorkomt in de geslachtsnaam van een natuurlijk persoon of 
in de statutaire naam van een niet natuurlijk persoon.

Voor dit endpoint kunnen alle niet natuurlijk personen & kadaster natuurlijk personen bevraagd worden die beschikbaar zijn in de testset van 'BRK Bevragen' API.
 