# KadastraalOnroerendeZaak

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
