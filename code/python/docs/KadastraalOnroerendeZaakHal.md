# KadastraalOnroerendeZaakHal

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**identificatie** | **str** |  | [optional] 
**domein** | **str** | Het domein waartoe de identificatie behoort. | [optional] 
**begrenzing_perceel** | [**PolygonGeoJSON**](PolygonGeoJSON.md) |  | [optional] 
**perceelnummer_rotatie** | **float** | Rotatie van het perceelnummer ten behoeve van visualisatie op de kaart. Perceelnummers worden bijvoorbeeld gekanteld om in een smal perceel te passen. | [optional] 
**plaatscoordinaten** | [**PointGeoJSON**](PointGeoJSON.md) |  | [optional] 
**koopsom** | [**TypeKoopsom**](TypeKoopsom.md) |  | [optional] 
**toelichting_bewaarder** | **str** | Toelichtende tekst bij een onroerende zaak van de bewaarder. De bewaarder is iemand die bij het Kadaster werkt. Hij schrijft stukken in in de openbare registers en de basisregistratie Kadaster conform de Kadasterwet. | [optional] 
**type** | [**TypeKadastraalOnroerendeZaakEnum**](TypeKadastraalOnroerendeZaakEnum.md) |  | [optional] 
**aard_cultuur_bebouwd** | [**Waardelijst**](Waardelijst.md) |  | [optional] 
**aard_cultuur_onbebouwd** | [**Waardelijst**](Waardelijst.md) |  | [optional] 
**kadastrale_aanduiding** | **str** |  | [optional] 
**kadastrale_grootte** | [**TypeOppervlak**](TypeOppervlak.md) |  | [optional] 
**perceelnummer_verschuiving** | [**TypePerceelnummerVerschuiving**](TypePerceelnummerVerschuiving.md) |  | [optional] 
**adressen** | [**list[LocatieKadastraalObject]**](LocatieKadastraalObject.md) |  | [optional] 
**zakelijk_gerechtigde_identificaties** | **list[str]** | Alle personen en rechtspersonen die een zakelijk recht hebben op deze kadastaraal onroerende zaak | [optional] 
**links** | [**KadastraalOnroerendeZaakLinks**](KadastraalOnroerendeZaakLinks.md) |  | [optional] 
**embedded** | [**KadastraalOnroerendeZaakEmbedded**](KadastraalOnroerendeZaakEmbedded.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

