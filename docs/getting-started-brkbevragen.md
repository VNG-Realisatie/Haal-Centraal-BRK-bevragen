# Getting Started

## BRK Bevragen API
De 'BRK Bevragen' API is gespecificeerd met behulp van de OpenAPI specifications (OAS).

### OAS specificatie
De (resolved) OAS specificatie is te downloaden van de Haal-Centraal-BRK-bevragen github repository - /specificatie/BRK-Bevragen/openapi.yaml
Zie [openapi.yaml](../specificatie/BRK-Bevragen/openapi.yaml)

### URI
De API lab versie is te benaderen via de volgende url: https://api.test.kadaster.nl/esd/gemeenten/brk/

### ApiKey
Om de api te kunnen bevragen is een apikey nodig. Voor de API lab is een algemene apiKey beschikbaar. 
Deze is ook alleen maar geldig op de API lab en zal na het API lab gedisabled worden.
De apiKey kan opgevraagd worden bij de mensen van het BRK team.

### Werking
De werking van de API is het makkelijkst te testen met behulp van [Postman](https://www.getpostman.com/).
De openapi.yaml specficatie kun je importeren als project, waarna je de verschillende requests kunt doen.

Er is ook aan Postman collection beschikbaar met daarin een paar testgevallen, welke je ook kunt importeren in Postman.
Zie [Postman-collection](BRK-Bevragen%20API.postman_collection.json)

### Testgevallen
Onderstaande tabellen bevatten testgevallen voor specifieke situaties waarmee de werking van de API kan worden getest.

#### Onroerende Zaken
Testgeval                                       |Kadastraalobjectidentificatie              |Kadastraleaanduiding   |Postcode & huisnummer  |                                                                    
----------------                                |:-------                                   |:-------               |:-------               |
2 eigenaren (Kadaster Natuurlijk Persoon)       |NL.IMKAD.KadastraalObject.76870487970000   |Beekbergen K 4879      |7361EW 29              |
1 eigenaar (Kadaster Niet Natuurlijk Persoon)   |NL.IMKAD.KadastraalObject.76870488070000   |Beekbergen K 4880      |7361EW 27              |
1 eigenaar (Kadaster Natuurlijk Persoon)        |NL.IMKAD.KadastraalObject.76870482670000   |Beekbergen K 4826      |7361EW 25              |
1 eigenaar (Kadaster Niet Natuurlijk Persoon)   |NL.IMKAD.KadastraalObject.76870482570000   |Beekbergen K 4825      |7361EW 21              |
1 eigenaar (Ingeschreven Natuurlijk Persoon)    |NL.IMKAD.KadastraalObject.22310827210003   |'s-Gravenhage N 8272 3 |                       |

#### Personen
Naam                    |Geboortedatum    |Zetel        |Type                                 |KadasterPersoonIdentificatie   | Burgerservicenummer |
----------------        |:-------         |:------      |:------                              |:------                        |:------              |
Christaan Goede         |1971-11-01       |             |Kadaster Natuurlijk Persoon          |NL.IMKAD.Persoon.71303564      |                     |
Willem Jansens          |1971-11-01       |             |Kadaster Natuurlijk Persoon          |NL.IMKAD.Persoon.70882239      |                     |
Sidonia Jansens         |1950-01-01       |             |Kadaster Natuurlijk Persoon          |NL.IMKAD.Persoon.50550743      |                     |
Linda Haglund           |1950-01-01       |             |Ingeschreven Natuurlijk Persoon      |                               |999991905            |
Bankbedrijf             |                 |ROTTERDAM    |Kadaster Niet Natuurlijk Persoon     |NL.IMKAD.Persoon.71291440      |                     |
Bankbedrijf van vrucht  |                 |GRAVE        |Kadaster Niet Natuurlijk Persoon     |NL.IMKAD.Persoon.71291493      |                     |

#### Foutscenarios
Aanvraag                                                                                       | Foutscenario               |
----------------                                                                               | :-------                   |
/kadastraalonroerendezaken/NL.IMKAD.KadastraalObject.122003017000                              | 500 Internal server error  |
/kadastraalonroerendezaken/NL.IMKAD.KadastraalObject.122003147000                              | 404 Not found              |
/kadastraalonroerendezaken/NL.IMKAD.KadastraalObject.122003157000                              | 410 Gone                   |
