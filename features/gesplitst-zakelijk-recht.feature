# language: nl

Functionaliteit: Gesplitst zakelijk recht
    # Als medewerker Erfpacht wil ik weten wie de eigenaren zijn van appartementsrechten die uit erfpacht zijn ontstaan
    # zodat ik weet aan wie ik een factuur kan sturen.
    # #882

Achtergrond:
    Gegeven perceel met identificatie "59020139970000" heeft het zakelijk recht van type "erfpachter" gesplitst naar twee appartementsrechten met identificatie "59020140010001" en "59020140010002"
    En perceel met identificatie "59020139970000" heeft kadastrale aanduiding "Groningen P 1399"
    En perceel met identificatie "59020139970000" heeft als eigenaar "Anne Janssens"
    En appartementsrecht met identificatie "59020140010001" heeft kadastrale aanduiding "Groningen P 1400 A1" 
    En appartementsrecht met identificatie "59020140010001" heeft als eigenaar "Jan de Groenen"
    En appartementsrecht met identificatie "59020140010002" heeft kadastrale aanduiding "Groningen P 1400 A2" 
    En appartementsrecht met identificatie "59020140010002" heeft als eigenaar "Susan in het Veld"

    En perceel met identificatie "59020130970000" heeft het zakelijk recht van type "eigenaar" gesplitst naar twee appartementsrechten met identificatie "59020170810218" en "59020170810219"
    En perceel met identificatie "59020130970000" heeft kadastrale aanduiding "Groningen P 1309" 
    En appartementsrecht met identificatie "59020170810219" heeft het zakelijk recht van type "eigenaar" gesplitst naar twee appartementsrechten met identificatie "59020170810593" en "59020170810594"
    En appartementsrecht met identificatie "59020170810219" heeft kadastrale aanduiding "Groningen P 1708 A219" 

Rule: Opvragen van zakelijk gerechtigden van een grondperceel dat is gesplitst in appartementsrechten geeft het type van het gesplitste zakelijk recht
    # property "gesplitstZakelijkRecht" geeft aan dat niet alle zakelijk gerechtigden  worden geleverd, omdat een zakelijk recht is gesplitst
    # link kadastraalOnroerendeZakenUitSplitsing toont hoe alle onroerende zaken uit splitsing kunnen worden opgehaald samen met de gevraagde onroerende zaak
    # link kadastraalOnroerendeZakenUitSplitsingInclusiefZakelijkGerechtigden toont hoe alle zakelijk gerechtigden, inclusief die uit splitsing

    Scenario: opvragen van de zakelijk gerechtigden van een grondperceel
        Als zakelijk gerechtigde wordt gevraagd met "/kadastraalonroerendezaken/59020139970000/zakelijkgerechtigden?fields=identificatie,type,persoon.omschrijving"
        Dan is het antwoord:
        """
        {
            "_links": {
                "self": {
                    "href": "/kadastraalonroerendezaken/59020139970000/zakelijkgerechtigden?fields=identificatie,type,persoon.omschrijving"
                },
                "kadastraalOnroerendeZakenUitSplitsing": {
                    "href": "/kadastraalonroerendezaken?kadastraleAanduiding=Groningen+P+1399&inclusiefKadastraalOnroerendeZakenUitSplitsing=true"
                },
                "kadastraalOnroerendeZakenUitSplitsingInclusiefZakelijkGerechtigden": {
                    "href": "/kadastraalonroerendezaken?expand=zakelijkGerechtigden&kadastraleAanduiding=Groningen+P+1399&inclusiefKadastraalOnroerendeZakenUitSplitsing=true"
                }
            },
            "_embedded": {
                "zakelijkGerechtigden": [
                    {
                        "identificatie": "1002195699",
                        "type": "eigenaar",
                        "persoon": {
                            "omschrijving": "Anne Janssens"
                        },
                        "_links": {
                            "self": {
                                "href": "/kadastraalonroerendezaken/59020139970000/zakelijkgerechtigden/1002195699"
                            }
                        }
                    }
                ]
            },
            "gesplitstZakelijkRecht": "erfpachter"
        }
        """

