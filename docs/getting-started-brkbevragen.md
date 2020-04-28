# Getting Started

## BRK Bevragen API
De 'BRK Bevragen' API is gespecificeerd met behulp van de OpenAPI specifications (OAS).

### OAS specificatie
De (resolved) OAS specificatie is te downloaden van de Haal-Centraal-BRK-bevragen github repository - /specificatie/BRK-Bevragen/APILAB2603/genereervariant/openapi.yaml
Zie [openapi.yaml](../specificatie/BRK-Bevragen/APILAB2603/genereervariant/openapi.yaml)

### URI
De API lab versie is te benaderen via de volgende url: https://api.test.kadaster.nl/esd/gemeenten/brk/

### ApiKey
Om de api te kunnen bevragen is een apikey nodig. Voor de API lab is een algemene apiKey beschikbaar. 
Deze is ook alleen maar geldig op de API lab en zal na het API lab gedisabled worden.
De apiKey is: l768cdafa7d7ab474baf89a86754cc9a6a

### Werking
De werking van de API is het makkelijkst te testen met behulp van [Postman](https://www.getpostman.com/).
De openapi.yaml specficatie kun je importeren als project, waarna je de verschillende requests kunt doen.

Er is ook aan Postman collection beschikbaar met daarin een paar testgevallen, welke je ook kunt importeren in Postman.
Zie [Postman-collection](BRK-Bevragen%20API.postman_collection.json)

### Testgevallen
Onderstaande tabellen bevatten testgevallen voor specifieke situaties waarmee de werking van de API kan worden getest.

#### Onroerende Zaken
Testgeval                                       |Kadastraalobjectidentificatie              |Kadastraleaanduiding      |Postcode               |Bijzonderheden      |                                                                    
----------------                                |:-------                                   |:-------                  |:-------               |:-------           |
2 eigenaren (Kadaster Natuurlijk Persoon)       |NL.IMKAD.KadastraalObject.76870487970000   |Beekbergen:87 K 4879      |7361EW 29              |<ul><li>alle velden gevuld</li></ul> |
1 eigenaar (Kadaster Niet Natuurlijk Persoon)   |NL.IMKAD.KadastraalObject.76870488070000   |Beekbergen:87 K 4880      |7361EW 27              ||
1 eigenaar (Kadaster Natuurlijk Persoon)        |NL.IMKAD.KadastraalObject.76870482670000   |Beekbergen:87 K 4826      |7361EW 25              ||
1 eigenaar (Kadaster Niet Natuurlijk Persoon)   |NL.IMKAD.KadastraalObject.76870482570000   |Beekbergen:87 K 4825      |7361EW 21              |<ul><li>2 erfpachters met erfpachtcanon</li></ul>|
1 eigenaar (Ingeschreven Natuurlijk Persoon)    |NL.IMKAD.KadastraalObject.22310827210003   |'s Gravenhage:881 N 8272 3|2517GL 84              |<ul><li>appartementsrecht</li></ul> |
1 eigenaar (Ingeschreven Natuurlijk Persoon)    |NL.IMKAD.KadastraalObject.56020234070000   |Odoorn:717 N 2340         |9573PA 3               |<ul><li>1 artikel5_3b</li></ul>|
1 eigenaar (Ingeschreven Natuurlijk Persoon)    |NL.IMKAD.KadastraalObject.23280647970000   |Loosduinen:561 H 6479     |2551XS 31              ||
1 eigenaar (Ingeschreven Natuurlijk Persoon)    |NL.IMKAD.KadastraalObject.65490485370000   |Hellendoorn:395 G 4853    |7441JC 1 a             |<ul><li>bevat huisletter</li></ul>|
1 eigenaar (Ingeschreven Natuurlijk Persoon)    |NL.IMKAD.KadastraalObject.24780711870000   |Voorschoten:1040 B 7118   |2252EB 16              ||
1 eigenaar (Ingeschreven Natuurlijk Persoon)    |NL.IMKAD.KadastraalObject.17150075470000   |Hellevoetsluis:396 E 754  |3224EA 39              ||
1 eigenaar (Kadaster Niet Natuurlijk Persoon)   |NL.IMKAD.KadastraalObject.22590043870000   |'s Gravenhage:881 AW 438  |2545NN 182             |<ul><li>1 erfpachter</li></ul>|
1 eigenaar (Ingeschreven Natuurlijk Persoon)    |NL.IMKAD.KadastraalObject.17500393970000   |IJsselmonde:459 D 3939    |3078JG 4               ||
1 eigenaar (Ingeschreven Natuurlijk Persoon)    |NL.IMKAD.KadastraalObject.22360467970000   |'s Gravenhage:881 V 4679  |2597LD 58              |<ul><li>1 erfpachter</li></ul>|
1 eigenaar (Ingeschreven Natuurlijk Persoon)    |NL.IMKAD.KadastraalObject.19560032970000   |Rotterdam:841 AF 329      |3011KD 72              ||
2 eigenaren (Ingeschreven Natuurlijk Persoon)   |NL.IMKAD.KadastraalObject.17550448670000   |Kralingen:501 C 4486      |3066VS 9               ||

#### Natuurlijke Personen
Naam                    |Geboortedatum    |Type                                 |KadasterPersoonIdentificatie   | Burgerservicenummer |Bijzonderheden        |
----------------        |:-------         |:------                              |:------                        |:------              |:------              |
Willem Jansens          |1971-11-01       |Kadaster Natuurlijk Persoon          |NL.IMKAD.Persoon.70882239      |                     |<ul><li>alle velden gevuld</li><li>woonadres is niet bekend in BAG</li></ul> |
Sidonia Jansens         |1950-01-01       |Kadaster Natuurlijk Persoon          |NL.IMKAD.Persoon.50550743      |                     |<ul><li>buitenlands woonadres</li></ul> |
Christaan Goede         |1971-11-01       |Kadaster Natuurlijk Persoon          |NL.IMKAD.Persoon.71303564      |                     |<ul><li>woonadres is wel bekend in BAG</li></ul> |
Linda Haglund           |                 |Ingeschreven Natuurlijk Persoon      |                               |999991905            ||
Lisanty do Livramento...|                 |Ingeschreven Natuurlijk Persoon      |                               |999990482            ||
Merel Kooyman           |                 |Ingeschreven Natuurlijk Persoon      |                               |999993847            ||
Suzanne van der Stappen |                 |Ingeschreven Natuurlijk Persoon      |                               |999993653            ||
Mirjam Heijn            |                 |Ingeschreven Natuurlijk Persoon      |                               |999991292            ||
Jael de Jager           |                 |Ingeschreven Natuurlijk Persoon      |                               |999992740            ||
Wladyslaw Kwasniewski   |                 |Ingeschreven Natuurlijk Persoon      |                               |999995017            ||
Żáïŀëñøŕ Åłéèç Ðëļŧå Streeveld   |        |Ingeschreven Natuurlijk Persoon      |                               |999994669            ||
Adrianus Hendrikus Holthuizen  |          |Ingeschreven Natuurlijk Persoon      |                               |999990421            ||
Peter-Jan Meijden  |                      |Ingeschreven Natuurlijk Persoon      |                               |999993872            ||
Paul Man          |                       |Ingeschreven Natuurlijk Persoon      |                               |999990883            ||

#### Niet Natuurlijke Personen
Statutaire Naam         |Zetel        |Type                                 |KadasterPersoonIdentificatie   |Bijzonderheden | 
----------------        |:------      |:------                              |:------                        |:------        |
Bankbedrijf             |ROTTERDAM    |Kadaster Niet Natuurlijk Persoon     |NL.IMKAD.Persoon.71291440      |<ul><li>postadres is postbus</li></ul> |
Bankbedrijf van vrucht  |GRAVE        |Ingeschreven Niet Natuurlijk Persoon |NL.IMKAD.Persoon.71291493      |  |
Gasunie Test BV         |GRONINGEN    |Ingeschreven Niet Natuurlijk Persoon |NL.IMKAD.Persoon.440650207     |  |

#### Foutscenarios
Aanvraag                                                                                       | Foutscenario               |
----------------                                                                               | :-------                   |
/kadastraalonroerendezaken/NL.IMKAD.KadastraalObject.122003147000                              | 404 Not found              |
/kadastraalonroerendezaken/NL.IMKAD.KadastraalObject.122003157000                              | 410 Gone                   |
