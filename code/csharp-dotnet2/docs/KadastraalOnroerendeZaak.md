# IO.Swagger.Model.KadastraalOnroerendeZaak
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Identificatie** | **string** |  | [optional] 
**Domein** | **string** | Het domein waartoe de identificatie behoort. | [optional] 
**BegrenzingPerceel** | [**PolygonGeoJSON**](PolygonGeoJSON.md) |  | [optional] 
**PerceelnummerRotatie** | [**decimal?**](BigDecimal.md) | Rotatie van het perceelnummer ten behoeve van visualisatie op de kaart. Perceelnummers worden bijvoorbeeld gekanteld om in een smal perceel te passen. | [optional] 
**Plaatscoordinaten** | [**PointGeoJSON**](PointGeoJSON.md) |  | [optional] 
**Koopsom** | [**TypeKoopsom**](TypeKoopsom.md) |  | [optional] 
**ToelichtingBewaarder** | **string** | Toelichtende tekst bij een onroerende zaak van de bewaarder. De bewaarder is iemand die bij het Kadaster werkt. Hij schrijft stukken in in de openbare registers en de basisregistratie Kadaster conform de Kadasterwet. | [optional] 
**Type** | [**TypeKadastraalOnroerendeZaakEnum**](TypeKadastraalOnroerendeZaakEnum.md) |  | [optional] 
**AardCultuurBebouwd** | [**Waardelijst**](Waardelijst.md) |  | [optional] 
**AardCultuurOnbebouwd** | [**Waardelijst**](Waardelijst.md) |  | [optional] 
**KadastraleAanduiding** | **string** |  | [optional] 
**KadastraleGrootte** | [**TypeOppervlak**](TypeOppervlak.md) |  | [optional] 
**PerceelnummerVerschuiving** | [**TypePerceelnummerVerschuiving**](TypePerceelnummerVerschuiving.md) |  | [optional] 
**Adressen** | [**List&lt;LocatieKadastraalObject&gt;**](LocatieKadastraalObject.md) |  | [optional] 
**ZakelijkGerechtigdeIdentificaties** | **List&lt;string&gt;** | Alle personen en rechtspersonen die een zakelijk recht hebben op deze kadastaraal onroerende zaak | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

