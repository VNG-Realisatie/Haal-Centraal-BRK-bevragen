# Releasenotes BRK-Bevragen

## Versie 1.1.0 :

### openapi.yaml :

- Productie en test-servers toegevoegd
- Api-Key toegevoegd
- Ongebruikte headers en foutcode uit de specificatie verwijderd.
- Domein toegevoegd
- Onnodig geneste objecten als component gedefinieerd.
- Namen van enkele query parameters aangepast
- Enkele property-namen aangepast

Enkele van deze wijzigingen zouden "breaking" zijn voor reeds gebouwde consumer-software. Er zijn op het moment van live-gang van versie 1.1.0 echter nog geen comsumer-implementaties in productie. Daarom is besloten om de het versienummer met een minor op te hogen.

### features:

Levering-koopsom.feature is gewijzigd
Levering-velden.feature is gewijzigd

### code

De map code is toegevoegd en bevat gegenereerde code voor csharp, java en python. Dit is een convenience-voorziening. Het staat developers uiteraard vrij om eigen code te genereren.

### test

De map test is toegevoegd. Deze map bevat testgevallen die in de testomgeving beschikbaar zijn.