Rule: Parameter type bij zakelijkgerechtigden werkt ook op gesplitstZakelijkRecht

    Scenario: opvragen van de zakelijk gerechtigden met type van ongesplitst recht
        Als zakelijk gerechtigde wordt gevraagd met "/kadastraalonroerendezaken/59020139970000/zakelijkgerechtigden?fields=identificatie,type,persoon.omschrijving&type=eigenaar"
        Dan is het antwoord:
        """
        {
            "_links": {
                "self": {
                    "href": "/kadastraalonroerendezaken/59020139970000/zakelijkgerechtigden?fields=identificatie,type,persoon.omschrijving&type=eigenaar"
                }
            },
            "_embedded": {
                "zakelijkGerechtigden": [
                    {
                        "identificatie": "1002195699",
                        "type": "eigenaar",
                        "persoon": {
                            "omschrijving": "Anne Janssens"
                        },
                        "_links": {
                            "self": {
                                "href": "/kadastraalonroerendezaken/59020139970000/zakelijkgerechtigden/1002195699"
                            }
                        }
                    }
                ]
            }
        }
        """

    Scenario: opvragen van de zakelijk gerechtigden met type van gesplitst recht
        Als zakelijk gerechtigde wordt gevraagd met "/kadastraalonroerendezaken/59020139970000/zakelijkgerechtigden?fields=identificatie,type,persoon.omschrijving&type=erfpachter"
        Dan is het antwoord:
        """
        {
            "_links": {
                "self": {
                    "href": "/kadastraalonroerendezaken/59020139970000/zakelijkgerechtigden?fields=identificatie,type,persoon.omschrijving&type=erfpachter"
                },
                "kadastraalOnroerendeZakenUitSplitsing": {
                    "href": "/kadastraalonroerendezaken?kadastraleAanduiding=Groningen+P+1399&inclusiefKadastraalOnroerendeZakenUitSplitsing=true"
                },
                "kadastraalOnroerendeZakenUitSplitsingInclusiefZakelijkGerechtigden": {
                    "href": "/kadastraalonroerendezaken?expand=zakelijkGerechtigden&kadastraleAanduiding=Groningen+P+1399&inclusiefKadastraalOnroerendeZakenUitSplitsing=true"
                }
            },
            "_embedded": {},
            "gesplitstZakelijkRecht": "erfpachter"
        }
        """

Rule: Bij een onroerende zaak met gesplitst zakelijk recht wordt het gesplitste recht getoond in gesplitstZakelijkRecht

    Scenario: opvragen van een perceel met gesplitst zakelijk recht
        Als een kadastraal onroerende zaak wordt geraadpleegd met "/kadastraalonroerendezaken/59020139970000?fields=identificatie,type,gesplitstZakelijkRecht"
        Dan is het antwoord:
        """
        {
            "identificatie": "59020139970000",
            "domein": "NL.IMKAD.KadastraalObject",
            "type": "perceel",
            "gesplitstZakelijkRecht": "erfpachter",
            "_links": {
                "self": {
                    "href": "/kadastraalonroerendezaken/59020139970000?fields=identificatie,type,gesplitstZakelijkRecht"
                }
            }
        }
        """

    Scenario: opvragen van een appartementsrecht uit gesplitst zakelijk recht
        Als een kadastraal onroerende zaak wordt geraadpleegd met "/kadastraalonroerendezaken/59020140010001?fields=identificatie,type,gesplitstZakelijkRecht"
        Dan is het antwoord:
        """
        {
            "identificatie": "59020140010001",
            "domein": "NL.IMKAD.KadastraalObject",
            "type": "appartementsrecht",
            "_links": {
                "self": {
                    "href": "/kadastraalonroerendezaken/59020140010001?fields=identificatie,type,gesplitstZakelijkRecht"
                }
            }
        }
        """

