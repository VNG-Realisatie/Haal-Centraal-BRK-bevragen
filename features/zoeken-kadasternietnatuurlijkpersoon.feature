Functionaliteit: zoeken kadaster nietnatuurlijkpersoon

    Achtergrond:
        Gegeven de registratie kadasternietnatuurlijk personen kent de persoon: De Raaf, Elburg, V.O.F.
        En de persoon Ravelijn B.V., Rotterdam, B.V.
        En de persoon Raafter, Apeldoorn, B.V.

    Scenario: Er wordt gezocht op de gehele statutaire naam en gehele statutaire zetel
        Als kadasternietnatuurlijk personen gezocht worden met /kadasternietnatuurlijkpersonen?q=de raaf elburg
        Dan wordt de kadasternietnatuurlijk persoon 'De Raaf' gevonden
        En wordt de kadasternietnatuurlijk persoon 'Ravelijn B.V.' niet gevonden
        En wordt de kadasternietnatuurlijk persoon 'Raafter' niet gevonden

    Scenario: Er wordt gezocht op de gehele statutaire naam (in omgekeerde volgorde) en gehele statutaire zetel
        Als kadasternietnatuurlijk personen gezocht worden met /kadasternietnatuurlijkpersonen?q=raaf de elburg
        Dan wordt de kadasternietnatuurlijk persoon 'De Raaf' gevonden
        En wordt de kadasternietnatuurlijk persoon 'Ravelijn B.V.' niet gevonden
        En wordt de kadasternietnatuurlijk persoon 'Raafter' niet gevonden

    Scenario: Er wordt gezocht op een gedeelte van de statutaire naam
        Als kadasternietnatuurlijk personen gezocht worden met /kadasternietnatuurlijkpersonen?q=raaf
        Dan wordt de kadasternietnatuurlijk persoon 'De Raaf' gevonden
        En wordt de kadasternietnatuurlijk persoon 'Ravelijn B.V.' niet gevonden
        En wordt de kadasternietnatuurlijk persoon 'Raafter' gevonden

    Scenario: Er wordt gezocht op een gedeelte van de statutaire naam en een gedeelte van de statutaire zetel
        Als kadasternietnatuurlijk personen gezocht worden met /kadasternietnatuurlijkpersonen?q=raaf elbu
        Dan wordt de kadasternietnatuurlijk persoon 'De Raaf' gevonden
        En wordt de kadasternietnatuurlijk persoon 'Ravelijn B.V.' niet gevonden
        En wordt de kadasternietnatuurlijk persoon 'Raafter' niet gevonden

    Scenario: Er wordt gezocht op een gedeelte van de statutaire naam; niet beginnend bij het begin van de naam
        Als kadasternietnatuurlijk personen gezocht worden met /kadasternatuurlijkpersonen?q=aaf
        Dan worden er geen kadasternietnatuurlijk personen gevonden

    Scenario: Er wordt gezocht op de gehele statutaire naam en een gedeelte van de statutaire zetel; niet beginnend bij het begin van de naam
        Als kadasternietnatuurlijk personen gezocht worden met /kadasternietnatuurlijkpersonen?q=de raaf burg
        Dan worden er geen kadasternietnatuurlijk personen gevonden