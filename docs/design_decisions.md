# Design decisions HaalCentraal BRK-Bevragen
Dit document beschrijft ontwerpkeuzes die gemaakt zijn voor het ontwerpen en specificeren van de API's. .

## Algemene Design Decisions
In het document [design_desicions.md](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/master/docs/design_decisions.md) dat in de Haal-Centraal-common repository is opgenomen staan beslissingen opgesomd waar alle Haal Centraal API's zich aan conformeren.

## Specifieke beslissingen t.a.v. de API BRK-Bevragen zijn hieronder vermeld.

Beslissing | 
Kadastrale onroerende zaak, perceel en appartementsrecht wordt 1 resource
Voor veruit de meeste gebruikers is het gewenst om op een kadastrale onroerende zaak te zoeken. De response geeft kadastrale onroerende zaken terug, zowel percelen als appartementsrechten.  De KOZ wordt platgeslagen als 1 resource, waarbij de de eigenschappen van het perceel optioneel zijn. Ook wordt een type element toegevoegd (type perceel of appartementsrecht).

Kadastrale onroerende zaak en teboekgestelde zaak blijven twee aparte resources en worden NIET samengenomen in een resource kadastraal object.  
De sociale dienst (opsporing uitkeringsfraude) is de enige gebruiker die de teboekgestelde zaak nodig heeft. Deze kunnen zij apart opvragen. Het alternatief is alle andere gebruikers lastig te vallen met de teboekgestelde zaak (niet wenselijk).

Zakelijke rechten worden als subresource gedefinieerd, en embedded opgenomen in de KOZ.  
Zakelijke rechten worden alleen via de KOZ of via de persoon opgevraagd, daarom wordt het zakelijk recht als subresource gedefinieerd. omdat veel afnemers geinteresseerd zijn in het zakelijk recht, worden zij embedded opgenomen bij de KOZ.

Zekerheidsstellingen worden als subresource gedefinieerd, en niet embedded opgenomen in de KOZ.  
Zekerheidsstellingen worden alleen via de KOZ of via de persoon opgevraagd, daarom wordt de zekerheidsstelling als subresource gedefinieerd. Deze worden niet embedded opgenomen in de KOZ, omdat slechts enkele afnemers geinteresseerd zijn in de zekerheidsstelling.

- Personen worden voor de tenaamstellingen niet embedded opgenomen. Er wordt dus met links verwezen en daarmee wordt er ook een endpoint voor kadaster-personenen geintroduceerd (niet-ingeschreven personen die eigenaar zijn). 
- Voor de ingeschreven personen verwijzen we voor tenaamstellingen altijd naar de actuele gegevens van de ingeschreven persoon in de BRP (vooralsnog middels BSN). De gegevens van de ingeschreven persoon zoals die op de akte staan worden dus niet geleverd. Voor niet-ingeschreven personenen levert het kadaster de gegevens zoals zij die kent, maar kan daar geen garantie leveren voor de actualiteit. (Dit zijn de persoonsgegevens zoals die op de akte zijn vastgelegd. \
- De gegevens van een natuurlijk persoon die bij het kadaster is geregistreerd, maar niet als ingeschreven persoon is opgenomen in de BRP wordt door het kadaster ontsloten als de resource "BRKPersoon"
- De gegevens van een rechtspersoon die bij het kadaster zijn geregistreerd, maar niet als ingeschreven rechtspersoon i sopgenomen in het Handelsregister wordt door het kadaster ontsloten als de resource "BRKRechtspersoon"
- Tenaamstellingen worden niet embedded opgenomen maar worden als een gegevensgroep opgenomen bij het zakelijkrecht.
- tenaamstellingfiliatie wordt niet opgenomen. Dit is een blik op historische gegevens. Dit objecttype wordt meegenomen als er historische bevragingen woren uitgewerkt.

- Het gezamenlijk aandeel kan een complexe geneste situatie omvatten. We laten dus zien dat er sprake is van een gezamenlijk aandeel, maar niet welk aandeel dat is en of er eventueel sprake is van een gezamenlijk aandeel van een gezamenlijk aandeel.  




