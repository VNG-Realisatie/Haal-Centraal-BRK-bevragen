# KadasterNietNatuurlijkPersonenApi

All URIs are relative to *https://service30.kadaster.nl/esd/bevragen/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getKadasterNietNatuurlijkPersonen**](KadasterNietNatuurlijkPersonenApi.md#getKadasterNietNatuurlijkPersonen) | **GET** /kadasternietnatuurlijkpersonen | 
[**getKadasterNietNatuurlijkPersoon**](KadasterNietNatuurlijkPersonenApi.md#getKadasterNietNatuurlijkPersoon) | **GET** /kadasternietnatuurlijkpersonen/{kadasternietnatuurlijkpersoonidentificatie} | 
[**getKadasterPersonen**](KadasterNietNatuurlijkPersonenApi.md#getKadasterPersonen) | **GET** /kadasternatuurlijkpersonen | 
[**getKadasterPersoon**](KadasterNietNatuurlijkPersonenApi.md#getKadasterPersoon) | **GET** /kadasternatuurlijkpersonen/{kadasternatuurlijkpersoonidentificatie} | 


<a name="getKadasterNietNatuurlijkPersonen"></a>
# **getKadasterNietNatuurlijkPersonen**
> KadasterNietNatuurlijkPersoonHalCollectie getKadasterNietNatuurlijkPersonen(q, fields)



Het zoeken van bij het kadaster geregistreerde niet natuurlijke personen die al dan niet in het handelsregister (HR) zijn ingeschreven. Kadasternietnatuurlijkpersonen worden niet geactualiseerd.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.KadasterNietNatuurlijkPersonenApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://service30.kadaster.nl/esd/bevragen/v1");

    KadasterNietNatuurlijkPersonenApi apiInstance = new KadasterNietNatuurlijkPersonenApi(defaultClient);
    String q = "q_example"; // String | Free query parameter. Dit endpoint evolueert naar free query zoeken. In deze versie kan alleen een combinatie van (het begin van de) de statutaire naam en zetel (vestigingsplaats) worden opgegeven. Let op! Een niet natuurlijk persoon kan meerdere keren, en op meer dan één manier voorkomen in de BRK.
    String fields = "fields_example"; // String | Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma's gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature)
    try {
      KadasterNietNatuurlijkPersoonHalCollectie result = apiInstance.getKadasterNietNatuurlijkPersonen(q, fields);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling KadasterNietNatuurlijkPersonenApi#getKadasterNietNatuurlijkPersonen");
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
 **q** | **String**| Free query parameter. Dit endpoint evolueert naar free query zoeken. In deze versie kan alleen een combinatie van (het begin van de) de statutaire naam en zetel (vestigingsplaats) worden opgegeven. Let op! Een niet natuurlijk persoon kan meerdere keren, en op meer dan één manier voorkomen in de BRK. |
 **fields** | **String**| Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#39;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) | [optional]

### Return type

[**KadasterNietNatuurlijkPersoonHalCollectie**](KadasterNietNatuurlijkPersoonHalCollectie.md)

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
**406** | Not Acceptable |  * api-version -  <br>  |
**410** | Gone |  * api-version -  <br>  |
**500** | Internal Server Error |  * api-version -  <br>  |
**503** | Service Unavailable |  * api-version -  <br>  |

<a name="getKadasterNietNatuurlijkPersoon"></a>
# **getKadasterNietNatuurlijkPersoon**
> KadasterNietNatuurlijkPersoonHal getKadasterNietNatuurlijkPersoon(kadasternietnatuurlijkpersoonidentificatie, fields)



Het raadplegen van een bij het kadaster geregistreerde niet natuurlijke persoon die al dan niet in het handelsregister (HR) is ingeschreven. Kadasternietnatuurlijkpersonen worden niet geactualiseerd.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.KadasterNietNatuurlijkPersonenApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://service30.kadaster.nl/esd/bevragen/v1");

    KadasterNietNatuurlijkPersonenApi apiInstance = new KadasterNietNatuurlijkPersonenApi(defaultClient);
    String kadasternietnatuurlijkpersoonidentificatie = "kadasternietnatuurlijkpersoonidentificatie_example"; // String | 
    String fields = "fields_example"; // String | Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma's gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature)
    try {
      KadasterNietNatuurlijkPersoonHal result = apiInstance.getKadasterNietNatuurlijkPersoon(kadasternietnatuurlijkpersoonidentificatie, fields);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling KadasterNietNatuurlijkPersonenApi#getKadasterNietNatuurlijkPersoon");
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
 **kadasternietnatuurlijkpersoonidentificatie** | **String**|  |
 **fields** | **String**| Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#39;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) | [optional]

### Return type

[**KadasterNietNatuurlijkPersoonHal**](KadasterNietNatuurlijkPersoonHal.md)

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

<a name="getKadasterPersonen"></a>
# **getKadasterPersonen**
> KadasterNatuurlijkPersoonHalCollectie getKadasterPersonen(q, fields)



Het zoeken van bij het kadaster geregistreerde natuurlijke personen die niet in de basisregistratie personen (BRP) zijn ingeschreven (of wel zijn ingeschreven maar niet zijn _gematched_ bij het inschrijven van de akte). Kadasternatuurlijkpersonen worden niet geactualiseerd. 

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.KadasterNietNatuurlijkPersonenApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://service30.kadaster.nl/esd/bevragen/v1");

    KadasterNietNatuurlijkPersonenApi apiInstance = new KadasterNietNatuurlijkPersonenApi(defaultClient);
    String q = "q_example"; // String | Free query parameter. Dit endpoint evolueert naar free query zoeken. In deze versie kan alleen een combinatie van (het begin van) de geslachtsnaam en geboortedatum [YYYY-mm-dd] worden opgegeven.
    String fields = "fields_example"; // String | Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma's gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature)
    try {
      KadasterNatuurlijkPersoonHalCollectie result = apiInstance.getKadasterPersonen(q, fields);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling KadasterNietNatuurlijkPersonenApi#getKadasterPersonen");
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
 **q** | **String**| Free query parameter. Dit endpoint evolueert naar free query zoeken. In deze versie kan alleen een combinatie van (het begin van) de geslachtsnaam en geboortedatum [YYYY-mm-dd] worden opgegeven. |
 **fields** | **String**| Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#39;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) | [optional]

### Return type

[**KadasterNatuurlijkPersoonHalCollectie**](KadasterNatuurlijkPersoonHalCollectie.md)

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
**406** | Not Acceptable |  * api-version -  <br>  |
**410** | Gone |  * api-version -  <br>  |
**500** | Internal Server Error |  * api-version -  <br>  |
**503** | Service Unavailable |  * api-version -  <br>  |

<a name="getKadasterPersoon"></a>
# **getKadasterPersoon**
> KadasterNatuurlijkPersoonHal getKadasterPersoon(kadasternatuurlijkpersoonidentificatie, fields)



Het raadplegen van een bij het kadaster geregistreerde natuurlijke persoon die niet in de basisregistratie personen (BRP) is ingeschreven (of wel is ingeschreven maar niet is gekoppeld bij het inschrijven van de akte). Kadasternatuurlijkpersonen worden niet geactualiseerd.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.KadasterNietNatuurlijkPersonenApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://service30.kadaster.nl/esd/bevragen/v1");

    KadasterNietNatuurlijkPersonenApi apiInstance = new KadasterNietNatuurlijkPersonenApi(defaultClient);
    String kadasternatuurlijkpersoonidentificatie = "kadasternatuurlijkpersoonidentificatie_example"; // String | 
    String fields = "fields_example"; // String | Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma's gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature)
    try {
      KadasterNatuurlijkPersoonHal result = apiInstance.getKadasterPersoon(kadasternatuurlijkpersoonidentificatie, fields);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling KadasterNietNatuurlijkPersonenApi#getKadasterPersoon");
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
 **kadasternatuurlijkpersoonidentificatie** | **String**|  |
 **fields** | **String**| Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#39;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) | [optional]

### Return type

[**KadasterNatuurlijkPersoonHal**](KadasterNatuurlijkPersoonHal.md)

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

