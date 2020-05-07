# Getting Started - BRK Bevragen API
De 'BRK Bevragen' API is gespecificeerd met behulp van de OpenAPI Specifications (OAS).

## OAS specificatie
De (resolved) OAS specificatie is hier te downloaden:<br/>
[openapi.yaml](../specificatie/BRK-Bevragen/genereervariant/openapi.yaml)

## URL
De API is te benaderen via de volgende url: <br/>
https://api.brk.kadaster.nl/esd/bevragen/v1/

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
- Opvragen van een collectie kadaster natuurlijkpersoon resources o.b.v. een zoekterm. (Zie feature [zoeken kadasternatuurlijkpersoon](../features/zoeken%kadasternatuurlijkpersoon.feature))

#### KadasterNietNatuurlijkPersoon
- Opvragen van 1 specifiek kadaster nietnatuurlijk persoon resource o.b.v. kadasterpersoonidentificatie.
- Opvragen van een collectie kadaster nietnatuurlijk persoon resources o.b.v. een zoekterm. (Zie feature [zoeken kadasternietnatuurlijkpersoon](../features/zoeken%20kadasternietnatuurlijkpersoon.feature))

### Algemeen
Verder zijn er nog een paar algemene functies die gelden voor alle bovenstaande aanvragen:
- Gebruik van de fields parameter om de response te filteren.* (Zie feature [fields](../../Haal-Centraal-common/features/fields.feature))

<i>* LET OP: <br/> voor bepaalde resources zijn een aantal velden die altijd verplicht worden geleverd. Deze worden hieronder opgesomd per resource.</i>

|Resource                       |Veld                   | 
|:---                           |:---                   |                         
|KadastraalOnroerendeZaak       |identificatie<br/>type |
|ZakelijkGerechtigde            |identificatie          |               
|KadasterNatuurlijkPersoon      |identificatie          |                                                       
|KadasterNietNatuurlijkPersoon  |identificatie          |                                                        

<i>Daarnaast bestaan er nog uitzonderingen voor bepaalde combinaties van velden:</i>
   
|Resource                   |Velden                                                         |Subresource                   |
|:---                       |:---                                                           |:---                          |
|KadastraalOnroerendeZaak   |Koopsom & <br/>CultuurcodeBebouwd en/of CultuurcodeOnbebouwd      |[koopsom](rtrtTODO)           |   
        
- Gebruik van de expand parameter om subresources te ontsluiten. ** (Zie feature [expand](../../Haal-Centraal-common/features/expand.feature)) 

<i>** Let op: dit is alleen mogelijk voor de volgende resources:</i>

|Resource                 |Subresource                   |
|:---                     |:---                          |
|KadastraalOnroerendeZaak |ZakelijkGerechtigden          |

## Wat werkt nog niet
- Momenteel werken de linkjes naar de externe API's BRP en BAG niet en deze worden dan ook niet teruggegeven in de response.