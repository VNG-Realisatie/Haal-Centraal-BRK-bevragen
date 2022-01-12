#language: nl

Functionaliteit: raadplegen zakelijk gerechtigden van gesplitste kadastraal onroerende zaken

    Als BRK
    Wil ik bij zakelijk gerechtigden bevragingen van een gesplitste kadastraal onroerende zaak een indicatie aan de response toevoegen
    Zodat de consumer wordt geattendeerd dat de gezochte zakelijk gerechtigden mogelijk in de isOvergegaanIn kadastraal onroerende zaken zitten.

Achtergrond:
    Gegeven de KadastraalOnroerendeZaak met identificatie '21010095970000'
    * heeft de volgende ZakelijkGerechtigden
      | identificatie | type     | persoon.identificatie |
      | 3             | eigenaar | 2                     |
    * is overgegaan in de KadastraalOnroerendeZaken
      | identificatie  |
      | 21010177310001 |
      | 21010177310002 |
    En de KadastraalOnroerendeZaak met identificatie '21010177310001'
    * heeft de volgende ZakelijkGerechtigden
      | identificatie | type     | persoon.identificatie |
      | 1             | eigenaar | 3                     |
    En de KadastraalOnroerendeZaak met identificatie '21010177310002'
    * heeft de volgende ZakelijkGerechtigden
      | identificatie | type     | persoon.identificatie |
      | 2             | eigenaar | 4                     |
      | 2             | eigenaar | 5                     |

Rule: bij raadplegen van ZakelijkGerechtigden van een gesplitste Kadastraal Onroerende Zaak wordt indicatieZakelijkGerechtigdenUitSplitsing op true gezet

    Scenario: Raadplegen ZakelijkGerechtigden van een gesplitste KadastraalOnroerendeZaak
        Als '/kadastraalonroerendezaken/21010095970000/ZakelijkGerechtigden?fields=identificatie,type,persoon.identificatie' wordt aangeroepen
        Dan bevat de response het volgende JSON fragment
        '''
        {
            "_embedded": {
                "indicatieZakelijkGerechtigdenUitSplitsing": "true"
                "zakelijkGerechtigden": [
                    {
                        "identificatie": "3",
                        "type": "eigenaar",
                        "persoon": {
                            "identificatie": "2"
                        }
                    }
                ]
            }
        }
        '''

    Scenario: Raadplegen ZakelijkGerechtigden van type eigenaar van een gesplitste KadastraalOnroerendeZaak
        Als '/kadastraalonroerendezaken/21010095970000/ZakelijkGerechtigden?type=eigenaar&fields=identificatie,type,persoon.identificatie' wordt aangeroepen
        Dan bevat de response het volgende JSON fragment
        '''
        {
            "_embedded": {
                "indicatieZakelijkGerechtigdenUitSplitsing": "true"
                "zakelijkGerechtigden": [
                    {
                        "identificatie": "3",
                        "type": "eigenaar",
                        "persoon": {
                            "identificatie": "2"
                        }
                    }
                ]
            }
        }
        '''

    Scenario: Raadplegen ZakelijkGerechtigden van een niet-gesplitste KadastraalOnroerendeZaak
        Als '/kadastraalonroerendezaken/21010095970001/ZakelijkGerechtigden?fields=identificatie,type,persoon.identificatie' wordt aangeroepen
        Dan bevat de response het volgende JSON fragment
        '''
        {
            "_embedded": {
                "zakelijkGerechtigden": [
                    {
                        "identificatie": "1",
                        "type": "eigenaar",
                        "persoon": {
                            "identificatie": "3"
                        }
                    }
                ]
            }
        }
        '''

    Scenario: Raadplegen ZakelijkGerechtigden van type eigenaar van een niet-gesplitste KadastraalOnroerendeZaak
        Als '/kadastraalonroerendezaken/21010095970002/ZakelijkGerechtigden?type=eigenaar&fields=identificatie,type,persoon.identificatie' wordt aangeroepen
        Dan bevat de response het volgende JSON fragment
        '''
        {
            "_embedded": {
                "zakelijkGerechtigden": [
                    {
                        "identificatie": "2",
                        "type": "eigenaar",
                        "persoon": {
                            "identificatie": "4"
                        }
                    },
                    {
                        "identificatie": "2",
                        "type": "eigenaar",
                        "persoon": {
                            "identificatie": "4"
                        }
                    }
                ]
            }
        }
        '''

Rule: bij raadplegen van ZakelijkGerechtigden met inclusiefUitSplitsing=true levert ook ZakelijkGerechtigden van de isOvergegaanIn KadastraalOnroerendeZaken 

    Scenario: Raadplegen ZakelijkGerechtigden van een gesplitste KadastraalOnroerendeZaak met inclusiefUitSplitsing=true
        Als '/kadastraalonroerendezaken/21010095970000/ZakelijkGerechtigden?inclusiefUitSplitsing=true&fields=identificatie,type,persoon.identificatie' wordt aangeroepen
        Dan bevat de response het volgende JSON fragment
        '''
        {
            "_embedded": {
                "zakelijkGerechtigden": [
                    {
                        "identificatie": "3",
                        "type": "eigenaar",
                        "persoon": {
                            "identificatie": "2"
                        }
                    },
                    {
                        "identificatie": "1",
                        "type": "eigenaar",
                        "persoon": {
                            "identificatie": "3"
                        },
                        "indicatieGerechtigdUitSplitsing": "true"
                    },
                    {
                        "identificatie": "2",
                        "type": "eigenaar",
                        "persoon": {
                            "identificatie": "4"
                        },
                        "indicatieGerechtigdUitSplitsing": "true"
                    },
                    {
                        "identificatie": "2",
                        "type": "eigenaar",
                        "persoon": {
                            "identificatie": "5"
                        },
                        "indicatieGerechtigdUitSplitsing": "true"
                    }
                ]
            }
        }
        '''

    Scenario: Raadplegen ZakelijkGerechtigden van een niet-gesplitste KadastraalOnroerendeZaak met inclusiefUitSplitsing=true
        Als '/kadastraalonroerendezaken/21010095970001/ZakelijkGerechtigden?inclusiefUitSplitsing=true&fields=identificatie,type,persoon.identificatie' wordt aangeroepen
        Dan bevat de response het volgende JSON fragment
        '''
        {
            "_embedded": {
                "zakelijkGerechtigden": [
                    {
                        "identificatie": "1",
                        "type": "eigenaar",
                        "persoon": {
                            "identificatie": "3"
                        }
                    }
                ]
            }
        }
        '''
