# Release notes BRK-Bevragen

## Versie 1.1.1:

Inhoudelijk is er in deze patch niets gewijzigd.
De structuur van de yaml-bestanden is aangepast omdat het bestand erg groot en onoverzichtelijk werd.
Door deze opslitsing is het beheer overzichtelijker en is het werken aan toekomstige wijzigingen beter te managen.

De openapi.yaml in de genereervariant is gewijzigd als gevolg van het gebruiken van een andere generator voor het resolven.
Deze wijzigingen betreffen hoofdzakelijk volgorde wijzigingen van schemacomponenten.
Daarnaast zijn er enkele parameter-properties met default-waarden nu expliciet opgenomen in de genereervariant.   

## Versie 1.1.0:

De repository is opgeschoond. Mappen die overbodig waren zijn verwijderd. De specificatie van de Waardelijsten API is verwijderd omdat die nog niet geïmplementeerd is.
Dit heeft ook gevolgen voor de tree: Map BRK-Bevragen is komen te vervallen en openapi.yaml en de map genereervariant staan direct onder de map /specificatie).

### openapi.yaml:

- Productie- en test-servers toegevoegd
- API-key toegevoegd
- Ongebruikte headers en foutcode uit de specificatie verwijderd
- Domein toegevoegd
- Onnodig geneste objecten als component gedefinieerd
- Namen van enkele query parameters aangepast
- Enkele property-namen aangepast

Enkele van deze wijzigingen zouden "breaking" zijn voor reeds gebouwde consumer-software. Op het moment van live-gang van versie 1.1.0 waren echter nog geen comsumer-implementaties in productie. Zodoende is besloten om de het versienummer met een minor op te hogen.

### features:

- Levering-koopsom.feature is gewijzigd
- Levering-velden.feature is gewijzigd

### code:

De map "code" is toegevoegd. Deze map bevat gegenereerde code voor C#, Java en Python. Dit wordt beschikbaar gesteld voor het gemak van ontwikkelaars. Het staat ontwikkelaars uiteraard vrij om eigen code te bouwen of genereren.

### testen:

De map "test" is toegevoegd. Deze map bevat testgevallen die in de testomgeving beschikbaar zijn.

### issues:

Alle issues die in deze release zijn opgelost hebben in de issues-lijst het label "BRK-Bevragen 1.1" gekregen. Door op dit label te filteren in de (gesloten) issues is een gedetailleerd overzicht van wijzigingen en bug-fixes te krijgen.
