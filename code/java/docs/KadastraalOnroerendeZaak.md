

# KadastraalOnroerendeZaak

Een kadastraal onroerende zaak is een perceel of een appartementsrecht. Een perceel is een stuk grond waarvan het Kadaster de grenzen heeft gemeten en dat bij het Kadaster een eigen nummer heeft. Een appartementsrecht is het recht dat iemand of een organisatie heeft om eigenaar te zijn van een deel van een gebouw of een stuk grond. In de praktijk wordt dit deel meestal een appartement genoemd.  Waardelijst in deze component : [aardCultuurBebouwd](http://www.kadaster.nl/schemas/waardelijsten/CultuurcodeBebouwd/) en [aardCultuurOnbebouwd](http://www.kadaster.nl/schemas/waardelijsten/CultuurcodeOnbebouwd/) 
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**identificatie** | **String** |  |  [optional]
**domein** | **String** | Het domein waartoe de identificatie behoort. |  [optional]
**begrenzingPerceel** | [**PolygonGeoJSON**](PolygonGeoJSON.md) |  |  [optional]
**perceelnummerRotatie** | [**BigDecimal**](BigDecimal.md) | Rotatie van het perceelnummer ten behoeve van visualisatie op de kaart. Perceelnummers worden bijvoorbeeld gekanteld om in een smal perceel te passen. |  [optional]
**plaatscoordinaten** | [**PointGeoJSON**](PointGeoJSON.md) |  |  [optional]
**koopsom** | [**TypeKoopsom**](TypeKoopsom.md) |  |  [optional]
**toelichtingBewaarder** | **String** | Toelichtende tekst bij een onroerende zaak van de bewaarder. De bewaarder is iemand die bij het Kadaster werkt. Hij schrijft stukken in in de openbare registers en de basisregistratie Kadaster conform de Kadasterwet. |  [optional]
**type** | [**TypeKadastraalOnroerendeZaakEnum**](TypeKadastraalOnroerendeZaakEnum.md) |  |  [optional]
**aardCultuurBebouwd** | [**Waardelijst**](Waardelijst.md) |  |  [optional]
**aardCultuurOnbebouwd** | [**Waardelijst**](Waardelijst.md) |  |  [optional]
**kadastraleAanduiding** | **String** |  |  [optional]
**kadastraleGrootte** | [**TypeOppervlak**](TypeOppervlak.md) |  |  [optional]
**perceelnummerVerschuiving** | [**TypePerceelnummerVerschuiving**](TypePerceelnummerVerschuiving.md) |  |  [optional]
**adressen** | [**List&lt;LocatieKadastraalObject&gt;**](LocatieKadastraalObject.md) |  |  [optional]
**zakelijkGerechtigdeIdentificaties** | **List&lt;String&gt;** | Alle personen en rechtspersonen die een zakelijk recht hebben op deze kadastaraal onroerende zaak |  [optional]



