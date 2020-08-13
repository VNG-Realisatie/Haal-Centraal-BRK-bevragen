# language: nl

Functionaliteit: Als gemeente wil ik de juiste en consistente briefaanhef in communicatie naar burgers
  Attribuut "aanhef" bij een natuurlijk persoon wordt gevuld om de persoon op eenduidige wijze te kunnen aanschrijven.
  De aanhef wordt gebruikt bovenaan een brief.

  Attribuut aanschrijfwijze wordt samengesteld op basis van:
  - adellijkeTitelOfPredikaat
  - aanduidingNaamgebruik
  - naam
    - geslachtsnaam
    - voornamen
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
    - Als geslachtsaanduiding==3 (Onbekend) Dan “Geachte heer/mevrouw"
  - VV = naam.voorvoegselsgeslachtsnaam
  - GN = naam.geslachtsnaam
  - VP = heeftPartnerschap.naamPartner.voorvoegselsgeslachtsnaam
  - GP = heeftPartnerschap.naamPartner.geslachtsnaam

  Samenstelling van aanhef voor een persoon zonder adellijke titel of predikaat:
  | aanduidingNaamgebruik | aanschrijfwijze |
  | E                     | AH VV GN        |
  | N                     | AH VV GN-VP GP  |
  | P                     | AH VP GP        |
  | V                     | AH VP GP-VV GN  |

  Bij de samenstelling van de aanhef voor een persoon zonder adellijke titel of predikaat volgens bovenstaande tabel gelden de volgende regels:
  1. Het voorvoegsel van de eerste geslachtsnaam in de aanhef wordt met een hoofdletter geschreven.
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


  Abstract Scenario: Aanhef
    Als de kadasternatuurlijkpersoon wordt geraadpleegd
    Dan heeft de gevonden persoon naam.aanhef="<aanhef>"

    Voorbeelden: persoon heeft geen adellijke titel of predikaat
      | aanduidingNaamgebruik | geslachtsaanduiding | VV     | GN       | VP     | GP       | aanhef                                      |
      | E                     | 1 (Man)             | in het | Veld     | van    | Velzen   | Geachte heer In het Veld                    |
      | E                     | 1 (Man)             |        | Groenen  |        |          | Geachte heer Groenen                        |
      | N                     | 2 (Vrouw)           | in het | Veld     | van    | Velzen   | Geachte mevrouw In het Veld-van Velzen      |
      | N                     | 2 (Vrouw)           |        | Groenen  |        | Groenink | Geachte mevrouw Groenen-Groenink            |
      | P                     | 2 (Vrouw)           | in het | Veld     | van    | Velzen   | Geachte mevrouw Van Velzen                  |
      | P                     | 2 (Vrouw)           |        | Groenink |        | Groenen  | Geachte mevrouw Groenen                     |
      | V                     | 3 (Onbekend)        | van    | Velzen   | in het | Veld     | Geachte heer/mevrouw In het Veld-van Velzen |

    Voorbeelden: persoon heeft een adellijke titel of predikaat
      | aanduidingNaamgebruik | AT/PK | geslachtsaanduiding | VV      | GN          | VP      | GP       | aanhef                       |
      | E                     | G     | 1 (Man)             | van den | Aedel       | van der | Veen     | Hooggeboren heer             |
      | N                     | PS    | 2 (Vrouw)           | van den | Aedel       | van der | Veen     | Hoogheid                     |
      | P                     | BS    | 2 (Vrouw)           | van den | Aedel       | van der | Veen     | Geachte mevrouw Van der Veen |
      | V                     | JV    | 3 (Onbekend)        |         | Cenerentola | il      | Principe | Hoogwelgeboren vrouwe        |
