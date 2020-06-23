Functionaliteit: zoeken kadaster natuurlijkpersoon

    Achtergrond:
        Gegeven de registratie kadasternatuurlijk personen kent de persoon: Willem Jansen, man, geboortedatum 01-01-1979
        En de persoon Sigrid Jansen, vrouw, geboortedatum 20-02-1980
        En de persoon Luuk Janssen, man, geboortedatum onbekend

    Scenario: Er wordt gezocht op de gehele geslachtnaam en gehele voornaam en gehele geboortedaum met notatie [YYYY-mm-dd]
        Als kadasternatuurlijk personen gezocht worden met /kadasternatuurlijkpersonen?q=jansen willem 1979-01-01
        Dan wordt de kadasternatuurlijk persoon 'Willem Jansen' gevonden
        En wordt de kadasternatuurlijk persoon 'Sigrid Jansen' niet gevonden
        En wordt de kadasternatuurlijk persoon 'Luuk Janssen' niet gevonden

    Scenario: Er wordt gezocht op de gehele geboortedaum met notatie [YYYY-mm-dd] en de gehele geslachtnaam en gehele voornaam
        Als kadasternatuurlijk personen gezocht worden met /kadasternatuurlijkpersonen?q=1979-01-01 jansen willem
        Dan wordt de kadasternatuurlijk persoon 'Willem Jansen' gevonden
        En wordt de kadasternatuurlijk persoon 'Sigrid Jansen' niet gevonden
        En wordt de kadasternatuurlijk persoon 'Luuk Janssen' niet gevonden

    Scenario: Er wordt gezocht op de gehele voornaam en de gehele geboortedaum met notatie [YYYY-mm-dd] en de gehele geslachtnaam
        Als kadasternatuurlijk personen gezocht worden met /kadasternatuurlijkpersonen?q=willem 1979-01-01 jansen
        Dan wordt de kadasternatuurlijk persoon 'Willem Jansen' gevonden
        En wordt de kadasternatuurlijk persoon 'Sigrid Jansen' niet gevonden
        En wordt de kadasternatuurlijk persoon 'Luuk Janssen' niet gevonden

    Scenario: Er wordt gezocht op de gehele geslachtnaam
        Als kadasternatuurlijk personen gezocht worden met /kadasternatuurlijkpersonen?q=jansen
        Dan wordt de kadasternatuurlijk persoon 'Willem Jansen' gevonden
        En wordt de kadasternatuurlijk persoon 'Sigrid Jansen' gevonden
        En wordt de kadasternatuurlijk persoon 'Luuk Janssen' niet gevonden

    Scenario: Er wordt gezocht op een gedeelte van de geslachtnaam
        Als kadasternatuurlijk personen gezocht worden met /kadasternatuurlijkpersonen?q=jans
        Dan wordt de kadasternatuurlijk persoon 'Willem Jansen' gevonden
        En wordt de kadasternatuurlijk persoon 'Sigrid Jansen' gevonden
        En wordt de kadasternatuurlijk persoon 'Luuk Janssen' gevonden

    Scenario: Er wordt gezocht op de gehele geslachtnaam en een gedeelte van de geboortedatum met notatie [YYYY-mm]
        Als kadasternatuurlijk personen gezocht worden met /kadasternatuurlijkpersonen?q=jansen 1979-01
        Dan worden er geen kadasternatuurlijk personen gevonden

    Scenario: Er wordt gezocht op de gehele geslachtnaam en de gehele geboortedatum met notatie [dd-mm-YYYY]
        Als kadasternatuurlijk personen gezocht worden met /kadasternatuurlijkpersonen?q=jansen 01-01-1979
        Dan worden er geen kadasternatuurlijk personen gevonden

    Scenario: Er wordt gezocht op de gehele geslachtnaam en de gehele geboortedatum met notatie [YYYYmmdd]
        Als kadasternatuurlijk personen gezocht worden met /kadasternatuurlijkpersonen?q=jansen 19790101
        Dan worden er geen kadasternatuurlijk personen gevonden

    Scenario: Er wordt gezocht op de gehele geslachtnaam en de gehele geboortedatum met notatie [YYYY-m-d]
        Als kadasternatuurlijk personen gezocht worden met /kadasternatuurlijkpersonen?q=jansen 1979-1-1
        Dan worden er geen kadasternatuurlijk personen gevonden

    Scenario: Er wordt gezocht op een gedeelte van de geslachtnaam; niet beginnend bij het begin van de naam
        Als kadasternatuurlijk personen gezocht worden met /kadasternatuurlijkpersonen?q=ansen
        Dan worden er geen kadasternatuurlijk personen gevonden