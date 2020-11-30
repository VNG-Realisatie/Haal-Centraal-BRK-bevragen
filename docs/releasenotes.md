# Release notes BRK-Bevragen


## **Versie 1.3.0:**

### openapi.yaml

- Algemeen
  - Nieuwe endpoints toegevoegd voor stukken en stukdelen.
  - Bestaande resources zijn (voorzover van toepassing) uitgebreid met relaties naar de betrokken stukken en stukdelen.

- stukken
  2 nieuwe endpoints:
  - /stukken/{stukidentificatie}
  - /stukdelen/{stukdeelidentificatie}

- kadastraalOnroerendeZaken
  - nummeraanduidingIdentificatie is toegevoegd als queryparameter aan /kadastraalonroerendezaken
  - Properties toegevoegd:
    - indicatieVervallenKadastraalOnroerendeZaak
    - einddatumRecht
    - isOvergegaanIn
    - isOntstaanUit
    - bijbeherendeGrondperceelIdentificatie
    - bijbehorendeAppartementsrechtIdentificaties
    - stukIdentificaties
    - adresseerbaarObjectIdentificatie (bij adres)
  - Links toegevoegd:
    - isOntstaanUit (achterwaartse filiatie naar gerelateerde kadastraalOnroerendeZaak)
    - isOvergegaanIn (voorwaartse filiatie naar gerelateerde kadastraalOnroerendeZaak)
    - stukken
    - adressen ([Haal-Centraal BAG-endpoint](https://vng-realisatie.github.io/Haal-Centraal-BAG-bevragen/) is nu in productie beschikbaar )
    - adresseerbareObjecten, ook beschikbaar via [Haal-Centraal BAG-endpoint](https://vng-realisatie.github.io/Haal-Centraal-BAG-bevragen/)
    - bijbehorendGrondperceel (link naar de betreffende gerelateerde kadastraalOnroerendeZaak)
    - bijbehorendeAppartementsrechten (links naar gerelateerde kadastraalOnroerendeZaekn die als appartementsrecht ontstaan zijn uit deze kadastraalOnroerendeZaak.

- hypotheken
  - Properties toegevoegd:
    - stukIdentificaties
    - omschrijvingGekozenWoonplaats
    - isGebaseerdOpStukdeelIdentificatie
    - isVermeldInStukdeelIdentificaties
  - De links naar stukken, isGebaseerdOpStukdeel en isVermeldInStukdelen zijn opgenomen.

-  beslagen
  - Properties toegevoegd:
    - stukIdentificaties
    - isGebaseerdOpStukdeelIdentificatie
    - isVermeldInStukdeelIdentificaties
  - De links naar stukken, isGebaseerdOpStukdeel en isVermeldInStukdelen zijn opgenomen.

- privaatrechtelijkeBeperkingen
  - Properties toegevoegd (overerfd uit Aantekening):
    - stukIdentificaties
    - isGebaseerdOpStukdeelIdentificatie
    - isVermeldInStukdeelIdentificaties
  - De links naar stukken, isGebaseerdOpStukdeel en isVermeldInStukdelen zijn opgenomen.

- publiekrechtelijkeBeperkingen
  - Properties toegevoegd:
    - stukIdentificaties
    - isGebaseerdOpStukdeelIdentificatie
    - isVermeldInStukdeelIdentificaties
  - De links naar stukken, isGebaseerdOpStukdeel en isVermeldInStukdelen zijn opgenomen.

- zakelijkGerechtigde
  - Properties toegevoegd:
    - stukIdentificaties
    - isGebaseerdOpStukdeelIdentificatie
    - isVermeldInStukdeelIdentificaties
    - erfpachtCanon.isGebaseerdOpStukdeelIdentificatie
    - erfpachtCanon.isVermeldInStukdeelIdentificaties
    - tenaamstelling.isGebaseerdOpStukdeelIdentificatie
    - tenaamstelling.isVermeldInStukdeelIdentificaties
  - De links naar stukken, isGebaseerdOpStukdeel en isVermeldInStukdelen zijn opgenomen.


## **Versie 1.2.0:**

### openapi.yaml

- Algemeen
  - Nieuwe endpoints toegevoegd voor hypotheken, beslagen, privaatrechtelijke- en publiekrechtelijke Beperkingen
  - Enkele properties deprecated verklaard
  - Diverse verbeteringen in de documentatie (descriptions) en examples.
  - Er is gebruikgemaakt van Haal-Centraal-common versie 1.2.0 (was 1.0.0)
  - De default-waarde voor de Accept-Crs header is verwijderd.
  - Uit alle componentnamen zijn de underscores verwijderd.


- hypotheken
  - 2 nieuwe endpoints:
    - /kadastraalonroerendezaken/{kadastraalonroerendezaakidentificatie}/hypotheken
    - /kadastraalonroerendezaken/{kadastraalonroerendezaakidentificatie}/hypotheken/{hypotheekidentificatie}


- beslagen
  - 2 nieuwe endpoints:
    - /kadastraalonroerendezaken/{kadastraalonroerendezaakidentificatie}/beslagen
    - /kadastraalonroerendezaken/{kadastraalonroerendezaakidentificatie}/beslagen/{beslagidentificatie}


- privaatrechtelijkeBeperkingen
  - 2 nieuwe endpoints:
    - /kadastraalonroerendezaken/{kadastraalonroerendezaakidentificatie}/privaatrechtelijkebeperkingen
    - /kadastraalonroerendezaken/{kadastraalonroerendezaakidentificatie}/privaatrechtelijkebeperkingen/{privaatrechtelijkebeperkingidentificatie}


- publiekrechtelijkeBeperkingen
  - 1 nieuw endpoint:   
    - /publiekrechtelijkebeperkingen


- kadastraalOnroerendeZaken
  - De default-waarde voor de Accept-Crs header is verwijderd bij /kadastraalonroerendezaken/{kadastraalonroerendezaakidentificatie}
  - privaatrechtelijkeBeperkingen is toegevoegd aan de _embedded en de _links. hypotheken en beslagen zijn toegevoegd aan de _links. De bijbehorende identificaties zijn opgenomen in de kadastraalOnroerendeZaak.
  - locatieKadastraalObject levert naast nummeraanduidingIdentificatie nu ook het adres.


- zakelijkGerechtigden
  - Accept-Crs header en Content-Crs header zijn toegevoegd bij
    - /kadastraalonroerendezaken/{kadastraalonroerendezaakidentificatie}/zakelijkgerechtigden/{zakelijkgerechtigdeidentificatie}
    - /kadastraalonroerendezaken/{kadastraalonroerendezaakidentificatie}/zakelijkgerechtigden


- aantekening  
  - Properties begrenzing en indicatieOorspronkelijkObject worden niet meer geleverd en zijn deprecated verklaard


- kadasterNatuurlijkPersonen
  - aanschrijfwijze, aanhef en gebruikInLopendeTekst zijn toegevoegd aan naam.


- heeftPartnerschap
  - Properties datumOntbinding en datumSluiting worden niet meer geleverd en zijn deprecated verklaard

### features:

De volgende features zijn toegevoegd:
- aanhef.features
- aanschrijfwijze.features
- gebruik_in_lopende_tekst.feature
- voorletters.feature

### issues:

Alle issues die in deze release zijn opgelost hebben in de issues-lijst het label "BRK-Bevragen 1.2.0" gekregen. Door op dit label te filteren in de (gesloten) issues is een gedetailleerd overzicht van wijzigingen en bug-fixes te krijgen.

Known issues die voor versie 1.2.1 gepland zijn :
 #521: bij zoeken personen worden niet alle gegevens geleverd
 #725: bij zoeken natuurlijk personen worden aanschrijfwijze, aanhef en gebruikInLopendeTekst niet correct gevuld



## **Versie 1.1.1:**

Inhoudelijk is er in deze patch niets gewijzigd.
De structuur van de yaml-bestanden is aangepast omdat het bestand erg groot en onoverzichtelijk werd.
Door deze opslitsing is het beheer overzichtelijker en is het werken aan toekomstige wijzigingen beter te managen.

De openapi.yaml in de genereervariant is gewijzigd als gevolg van het gebruiken van een andere generator voor het resolven.
Deze wijzigingen betreffen hoofdzakelijk volgorde wijzigingen van schemacomponenten.
Daarnaast zijn er enkele parameter-properties met default-waarden nu expliciet opgenomen in de genereervariant.   

## **Versie 1.1.0:**

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
