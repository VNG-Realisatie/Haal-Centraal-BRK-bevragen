# Design decisions
Dit document beschrijft ontwerpkeuzes die gemaakt zijn voor het ontwerpen en specificeren van de API's in dit koppelvlak.

Beslissing | Ratio
---------- | -----
Kadastrale onroerende zaak, perceel en appartementsrecht wordt 1 resource
Voor veruit de meeste gebruikers is het gewenst om op een kadastrale onroerende zaak te zoeken. De response geeft kadastrale onroerende zaken terug, zowel percelen als appartementsrechten.  De KOZ wordt platgeslagen als 1 resource, waarbij de de eigenschappen van het perceel optioneel zijn. Ook wordt een type element toegevoegd (type perceel of appartementsrecht).

Kadastrale onroerende zaak en teboekgestelde zaak blijven twee aparte resources en worden NIET samengenomen in een resource kadastraal object.
De sociale dienst (opsporing uitkeringsfraude) is de enige gebruiker die de teboekgestelde zaak nodig heeft. Deze kunnen zij apart opvragen. Het alternatief is alle andere gebruikers lastig te vallen met de teboekgestelde zaak (niet wenselijk).

Zakelijk rechten worden alleen via de KOZ of via de persoon opgevraagd, daarom wordt het zakelijk recht als subresource gedefinieerd, en embedded opgenomen in de KOZ, omdat veel afnemers geinteresseerd zijn in het zakelijk recht.

Zekerheidsstellingen worden alleen via de KOZ of via de persoon opgevraagd, daarom wordt de zekerheidsstelling als subresource gedefinieerd. Deze worden niet embedded opgenomen in de KOZ, omdat slechts enkele afnemers geinteresseerd zijn in de zekerheidsstelling.






