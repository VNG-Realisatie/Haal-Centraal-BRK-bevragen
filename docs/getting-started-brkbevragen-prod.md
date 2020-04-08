# Getting Started - BRK Bevragen API
De 'BRK Bevragen' API is gespecificeerd met behulp van de OpenAPI Specifications (OAS).

## OAS specificatie
De (resolved) OAS specificatie is hier te downloaden:<br/>
[openapi.yaml](../specificatie/BRK-Bevragen/APILAB2603/genereervariant/openapi.yaml)

## URL
De API is te benaderen via de volgende url: <br/>
https://api.kadaster.nl/esd/gemeenten/brk/

## Connectiviteit
[TODO; apiKey / TLS / OAuth????]

## Werking
De werking van de API is het makkelijkst te testen met behulp van [Postman](https://www.getpostman.com/).
De <b>openapi.yaml</b> kun je importeren als project, waarna de verschillende requests worden ingeladen die deze API ondersteunt.

## Functionaliteit
De volgende Basis Registratie Kadaster gegevens kunnen opgevraagd worden:

#### KadastraalOnroerendeZaak
- Opvragen van 1 specifiek kadastraalonroerendezaak resource o.b.v. een kadastraalonroerendezaakidentificatie.
- Opvragen van een collectie kadastraalonroerendezaak resources o.b.v. een kadastraleaanduiding. 
- Opvragen van een collectie kadastraalonroerendezaak resources o.b.v. een adres (postcode, huisnummer, huisletter, huisnummertoevoeging).
- Opvragen van een collectie kadastraalonroerendezaak resources, waarbij een kadaster natuurlijk persoon rechthebbende is, o.b.v. een kadasterpersoonidentificatie.
- Opvragen van een collectie kadastraalonroerendezaak resources, waarbij een kadaster nietnatuurlijk persoon rechthebbende is, o.b.v. een kadasterpersoonidentificatie.
- Opvragen van een collectie kadastraalonroerendezaak resources, waarbij een ingeschreven natuurlijk persoon rechthebbende is, o.b.v. een burgerservicenummer.

#### ZakelijkGerechtigde
- Opvragen van een collectie zakelijkgerechtigde resources van 1 specifiek kadastraalonroerendezaak o.b.v. een kadastraalonroerendezaakidentificatie.
- Opvragen van 1 specifiek zakelijkgerechtigde resource o.b.v. een zakelijkgerechtigdeidentificatie.

#### KadasterNatuurlijkPersoon
- Opvragen van 1 specifiek kadaster natuurlijk persoon resource o.b.v. een kadasterpersoonidentificatie.
- Opvragen van een collectie kadaster natuurlijkpersoon resources o.b.v. een zoekterm. <i>(Momenteel alleen mogelijk op naam + evt. geboortedatum [YYYY-mm-dd])</i>

#### KadasterNietNatuurlijkPersoon
- Opvragen van 1 specifiek kadaster nietnatuurlijk persoon resource o.b.v. kadasterpersoonidentificatie.
- Opvragen van een collectie kadaster nietnatuurlijk persoon resources o.b.v. een zoekterm. <i>(Momenteel alleen mogelijk op statutaire naam)</i>

### Algemeen
Verder zijn er nog een paar algemene functies die gelden voor alle bovenstaande aanvragen:
- Gebruik van de fields parameter om de response te filteren.*

<i>* Let op: voor bepaalde resources zijn een aantal velden die altijd verplicht worden geleverd. Deze worden hieronder opgesomd per resource.</i>

|Resource                    |Veld                          |
|:---                        |:---                          |
|KadastraalOnroerendeZaak    |identificatie                 |
|                            |typekadastraalonroerendezaak  |
|ZakelijkGerechtigde         |identificatie                 |
|                            |typegerechtigde               |
|Aantekening                 |identificatie                 |                                       

<i>Daarnaast zijn er ook voor bepaalde gegevensgroepen velden die altijd worden teruggegeven, ongeacht of je deze gefilterd hebt middels het fields parameter:</i>

|Gegevensgroep               |Veld                          |
|:---                        |:---                          |
|Koopsom                     |koopsom                       |
|                            |koopjaar                      |
                   
- Gebruik van de expand parameter om subresources te ontsluiten. ** 

<i>** Let op: dit is alleen mogelijk voor de volgende resources:</i>

|Resource                 |Subresource                   |
|:---                     |:---                          |
|KadastraalOnroerendeZaak |ZakelijkGerechtigden          |

## Wat werkt nog niet
- Momenteel werken de linkjes naar de externe API's BRP en BAG niet en deze worden dan ook niet teruggegeven in de response.