Rule: De onroerende zaken waarin het zakelijk recht van een onroerende zaak is gesplitst kunnen worden opgevraagd door gebruik van de parameter inclusiefKadastraalOnroerendeZakenUitSplitsing in combinatie met kadastraleAanduiding
    # Het resultaat is een lijst met zowel het grondperceel als de appartementsrechten waarin het is gesplitst

    Scenario: opvragen van de onroerende zaken waarin het zakelijk recht van een grondperceel is gesplitst
        Als de onroerende zaken worden gezocht met "/kadastraalonroerendezaken?fields=identificatie,kadastraleAanduiding,type,gesplitstZakelijkRecht&kadastraleAanduiding=Groningen+P+1399&inclusiefKadastraalOnroerendeZakenUitSplitsing=true"
        Dan is het antwoord:
        """
        {
            "_links": {
                "self": {
                    "href": "/kadastraalonroerendezaken?fields=identificatie,kadastraleAanduiding,type,gesplitstZakelijkRecht&kadastraleAanduiding=Groningen+P+1399&inclusiefKadastraalOnroerendeZakenUitSplitsing=true"
                }
            },
            "_embedded": {
                "kadastraalOnroerendeZaken": [
                    {
                        "identificatie": "59020139970000",
                        "domein": "NL.IMKAD.KadastraalObject",
                        "type": "perceel",
                        "kadastraleAanduiding": "Groningen P 1399",
                        "gesplitstZakelijkRecht": "erfpachter",
                        "_links": {
                            "self": {
                                "href": "/kadastraalonroerendezaken/59020139970000"
                            }
                        }
                    },
                    {
                        "identificatie": "59020140010001",
                        "domein": "NL.IMKAD.KadastraalObject",
                        "type": "appartementsrecht",
                        "kadastraleAanduiding": "Groningen P 1400 A1",
                        "_links": {
                            "self": {
                                "href": "/kadastraalonroerendezaken/59020140010001"
                            }
                        }
                    },
                    {
                        "identificatie": "59020140010002",
                        "domein": "NL.IMKAD.KadastraalObject",
                        "type": "appartementsrecht",
                        "kadastraleAanduiding": "Groningen P 1400 A2",
                        "_links": {
                            "self": {
                                "href": "/kadastraalonroerendezaken/59020140010002"
                            }
                        }
                    }
                ]
            }
        }
        """

    Scenario: opvragen van de onroerende zaken waarin het zakelijk recht van een grondperceel is gesplitst inclusief de zakelijk gerechtigden 
        Als de onroerende zaken worden gezocht met "/kadastraalonroerendezaken?fields=identificatie,kadastraleAanduiding,type&inclusiefKadastraalOnroerendeZakenUitSplitsing=true&expand=zakelijkGerechtigden.identificatie,zakelijkGerechtigden.type,zakelijkGerechtigden.persoon.omschrijving&kadastraleAanduiding=Groningen+P+1399"
        Dan is het antwoord:
        """
        {
            "_links": {
                "self": {
                    "href": "/kadastraalonroerendezaken?fields=identificatie,kadastraleAanduiding,type&inclusiefKadastraalOnroerendeZakenUitSplitsing=true&expand=zakelijkGerechtigden.identificatie,zakelijkGerechtigden.type,zakelijkGerechtigden.persoon.omschrijving&kadastraleAanduiding=Groningen+P+1399"
                }
            },
            "_embedded": {
                "kadastraalOnroerendeZaken": [
                    {
                        "identificatie": "59020139970000",
                        "domein": "NL.IMKAD.KadastraalObject",
                        "type": "perceel",
                        "kadastraleAanduiding": "Groningen P 1399",
                        "_links": {
                            "self": {
                                "href": "/kadastraalonroerendezaken/59020139970000"
                            }
                        },
                        "_embedded": {
                            "zakelijkGerechtigden": [
                                {
                                    "identificatie": "1002195699",
                                    "type": "eigenaar",
                                    "persoon": {
                                        "omschrijving": "Anne Janssens"
                                    },
                                    "_links": {
                                        "self": {
                                            "href": "/kadastraalonroerendezaken/59020139970000/zakelijkgerechtigden/1002195699"
                                        }
                                    }
                                }
                            ]
                        }
                    },
                    {
                        "identificatie": "59020140010001",
                        "domein": "NL.IMKAD.KadastraalObject",
                        "type": "appartementsrecht",
                        "kadastraleAanduiding": "Groningen P 1400 A1",
                        "_links": {
                            "self": {
                                "href": "/kadastraalonroerendezaken/59020140010001"
                            }
                        },
                        "_embedded": {
                            "zakelijkGerechtigden": [
                                {
                                    "identificatie": "80214001",
                                    "type": "eigenaar",
                                    "persoon": {
                                        "omschrijving": "Jan de Groenen"
                                    },
                                    "_links": {
                                        "self": {
                                            "href": "/kadastraalonroerendezaken/59020140010001/zakelijkgerechtigden/80214001"
                                        }
                                    }
                                }
                            ]
                        }
                    },
                    {
                        "identificatie": "59020140010002",
                        "domein": "NL.IMKAD.KadastraalObject",
                        "type": "appartementsrecht",
                        "kadastraleAanduiding": "Groningen P 1400 A2",
                        "_links": {
                            "self": {
                                "href": "/kadastraalonroerendezaken/59020140010002"
                            }
                        },
                        "_embedded": {
                            "zakelijkGerechtigden": [
                                {
                                    "identificatie": "80214002",
                                    "type": "eigenaar",
                                    "persoon": {
                                        "omschrijving": "Susan in het Veld"
                                    },
                                    "_links": {
                                        "self": {
                                            "href": "/kadastraalonroerendezaken/59020140010002/zakelijkgerechtigden/80214002"
                                        }
                                    }
                                }
                            ]
                        }
                    }
                ]
            }
        }
        """

