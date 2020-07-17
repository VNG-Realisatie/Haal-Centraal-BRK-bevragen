# Release notes BRK-Bevragen

## Versie 1.1.0:

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
