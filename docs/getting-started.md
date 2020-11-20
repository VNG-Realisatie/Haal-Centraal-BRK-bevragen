---
layout: page-with-side-nav
title: Getting Started
---
# Getting Started
De 'BRK Bevragen' API is gespecificeerd met behulp van de OpenAPI Specifications (OAS3).

Om aan te sluiten kun je de volgende stappen doorlopen:
1. [Meld je aan bij het kadaster om toegang te krijgen](#aanmelden-om-aan-te-sluiten)
2. [Bekijk de functionaliteit en specificaties](#functionaliteit-en-specificaties)
3. [Implementeer de API](#bouw-de-api)
4. [Probeer en test de API](#probeer-en-test-de-api)
5. [Sluit aan op productie](#aansluiten-op-productie)

|kop1 |kop2 |
|-----|-----|
|iets |* item 1 * item 2|


## Aanmelden om aan te sluiten
Meld je aan bij het kadaster om [aan te sluiten en voor toegang tot de testomgeving](https://formulieren.kadaster.nl/aanmelden_brk_bevragen). Je ontvangt dan o.a. een API-key die nodig is voor toegang tot de testomgeving.

## Functionaliteit en specificaties
Je kunt een visuele representatie van de specificatie bekijken met [Swagger UI]({{ site.baseurl }}/swagger-ui) of [Redoc]({{ site.baseurl }}/redoc).

Je kunt de [functionele documentatie](./features) vinden in de [features](./features).

### Beschikbare resources
De volgende Basis Registratie Kadaster gegevens kunnen opgevraagd worden:
- [Kadastraal onroerende zaak](#kadastraalonroerendezaak)
- [Zakelijk gerechtigde](#zakelijkgerechtigde)
- [Kadaster natuurlijk persoon](#kadasternatuurlijkpersoon)
- [Kadaster niet-natuurlijk persoon](#kadasternietnatuurlijkpersoon)
- [Hypotheek](#hypotheek)
- [Beslag](#beslag)
- [Privaatrechtelijke beperking](#privaatrechtelijkebeperking)
- [Publiekrechtelijke beperking](#publiekrechtelijkebeperking)

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

#### Hypotheek
- Opvragen van 1 specifiek hypotheek resource o.b.v. hypotheekidentificatie en kadastraalonroerendezaakidentificatie.
- Opvragen van een collectie hypotheek resources behorende bij een kadastraal onroerende zaak o.b.v. een kadastraalonroerendezaakidentificatie.

#### Beslag
- Opvragen van 1 specifiek beslag resource o.b.v. beslagidentificatie en kadastraalonroerendezaakidentificatie.
- Opvragen van een collectie beslag resources behorende bij een kadastraal onroerende zaak o.b.v. een kadastraalonroerendezaakidentificatie.

#### PrivaatrechtelijkeBeperking
- Opvragen van 1 specifiek privaatrechtelijkebeperking resource o.b.v. privaatrechtelijkebeperkingidentificatie en kadastraalonroerendezaakidentificatie.
- Opvragen van een collectie privaatrechtelijkebeperking resources behorende bij een kadastraal onroerende zaak o.b.v. een kadastraalonroerendezaakidentificatie.

#### PrubliekrechtelijkeBeperking
- Opvragen van een collectie publiekrechtelijkebeperking resources o.b.v. een kadastraalonroerendezaakidentificatie.


### Algemeen
Verder zijn er nog een paar algemene functies die gelden voor alle bovenstaande aanvragen:
- Gebruik van de fields parameter om de response te filteren. (Voor werking, zie feature [fields](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.2.0/features/fields.feature))
- Gebruik van de expand parameter om subresources te ontsluiten. (Voor werking, zie feature [expand](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.2.0/features/expand.feature))
- Velden die altijd worden geleverd. (Voor werking, zie feature [levering velden](../features/levering-velden.feature))

|Resource                           |Velden                         |
|-----                              |------                         |
|KadastraalOnroerendeZaak           |identificatie, type, _links.self |
|ZakelijkGerechtigde                |identificatie, _links.self |
|KadasterNatuurlijkPersoon          |identificatie, _links.self |
|KadasterNietNatuurlijkPersoon      |identificatie, _links.self |
|Beslag                             |identificatie, _links.self |
|hypotheek                          |identificatie, _links.self |
|KadasterNietNatuurlijkPersoon      |identificatie, _links.self |
|PrivaatrechtelijkeBeperking        |identificatie, _links.self |
|PubliekrechtelijkeBeperking        |identificatie |

- Combinatie van velden die altijd verplicht worden geleverd.

|Resource                           |Velden                         | Uitleg |
|-----                              |------                         |----- |
|KadastraalOnroerendeZaak           |koopsom & koopjaar & (aardCultuurBebouwd of aardCultuurOnBebouwd) | [levering koopsom](../features/levering-koopsom.feature)|

- [HAL links](https://tools.ietf.org/html/draft-kelly-json-hal-08), die soms [templated](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.2.0/features/uri-templating.feature) worden geleverd.

## Bouw de API
We hebben [client code](https://github.com/VNG-Realisatie/Haal-Centraal-BRK-bevragen/tree/master/code){:target="_blank" rel="noopener"} voor API-clients in enkele varianten. Hiermee kan je direct aan de slag met het gebruiken van de API.

Zit jouw gewenste ontwikkelomgeving er niet bij, dan kan je zelf ook code genereren vanuit de "[genereervariant](https://github.com/VNG-Realisatie/Haal-Centraal-BRK-bevragen/blob/master/specificatie/genereervariant/openapi.yaml){:target="_blank" rel="noopener"}" van de API-specificaties.

## Probeer en test de API
De werking van de API is het makkelijkst te testen met behulp van [Postman](https://www.getpostman.com/).
We hebben al een project voor je gemaakt die je kan gebruiken: [BRK-Bevragen-postman-collection.json](../test/BRK-Bevragen-postman-collection.json). Hierin moet je alleen de endpoints en authenticatie (API-key) nog invullen.
We hebben al een [Postman collection](https://github.com/VNG-Realisatie/Haal-Centraal-BRK-bevragen/blob/master/test/BRK-Bevragen-postman-collection.json){:target="_blank" rel="noopener"} voor je klaargezet. Deze kun je importeren in Postman.

### Configureer de url en api key

1. Klik bij "Kadaster - BRK-Bevragen API" op de drie bolletjes.
2. Klik vervolgens op Edit
3. Selecteer tabblad "Authorization"
4. Kies TYPE "API Key"
5. Vul in Key: "x-api-key", Value: de API key die je van het Kadaster hebt ontvangen, Add to: "Header"
6. Selecteer tabblad "Variables"
7. Vul bij baseUrl INITIAL VALUE en bij CURRENT VALUE de url
8. Klik op de knop Update

De testomgeving van de API is te benaderen via de volgende urls:
- _Beveiligde verbinding met alleen API-key: https://api.brk.kadaster.nl/esd-eto-apikey/bevragen/v1/_
    - Voor deze connectie met de testomgeving van deze API is vereist:
        - Een geldige API-key. Deze wordt bij de request opgenomen in request header "X-Api-Key". Wanneer je je aanmeldt voor het gebruiken van de API ontvang je de API-key.

- _Beveiligde verbinding met API-key & mTLS: https://api.brk.kadaster.nl/esd-eto/bevragen/v1/_
    - Voor deze connectie met de testomgeving van deze API is vereist:
        - Een geldige API-key. Deze wordt bij de request opgenomen in request header "X-Api-Key". Wanneer je je aanmeldt voor het gebruiken van de API ontvang je de API-key.
        - Internet toegang tot het Kadaster endpoint via IPv4 of IPv6 en met het TLS 1.2 protocol.
        - Een Staat der Nederlanden root CA - G3 certificaat in de truststore, zie hiervoor: https://www.pkioverheid.nl/
        - Een geldig PKIoverheid client certificaat met SERIALNUMMER=<eigen-OIN-nummer> in de keystore dat deel uitmaakt van de Staat der Nederlanden - G3 hiërarchie,
zie hiervoor: https://www.logius.nl/diensten/pkioverheid
        - Een mutual TLS endpoint configuratie, waarbij de TLS verbinding met het Kadaster alleen tot stand mag en kan komen als er bij het opzetten van de verbinding een wederzijds vertrouwen op basis van de PKIoverheid certificaten hiërarchie bestaat.

### Testgevallen
Onderstaande tabellen bevatten testgevallen voor specifieke situaties waarmee de werking van de API kan worden getest op de test omgeving.

#### Onroerende Zaken

| Testgeval                                       |Kadastraalobjectidentificatie              |Kadastraleaanduiding      |Postcode               |Bijzonderheden |                                                                    
|----------------                                |-------                                   |-------                  |-------               |-------        |
|2 eigenaren (Kadaster Natuurlijk Persoon)       |76870487970000   |Beekbergen:87 K 4879      |7361EW 29              |<ul><li>alle velden gevuld</li><li>1x hypotheek</li><li>2x publiekrechtelijke beperking</li><li>1x privaatrechtelijke beperking</li></ul> |
|1 eigenaar (Kadaster Niet Natuurlijk Persoon)   |76870488070000   |Beekbergen:87 K 4880      |7361EW 27              |<ul><li>1x privaatrechtelijke beperking</li></ul>|
|1 eigenaar (Kadaster Natuurlijk Persoon)        |76870482670000   |Beekbergen:87 K 4826      |7361EW 25              |<ul><li>2x hypotheek</li></ul>|
|1 eigenaar (Kadaster Niet Natuurlijk Persoon)   |76870482570000   |Beekbergen:87 K 4825      |7361EW 21              |<ul><li>2 erfpachters met erfpachtcanon</li><li>1x hypotheek</li></ul>|
|1 eigenaar (Ingeschreven Natuurlijk Persoon)    |22310827210003   |'s Gravenhage:881 N 8272 3|2517GL 84              |<ul><li>appartementsrecht</li><li>1x hypotheek</li><li>1x publiekrechtelijke beperking</li></ul> |
|1 eigenaar (Ingeschreven Natuurlijk Persoon)    |22310827210004   |'s Gravenhage:881 N 8272 4|2517GL 85              |<ul><li>appartementsrecht</li></ul> |
|1 eigenaar (Ingeschreven Natuurlijk Persoon)    |56020234070000   |Odoorn:717 N 2340         |9573PA 3               |<ul><li>1 artikel5_3b</li><li>1x hypotheek</li></ul>|
|1 eigenaar (Ingeschreven Natuurlijk Persoon)    |23280647970000   |Loosduinen:561 H 6479     |2551XS 31<br/>2551XN 45<br/>2551XN 47<br/>2551XN 49<br/>2551XN 51              |<ul><li>meerdere adressen</li><li>1x privaatrechtelijke beperking</li></ul>|
|1 eigenaar (Ingeschreven Natuurlijk Persoon)    |65490485370000   |Hellendoorn:395 G 4853    |7441JC 1 a             |<ul><li>bevat huisletter</li></ul>|
|2 eigenaen (Ingeschreven & Kadaster Natuurlijk Persoon)    |65490485270000   |Hellendoorn:395 G 4853    |7441JC 1               ||
|1 eigenaar (Ingeschreven Natuurlijk Persoon)    |24780711870000   |Voorschoten:1040 B 7118   |2252EB 14<br/>2252EB 14 B<br/>2252EB 14 C<br/>2252EB 14 D<br/>2252EB 16<br/>2252EB 18              |<ul><li>meerdere adressen</li><li>betrokkenGorzenEnAanwassen</li></ul>|
|1 eigenaar (Ingeschreven Natuurlijk Persoon)    |17150075470000   |Hellevoetsluis:396 E 754  |3224EA 39              |<ul><li>1x hypotheek</li><li>1x beslag</li></ul>|
|1 eigenaar (Kadaster Niet Natuurlijk Persoon)   |22590043870000   |'s Gravenhage:881 AW 438  |2545NN 178<br/>2545NN 180<br/>2545NN 182             |<ul><li>1 erfpachter</li><li>meerdere adressen</li><li>betrokkenSamenwerkingsverband</li><li>2x privaatrechtelijke beperking</li></ul>|
|1 eigenaar (Ingeschreven Natuurlijk Persoon)    |17500393970000   |IJsselmonde:459 D 3939    |3078JG 4               | |
|1 eigenaar (Ingeschreven Natuurlijk Persoon)    |22360467970000   |'s Gravenhage:881 V 4679  |2597LD 58              |<ul><li>1 erfpachter</li><li>1x publiekrechtelijke beperking</li></ul>|
|1 eigenaar (Ingeschreven Natuurlijk Persoon)    |19560032970000   |Rotterdam:841 AF 329      |3011KD 70<br/>3011KD 72              |<ul><li>meerdere adressen</li><li>2x hypotheek</li><li>2x publiekrechtelijke beperking</li></ul>|
|2 eigenaren (Ingeschreven Natuurlijk Persoon)   |17550448670000   |Kralingen:501 C 4486      |3066VS 9               |<ul><li>betrokkenPartner</li><li>1x hypotheek</li></ul>|

#### Natuurlijke Personen

|Naam                    |Geboortedatum    |Type                                 |KadasterPersoon-Identificatie   | Burgerservice-nummer |Bijzonderheden        |
|----------------        |-------         |------                              |------                        |------              |------              |
|Willem Jansens          |1971-11-01       |Kadaster Natuurlijk Persoon          |70882239      |                     |<ul><li>alle velden gevuld</li><li>woonadres is niet bekend in BAG</li></ul> |
|Sidonia Jansens         |1950-01-01       |Kadaster Natuurlijk Persoon          |50550743      |                     |<ul><li>buitenlands woonadres</li></ul> |
|Christaan Goede         |1971-11-01       |Kadaster Natuurlijk Persoon          |71303564      |                     |<ul><li>woonadres is wel bekend in BAG</li></ul> |
|Linda Haglund           |                 |Ingeschreven Natuurlijk Persoon      |                               |999991905            ||
|Lisanty do Livramento...|                 |Ingeschreven Natuurlijk Persoon      |                               |999990482            ||
|Merel Kooyman           |                 |Ingeschreven Natuurlijk Persoon      |                               |999993847            ||
|Suzanne van der Stappen |                 |Ingeschreven Natuurlijk Persoon      |                               |999993653            ||
|Mirjam Heijn            |                 |Ingeschreven Natuurlijk Persoon      |                               |999991292            ||
|Jael de Jager           |                 |Ingeschreven Natuurlijk Persoon      |                               |999992740            ||
|Wladyslaw Kwasniewski   |                 |Ingeschreven Natuurlijk Persoon      |                               |999995017            ||
|Żáïŀëñøŕ Åłéèç Ðëļŧå Streeveld   |        |Ingeschreven Natuurlijk Persoon      |                               |999994669            ||
|Adrianus Hendrikus Holthuizen  |          |Ingeschreven Natuurlijk Persoon      |                               |999990421            ||
|Peter-Jan Meijden  |                      |Ingeschreven Natuurlijk Persoon      |                               |999993872            ||
|Paul Man          |                       |Ingeschreven Natuurlijk Persoon      |                               |999990883            ||
|Anne Janssens        |                       |Kadaster Natuurlijk Persoon    |80000001              |            |<ul><li>geslacht onbekend</li><li>kan niet op gezocht worden via /kadasternatuurlijkpersonen?q=</li></ul>|
|Jan Groenen          |                       |Kadaster Natuurlijk Persoon    |80000002              |            |<ul><li>aanduiding: eigen geslachtsnaam</li><li>kan niet op gezocht worden via /kadasternatuurlijkpersonen?q=</li></ul>|
|Susan in het Veld    |                       |Kadaster Natuurlijk Persoon    |80000003              |            |<ul><li>aanduiding: geslachtsnaam echtgenoot/geregistreerd partner na eigen geslachtsnaam</li><li>kan niet op gezocht worden via /kadasternatuurlijkpersonen?q=</li></ul>|
|Petra Anne Veldwijk  |                       |Kadaster Natuurlijk Persoon    |80000004              |            |<ul><li>aanduiding: geslachtsnaam echtgenoot/geregistreerd partner</li><li>kan niet op gezocht worden via /kadasternatuurlijkpersonen?q=</li></ul>|
|H Pieters            |                       |Kadaster Natuurlijk Persoon    |80000005              |            |<ul><li>aanduiding: geslachtsnaam echtgenoot/geregistreerd partner voor eigen geslachtsnaam</li><li>kan niet op gezocht worden via /kadasternatuurlijkpersonen?q=</li></ul>|
|Öle Klaassen         |                       |Kadaster Natuurlijk Persoon    |80000006              |            |<ul><li>diakriet in voornaam</li><li>kan niet op gezocht worden via /kadasternatuurlijkpersonen?q=</li></ul>|
|Baron Jan-Jaap de Vierde          |                       |Kadaster Natuurlijk Persoon    |80000007              |            |<ul><li>adellijke titel</li><li>kan niet op gezocht worden via /kadasternatuurlijkpersonen?q=</li></ul>|

#### Niet Natuurlijke Personen

|Statutaire Naam         |Zetel         |Type                                 |KadasterPersoonIdentificatie   |Bijzonderheden        |
|----------------        |------        |------                               |------                         |------                |
|Bankbedrijf             |ROTTERDAM     |Kadaster Niet Natuurlijk Persoon     |71291440      |<ul><li>postadres is postbus</li></ul>|
|Bankbedrijf van vrucht  |GRAVE         |Ingeschreven Niet Natuurlijk Persoon |71291493      |<ul><li>heeft niks op naam</li></ul>|
|Gasunie Test BV         |GRONINGEN     |Ingeschreven Niet Natuurlijk Persoon |440650207     |                                       |
|Gemeente Den Testland   |'S-GRAVENHAGE |Kadaster Niet Natuurlijk Persoon     |71291441      |<ul><li>kan niet op gezocht worden via /kadasternietnatuurlijkpersonen?q=</li></ul>|
|Woningstichting Den Testland |'S-GRAVENHAGE |Kadaster Niet Natuurlijk Persoon |71291442      |<ul><li>kan niet op gezocht worden /kadasternietnatuurlijkpersonen?q=</li></ul>|

#### Foutscenarios

|Aanvraag                                |Foutscenario   |
|-----                                   |-------        |
|/kadastraalonroerendezaken/122003147000 | 404 Not found |
|/kadastraalonroerendezaken/122003157000 | 410 Gone      |

## Aansluiten op productie
Voor de connectie met de productieomgeving van deze API is vereist:
- Een geldige API-key. Deze wordt bij de request opgenomen in request header "X-Api-Key". Wanneer je je aanmeldt voor het gebruiken van de API ontvang je de API-key.
- Internet toegang tot het Kadaster endpoint via IPv4 of IPv6 en met het TLS 1.2 protocol.
- Een Staat der Nederlanden root CA - G3 certificaat in de truststore, zie hiervoor: https://www.pkioverheid.nl/
- Een geldig PKIoverheid client certificaat met SERIALNUMMER=<eigen-OIN-nummer> in de keystore dat deel uitmaakt van de Staat der Nederlanden - G3 hiërarchie,
zie hiervoor: https://www.logius.nl/diensten/pkioverheid
- Een mutual TLS endpoint configuratie, waarbij de TLS verbinding met het Kadaster alleen tot stand mag en kan komen als er bij het opzetten van de verbinding een wederzijds vertrouwen op basis van de PKIoverheid certificaten hiërarchie bestaat.

### URL
De productieomgeving van de API is te benaderen via de volgende url: https://api.brk.kadaster.nl/esd/bevragen/v1/
