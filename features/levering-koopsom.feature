Functionaliteit: Koopsommen worden alleen geleverd in combinatie met zowel koopjaar als cultuurcode (bebouwd en/of onbebouwd).
                 Als 1 van deze elementen niet geleverd kan worden door het Kadaster, dan worden alle andere elementen ook niet teruggegeven.

    Achtergrond:
        Gegeven de registratie BRK kent de onroerendezaak met kadastraalonroerendezaakidentificatie: NL.IMKAD.KadastraalObject.76870487970000,
        En waarvan de volgende velden gevuld zijn: identificatie, type, kadastraleaanduiding, koopsom, koopjaar, aardCultuurbebouwd
        En de onroerendezaak met kadastraalonroerendezaakidentificatie: NL.IMKAD.KadastraalObject.76870488070000,
        En waarvan de volgende velden gevuld zijn: identificatie, type, kadastraleaanduiding, koopsom, aardCultuurbebouwd

    Scenario: Onroerendezaak (met koopsom & koopjaar & aardCultuurbebouwd) wordt opgevraagd zonder fields parameter
        Als onroerendezaak gezocht word met /kadastraalonroerendezaken/NL.IMKAD.KadastraalObject.76870487970000
        Dan worden de koopsom & koopjaar & aardCultuurBebouwd teruggegeven
        En wordt de volgende json response teruggegeven:
        """
        {
            "identificatie": "NL.IMKAD.KadastraalObject.76870487970000",
            "koopsom": {
                "koopsom": 185000,
                "koopjaar": 2015
            },
            "type": "perceel",
            "aardCultuurBebouwd": {
                "code": "11",
                "waarde": "Wonen"
            },
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


    Scenario: Onroerendezaak (met koopsom & koopjaar & aardCultuurbebouwd) wordt opgevraagd met fields parameter met 1 van die drie velden (koopsom of koopjaar of aardCultuurbebouwd) erin
        Als onroerendezaak gezocht word met /kadastraalonroerendezaken/NL.IMKAD.KadastraalObject.76870487970000?fields=koopsom
        Dan worden de koopsom & koopjaar & aardCultuurBebouwd teruggegeven
        En wordt de volgende json response teruggegeven:
        """
        {
            "identificatie": "NL.IMKAD.KadastraalObject.76870487970000",
            "koopsom": {
                "koopsom": 185000,
                "koopjaar": 2015
            },
            "type": "perceel",
            "aardCultuurBebouwd": {
                "code": "11",
                "waarde": "Wonen"
            },
            "_links": {
                "self": {
                    "href": "/kadastraalonroerendezaken/NL.IMKAD.KadastraalObject.76870487970000?fields=koopsom"
                }
            }
        }
        """

    Scenario: Onroerendezaak (met koopsom & koopjaar & aardCultuurbebouwd) wordt opgevraagd met fields parameter zonder 1 van die drie velden (koopsom of koopjaar of aardCultuurbebouwd) erin
        Als onroerendezaak gezocht word met /kadastraalonroerendezaken/NL.IMKAD.KadastraalObject.76870487970000?fields=kadastraleAanduiding
        Dan worden de koopsom & koopjaar & aardCultuurBebouwd niet teruggegeven
        En wordt de volgende json response teruggegeven:
        """
        {
            "identificatie": "NL.IMKAD.KadastraalObject.76870487970000",
            "type": "perceel",
            "kadastraleAanduiding": "Beekbergen K 4879",
            "_links": {
                "self": {
                    "href": "/kadastraalonroerendezaken/NL.IMKAD.KadastraalObject.76870487970000?fields=kadastraleAanduiding"
                }
            }
        }
        """

    Scenario: Onroerendezaak (met alleen koopsom & aardCultuurbebouwd) wordt opgevraagd zonder fields parameter
        Als onroerendezaak gezocht word met /kadastraalonroerendezaken/NL.IMKAD.KadastraalObject.76870488070000
        Dan worden de koopsom & aardCultuurBebouwd niet teruggegeven
        En wordt de volgende json response teruggegeven:
        """
        {
            "identificatie": "NL.IMKAD.KadastraalObject.76870488070000",
            "type": "perceel",
            "kadastraleAanduiding": "Beekbergen K 4880",
            "_links": {
                "self": {
                    "href": "/kadastraalonroerendezaken/NL.IMKAD.KadastraalObject.76870488070000"
                }
            }
        }
        """

    Scenario: Onroerendezaak (met alleen koopsom & aardCultuurbebouwd) wordt opgevraagd met fields parameter met 1 van die twee velden (koopsom of aardCultuurbebouwd) erin
        Als onroerendezaak gezocht word met /kadastraalonroerendezaken/NL.IMKAD.KadastraalObject.76870488070000?fields=koopsom
        Dan worden de koopsom & aardCultuurBebouwd niet teruggegeven
        En wordt de volgende json response teruggegeven:
        """
        {
            "identificatie": "NL.IMKAD.KadastraalObject.76870488070000",
            "type": "perceel",
            "_links": {
                "self": {
                    "href": "/kadastraalonroerendezaken/NL.IMKAD.KadastraalObject.76870488070000?fields=koopsom"
                }
            }
        }
        """

    Scenario: Onroerendezaak (met alleen koopsom & aardCultuurbebouwd) wordt opgevraagd met fields parameter zonder 1 van die twee velden (koopsom of aardCultuurbebouwd) erin
        Als onroerendezaak gezocht word met /kadastraalonroerendezaken/NL.IMKAD.KadastraalObject.76870488070000?fields=kadastraleAanduiding
        Dan worden de koopsom & aardCultuurBebouwd niet teruggegeven
        En wordt de volgende json response teruggegeven:
        """
        {
            "identificatie": "NL.IMKAD.KadastraalObject.76870488070000",
            "type": "perceel",
            "kadastraleAanduiding": "Beekbergen K 4880",
            "_links": {
                "self": {
                    "href": "/kadastraalonroerendezaken/NL.IMKAD.KadastraalObject.76870488070000?fields=kadastraleAanduiding"
                }
            }
        }
        """