# ZakelijkeGerechtigdenApi

All URIs are relative to *https://service30.kadaster.nl/esd/bevragen/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getZakelijkGerechtigde**](ZakelijkeGerechtigdenApi.md#getZakelijkGerechtigde) | **GET** /kadastraalonroerendezaken/{kadastraalonroerendezaakidentificatie}/zakelijkgerechtigden/{zakelijkgerechtigdeidentificatie} | 
[**getZakelijkGerechtigden**](ZakelijkeGerechtigdenApi.md#getZakelijkGerechtigden) | **GET** /kadastraalonroerendezaken/{kadastraalonroerendezaakidentificatie}/zakelijkgerechtigden | 

<a name="getZakelijkGerechtigde"></a>
# **getZakelijkGerechtigde**
> ZakelijkGerechtigdeHal getZakelijkGerechtigde(kadastraalonroerendezaakidentificatie, zakelijkgerechtigdeidentificatie, fields)



Het raadplegen van een specifieke zakelijk gerechtigde van een kadastraal onroerende zaak. Het aandeel van de zakelijk gerechtigde wordt altijd geleverd in combinatie met het gezamenlijk aandeel (wanneer twee of meer personen een gezamenlijk aandeel hebben in een zakelijk recht, en ieders afzonderlijke aandeel in het gezamenlijk aandeel niet bekend is)

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ZakelijkeGerechtigdenApi;


ZakelijkeGerechtigdenApi apiInstance = new ZakelijkeGerechtigdenApi();
String kadastraalonroerendezaakidentificatie = "kadastraalonroerendezaakidentificatie_example"; // String | De unieke identificatie van een kadastraal onroerende zaak.
String zakelijkgerechtigdeidentificatie = "zakelijkgerechtigdeidentificatie_example"; // String | De identificatie van de zakelijk gerechtigde
String fields = "fields_example"; // String | Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma's gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature)
try {
    ZakelijkGerechtigdeHal result = apiInstance.getZakelijkGerechtigde(kadastraalonroerendezaakidentificatie, zakelijkgerechtigdeidentificatie, fields);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ZakelijkeGerechtigdenApi#getZakelijkGerechtigde");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kadastraalonroerendezaakidentificatie** | **String**| De unieke identificatie van een kadastraal onroerende zaak. |
 **zakelijkgerechtigdeidentificatie** | **String**| De identificatie van de zakelijk gerechtigde |
 **fields** | **String**| Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#x27;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) | [optional]

### Return type

[**ZakelijkGerechtigdeHal**](ZakelijkGerechtigdeHal.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/hal+json, application/problem+json

<a name="getZakelijkGerechtigden"></a>
# **getZakelijkGerechtigden**
> ZakelijkGerechtigdeHalCollectie getZakelijkGerechtigden(kadastraalonroerendezaakidentificatie, fields, typegerechtigde)



Het zoeken van zakelijk gerechtigden van een kadastraal onroerende zaak. Het aandeel van de zakelijk gerechtigde wordt altijd geleverd in combinatie met het gezamenlijk aandeel (wanneer twee of meer personen een gezamenlijk aandeel hebben in een zakelijk recht, en ieders afzonderlijke aandeel in het gezamenlijk aandeel niet bekend is)

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ZakelijkeGerechtigdenApi;


ZakelijkeGerechtigdenApi apiInstance = new ZakelijkeGerechtigdenApi();
String kadastraalonroerendezaakidentificatie = "kadastraalonroerendezaakidentificatie_example"; // String | De unieke identificatie van een kadastraal onroerende zaak.
String fields = "fields_example"; // String | Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma's gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature)
TypeGerechtigdeEnum typegerechtigde = new TypeGerechtigdeEnum(); // TypeGerechtigdeEnum | Het type recht dat de zakelijk gerechtigde heeft op de kadastraal onroerende zaak. De waarden van de typering staan in een waardelijst.
try {
    ZakelijkGerechtigdeHalCollectie result = apiInstance.getZakelijkGerechtigden(kadastraalonroerendezaakidentificatie, fields, typegerechtigde);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ZakelijkeGerechtigdenApi#getZakelijkGerechtigden");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kadastraalonroerendezaakidentificatie** | **String**| De unieke identificatie van een kadastraal onroerende zaak. |
 **fields** | **String**| Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#x27;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) | [optional]
 **typegerechtigde** | [**TypeGerechtigdeEnum**](.md)| Het type recht dat de zakelijk gerechtigde heeft op de kadastraal onroerende zaak. De waarden van de typering staan in een waardelijst. | [optional]

### Return type

[**ZakelijkGerechtigdeHalCollectie**](ZakelijkGerechtigdeHalCollectie.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/hal+json, application/problem+json

