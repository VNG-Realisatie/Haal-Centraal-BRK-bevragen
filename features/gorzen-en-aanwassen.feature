# language: nl

Functionaliteit: Gorzen en Aanwassen van Gebied

Achtergrond:
    Gegeven de KadastraalOnroerendeZaak met identificatie 76870487970000
    * heeft een ZakelijkGerechtigde van het type 'eigenaar' gekoppeld aan NatuurlijkPersoon met identificatie 70882239
    * dat is betrokken bij een GorzenEnAanwassen gebied gekoppeld aan NietNatuurlijkPersoon met identificatie 71291497
    En de KadastraalOnroerendeZaak met identificatie 76870482670000
    * heeft een ZakelijkGerechtigde van het type 'eigenaar' gekoppeld aan NatuurlijkPersoon met identificatie 70882239
    * dat is betrokken bij een GorzenEnAanwassen gebied gekoppeld aan NietNatuurlijkPersoon met identificatie 71291497

Scenario: zoeken van kadastraal onroerende zaken die zijn betrokken bij een Gorzen en Aanwassen Gebied
    Als de KadastraalOnroerendeZaken betrokken bij de GorzenEnAanwassen gebied gekoppeld aan NietNatuurlijkPersoon met identificatie 71291497 moet worden opgehaald
    Dan moet eerst de KadastraalOnroerendeZaken met ZakelijkGerechtigden worden opgehaald met de volgende request
    | verb | path                       | persoon__identificatie parameter | zakelijkGerechtigde__type parameter | expand parameter     |
    | GET  | /kadastraalonroerendezaken | 70882239                         | eigenaar                            | zakelijkGerechtigden |
    En moet in de response KadastraalOnroerendeZaken worden gefilterd waarvan één of meer ZakelijkGerechtigden zijn betrokken bij een GorzenEnAanwassen gebied gekoppeld aan NietNatuurlijkPerson met identificatie 71291497
    En is het filter resultaat de KadastraalOnroerendeZaken met de volgende identificaties:
    | KadastraalOnroerendeZaak identificatie |
    | 76870487970000                         |
    | 76870482670000                         |

Rule: Het is niet mogelijk om de identificaties van betrokken KadastraalOnroerendeZaken op te vragen voor een fictief persoon

Scenario: raadplegen van de niet-natuurlijk persoon gekoppeld aan een Gorzen en Aanwassen Gebied
    Als een NietNatuurlijkPersoon wordt opgehaald met de request "GET /kadasternietnatuurlijkpersonen/71291497"
    Dan bevat de response voor deze persoon geen KadastraalOnroerendeZaakIdentificatie lijst
