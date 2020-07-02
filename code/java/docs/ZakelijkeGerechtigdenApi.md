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
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ZakelijkeGerechtigdenApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://service30.kadaster.nl/esd/bevragen/v1");

    ZakelijkeGerechtigdenApi apiInstance = new ZakelijkeGerechtigdenApi(defaultClient);
    String kadastraalonroerendezaakidentificatie = "kadastraalonroerendezaakidentificatie_example"; // String | De unieke identificatie van een kadastraal onroerende zaak.
    String zakelijkgerechtigdeidentificatie = "zakelijkgerechtigdeidentificatie_example"; // String | De identificatie van de zakelijk gerechtigde
    String fields = "fields_example"; // String | Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma's gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature)
    try {
      ZakelijkGerechtigdeHal result = apiInstance.getZakelijkGerechtigde(kadastraalonroerendezaakidentificatie, zakelijkgerechtigdeidentificatie, fields);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling ZakelijkeGerechtigdenApi#getZakelijkGerechtigde");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kadastraalonroerendezaakidentificatie** | **String**| De unieke identificatie van een kadastraal onroerende zaak. |
 **zakelijkgerechtigdeidentificatie** | **String**| De identificatie van de zakelijk gerechtigde |
 **fields** | **String**| Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#39;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) | [optional]

### Return type

[**ZakelijkGerechtigdeHal**](ZakelijkGerechtigdeHal.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/hal+json, application/problem+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Zoekactie geslaagd |  * api-version -  <br>  * warning -  <br>  * X-Rate-Limit-Limit -  <br>  * X-Rate-Limit-Remaining -  <br>  * X-Rate-Limit-Reset -  <br>  |
**400** | Bad Request |  * api-version -  <br>  |
**401** | Unauthorized |  * api-version -  <br>  |
**403** | Forbidden |  * api-version -  <br>  |
**404** | Not Found |  * api-version -  <br>  |
**406** | Not Acceptable |  * api-version -  <br>  |
**410** | Gone |  * api-version -  <br>  |
**500** | Internal Server Error |  * api-version -  <br>  |
**503** | Service Unavailable |  * api-version -  <br>  |

<a name="getZakelijkGerechtigden"></a>
# **getZakelijkGerechtigden**
> ZakelijkGerechtigdeHalCollectie getZakelijkGerechtigden(kadastraalonroerendezaakidentificatie, fields, typegerechtigde)



Het zoeken van zakelijk gerechtigden van een kadastraal onroerende zaak. Het aandeel van de zakelijk gerechtigde wordt altijd geleverd in combinatie met het gezamenlijk aandeel (wanneer twee of meer personen een gezamenlijk aandeel hebben in een zakelijk recht, en ieders afzonderlijke aandeel in het gezamenlijk aandeel niet bekend is)

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ZakelijkeGerechtigdenApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://service30.kadaster.nl/esd/bevragen/v1");

    ZakelijkeGerechtigdenApi apiInstance = new ZakelijkeGerechtigdenApi(defaultClient);
    String kadastraalonroerendezaakidentificatie = "kadastraalonroerendezaakidentificatie_example"; // String | De unieke identificatie van een kadastraal onroerende zaak.
    String fields = "fields_example"; // String | Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma's gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature)
    TypeGerechtigdeEnum typegerechtigde = new TypeGerechtigdeEnum(); // TypeGerechtigdeEnum | Het type recht dat de zakelijk gerechtigde heeft op de kadastraal onroerende zaak. De waarden van de typering staan in een waardelijst.
    try {
      ZakelijkGerechtigdeHalCollectie result = apiInstance.getZakelijkGerechtigden(kadastraalonroerendezaakidentificatie, fields, typegerechtigde);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling ZakelijkeGerechtigdenApi#getZakelijkGerechtigden");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kadastraalonroerendezaakidentificatie** | **String**| De unieke identificatie van een kadastraal onroerende zaak. |
 **fields** | **String**| Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#39;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) | [optional]
 **typegerechtigde** | [**TypeGerechtigdeEnum**](.md)| Het type recht dat de zakelijk gerechtigde heeft op de kadastraal onroerende zaak. De waarden van de typering staan in een waardelijst. | [optional] [enum: beklemrechthouder, eigenaar, erfpachter, gebruik_bewoning, grondrente, opstalhouder, vaderlandsrecht, stadsmeierrecht, vruchtgebruiker, erfpachter_opstalhouder, nutsvoorzieningen, twee_belastingen, belasting_derde, bp_recht, nutsvoorzieningen_gedeelte, artikel5_3b]

### Return type

[**ZakelijkGerechtigdeHalCollectie**](ZakelijkGerechtigdeHalCollectie.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/hal+json, application/problem+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Zoekactie geslaagd |  * api-version -  <br>  * warning -  <br>  * X-Rate-Limit-Limit -  <br>  * X-Rate-Limit-Remaining -  <br>  * X-Rate-Limit-Reset -  <br>  |
**400** | Bad Request |  * api-version -  <br>  |
**401** | Unauthorized |  * api-version -  <br>  |
**403** | Forbidden |  * api-version -  <br>  |
**404** | Not Found |  * api-version -  <br>  |
**406** | Not Acceptable |  * api-version -  <br>  |
**410** | Gone |  * api-version -  <br>  |
**500** | Internal Server Error |  * api-version -  <br>  |
**503** | Service Unavailable |  * api-version -  <br>  |

