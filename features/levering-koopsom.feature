Functionaliteit: Koopsommen worden alleen geleverd in combinatie met koopjaar als cultuurcode (bebouwd en/of onbebouwd).
                 Als 1 van deze elementen gevraagd wordt, dan worden al deze elementen ook teruggegeven.
                 Als 1 van deze elementen niet geleverd kan worden door het Kadaster, dan worden al deze elementen niet teruggegeven.
                 Het element indicatieMetMeerObjectenVerkregen (van koopsom) maakt geen deel uit van deze combinatie.

    Achtergrond:
        Gegeven de registratie BRK kent de onroerendezaak met kadastraalonroerendezaakidentificatie: 76870487970000,
        En waarvan de volgende velden gevuld zijn: identificatie, type, kadastraleaanduiding, koopsom (van koopsom), koopjaar (van koopsom), aardCultuurbebouwd
        En de onroerendezaak met kadastraalonroerendezaakidentificatie: 76870488070000,
        En waarvan de volgende velden gevuld zijn: identificatie, type, kadastraleaanduiding, koopsom (van koopsom), aardCultuurbebouwd

    Scenario: Onroerendezaak (met aardCultuurBebouwd & koopsom, welke koopsom en koopjaar bevat) wordt opgevraagd zonder fields parameter
        Als onroerendezaak gezocht word met /kadastraalonroerendezaken/76870487970000
        Dan worden alle velden van koopsom & aardCultuurBebouwd teruggegeven
        En wordt de volgende json response teruggegeven:
        """
        {
            "identificatie": "76870487970000",
            "domein": "NL.IMKAD.KadastraalObject",
            "koopsom": {
                "koopsom": 185000,
                "koopjaar": 2015
            },
            "type": "perceel",
            "aardCultuurBebouwd": {
                "code": "11",
                "waarde": "Wonen"
            },
            "kadastraleAanduiding": "Beekbergen K 4879",
            "_links": {
                "self": {
                    "href": "/kadastraalonroerendezaken/76870487970000"
                }
            }
        }
        """


    Scenario: Onroerendezaak (met aardCultuurBebouwd & koopsom, welke koopsom en koopjaar bevat) wordt opgevraagd met fields parameter met 1 van die drie velden (koopsom of koopjaar of aardCultuurbebouwd) erin
        Als onroerendezaak gezocht word met /kadastraalonroerendezaken/76870487970000?fields=koopsom
        Dan worden alle velden van koopsom & aardCultuurBebouwd teruggegeven
        En wordt de volgende json response teruggegeven:
        """
        {
            "identificatie": "76870487970000",
            "domein": "NL.IMKAD.KadastraalObject",
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
                    "href": "/kadastraalonroerendezaken/76870487970000?fields=koopsom"
                }
            }
        }
        """

    Scenario: Onroerendezaak (met aardCultuurBebouwd & koopsom, welke koopsom en koopjaar bevat) wordt opgevraagd met fields parameter zonder 1 van die drie velden (koopsom of koopjaar of aardCultuurbebouwd) erin
        Als onroerendezaak gezocht word met /kadastraalonroerendezaken/76870487970000?fields=kadastraleAanduiding
        Dan worden koopsom, koopjaar & aardCultuurBebouwd niet teruggegeven
        En wordt de volgende json response teruggegeven:
        """
        {
            "identificatie": "76870487970000",
            "domein": "NL.IMKAD.KadastraalObject",
            "type": "perceel",
            "kadastraleAanduiding": "Beekbergen K 4879",
            "_links": {
                "self": {
                    "href": "/kadastraalonroerendezaken/76870487970000?fields=kadastraleAanduiding"
                }
            }
        }
        """

    Scenario: Onroerendezaak (met aardCultuurBebouwd & koopsom, welke alleen koopsom bevat) wordt opgevraagd zonder fields parameter
        Als onroerendezaak gezocht word met /kadastraalonroerendezaken/76870488070000
        Dan worden de koopsom & aardCultuurBebouwd niet teruggegeven
        En wordt de volgende json response teruggegeven:
        """
        {
            "identificatie": "76870488070000",
            "domein": "NL.IMKAD.KadastraalObject",
            "type": "perceel",
            "kadastraleAanduiding": "Beekbergen K 4880",
            "_links": {
                "self": {
                    "href": "/kadastraalonroerendezaken/76870488070000"
                }
            }
        }
        """

    Scenario: Onroerendezaak (met aardCultuurBebouwd & koopsom, welke alleen koopsom bevat) wordt opgevraagd met fields parameter met 1 van die twee velden (koopsom of aardCultuurbebouwd) erin
        Als onroerendezaak gezocht word met /kadastraalonroerendezaken/76870488070000?fields=koopsom
        Dan worden de koopsom & aardCultuurBebouwd niet teruggegeven
        En wordt de volgende json response teruggegeven:
        """
        {
            "identificatie": "76870488070000",
            "domein": "NL.IMKAD.KadastraalObject",
            "type": "perceel",
            "_links": {
                "self": {
                    "href": "/kadastraalonroerendezaken/76870488070000?fields=koopsom"
                }
            }
        }
        """

    Scenario: Onroerendezaak (met aardCultuurBebouwd & koopsom, welke alleen koopsom bevat) wordt opgevraagd met fields parameter zonder 1 van die twee velden (koopsom of aardCultuurbebouwd) erin
        Als onroerendezaak gezocht word met /kadastraalonroerendezaken/76870488070000?fields=kadastraleAanduiding
        Dan worden de koopsom & aardCultuurBebouwd niet teruggegeven
        En wordt de volgende json response teruggegeven:
        """
        {
            "identificatie": "76870488070000",
            "domein": "NL.IMKAD.KadastraalObject",
            "type": "perceel",
            "kadastraleAanduiding": "Beekbergen K 4880",
            "_links": {
                "self": {
                    "href": "/kadastraalonroerendezaken/76870488070000?fields=kadastraleAanduiding"
                }
            }
        }
        """
