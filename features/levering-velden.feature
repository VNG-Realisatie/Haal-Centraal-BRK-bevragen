Functionaliteit: levering velden

    Achtergrond:
        Gegeven de registratie BRK kent de onroerendezaak met kadastraalonroerendezaakidentificatie: NL.IMKAD.KadastraalObject.76870487970000,
        En waarvan de volgende velden gevuld zijn: identificatie, kadastraleaanduiding
        En de velden _links.self, identificatie en type zijn verplicht en dienen altijd teruggegeven te worden

    Scenario: Onroerendezaak wordt opgevraagd zonder fields parameter
        Als onroerendezaak gezocht word met /kadastraalonroerendezaken/NL.IMKAD.KadastraalObject.76870487970000
        Dan worden alle velden teruggegeven
        En wordt de volgende json response teruggegeven:
        """
        {
            "identificatie": "NL.IMKAD.KadastraalObject.76870487970000",
            "type": "perceel",
            "kadastraleAanduiding": {
                "kadastraleGemeente": {
                    "code": "87",
                    "waarde": "Beekbergen"
                },
                "perceelnummer": 4879,
                "sectie": "K"
            },
            "_links": {
                "self": {
                    "href": "/kadastraalonroerendezaken/NL.IMKAD.KadastraalObject.76870487970000"
                }
            }
        }
        """

    Scenario: Onroerendezaak wordt opgevraagd met fields parameter
        Als onroerendezaak gezocht word met /kadastraalonroerendezaken/NL.IMKAD.KadastraalObject.76870487970000?fields=kadastraleAanduiding
        Dan worden de volgende velden teruggegeven: kadastraleAanduiding, identificatie, type, _links.self
        En wordt de volgende json response teruggegeven:
        """
        {
            "identificatie": "NL.IMKAD.KadastraalObject.76870487970000",
            "type": "perceel",
            "kadastraleAanduiding": {
                "kadastraleGemeente": {
                    "code": "87",
                    "waarde": "Beekbergen"
                },
                "perceelnummer": 4879,
                "sectie": "K"
            },
            "_links": {
                "self": {
                    "href": "/kadastraalonroerendezaken/NL.IMKAD.KadastraalObject.76870487970000"
                }
            }
        }
        """