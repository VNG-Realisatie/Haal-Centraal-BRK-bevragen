# language: nl

Functionaliteit: Als gemeente wil ik inzicht in de filiatie van Kadastraal onroerende zaken
    Zodat ik inzicht heb in de splitsingen en samenvoegingen waarbij de kadastraal onroerende zaak betrokken is geweest.
    En zodat ik inzicht heb in alle splitsingen en samenvoegingen die hebben plaatsgevonden tot en met de uitgifte van de grond door de gemeente.

    Filiatie is de relatie naar de kadastraal onroerende zaken waaruit betreffende onroerende zaak is ontstaan en/of waarin de kadastraal onroerende zaak is overgegaan.
    
    Er zijn twee soorten kadastraal onroerende zaken, perceel en appartementsrecht. Een perceel is een begrensd deel van het Nederlands grondgebied. Een appartementsrecht omvat de bevoegdheid tot het gebruik van bepaalde gedeelten van een gebouw die blijkens hun inrichting bestemd zijn of worden om als afzonderlijk geheel te worden gebruikt. 
    
    De filiatie van een perceel wordt op een andere manier geregistreerd en daardoor ook op een andere manier in de API getoond dan een appartementsrecht.

    Een perceel kan worden gesplitst in meerdere nieuwe percelen. Een perceel kan ook worden samengevoegd met één of meerdere andere percelen. 
    Wanneer een perceel wordt gesplitst of samengevoegd vervallen de oude kadastraal onroerende zaken (percelen) en ontstaan er nieuwe kadastraal onroerende zaken (percelen). De vervallen kadastraal onroerende zaken (percelen) zijn dan nog wel raadpleegbaar.

    Een perceel kan worden gesplitst in meerdere appartementsrechten. Zowel het perceel als de daaruit gesplitste appartementsrechten zijn kadastraal onroerende zaken. Bij splitsing van een perceel in appartementsrechten blijft de kadastraal onroerende zaak van het "grondperceel" actueel, het is dan niet vervallen.

    Een appartementsrecht kan worden gesplitst in meerdere nieuwe appartementsrechten. Dit heet "ondersplitsing" van het appartementsrecht. In dat geval wordt de oude kadastraal onroerende zaak (het oude appartementsrecht) "sluimerend". Dat oude appartementsrecht is dan dus niet vervallen en blijft ook raadpleegbaar.

    Wanneer een appartementsrechtsplitsing moet worden gewijzigd, bijvoorbeeld wanneer appartementsrechten worden samengevoegd, dan vervallen de oude kadastraal onroerende zaken (appartementsrechten). De oude kadastraal onroerende zaken (appartementsrechten) vervallen dan en zijn niet meer raadpleegbaar. De filiatie van de oude kadastraal onroerende zaken (vervallen appartementsrechten) wordt dan overgenomen in de nieuwe kadastraal onroerende zaken (appartementsrechten).

    In een overzicht:
    | gebeurtenis                               | status oude kadastraal onroerende zaak/zaken | oude kadastraal onroerende zaak/zaken raadpleegbaar |
    | splitsen van perceel in nieuwe percelen   | vervallen                                    | ja                                                  |
    | samenvoegen van percelen                  | vervallen                                    | ja                                                  |
    | splitsen perceel in appartementsrechten   | actueel                                      | ja                                                  |
    | ondersplitsing van appartementsrecht      | sluimerend                                   | ja                                                  |
    | wijzigingssplitsing van appartementsrecht | vervallen                                    | nee                                                 |


    Naast de filiatie worden relaties naar de grondpercelen waaruit het appartementsrecht is ontstaan of naar de appartementsrechten horend bij het perceel geleverd, zodat direct de bijbehorende grondpercelen dan wel bijbehorende appartementsrechten kunnen worden opgehaald, zonder eerst via eventuele sluimerende appartementsrechten de filiatie af te hoeven lopen.

    #TODO: invullen onroerende zaak identificaties

    Rule: Na splitsing van een perceel wordt filiatie opgenomen bij het vervallen perceel en bij de nieuwe percelen
        Scenario: Opvragen van een vervallen perceel na splitsing
            Gegeven Perceel met identificatie "P1" is gesplitst naar percelen "P2" en "P3"
            En Perceel met identificatie "P1" is niet ontstaan uit splitsing of vereniging van een ander perceel
            En Perceel met identificatie "P2" is niet verder gesplitst of verenigd
            En Perceel met identificatie "P3" is niet verder gesplitst of verenigd
            Als "/kadastraalonroerendezaken/P1" wordt gevraagd
            Dan bevat het antwoord "isOvergegaanIn" met waarde:    
                """
                [
                    {
                        "aard": {
                            "code": "20",
                            "waarde": "Splitsen perceel"
                        },
                        "kadastraalOnroerendeZaken": [{
                            "identificatie": "P2",
                            "type": "perceel"
                        }, {
                            "identificatie": "P3",
                            "type": "perceel"
                        }]
                    }
                ]
                """
            En bevat het antwoord "indicatieVervallen": true
            En bevat het antwoord property "einddatum" met een waarde
            En is de kadastraal onroerende zaak niet sluimerend
            En bevat het antwoord geen property "bijbehorendeGrondperceelIdentificaties"
            En bevat het antwoord geen property "bijbehorendeAppartementsrechten"

        Scenario: Opvragen perceel uit splitsing
            Als "/kadastraalonroerendezaken/P2" wordt gevraagd
            Dan bevat het antwoord "isOntstaanUit" met waarde:    
                """
                [
                    {
                        "aard": {
                            "code": "20",
                            "waarde": "Splitsen perceel"
                        },
                        "kadastraalOnroerendeZaken": [{
                            "identificatie": "P1",
                            "type": "perceel"
                        }]
                    }
                ]
                """
            En bevat het antwoord geen property "indicatieVervallen"
            En bevat het antwoord geen property "einddatum"
            En is de kadastraal onroerende zaak niet sluimerend
            En bevat het antwoord geen property "isOvergegaanIn"
            En bevat het antwoord geen property "bijbehorendeGrondperceelIdentificaties"
            En bevat het antwoord geen property "bijbehorendeAppartementsrechten"
    
    Rule: Na vereniging van percelen wordt filiatie getoond bij de vervallen percelen en bij het nieuwe perceel
        Scenario: Opvragen vervallen perceel na vereniging
            Gegeven Percelen met identificatie "P4" en "P5" zijn verenigd naar perceel "P6"
            En Perceel met identificatie "P4" is niet ontstaan uit splitsing of vereniging van een ander perceel
            En Perceel met identificatie "P5" is niet ontstaan uit splitsing of vereniging van een ander perceel
            En Perceel met identificatie "P6" is niet verder gesplitst of verenigd
            Als "/kadastraalonroerendezaken/P4" wordt gevraagd
            Dan bevat het antwoord "isOvergegaanIn" met waarde:    
                """
                [
                    {
                        "aard": {
                            "code": "19",
                            "waarde": "Verenigen percelen"
                        },
                        "kadastraalOnroerendeZaken": [{
                            "identificatie": "P6",
                            "type": "perceel"
                        }]
                    }
                ]
                """
            En bevat het antwoord "indicatieVervallen": true
            En bevat het antwoord property "einddatum" met een waarde
            En is de kadastraal onroerende zaak niet sluimerend
            En bevat het antwoord geen property "bijbehorendeGrondperceelIdentificaties"
            En bevat het antwoord geen property "bijbehorendeAppartementsrechten"

        Scenario: Opvragen perceel uit vereniging
            Gegeven Percelen met identificatie "P4" en "P5" zijn verenigd naar perceel "P6"
            En Perceel met identificatie "P4" is niet ontstaan uit splitsing of vereniging van een ander perceel
            En Perceel met identificatie "P5" is niet ontstaan uit splitsing of vereniging van een ander perceel
            En Perceel met identificatie "P6" is niet verder gesplitst of verenigd
            Als "/kadastraalonroerendezaken/P6" wordt gevraagd
            Dan bevat het antwoord "isOntstaanUit" met waarde:    
                """
                [
                    {
                        "aard": {
                            "code": "19",
                            "waarde": "Verenigen percelen"
                        },
                        "kadastraalOnroerendeZaken": [
                            {
                                "identificatie": "P4",
                                "type": "perceel"
                            }, {
                                "identificatie": "P5",
                                "type": "perceel"
                            }
                        ]
                    }
                ]
                """
            En bevat het antwoord geen property "indicatieVervallen"
            En bevat het antwoord geen property "einddatum"
            En is de kadastraal onroerende zaak niet sluimerend
            En bevat het antwoord geen property "isOvergegaanIn"
            En bevat het antwoord geen property "bijbehorendeGrondperceelIdentificaties"
            En bevat het antwoord geen property "bijbehorendeAppartementsrechten"

    Rule: Splitsing in appartementsrechten van een perceel toont verwijzingen van het grondperceel naar de appartementsrechten en vice versa
        Scenario: Opvragen van het grondperceel na splitsing in appartementsrechten
            Gegeven Perceel met identificatie "P7" is gesplitst naar appartementsrechten "A1" en "A2"
            En Perceel met identificatie "P7" is niet ontstaan uit splitsing of vereniging van een ander perceel
            En Appartementsrecht met identificatie "A1" is niet verder gesplitst of verenigd
            En Appartementsrecht met identificatie "A1" heeft "volgnummer"= 1
            En Appartementsrecht met identificatie "A2" is niet verder gesplitst of verenigd
            En Appartementsrecht met identificatie "A2" heeft "volgnummer"= 2
            Als "/kadastraalonroerendezaken/P7" wordt gevraagd
            Dan bevat het antwoord "isOvergegaanIn" met waarde:    
                """
                [
                    {
                        "kadastraalOnroerendeZaken": [
                            {
                                "identificatie": "A1",
                                "type": "appartementsrecht"
                            }, 
                                "identificatie": "A2",
                                "type": "appartementsrecht"
                            }
                        ]
                    }
                ]
                """
            En bevat het antwoord "bijbehorendeAppartementsrechten" met waarde:    
                """
                [
                    {
                        "identificatie": "A1",
                        "volgnummer": 1
                    },
                    {
                        "identificatie": "A2",
                        "volgnummer": 2
                    }
                ]
                """
            En bevat het antwoord geen property "indicatieVervallen"
            En bevat het antwoord geen property "einddatum"
            En is de kadastraal onroerende zaak niet sluimerend
            En bevat het antwoord geen property "volgnummer"
            En bevat het antwoord geen property "bijbehorendeGrondperceelIdentificaties"

        Scenario: Opvragen appartementsrecht uit splitsing
            Gegeven Perceel met identificatie "P7" is gesplitst naar appartementsrechten "A1" en "A2"
            En Perceel met identificatie "P7" is niet ontstaan uit splitsing of vereniging van een ander perceel
            En Appartementsrecht met identificatie "A1" is niet verder gesplitst of verenigd
            En Appartementsrecht met identificatie "A1" heeft "volgnummer"= 1
            En Appartementsrecht met identificatie "A2" is niet verder gesplitst of verenigd
            En Appartementsrecht met identificatie "A2" heeft "volgnummer"= 2
            Als "/kadastraalonroerendezaken/A1" wordt gevraagd
            Dan bevat het antwoord "isOntstaanUit" met waarde:    
                """
                [
                    {
                        "kadastraalOnroerendeZaken": [{
                            "identificatie": "P7",
                            "type": "perceel"
                        }]
                    }
                ]
                """
            En bevat het antwoord "bijbehorendeGrondperceelIdentificaties": [ "P7" ]
            En bevat het antwoord "volgnummer": 1
            En bevat het antwoord geen property "indicatieVervallen"
            En bevat het antwoord geen property "einddatum"
            En is de kadastraal onroerende zaak niet sluimerend
            En bevat het antwoord geen property "isOvergegaanIn"
            En bevat het antwoord geen property "bijbehorendeAppartementsrechten"

        Scenario: Opvragen appartementsrecht met meerdere bijbehorende grondpercelen
            Gegeven Percelen met identificatie "P8" en "P9" zijn gesplitst naar appartementsrechten "A3" en "A4"
            En Perceel met identificatie "P8" is niet ontstaan uit splitsing of vereniging van een ander perceel
            En Perceel met identificatie "P9" is niet ontstaan uit splitsing of vereniging van een ander perceel
            En Appartementsrecht met identificatie "A3" is niet verder gesplitst of verenigd
            En Appartementsrecht met identificatie "A3" heeft "volgnummer"= 1
            En Appartementsrecht met identificatie "A4" is niet verder gesplitst of verenigd
            En Appartementsrecht met identificatie "A4" heeft "volgnummer"= 2
            Als "/kadastraalonroerendezaken/A3" wordt gevraagd
            Dan bevat het antwoord "isOntstaanUit" met waarde:    
                """
                [
                    {
                        "kadastraalOnroerendeZaken": [
                            {
                                "identificatie": "P8",
                                "type": "perceel"
                            }, {
                                "identificatie": "P9",
                                "type": "perceel"
                            }
                        ]
                    }
                ]
                """
            En bevat het antwoord "bijbehorendeGrondperceelIdentificaties": [ "P8", "P9" ]
            En bevat het antwoord "volgnummer": 1
            En bevat het antwoord geen property "indicatieVervallen"
            En bevat het antwoord geen property "einddatum"
            En is de kadastraal onroerende zaak niet sluimerend
            En bevat het antwoord geen property "isOvergegaanIn"
            En bevat het antwoord geen property "bijbehorendeAppartementsrechten"

    Rule: Bij ondersplitsing van een appartementsrecht worden alle bijbehorende appartementsrechten getoond bij het perceel
        Scenario: Opvragen van het grondperceel na splitsing in appartementsrechten en ondersplitsing van een appartementsrecht
            Gegeven Perceel met identificatie "P10" is gesplitst naar appartementsrechten "A5" en "A6"
            En Perceel met identificatie "P10" is niet ontstaan uit splitsing of vereniging van een ander perceel
            En Appartementsrecht met identificatie "A5" is niet verder gesplitst of verenigd
            En Appartementsrecht met identificatie "A5" heeft "volgnummer"= 1
            En Appartementsrecht met identificatie "A6" is ondergesplitst in appartementsrechten "A7" en "A8"
            En Appartementsrecht met identificatie "A6" heeft "volgnummer"= 2
            En Appartementsrecht met identificatie "A7" heeft "volgnummer"= 3
            En Appartementsrecht met identificatie "A8" heeft "volgnummer"= 4
            Als "/kadastraalonroerendezaken/P10" wordt gevraagd
            Dan bevat het antwoord "isOvergegaanIn" met waarde:
                """
                [
                    {
                        "kadastraalOnroerendeZaken": [
                            {
                                "identificatie": "A5",
                                "type": "appartementsrecht"
                            }, {
                                "identificatie": "A6",
                                "type": "appartementsrecht"
                            }
                        ]
                    }
                ]
                """
            En bevat het antwoord "bijbehorendeAppartementsrechten" met waarde:    
                """
                [
                    {
                        "identificatie": "A5",
                        "volgnummer": 1
                    },
                    {
                        "identificatie": "A6",
                        "volgnummer": 2
                    },
                    {
                        "identificatie": "A7",
                        "volgnummer": 3
                    },
                    {
                        "identificatie": "A8",
                        "volgnummer": 4
                    }
                ]
                """
            En bevat het antwoord geen property "indicatieVervallen"
            En bevat het antwoord geen property "einddatum"
            En is de kadastraal onroerende zaak niet sluimerend
            En bevat het antwoord geen property "volgnummer"
            En bevat het antwoord geen property "bijbehorendeGrondperceelIdentificaties"

    Rule: Na ondersplitsing van een appartementsrecht toont de filiatie één stap omhoog of omlaag, plus het bijbehorende grondperceel
        Scenario: Opvragen sluimerend appartementsrecht na ondersplitsing
            Gegeven Perceel met identificatie "P10" is gesplitst naar appartementsrechten "A5" en "A6"
            En Perceel met identificatie "P10" is niet ontstaan uit splitsing of vereniging van een ander perceel
            En Appartementsrecht met identificatie "A5" is niet verder gesplitst of verenigd
            En Appartementsrecht met identificatie "A5" heeft "volgnummer"= 1
            En Appartementsrecht met identificatie "A6" is ondergesplitst in appartementsrechten "A7" en "A8"
            En Appartementsrecht met identificatie "A6" heeft "volgnummer"= 2
            En Appartementsrecht met identificatie "A7" heeft "volgnummer"= 3
            En Appartementsrecht met identificatie "A8" heeft "volgnummer"= 4
            Als "/kadastraalonroerendezaken/A6" wordt gevraagd
            Dan bevat het antwoord "isOntstaanUit" met waarde:    
                """
                [
                    {
                        "kadastraalOnroerendeZaken": [{
                            "identificatie": "P10",
                            "type": "perceel"
                        }]
                    }
                ]
                """
            En bevat het antwoord "isOvergegaanIn" met waarde:    
                """
                [
                    {
                        "kadastraalOnroerendeZaken": [
                            {
                                "identificatie": "A7",
                                "type": "appartementsrecht"
                            }, {
                                "identificatie": "A8",
                                "type": "appartementsrecht"
                            }
                        ]
                    }
                ]
                """
            En bevat het antwoord "bijbehorendeGrondperceelIdentificaties": [ "P10" ]
            En bevat het antwoord "volgnummer": 2
            En bevat het antwoord geen property "indicatieVervallen"
            En bevat het antwoord geen property "einddatum"
            En is de kadastraal onroerende zaak sluimerend
            En bevat het antwoord geen property "bijbehorendeAppartementsrechten"

        Scenario: Opvragen appartementsrecht uit ondersplitsing
            Gegeven Perceel met identificatie "P10" is gesplitst naar appartementsrechten "A5" en "A6"
            En Perceel met identificatie "P10" is niet ontstaan uit splitsing of vereniging van een ander perceel
            En Appartementsrecht met identificatie "A5" is niet verder gesplitst of verenigd
            En Appartementsrecht met identificatie "A5" heeft "volgnummer"= 1
            En Appartementsrecht met identificatie "A6" is ondergesplitst in appartementsrechten "A7" en "A8"
            En Appartementsrecht met identificatie "A6" heeft "volgnummer"= 2
            En Appartementsrecht met identificatie "A7" heeft "volgnummer"= 3
            En Appartementsrecht met identificatie "A8" heeft "volgnummer"= 4
            Als "/kadastraalonroerendezaken/A7" wordt gevraagd
            Dan bevat het antwoord "isOntstaanUit" met waarde:    
                """
                [
                    {
                        "kadastraalOnroerendeZaken": [{
                            "identificatie": "A6",
                            "type": "appartementsrecht"
                        }]
                    }
                ]
                """
            En bevat het antwoord "bijbehorendeGrondperceelIdentificaties": [ "P10" ]
            En bevat het antwoord "volgnummer": 3
            En bevat het antwoord geen property "indicatieVervallen"
            En bevat het antwoord geen property "einddatum"
            En is de kadastraal onroerende zaak niet sluimerend
            En bevat het antwoord geen property "isOvergegaanIn"
            En bevat het antwoord geen property "bijbehorendeAppartementsrechten"

    Rule: Een vervallen (verenigd of gesplitst) perceel wordt niet getoond als bijbehorend grondperceel 
        Scenario: Opvragen appartementsrecht met grondperceel uit splitsing
            Gegeven Perceel met identificatie "P11" is gesplitst naar percelen "P12" en "P13"
            En Perceel met identificatie "P12" is gesplitst naar appartementsrechten "A9" en "A10"
            En Appartementsrecht met identificatie "A9" is niet verder gesplitst of verenigd
            En Appartementsrecht met identificatie "A9" heeft "volgnummer"= 1
            En Appartementsrecht met identificatie "A10" is niet verder gesplitst of verenigd
            En Appartementsrecht met identificatie "A10" heeft "volgnummer"= 2
            Als "/kadastraalonroerendezaken/A9" wordt gevraagd
            Dan bevat het antwoord "isOntstaanUit" met waarde:    
                """
                [
                    {
                        "kadastraalOnroerendeZaken": [{
                            "identificatie": "P12",
                            "type": "perceel"
                        }]
                    }
                ]
                """
            En bevat het antwoord "bijbehorendeGrondperceelIdentificaties": [ "P12" ]
            En bevat het antwoord in "bijbehorendeGrondperceelIdentificaties" geen waarde "P11"
            En bevat het antwoord in "bijbehorendeGrondperceelIdentificaties" geen waarde "P13"
            En bevat het antwoord "volgnummer": 1
            En bevat het antwoord geen property "indicatieVervallen"
            En bevat het antwoord geen property "einddatum"
            En is de kadastraal onroerende zaak niet sluimerend
            En bevat het antwoord geen property "isOvergegaanIn"
            En bevat het antwoord geen property "bijbehorendeAppartementsrechten"

        Scenario: Opvragen appartementsrecht met grondperceel uit vereniging
            Gegeven Percelen met identificatie "P14" en "P15" zijn verenigd naar perceel "P16"
            En Perceel met identificatie "P16" is gesplitst naar appartementsrechten "A11" en "A12"
            En Appartementsrecht met identificatie "A11" is niet verder gesplitst of verenigd
            En Appartementsrecht met identificatie "A11" heeft "volgnummer"= 1
            En Appartementsrecht met identificatie "A12" is niet verder gesplitst of verenigd
            En Appartementsrecht met identificatie "A12" heeft "volgnummer"= 2
            Als "/kadastraalonroerendezaken/A11" wordt gevraagd
            Dan bevat het antwoord "isOntstaanUit" met waarde:    
                """
                [
                    {
                        "kadastraalOnroerendeZaken": [{
                            "identificatie": "P16",
                            "type": "perceel"
                        }]
                    }
                ]
                """
            En bevat het antwoord "bijbehorendeGrondperceelIdentificaties": [ "P16" ]
            En bevat het antwoord in "bijbehorendeGrondperceelIdentificaties" geen waarde "P14"
            En bevat het antwoord in "bijbehorendeGrondperceelIdentificaties" geen waarde "P15"
            En bevat het antwoord "volgnummer": 1
            En bevat het antwoord geen property "indicatieVervallen"
            En bevat het antwoord geen property "einddatum"
            En is de kadastraal onroerende zaak niet sluimerend
            En bevat het antwoord geen property "isOvergegaanIn"
            En bevat het antwoord geen property "bijbehorendeAppartementsrechten"
    
    Rule: Na een wijzigingssplitsing van een appartementsrecht worden de vervallen appartementsrechten niet getoond en wordt de filiatie uit het oude appartementsrecht overgenomen in de nieuwe appartementsrechten
        Scenario: Opvragen van het grondperceel na wijzigingssplitsing van appartementsrechten
            Gegeven Perceel met identificatie "P17" is gesplitst naar appartementsrechten "A13", "A14" en "A15"
            En Perceel met identificatie "P17" is niet ontstaan uit splitsing of vereniging van een ander perceel
            En Appartementsrecht met identificatie "A13" is niet verder gesplitst of verenigd
            En Appartementsrecht met identificatie "A14" is ondergesplitst in appartementsrechten "A16" en "A17"
            En Appertementsrechten met identificatie "A15" en "A17" zijn samengevoegd (via wijzigingssplitsing)
            En voor de wijzigingssplitsing zijn appartementsrechten "A13", "A14", "A15", "A16" en "A17" vervallen
            En is appartementsrecht "A13" nieuw appartementsrecht "A18" geworden
            En is appartementsrecht "A16" nieuw appartementsrecht "A19" geworden
            En zijn appartementsrechten "A15" en "A17" nieuw appartementsrecht "A20" geworden
            En Appartementsrecht met identificatie "A13" heeft "volgnummer"= 1
            En Appartementsrecht met identificatie "A14" heeft "volgnummer"= 2
            En Appartementsrecht met identificatie "A15" heeft "volgnummer"= 3
            En Appartementsrecht met identificatie "A16" heeft "volgnummer"= 4
            En Appartementsrecht met identificatie "A17" heeft "volgnummer"= 5
            En Appartementsrecht met identificatie "A18" heeft "volgnummer"= 6
            En Appartementsrecht met identificatie "A19" heeft "volgnummer"= 7
            En Appartementsrecht met identificatie "A20" heeft "volgnummer"= 8
            En Appartementsrecht met identificatie "A18" is niet verder gesplitst of verenigd
            Als "/kadastraalonroerendezaken/P17" wordt gevraagd
            Dan bevat het antwoord "isOvergegaanIn" met waarde:    
                """
                [
                    {
                        "kadastraalOnroerendeZaken": [
                            {
                                "identificatie": "A13",
                                "type": "appartementsrecht"
                            }, {
                                "identificatie": "A14",
                                "type": "appartementsrecht"
                            }, {
                                "identificatie": "A16",
                                "type": "appartementsrecht"
                            }
                        ]
                    }
                ]
                """
            En bevat het antwoord "bijbehorendeAppartementsrechten" met waarde:    
                """
                [
                    {
                        "identificatie": "A13",
                        "volgnummer": 1
                    },
                    {
                        "identificatie": "A14",
                        "volgnummer": 2
                    },
                    {
                        "identificatie": "A16",
                        "volgnummer": 4
                    },
                    {
                        "identificatie": "A18",
                        "volgnummer": 6
                    }
                ]
                """
            En bevat het antwoord geen property "indicatieVervallen"
            En bevat het antwoord geen property "einddatum"
            En is de kadastraal onroerende zaak niet sluimerend
            En bevat het antwoord geen property "volgnummer"
            En bevat het antwoord geen property "bijbehorendeGrondperceelIdentificaties"

        Scenario: Opvragen van een vervallen appartementsrecht
            Gegeven Perceel met identificatie "P17" is gesplitst naar appartementsrechten "A13", "A14" en "A15"
            En Perceel met identificatie "P17" is niet ontstaan uit splitsing of vereniging van een ander perceel
            En Appartementsrecht met identificatie "A13" is niet verder gesplitst of verenigd
            En Appartementsrecht met identificatie "A14" is ondergesplitst in appartementsrechten "A16" en "A17"
            En Appertementsrechten met identificatie "A15" en "A17" zijn samengevoegd (via wijzigingssplitsing)
            En voor de wijzigingssplitsing zijn appartementsrechten "A13", "A14", "A15", "A16" en "A17" vervallen
            En is appartementsrecht "A13" nieuw appartementsrecht "A18" geworden
            En is appartementsrecht "A16" nieuw appartementsrecht "A19" geworden
            En zijn appartementsrechten "A15" en "A17" nieuw appartementsrecht "A20" geworden
            En Appartementsrecht met identificatie "A13" heeft "volgnummer"= 1
            En Appartementsrecht met identificatie "A14" heeft "volgnummer"= 2
            En Appartementsrecht met identificatie "A15" heeft "volgnummer"= 3
            En Appartementsrecht met identificatie "A16" heeft "volgnummer"= 4
            En Appartementsrecht met identificatie "A17" heeft "volgnummer"= 5
            En Appartementsrecht met identificatie "A18" heeft "volgnummer"= 6
            En Appartementsrecht met identificatie "A19" heeft "volgnummer"= 6
            En Appartementsrecht met identificatie "A20" heeft "volgnummer"= 6
            En Appartementsrecht met identificatie "A18" is niet verder gesplitst of verenigd
            Als "/kadastraalonroerendezaken/A15" wordt gevraagd
            Dan geeft het antwoord http statuscode 410
            En bevat het antwoord "detail": "Dit appartementsrecht is vervallen en is overgegaan in appartementsrecht A18"

        Scenario: opvragen van appartementsrecht na wijzigingssplitsing
            Gegeven Perceel met identificatie "P17" is gesplitst naar appartementsrechten "A13", "A14" en "A15"
            En Perceel met identificatie "P17" is niet ontstaan uit splitsing of vereniging van een ander perceel
            En Appartementsrecht met identificatie "A13" is niet verder gesplitst of verenigd
            En Appartementsrecht met identificatie "A14" is ondergesplitst in appartementsrechten "A16" en "A17"
            En Appertementsrechten met identificatie "A15" en "A17" zijn samengevoegd (via wijzigingssplitsing)
            En door de wijzigingssplitsing zijn appartementsrechten "A13", "A14", "A15", "A16" en "A17" vervallen
            En is appartementsrecht "A13" nieuw appartementsrecht "A18" geworden
            En is appartementsrecht "A16" nieuw appartementsrecht "A19" geworden
            En zijn appartementsrechten "A15" en "A17" nieuw appartementsrecht "A20" geworden
            En Appartementsrecht met identificatie "A13" heeft "volgnummer"= 1
            En Appartementsrecht met identificatie "A14" heeft "volgnummer"= 2
            En Appartementsrecht met identificatie "A15" heeft "volgnummer"= 3
            En Appartementsrecht met identificatie "A16" heeft "volgnummer"= 4
            En Appartementsrecht met identificatie "A17" heeft "volgnummer"= 5
            En Appartementsrecht met identificatie "A18" heeft "volgnummer"= 6
            En Appartementsrecht met identificatie "A19" heeft "volgnummer"= 6
            En Appartementsrecht met identificatie "A20" heeft "volgnummer"= 6
            En Appartementsrecht met identificatie "A18" is niet verder gesplitst of verenigd
            Als "/kadastraalonroerendezaken/A18" wordt gevraagd
            Dan bevat het antwoord "isOntstaanUit" met waarde:    
                """
                [
                    {
                        "kadastraalOnroerendeZaken": [
                            {
                                "identificatie": "A14",
                                "type": "appartementsrecht"
                            }, {
                                "identificatie": "P17",
                                "type": "perceel"
                            }
                        ]
                    }
                ]
                """
            En bevat het antwoord "bijbehorendeGrondperceelIdentificaties": [ "P17" ]
            En bevat het antwoord "volgnummer": 6
            En bevat het antwoord geen property "indicatieVervallen"
            En bevat het antwoord geen property "einddatum"
            En is de kadastraal onroerende zaak niet sluimerend
            En bevat het antwoord geen property "isOvergegaanIn"
            En bevat het antwoord geen property "bijbehorendeAppartementsrechten"

        Scenario: opvragen van sluimerend appartementsrecht na wijzigingssplitsing in gesplitst perceel
            Gegeven Perceel met identificatie "P17" is gesplitst naar appartementsrechten "A13", "A14" en "A15"
            En Perceel met identificatie "P17" is niet ontstaan uit splitsing of vereniging van een ander perceel
            En Appartementsrecht met identificatie "A13" is niet verder gesplitst of verenigd
            En Appartementsrecht met identificatie "A14" is ondergesplitst in appartementsrechten "A16" en "A17"
            En Appertementsrechten met identificatie "A15" en "A17" zijn samengevoegd (via wijzigingssplitsing)
            En voor de wijzigingssplitsing zijn appartementsrechten "A13", "A14", "A15", "A16" en "A17" vervallen
            En is appartementsrecht "A13" nieuw appartementsrecht "A18" geworden
            En is appartementsrecht "A16" nieuw appartementsrecht "A19" geworden
            En zijn appartementsrechten "A15" en "A17" nieuw appartementsrecht "A20" geworden
            En Appartementsrecht met identificatie "A13" heeft "volgnummer"= 1
            En Appartementsrecht met identificatie "A14" heeft "volgnummer"= 2
            En Appartementsrecht met identificatie "A15" heeft "volgnummer"= 3
            En Appartementsrecht met identificatie "A16" heeft "volgnummer"= 4
            En Appartementsrecht met identificatie "A17" heeft "volgnummer"= 5
            En Appartementsrecht met identificatie "A18" heeft "volgnummer"= 6
            En Appartementsrecht met identificatie "A19" heeft "volgnummer"= 6
            En Appartementsrecht met identificatie "A20" heeft "volgnummer"= 6
            En Appartementsrecht met identificatie "A18" is niet verder gesplitst of verenigd
            Als "/kadastraalonroerendezaken/A14" wordt gevraagd
            Dan bevat het antwoord "isOntstaanUit" met waarde:    
                """
                [
                    {
                        "kadastraalOnroerendeZaken": [{
                            "identificatie": "P17",
                            "type": "perceel"
                        }]
                    }
                ]
                """
            En bevat het antwoord "isOvergegaanIn" met waarde:    
                """
                [
                    {
                        "kadastraalOnroerendeZaken": [{
                            "identificatie": "A16",
                            "type": "appartementsrecht"
                        }]
                    }
                ]
                """
            En bevat het antwoord "bijbehorendeGrondperceelIdentificaties": [ "P17" ]
            En bevat het antwoord "volgnummer": 2
            En bevat het antwoord geen property "indicatieVervallen"
            En bevat het antwoord geen property "einddatum"
            En is de kadastraal onroerende zaak sluimerend
            En bevat het antwoord geen property "bijbehorendeAppartementsrechten"
            