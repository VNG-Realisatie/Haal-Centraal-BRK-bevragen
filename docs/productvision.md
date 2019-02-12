# Productvisie BRK Bevragen

## Introductie
Het programma Haal Centraal heeft tot doel het verstrekken van basisgegevens aan binnengemeentelijke afnemers te outsourcen naar Landelijke Registraties (Kadaster, KVK, RvIG). Voor de BRK wordt gestart wordt met de realisatie van een API voor het zoeken en raadplegen van kadastrale onroerende zaken.

### Toegevoegde waarde voor gemeenten
- sneller aansluiten afnemers 
- goedkoper aansluiten afnemers (x aantal binnegemeentelijke aansluiters x 351 gemeenten)
- lagere investeringen (geen lokale kopie/ gegevensmagazijn)
- lagere beheerkosten (geen gegevensbeheer lokale kopieen)
- hogere ROI op de API door hergebruik door alle gemeenten
- betere technologie-business alignment (Landelijke Registratie voert sneller een wijziging door dan 351 afzonderlijke gemeenten) 
- meer focus op de businessvraag van afnemers (geen aandacht meer nodig voor gegevensbeheer)
- compliancy op de softwaremarkt (1 aanbieder van een API betekent 100% herbruikbare stekkers bij gemeenten)

### Toegevoegde waarde voor leveranciers
- Kunnen zich richten op het bieden van toegevoegde waarde voor burgers, bedrijven en medewerkers i.p.v. plumbing

## Context
Haal Centraal is een G5 initiatief (Amsterdam, Rotterdam, Den Haag, Utrecht en Eindhoven). Het concept is getoetst in de BRK pilot van de gemeente Den Haag en het Kadaster. Businesscase op basis van ervaringscijfers gemeente Den Haag en softwareontwikkeling tbv de pilot. 

## Productvisie

BRK bevragen API is:

- Business driven 
resourcedefinitie op basis van de businessvraag van de grootste gemene infobehoefte van alle binnengemeentelijke afnemers van NL. Dit is niet hetzelfde als modelgedreven ontwikkeling (MDD)! Traceerbaarheid naar het informatiemodel waarborgt scope, semantiek en volledigheid. 

- Consumer first 
voordelen zoveel mogelijk bij de consumer (=binnengemeentelijke afnemer) vanwege de hefboomwerking: complexiteit bij de provider (1x), de voordelen in kosten en doorlooptijd bij de consumer (maal x maal 351)

- Developer first
Focus op en getest op bruikbaarheid voor de ontwikkelaar (AOS spec getest op codegeneratie (Java, .NET meest gebruikt in gemeentelijke markt), consistentie met andere Haal Centraal API’s en Landelijke API Strategie, ontwerpbeslissingen worden getest op het effect op de code, BDD scenario's in Gherkin om het gedrag van de API te beschrijven.

- Contract first
…en niet development first. Agnostisch, vrij van implementatiedetails (uit providersysteem), niet gevoelig voor wijzigen systeemlogica provider.

- Agnostisch
= Zonder kennis van de consumer. Moet door alle gemeentelijke processen kunnen worden gebruikt die BRK gegevens nodig hebben.

- Geïmplementeerd 
Kadaster bouwt de API, gemeente Den Haag, gemeente Amsterdam en Vicrea bouwen consumers. 

Non functionals:
- supersnel
- schaalbaar
- betrouwbaar
- resilient

## Scope
Ontwerp o.b.v. een inventarisatie informatiebehoefte binnengemeentelijke afnemers. Invulling van de informatiebehoefte wordt beperkt door de inhoud van het BRK informatiemodel.

## REST
De API is zo RESTful mogelijk.

## DSO API Strategie
Het project conformeert zich aan de DSO API strategie en levert een bijdrage aan de ontwikkeling van deze strategie naar een landelijke API strategie voor de Nederlandse overheid.  

## Uitgangspunten
- Startpunt voor informatiemodellen van gegevens in de berichten is IMKAD model versie .....
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

OAS3 specs worden opgesteld door VNG Realisatie ism een developer 
OAS3 specs worden getoetst door een developer. 
BDD scenario's worden beschreven door de PO, VNG Realisatie en de developer. 
BRK bevragen API wordt gerealiseerd door het Kadaster
Consumers worden gerealiseerd door de gemeente Den Haag, de gemeente Amsterdam en Vicrea

Alle deelproducten (deliverables) van het project worden gepubliceerd op het GitHub project, m.u.v. de consumers van de gemeente Den Haag en Vicrea. De API specificaties worden daarnaast op SWAGGERhub geplaatst.

