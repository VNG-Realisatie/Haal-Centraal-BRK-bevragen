# language: nl

Functionaliteit: Als gemeente wil ik de juiste en consistente briefaanhef in communicatie naar burgers
  Attribuut "aanhef" bij een natuurlijk persoon wordt gevuld om de persoon op eenduidige wijze te kunnen aanschrijven.
  De aanhef wordt gebruikt bovenaan een brief.

  Attribuut aanhef wordt samengesteld op basis van:
  - adellijkeTitelOfPredikaat
  - aanduidingNaamgebruik
  - naam
    - geslachtsnaam
    - voorvoegselsgeslachtsnaam
  - geslacht
    - geslachtsaanduiding
  - heeftPartnerschap
    - naamPartner
      - geslachtsnaam
      - voorvoegselsgeslachtsnaam

  In de BRK is niet bekend of de partner een adellijke titel heeft. In de aanhef wordt daarom nooit een adellijke titel van de partner gebruikt.

  In onderstaande tabellen betekenen de afkortingen voor naamcomponenten:
  - AH = aanhef afhankelijk van geslachtsaanduiding:
    - Als geslachtsaanduiding==1 (Man) Dan “Geachte heer”
    - Als geslachtsaanduiding==2 (Vrouw) Dan “Geachte mevrouw"
    - Als geslachtsaanduiding==3 (Onbekend) Dan de voorletters
  - AP = AdellijkeTitelOfPredikaat
  - VV = naam.voorvoegselsgeslachtsnaam
  - GN = naam.geslachtsnaam
  - VP = heeftPartnerschap.naamPartner.voorvoegselsgeslachtsnaam
  - GP = heeftPartnerschap.naamPartner.geslachtsnaam

  Codes voor aanduidingNaamgebruik hieronder zijn volgens waardelijst [BRPAanduidingNaamgebruik](https://www.kadaster.nl/schemas/waardelijsten/BRPAanduidingNaamgebruik/)
  - E	= Eigen geslachtsnaam
  - P	= Geslachtsnaam echtgenoot/geregistreerd partner
  - V	= Geslachtsnaam echtgenoot/geregistreerd partner voor eigen geslachtsnaam
  - N	= Geslachtsnaam echtgenoot/geregistreerd partner na eigen geslachtsnaam

  Samenstelling van aanhef voor een persoon zonder adellijke titel of predikaat:
  | aanduidingNaamgebruik | aanhef          |
  | E                     | AH VV GN        |
  | N                     | AH VV GN-VP GP  |
  | P                     | AH VP GP        |
  | V                     | AH VP GP-VV GN  |

  Bij de samenstelling van de aanhef voor een persoon zonder adellijke titel of predikaat volgens bovenstaande tabel gelden de volgende regels:
  1. Wanneer geslachtsaanduiding=1 (Man) of 2 (Vrouw), dan wordt het voorvoegsel van de eerste geslachtsnaam in de aanhef met een hoofdletter geschreven.
  2. Wanneer een naamcomponent geen waarde heeft, wordt ook de spatie erna niet opgenomen.

  Wanneer de persoon een adellijke titel of predikaat heeft, en de persoon gebruikt de eigen naam (aanduidingNaamgebruik ongelijk aan "P"), dan wordt de aanhef gevuld volgens de volgende tabel:
  | adellijkeTitelOfPredikaat | aanhef                |
  | Baron                     | Hoogwelgeboren heer   |
  | Barones                   | Hoogwelgeboren vrouwe |
  | Graaf                     | Hooggeboren heer      |
  | Gravin                    | Hooggeboren vrouwe    |
  | Hertog                    | Hoogwelgeboren heer   |
  | Hertogin                  | Hoogwelgeboren vrouwe |
  | Jonkheer                  | Hoogwelgeboren heer   |
  | Jonkvrouw                 | Hoogwelgeboren vrouwe |
  | Markies                   | Hoogwelgeboren heer   |
  | Markiezin                 | Hoogwelgeboren vrouwe |
  | Prins                     | Hoogheid              |
  | Prinses                   | Hoogheid              |
  | Ridder                    | Hoogwelgeboren heer   |
  Waardes van adellijkeTitelOfPredikaat zijn volgens de waardelijst [AdellijkeTitelOfPredikaat](https://www.kadaster.nl/schemas/waardelijsten/AdellijkeTitelOfPredikaat/)

  Abstract Scenario: Aanhef
    Als de kadasternatuurlijkpersoon wordt geraadpleegd
    Dan heeft de gevonden persoon naam.aanhef="<aanhef>"

    Voorbeelden: persoon heeft geen adellijke titel of predikaat
      | aanduidingNaamgebruik | geslachtsaanduiding | Voornamen | VV     | GN       | VP     | GP       | aanhef                                      |
      | E                     | 1 (Man)             | Peter     | in het | Veld     | van    | Velzen   | Geachte heer In het Veld                    |
      | E                     | 1 (Man)             | Jan       |        | Groenen  |        |          | Geachte heer Groenen                        |
      | N                     | 2 (Vrouw)           | Susan     | in het | Veld     | van    | Velzen   | Geachte mevrouw In het Veld-van Velzen      |
      | N                     | 2 (Vrouw)           | Karin     |        | Groenen  |        | Groenink | Geachte mevrouw Groenen-Groenink            |
      | P                     | 2 (Vrouw)           | Marja     | in het | Veld     | van    | Velzen   | Geachte mevrouw Van Velzen                  |
      | P                     | 2 (Vrouw)           | Anja      |        | Groenink |        | Groenen  | Geachte mevrouw Groenen                     |
      | V                     | 3 (Onbekend)        | Jo Anne   | van    | Velzen   | in het | Veld     | J.A. in het Veld-van Velzen                 |

    Voorbeelden: persoon heeft een adellijke titel of predikaat
      | aanduidingNaamgebruik | AP        | geslachtsaanduiding | Voornamen | VV      | GN          | VP      | GP       | aanhef                       |
      | E                     | Graaf     | 1 (Man)             | Willem    | van den | Aedel       | van der | Veen     | Hooggeboren heer             |
      | N                     | Prinses   | 2 (Vrouw)           | Josephine | van den | Aedel       | van der | Veen     | Hoogheid                     |
      | P                     | Barones   | 2 (Vrouw)           | Catharina | van den | Aedel       | van der | Veen     | Geachte mevrouw Van der Veen |
      | P                     | Gravin    | 3 (Onbekend)        | Fleur     | van den | Aedel       | van der | Veen     | F. van der Veen              |
      | V                     | Jonkvrouw | 3 (Onbekend)        | Astrid    |         | Cenerentola | il      | Principe | Hoogwelgeboren vrouwe        |
