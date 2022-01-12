# Zakelijk gerechtigden uit splitsing

/kadastraalonroerendezaken/1/zakelijkgerechtigden


{
    "_links": {
        "self": {
            "href": "/kadastraalonroerendezaken/1/zakelijkgerechtigden"
        },
        "kadastraalOnroerendeZakenUitSplitsing": {
            "href": "/kadastraalonroerendezaken?kadastraleAanduiding=Apeldoorn A 1&inclusiefKadastraalOnroerendeZakenUitSplitsing=true"
        },
        "kadastraalOnroerendeZakenUitSplitsingInclusiefZakelijkGerechtigden": {
            "href": "/kadastraalonroerendezaken?kadastraleAanduiding=Apeldoorn A 1&inclusiefKadastraalOnroerendeZakenUitSplitsing=true&expand=zakelijkGerechtigden"
        }
    },
    "_embedded": {
        "zakelijkGerechtigden": []
    },
    "gesplitstZakelijkRecht": "eigenaar"
}

/kadastraalonroerendezaken?kadastraleAanduiding=Apeldoorn A 1&inclusiefKadastraalOnroerendeZakenUitSplitsing=true&expand=zakelijkGerechtigden

{
    "_links": {
        "self": "/kadastraalonroerendezaken?kadastraleAanduiding=Apeldoorn A 1&inclusiefKadastraalOnroerendeZakenUitSplitsing=true&expand=zakelijkGerechtigden"
    },
    "_embedded": {
        "kadastraalOnroerendeZaken": [
            {
                "identificatie": "1",
                "stukIdentificaties": [],
                "_embedded": {},
                "_links": {}
                "gesplitstZakelijkRecht": "eigenaar"
            },
            {
                "identificatie": "5",
                "stukIdentificaties": [
                    "20210707001934"
                ],
                "_embedded": {
                    "zakelijkGerechtigden": [
                        {
                            "identificatie": "7",
                            "type": "eigenaar",
                            "persoon": {
                                "type": "ingeschreven_natuurlijk_persoon",
                                "identificatie": "7",
                                "omschrijving": "Piet Pietersen"
                            }
                        }
                    ]
                }
            },
            {
                "identificatie": "8",
                "stukIdentificaties": [
                    "20210707001934"
                ],
                "_embedded": {
                    "zakelijkGerechtigden": [
                        {
                            "identificatie": "10",
                            "type": "eigenaar",
                            "persoon": {
                                "type": "ingeschreven_natuurlijk_persoon",
                                "identificatie": "10",
                                "omschrijving": "Jan Janssen"
                            }
                        }
                    ]
                }
            }
        ]
    }
}
