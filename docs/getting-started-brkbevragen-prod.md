# Getting Started - BRK Bevragen API
De 'BRK Bevragen' API is gespecificeerd met behulp van de OpenAPI Specifications (OAS3).

## OAS3
De (resolved) OAS3 is hier te downloaden:<br/>
[openapi.yaml](../specificatie/BRK-Bevragen/genereervariant/openapi.yaml)

## URL
De API is te benaderen via de volgende url: <br/>
https://service30.kadaster.nl/esd/bevragen/v1/

## Connectiviteit
Voor de connectie met deze API is vereist: 
- Internet toegang tot het Kadaster endpoint via IPv4 of IPv6 en met het TLS 1.2 protocol. 
- Een Staat der Nederlanden root CA - G3 certificaat in de truststore, zie hiervoor: https://www.pkioverheid.nl/ 
- Een geldig PKIoverheid client certificaat met SERIALNUMMER=<eigen-OIN-nummer> in de keystore dat deel uitmaakt van de Staat der Nederlanden - G3 hiërarchie, 
zie hiervoor: https://www.logius.nl/diensten/pkioverheid 
- Een mutual TLS endpoint configuratie, waarbij de TLS verbinding met het Kadaster alleen tot stand mag en kan komen als er bij het opzetten van de verbinding een wederzijds vertrouwen op basis van de PKIoverheid certificaten hiërarchie bestaat. 

## Werking
De werking van de API is het makkelijkst te testen met behulp van [Postman](https://www.getpostman.com/).
De <b>openapi.yaml</b> kun je importeren als project, waarna de verschillende requests worden ingeladen die deze API ondersteunt.

## Functionaliteit
De volgende Basis Registratie Kadaster gegevens kunnen opgevraagd worden:

#### KadastraalOnroerendeZaak
- Opvragen van 1 specifiek kadastraalonroerendezaak resource o.b.v. een kadastraalonroerendezaakidentificatie.
- Opvragen van 1 specifiek kadastraalonroerendezaak resource o.b.v. een kadastraleaanduiding. 
- Opvragen van een collectie kadastraalonroerendezaak resources o.b.v. een adres (postcode, huisnummer, huisletter, huisnummertoevoeging).
- Opvragen van een collectie kadastraalonroerendezaak resources, waarbij een kadaster natuurlijk persoon rechthebbende is, o.b.v. een kadasterpersoonidentificatie.
- Opvragen van een collectie kadastraalonroerendezaak resources, waarbij een kadaster nietnatuurlijk persoon rechthebbende is, o.b.v. een kadasterpersoonidentificatie.
- Opvragen van een collectie kadastraalonroerendezaak resources, waarbij een ingeschreven natuurlijk persoon rechthebbende is, o.b.v. een burgerservicenummer.

#### ZakelijkGerechtigde
- Opvragen van een collectie zakelijkgerechtigde resources van 1 specifiek kadastraalonroerendezaak o.b.v. een kadastraalonroerendezaakidentificatie.
- Opvragen van 1 specifiek zakelijkgerechtigde resource o.b.v. een zakelijkgerechtigdeidentificatie.

#### KadasterNatuurlijkPersoon
- Opvragen van 1 specifiek kadaster natuurlijk persoon resource o.b.v. een kadasterpersoonidentificatie.
- Opvragen van een collectie kadaster natuurlijkpersoon resources o.b.v. een zoekterm. (Zie feature [zoeken kadasternatuurlijkpersoon](../features/zoeken-kadasternatuurlijkpersoon.feature))

#### KadasterNietNatuurlijkPersoon
- Opvragen van 1 specifiek kadaster nietnatuurlijk persoon resource o.b.v. kadasterpersoonidentificatie.
- Opvragen van een collectie kadaster nietnatuurlijk persoon resources o.b.v. een zoekterm. (Zie feature [zoeken kadasternietnatuurlijkpersoon](../features/zoeken-kadasternietnatuurlijkpersoon.feature))

### Algemeen
Verder zijn er nog een paar algemene functies die gelden voor alle bovenstaande aanvragen:
- Gebruik van de fields parameter om de response te filteren. (Voor werking, zie feature [fields](../../Haal-Centraal-common/features/fields.feature))
- Gebruik van de expand parameter om subresources te ontsluiten. (Voor werking, zie feature [expand](../../Haal-Centraal-common/features/expand.feature)) 
- Velden die altijd worden geleverd. (Voor werking, zie feature [levering velden](../features/levering-velden.feature))

|Resource                           |Velden                         |
|-----                              |------                         |
|KadastraalOnroerendeZaak           |identificatie<br/>type<br/>_links.self |
|ZakelijkGerechtigde                |identificatie<br/>_links.self |
|KadasterNatuurlijkPersoon          |identificatie<br/>_links.self |
|KadasterNietNatuurlijkPersoon      |identificatie<br/>_links.self |

- Combinatie van velden die altijd verplicht worden geleverd.

|Resource                           |Velden                         | Uitleg |
|-----                              |------                         |----- |
|KadastraalOnroerendeZaak           |koopsom & koopjaar & (aardCultuurBebouwd of aardCultuurOnBebouwd) | [levering koopsom](../features/levering-koopsom.feature)|