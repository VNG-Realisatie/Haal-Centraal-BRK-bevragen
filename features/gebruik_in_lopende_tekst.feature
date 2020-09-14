# language: nl

Functionaliteit: Als gemeente wil ik de juiste en consistent naamgebruik in een lopende tekst
  Attribuut "gebruikInLopendeTekst" bij een natuurlijk persoon wordt gevuld om de persoon op eenduidige wijze te kunnen aanschrijven.
  Dit attribuut kan worden gebruikt in bijvoorbeeld een zin in een brief als "In uw brief van 12 mei jongstleden, geeft u het overlijden van uw vader, de heer in het Veld, aan.", waarbij "de heer in het Veld" gehaald is uit attribuut gebruikInLopendeTekst.

  Attribuut gebruikInLopendeTekst wordt samengesteld op basis van:
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

  In de BRK is niet bekend of de partner een adellijke titel heeft. In de gebruikInLopendeTekst wordt daarom nooit een adellijke titel van de partner gebruikt.

  In onderstaande tabellen betekenen de afkortingen voor naamcomponenten:
  - GA = geslachtsaanduiding afhankelijk van geslachtsaanduiding:
    - Als geslachtsaanduiding==1 (Man) Dan "de heer”
    - Als geslachtsaanduiding==2 (Vrouw) Dan "mevrouw"
    - Als geslachtsaanduiding==3 (Onbekend) Dan “de heer/mevrouw"
  - AP = adellijkeTitelOfPredikaat
  - VV = naam.voorvoegselsgeslachtsnaam
  - GN = naam.geslachtsnaam
  - VP = heeftPartnerschap.naamPartner.voorvoegselsgeslachtsnaam
  - GP = heeftPartnerschap.naamPartner.geslachtsnaam

  Codes voor aanduidingNaamgebruik hieronder zijn volgens waardelijst [BRPAanduidingNaamgebruik](https://www.kadaster.nl/schemas/waardelijsten/BRPAanduidingNaamgebruik/)
  - E	= Eigen geslachtsnaam
  - P	= Geslachtsnaam echtgenoot/geregistreerd partner
  - V	= Geslachtsnaam echtgenoot/geregistreerd partner voor eigen geslachtsnaam
  - N	= Geslachtsnaam echtgenoot/geregistreerd partner na eigen geslachtsnaam

  Samenstelling van gebruikInLopendeTekst voor een persoon zonder adellijke titel of predikaat:
  | aanduidingNaamgebruik | gebruikInLopendeTekst |
  | E                     | AH VV GN              |
  | N                     | AH VV GN-VP GP        |
  | P                     | AH VP GP              |
  | V                     | AH VP GP-VV GN        |

  Samenstelling van gebruikInLopendeTekst voor een persoon met adellijke titel of predikaat:
  | aanduidingNaamgebruik | gebruikInLopendeTekst |
  | E                     | AP VV GN              |
  | N                     | AP VV GN-VP GP        |
  | P                     | AH VP GP              |
  | V                     | AH VP GP-AP VV GN     |

  Bij de samenstelling van gebruikInLopendeTekst volgens bovenstaande tabel gelden de volgende regels:
  1. Voor adellijke titel en predicaat wordt de Waarde volgens waardelijst "AdellijkeTitelOfPredikaat" gebruikt, geschreven in kleine letters.
  2. Het voorvoegsel van de eerste geslachtsnaam in gebruikInLopendeTekst wordt met een hoofdletter geschreven.
  3. Wanneer een naamcomponent geen waarde heeft, wordt ook de spatie erna niet opgenomen.


  Abstract Scenario: gebruikInLopendeTekst wordt samengesteld op basis van geslachtsaanduiding en naamgegevens van de persoon en de partner
    Als de kadasternatuurlijkpersoon wordt geraadpleegd
    Dan heeft de gevonden persoon naam.gebruikInLopendeTekst="<gebruikInLopendeTekst>"

    Voorbeelden: persoon heeft geen adellijke titel of predikaat
      | aanduidingNaamgebruik | geslachtsaanduiding | VV     | GN       | VP     | GP       | gebruikInLopendeTekst                  |
      | E                     | 1 (Man)             | in het | Veld     | van    | Velzen   | de heer In het Veld                    |
      | E                     | 1 (Man)             |        | Groenen  |        |          | de heer Groenen                        |
      | N                     | 2 (Vrouw)           | in het | Veld     | van    | Velzen   | mevrouw In het Veld-van Velzen         |
      | N                     | 2 (Vrouw)           |        | Groenen  |        | Groenink | mevrouw Groenen-Groenink               |
      | P                     | 2 (Vrouw)           | in het | Veld     | van    | Velzen   | mevrouw Van Velzen                     |
      | P                     | 2 (Vrouw)           |        | Groenink |        | Groenen  | mevrouw Groenen                        |
      | V                     | 3 (Onbekend)        | van    | Velzen   | in het | Veld     | de heer/mevrouw In het Veld-van Velzen |

    Voorbeelden: persoon heeft een adellijke titel of predikaat
      | aanduidingNaamgebruik | geslachtsaanduiding | AP | VV      | GN           | VP      | GP                  | gebruikInLopendeTekst                              |
      | E                     | 1 (Man)             | G  | van den | Aedel        | van der | Veen                | graaf Van den Aedel                                |
      | N                     | 2 (Vrouw)           | PS | van den | Aedel        | van der | Veen                | prinses Van den Aedel-van der Veen                 |
      | P                     | 2 (Vrouw)           | BS | van den | Aedel        | van der | Veen                | mevrouw Van der Veen                               |
      | V                     | 3 (Onbekend)        | GI | van den | Aedel        | van der | Veen                | de heer/mevrouw Van der Veen-gravin van den Aedel  |
      | V                     | 2 (Vrouw)           | JV |         | Blancanieves |         | Príncipe Encantador | mevrouw Príncipe Encantador-jonkvrouw Blancanieves |
