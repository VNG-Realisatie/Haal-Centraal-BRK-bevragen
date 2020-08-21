# language: nl

Functionaliteit: Als gemeente wil ik de juiste en consistente aanschrijfwijze van mijn burgers
  Attribuut "aanschrijfwijze" bij een natuurlijk persoon wordt gevuld om de persoon op eenduidige wijze te kunnen aanschrijven.
  De aanschrijfwijze wordt gebruikt als eerste regel in de adressering op een envelop, of links bovenaan een brief, direct boven het adres.
  De aanschrijfwijze kan ook worden gebruikt in lijsten met zoekresultaten, of op een website om te tonen op wie het betrekking heeft.

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

  In de BRK is niet bekend of de partner een adellijke titel heeft. In de aanschrijfwijze wordt daarom nooit een adellijke titel van de partner gebruikt.

  In onderstaande tabellen betekenen de afkortingen voor naamcomponenten:
  - VL = voorletters afgeleid uit naam.voornamen zoals beschreven in voorletters.feature
  - VV = naam.voorvoegselsgeslachtsnaam
  - GN = naam.geslachtsnaam
  - VP = heeftPartnerschap.naamPartner.voorvoegselsgeslachtsnaam
  - GP = heeftPartnerschap.naamPartner.geslachtsnaam
  - PK = Predikaat (adellijkeTitelOfPredikaat is "JV" of "JH")
  - AT = adellijke titel (adellijkeTitelOfPredikaat anders dan "JV" of "JH")

  Codes voor aanduidingNaamgebruik hieronder zijn volgens waardelijst [BRPAanduidingNaamgebruik](https://www.kadaster.nl/schemas/waardelijsten/BRPAanduidingNaamgebruik/)
  - E	= Eigen geslachtsnaam
  - P	= Geslachtsnaam echtgenoot/geregistreerd partner
  - V	= Geslachtsnaam echtgenoot/geregistreerd partner voor eigen geslachtsnaam
  - N	= Geslachtsnaam echtgenoot/geregistreerd partner na eigen geslachtsnaam

  Samenstelling van aanschrijfwijze:
  | aanduidingNaamgebruik | aanschrijfwijze      |
  | E                     | PK VL AT VV GN       |
  | N                     | PK VL AT VV GN-VP GP |
  | P                     | VL VP GP             |
  | V                     | VL VP GP-PK AT VV GN |

  Bij de samenstelling van de aanschrijfwijze volgens bovenstaande tabel gelden de volgende regels:
  1. Voor adellijke titel en predicaat wordt de Waarde volgens waardelijst "AdellijkeTitelOfPredikaat" gebruikt, geschreven in kleine letters.
  2. Wanneer een naamcomponent geen waarde heeft, wordt ook de spatie erna niet opgenomen.


  Abstract Scenario: Aanschrijfwijze
    Als de kadasternatuurlijkpersoon wordt geraadpleegd
    Dan heeft de gevonden persoon naam.aanschrijfwijze="<aanschrijfwijze>"

    Voorbeelden: persoon heeft geen adellijke titel of predikaat
      | aanduidingNaamgebruik | VN                  | VV     | GN       | VP     | GP       | aanschrijfwijze               |
      | E                     | Anton               | in het | Veld     | van    | Velzen   | A. in het Veld                |
      | E                     | Bert                |        | Groenen  |        |          | B. Groenen                    |
      | N                     | Corine              | in het | Veld     | van    | Velzen   | C. in het Veld-van Velzen     |
      | N                     | Dianne              |        | Groenen  |        | Groenink | D. Groenen-Groenink           |
      | P                     | Elsa                | in het | Veld     | van    | Velzen   | E. van Velzen                 |
      | P                     | Felice              |        | Groenink |        | Groenen  | F. Groenen                    |
      | V                     | Gert-Jan H Isaak    | van    | Velzen   | In het | Veld     | G.H I. In het Veld-van Velzen |

    Voorbeelden: persoon heeft een adellijke titel of predikaat
      | aanduidingNaamgebruik | AT/PK | VN             | VV      | GN           | VP      | GP                  | aanschrijfwijze                               |
      | E                     | G     | Arthur         | van den | Aedel        | van der | Veen                | A. graaf van den Aedel                        |
      | N                     | PS    | Belle          | van den | Aedel        | van der | Veen                | B. prinses van den Aedel-van der Veen         |
      | P                     | BS    | Constance      | van den | Aedel        | van der | Veen                | C. van der Veen                               |
      | V                     | GI    | Deirdre        | van den | Aedel        | van der | Veen                | D. van der Veen-gravin van den Aedel          |
      | E                     | JH    | Ernst Frederik | van     | Hoogh        | in het  | Veld                | jonkheer E.F. van Hoogh                       |
      | N                     | JV    | Gratia         | van     | Hoogh        | in het  | Veld                | jonkvrouw G. van Hoogh-in het Veld            |
      | P                     | JV    | Hannelore      | van     | Hoogh        | in het  | Veld                | H. in het Veld                                |
      | V                     | JV    | Isabelle       | van     | Hoogh        | in het  | Veld                | I. in het Veld-jonkvrouw van Hoogh            |
      | V                     | JV    | Johanna        |         | Blancanieves |         | Príncipe Encantador | J. Príncipe Encantador-jonkvrouw Blancanieves |