Rule: Wanneer een appartementsrecht is (onder)gesplitst wordt bij opvragen van het grondperceel inclusiefKadastraalOnroerendeZakenUitSplitsing zowel het gesplitste appartementsrecht als de appartementsrechten die daaruit zijn ontstaan geleverd

    Scenario: opvragen onroerende zaken waarin het zakelijk recht van een grondperceel is gesplitst en een appartementsrecht is ondergesplitst 
        Als de onroerende zaken worden gezocht met "/kadastraalonroerendezaken?fields=identificatie,kadastraleAanduiding,type,indicatieSluimerend,gesplitstZakelijkRecht&kadastraleAanduiding=Groningen%20P%201309&inclusiefKadastraalOnroerendeZakenUitSplitsing=true"
        Dan is het antwoord:
        """
        {
            "_links": {
                "self": {
                    "href": "/kadastraalonroerendezaken?fields=identificatie,kadastraleAanduiding,type,indicatieSluimerend,gesplitstZakelijkRecht&kadastraleAanduiding=Groningen%20P%201309&inclusiefKadastraalOnroerendeZakenUitSplitsing=true"
                }
            },
            "_embedded": {
                "kadastraalOnroerendeZaken": [
                    {
                        "identificatie": "59020130970000",
                        "domein": "NL.IMKAD.KadastraalObject",
                        "type": "perceel",
                        "kadastraleAanduiding": "Groningen P 1309",
                        "gesplitstZakelijkRecht": "eigenaar",
                        "_links": {
                            "self": {
                                "href": "/kadastraalonroerendezaken/59020130970000"
                            }
                        }
                    },
                    {
                        "identificatie": "59020170810218",
                        "domein": "NL.IMKAD.KadastraalObject",
                        "type": "appartementsrecht",
                        "kadastraleAanduiding": "Groningen P 1708 A218",
                        "_links": {
                            "self": {
                                "href": "/kadastraalonroerendezaken/59020170810218"
                            }
                        }
                    },
                    {
                        "identificatie": "59020170810219",
                        "domein": "NL.IMKAD.KadastraalObject",
                        "indicatieSluimerend": true,
                        "type": "appartementsrecht",
                        "kadastraleAanduiding": "Groningen P 1708 A219",
                        "gesplitstZakelijkRecht": "eigenaar",
                        "_links": {
                            "self": {
                                "href": "/kadastraalonroerendezaken/59020170810219"
                            }
                        }
                    },
                    {
                        "identificatie": "59020170810593",
                        "domein": "NL.IMKAD.KadastraalObject",
                        "type": "appartementsrecht",
                        "kadastraleAanduiding": "Groningen P 1708 A593",
                        "_links": {
                            "self": {
                                "href": "/kadastraalonroerendezaken/59020170810593"
                            }
                        }
                    },
                    {
                        "identificatie": "59020170810594",
                        "domein": "NL.IMKAD.KadastraalObject",
                        "type": "appartementsrecht",
                        "kadastraleAanduiding": "Groningen P 1708 A594",
                        "_links": {
                            "self": {
                                "href": "/kadastraalonroerendezaken/59020170810594"
                            }
                        }
                    }
                ]
            }
        }
        """

    Scenario: opvragen onroerende zaken waarin het zakelijk recht van een appartementsrecht is ondergesplitst 
        Als de onroerende zaken worden gezocht met "/kadastraalonroerendezaken?fields=identificatie,kadastraleAanduiding,type,indicatieSluimerend,gesplitstZakelijkRecht&kadastraleAanduiding=Groningen%20P%201708%20A219&inclusiefKadastraalOnroerendeZakenUitSplitsing=true"
        Dan is het antwoord:
        """
        {
            "_links": {
                "self": {
                    "href": "/kadastraalonroerendezaken?fields=identificatie,kadastraleAanduiding,type,indicatieSluimerend,gesplitstZakelijkRecht&kadastraleAanduiding=Groningen%20P%201708%20A219&inclusiefKadastraalOnroerendeZakenUitSplitsing=true"
                }
            },
            "_embedded": {
                "kadastraalOnroerendeZaken": [
                    {
                        "identificatie": "59020170810219",
                        "domein": "NL.IMKAD.KadastraalObject",
                        "indicatieSluimerend": true,
                        "type": "appartementsrecht",
                        "kadastraleAanduiding": "Groningen P 1708 A219",
                        "gesplitstZakelijkRecht": "eigenaar",
                        "_links": {
                            "self": {
                                "href": "/kadastraalonroerendezaken/59020170810219"
                            }
                        }
                    },
                    {
                        "identificatie": "59020170810593",
                        "domein": "NL.IMKAD.KadastraalObject",
                        "type": "appartementsrecht",
                        "kadastraleAanduiding": "Groningen P 1708 A593",
                        "_links": {
                            "self": {
                                "href": "/kadastraalonroerendezaken/59020170810593"
                            }
                        }
                    },
                    {
                        "identificatie": "59020170810594",
                        "domein": "NL.IMKAD.KadastraalObject",
                        "type": "appartementsrecht",
                        "kadastraleAanduiding": "Groningen P 1708 A594",
                        "_links": {
                            "self": {
                                "href": "/kadastraalonroerendezaken/59020170810594"
                            }
                        }
                    }
                ]
            }
        }
        """

Rule: Bij gebruik van fields wordt gesplitstZakelijkRecht altijd geleverd wanneer die ook een waarde heeft in de resource

    Scenario: perceel met gesplitst zakelijk recht en daar niet om vragen met fields
        Gegeven perceel met identificatie "22310691970000" heeft het zakelijk recht van type "eigenaar" gesplitst naar twee appartementsrechten met identificatie "22310827210004" en "22310827210003"
        En perceel met identificatie "22310691970000" heeft kadastrale grootte van 275 m2
        Als een kadastraal onroerende zaak wordt geraadpleegd met "/kadastraalonroerendezaken/22310691970000?fields=kadastraleGrootte.waarde"
        Dan is het antwoord:
        """
        {
            "identificatie": "22310691970000",
            "domein": "NL.IMKAD.KadastraalObject",
            "type": "perceel",
            "kadastraleGrootte": {
                "waarde": 275
            },
            "gesplitstZakelijkRecht": "eigenaar",
            "_links": {
                "self": {
                    "href": "/kadastraalonroerendezaken/22310691970000?fields=kadastraleGrootte.waarde"
                }
            }
        }
        """
