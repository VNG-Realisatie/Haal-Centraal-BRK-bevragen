# Productvisie BRK Bevragen

## Introductie
Doel van het programma Haal Centraal het verstrekken van basisgegevens aan binnengemeentelijke afnemers te outsourcen naar Landelijke Registraties (Kadaster, KVK, RvIG). Dit moet leiden tot een forse reductie van lokale kopieën bij gemeenten. 

We doen dit door voor zoveel mogelijk activiteiten op een lokale kopie een Haal Centraal alternatief te bieden in de vorm van een API. De BRK bevragen API biedt binnengemeentelijke afnemers (e.a.) de mogelijkheid om kadastrale onroerende zaken te zoeken en raadplegen.

### Toegevoegde waarde voor gemeenten
- sneller aansluiten afnemers 
- goedkoper aansluiten afnemers (x aantal binnegemeentelijke aansluiters x 351 gemeenten)
- lagere investeringen (geen lokale kopie/ gegevensmagazijn)
- lagere beheerkosten (geen gegevensbeheer lokale kopieën)
- hogere ROI: hergebruik API Landelijke Registratie door alle gemeenten
- betere technologie-business alignment (Landelijke Registratie voert sneller een wijziging door dan 351 afzonderlijke gemeenten) 
- meer focus op de businessvraag van afnemers (i.p.v. op betrouwbaarheid etc. lokale kopieën)
- maximale compliancy op de gemeentelijke softwaremarkt (aansluiting gemeente x = 100% herbruikbaar in gemeente y)

### Toegevoegde waarde voor leveranciers
- Kunnen zich richten op het bieden van toegevoegde waarde voor burgers, bedrijven en medewerkers i.p.v. plumbing concerns.

## Context
Haal Centraal is een G5 initiatief (Amsterdam, Rotterdam, Den Haag, Utrecht en Eindhoven). Het concept is getoetst in de BRK pilot van de gemeente Den Haag met het Kadaster op basis van de RSGB bevragingen standaard (voorloper BRK-bevragen). De businesscase is gebaseerd op ervaringscijfers van de gemeente Den Haag en de softwareontwikkeling gedurende de pilot. 

## Productvisie

BRK bevragen API is:

### Business driven 
Resourcedefinitie op basis van de businessvraag van de grootste gemene infobehoefte van alle binnengemeentelijke afnemers van NL. 
Is niet hetzelfde als modelgedreven ontwikkeling (MDD). Wel is er sprake van traceerbaarheid naar het IMKAD informatiemodel. Dit waarborgt de realiseerbaarheid, semantiek en volledigheid van de API. 

- Consumer first
#Gestreefd wordt naar zoveel mogelijk voordelen bij de consumer (=binnengemeentelijke afnemer) vanwege de hefboomwerking: complexiteit bij de provider (1x), de voordelen in kosten en doorlooptijd bij de consumer (aantal binnengemeentelijke afnemers x 351)

- Developer first
Focus op bruikbaarheid voor de ontwikkelaar: AOS spec wordt getest op codegeneratie (Java, .NET meest gebruikt in gemeentelijke markt), ontwerpbeslissingen worden getest op het effect op de code, maximale consistentie met andere Haal Centraal API’s, compliancy aan Landelijke API Strategie, BDD scenario's in Gherkin om het gedrag van de API te beschrijven.

- Contract first
…en niet development first. Agnostisch, vrij van implementatiedetails (uit providersysteem), niet gevoelig voor wijzigen systeemlogica provider.

- Agnostisch
= zonder kennis van de consumer. De API moet door alle (in theorie 200 verschillende) gemeentelijke processen kunnen worden gebruikt die BRK gegevens nodig hebben.

- Geïmplementeerd 
Kadaster bouwt de API, de gemeente Den Haag, de gemeente Amsterdam en Vicrea bouwen consumers in een SCRUM traject. 

Non functionals:
- supersnel
- schaalbaar
- betrouwbaar
- resilient

## Scope
Ontwerp o.b.v. een inventarisatie informatiebehoefte binnengemeentelijke afnemers. Invulling van de informatiebehoefte wordt beperkt door de inhoud van het BRK informatiemodel.

## REST
De API is zo RESTful mogelijk, met het oog op maximale realisatie van de REST doelstellingen: performance, schaalbaarheid, eenvoud, aanpasbaarheid, zichtbaarheid, verplaatsbaarheid en betrouwbaarheid.  

## DSO API Strategie
Het project conformeert zich aan de DSO API strategie en levert een bijdrage aan de ontwikkeling van deze strategie naar een landelijke API strategie voor de Nederlandse overheid.  

## Uitgangspunten
- Alle ingredienten van de API zijn herleidbaar naar het IMKAD model
- Alle code, documenten en specificaties die ontstaan in dit traject wordt Open
Source gepubliceerd onder de
[EUPL licentie](https://joinup.ec.europa.eu/collection/eupl/eupl-text-11-12).
- Voor de specificatie van API's wordt de onlangs door Forum Standaardisatie op
de
["Pas toe of leg uit"-lijst](https://www.forumstandaardisatie.nl/lijst-open-standaarden/in_lijst/verplicht-pas-toe-leg-uit)
geplaatste
[OpenAPI Specification v3.x](https://www.forumstandaardisatie.nl/standaard/openapi-specification)
gebruikt.
- De
[API en URI strategie](https://aandeslagmetdeomgevingswet.nl/digitaal-stelsel/documenten/documenten/api-uri-strategie/)
zoals opgesteld binnen het programma Digitaal Stelsel Omgevingswet worden waar
mogelijk toegepast.

## Realisatie
Van iedere informatiebehoefte van binnengemeentelijke afnemers wordt een issue (user story) gemaakt. Voor deze issues worden achtereenvolgens AOS3 specs en featues opgesteld en gerealiseerd. 

OAS3 specs worden opgesteld door VNG Realisatie adviseur standaarden ism een developer 
OAS3 specs worden getoetst door een developer. 
BDD scenario's worden beschreven door de PO, VNG Realisatie adviseur standaarden en de developer. 
BRK bevragen API wordt gerealiseerd door het Kadaster
Consumers worden gerealiseerd door de gemeente Den Haag, de gemeente Amsterdam en Vicrea

Alle deelproducten (deliverables) van het project worden gepubliceerd op het GitHub project, m.u.v. de consumers van de gemeente Den Haag en Vicrea. De API specificaties worden daarnaast op SWAGGERhub geplaatst.

