# Getting Started

## BRK Bevragen API
De 'BRK Bevragen' API is gespecificeerd met behulp van de OpenAPI specifications (OAS).

### OAS specificatie
De (resolved) OAS specificatie is te downloaden van de Haal-Centraal-BRK-bevragen github repository - /specificatie/BRK-Bevragen/openapi.yaml

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
- Foutafhandeling: alle foutsituaties geven nu een http 404 error response terug
- Fields & Expand query parameters
- Ophalen Kadastraal Onroerende Zaken op basis van een kadastraleAanduiding (kadastraleGemeenteNaam, sectie, perceelNummer)
- Ophalen van stukken
- Ophalen van hypotheken van een specifieke geldverstrekker
- Ophalen van beslagen van een specifieke beslaglegger 

### Testgevallen
Onderstaande tabellen bevatten testgevallen voor specifieke situaties waarmee de werking van de API kan worden getest, uitgespecificeerd per endpoint

#### Endpoint /kadastraalonroerendezaken?kadastraalPersoonIdentificatie={kpi}
Om kadastrale onroerende zaken op te vragen van een specifiek persoon waar de persoon eigenaar is op basis van een KPI

kpi test persoon | situatie
---------------- | :-------  
NL.IMKAD.Persoon.158578833 | Derks (Kadaster Natuurlijk Persoon)
NL.IMKAD.Persoon.158578844  | Goedhart (Kadaster Natuurlijk Persoon)

#### Endpoint /kadastraalonroerendezaken?burgerservicenummer={bsn}
Om kadastrale onroerende zaken op te vragen van een specifiek persoon waar de persoon eigenaar is op basis van een BSN

bsn test persoon | situatie
---------------- | :-------  
999991905 | Haglund
999993872 | Meijden
999993926 | Leemstra
999993550 | Jansen-de Groot
999990421 | Holthuizen
999990482 | Livramento
999994669 | Streeveld

#### Endpoint /kadastraalonroerendezaak/{koi}
Om informatie over een kadastrale onroerende zaak op te vragen op basis van een KadastraalObjectIdentificatie. 

Verder kunnen van deze kadastraal onroerende zaak de:
- zakelijkgerechtigden van het type eigenaar opgevraagd worden via /kadastraalonroerendezaak/{koi}/zakelijkgerechtigden?type=eigenaar
- hypotheken opgevraagd worden via /kadastraalonroerendezaak/{koi}/hypotheken
- beslagen opgevraagd worden via /kadastraalonroerendezaak/{koi}/beslagen

koi         |   situatie
---------------- | :------- 
NL.IMKAD.KadastraalObject.76370602970000    |	1 eigenaar; 1 geldverstrekker
NL.IMKAD.KadastraalObject.15710077470000    |	2 eigenaren; 1 geldverstrekker is particulier
NL.IMKAD.KadastraalObject.25850153070000	|   1 eigenaar; 2 geldverstrekkers
NL.IMKAD.KadastraalObject.89100047270000	|   1 eigenaar; geen hypotheek op dit object
NL.IMKAD.KadastraalObject.1220294670000	    |   2 eigenaren; 2 hypotheken bij 1 geldverstrekker
NL.IMKAD.KadastraalObject.2560430970000	    |   1 eigenaar; 2 beslagen (conservatoir beslag en  executoriaal beslag); 2 geldverstrekkers waarvan 1 particulier

#### Endpoint /kadasternatuurlijkpersonen/{kpi}
Om informatie over een kadaster natuurlijk persoon op te vragen op basis van een KadastraalPersoonIdentificatie.

kpi test persoon | situatie
---------------- | :-------  
NL.IMKAD.Persoon.15878833 | Derks (Kadaster Natuurlijk Persoon)
NL.IMKAD.Persoon.15878844 | Goedhart (Kadaster Natuurlijk Persoon) 
NL.IMKAD.Persoon.68910095 | Oever (Kadaster Natuurlijk Persoon)

#### Endpoint /kadasternietnatuurlijkpersonen/{kpi}
Om informatie over een kadaster niet natuurlijk persoon op te vragen op basis van een KadastraalPersoonIdentificatie. 
Deze persoon kan een Kadaster Niet Natuurlijk Persoon zijn (rsin/kvk nummer niet bekend) of een Ingeschreven Niet Natuurlijk Persoon (rsin/kvk nummer wel bekend)

kpi test persoon | situatie
---------------- | :-------  
NL.IMKAD.Persoon.537471837  | DeHypotheekverstrekker Brussel (Kadaster Niet Natuurlijk Persoon)
NL.IMKAD.Persoon.449125246  | GoedeHypotheken B.V. Rotterdam (Kadaster Niet Natuurlijk Persoon)
NL.IMKAD.Persoon.24268005   | AlleenGoedeHypotheken Vlaardingen (Kadaster Niet Natuurlijk Persoon)
NL.IMKAD.Persoon.537742055  | Beslaglegger1 Utrecht (Kadaster Niet Natuurlijk Persoon)
NL.IMKAD.Persoon.146134936  | Vastgoed Hypotheken Zeist (Kadaster Niet Natuurlijk Persoon)
NL.IMKAD.Persoon.533499594  | BetereGeld B.V. Groningen (Kadaster Niet Natuurlijk Persoon)
NL.IMKAD.Persoon.537735891  | GoedeKeuze B.V. Assen (Ingeschreven Niet Natuurlijk Persoon) 