# IO.Swagger.Api.KadasterNietNatuurlijkPersonenApi

All URIs are relative to *https://service30.kadaster.nl/esd/bevragen/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetKadasterNietNatuurlijkPersonen**](KadasterNietNatuurlijkPersonenApi.md#getkadasternietnatuurlijkpersonen) | **GET** /kadasternietnatuurlijkpersonen | 
[**GetKadasterNietNatuurlijkPersoon**](KadasterNietNatuurlijkPersonenApi.md#getkadasternietnatuurlijkpersoon) | **GET** /kadasternietnatuurlijkpersonen/{kadasternietnatuurlijkpersoonidentificatie} | 
[**GetKadasterPersonen**](KadasterNietNatuurlijkPersonenApi.md#getkadasterpersonen) | **GET** /kadasternatuurlijkpersonen | 
[**GetKadasterPersoon**](KadasterNietNatuurlijkPersonenApi.md#getkadasterpersoon) | **GET** /kadasternatuurlijkpersonen/{kadasternatuurlijkpersoonidentificatie} | 

<a name="getkadasternietnatuurlijkpersonen"></a>
# **GetKadasterNietNatuurlijkPersonen**
> KadasterNietNatuurlijkPersoonHalCollectie GetKadasterNietNatuurlijkPersonen (string q, string fields)



Het zoeken van bij het kadaster geregistreerde niet natuurlijke personen die al dan niet in het handelsregister (HR) zijn ingeschreven. Kadasternietnatuurlijkpersonen worden niet geactualiseerd.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetKadasterNietNatuurlijkPersonenExample
    {
        public void main()
        {

            var apiInstance = new KadasterNietNatuurlijkPersonenApi();
            var q = q_example;  // string | Free query parameter. Dit endpoint evolueert naar free query zoeken. In deze versie kan alleen een combinatie van (het begin van de) de statutaire naam en zetel (vestigingsplaats) worden opgegeven. Let op! Een niet natuurlijk persoon kan meerdere keren, en op meer dan één manier voorkomen in de BRK.
            var fields = fields_example;  // string | Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma's gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) (optional) 

            try
            {
                KadasterNietNatuurlijkPersoonHalCollectie result = apiInstance.GetKadasterNietNatuurlijkPersonen(q, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KadasterNietNatuurlijkPersonenApi.GetKadasterNietNatuurlijkPersonen: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**| Free query parameter. Dit endpoint evolueert naar free query zoeken. In deze versie kan alleen een combinatie van (het begin van de) de statutaire naam en zetel (vestigingsplaats) worden opgegeven. Let op! Een niet natuurlijk persoon kan meerdere keren, en op meer dan één manier voorkomen in de BRK. | 
 **fields** | **string**| Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#x27;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) | [optional] 

### Return type

[**KadasterNietNatuurlijkPersoonHalCollectie**](KadasterNietNatuurlijkPersoonHalCollectie.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/hal+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getkadasternietnatuurlijkpersoon"></a>
# **GetKadasterNietNatuurlijkPersoon**
> KadasterNietNatuurlijkPersoonHal GetKadasterNietNatuurlijkPersoon (string kadasternietnatuurlijkpersoonidentificatie, string fields)



Het raadplegen van een bij het kadaster geregistreerde niet natuurlijke persoon die al dan niet in het handelsregister (HR) is ingeschreven. Kadasternietnatuurlijkpersonen worden niet geactualiseerd.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetKadasterNietNatuurlijkPersoonExample
    {
        public void main()
        {

            var apiInstance = new KadasterNietNatuurlijkPersonenApi();
            var kadasternietnatuurlijkpersoonidentificatie = kadasternietnatuurlijkpersoonidentificatie_example;  // string | 
            var fields = fields_example;  // string | Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma's gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) (optional) 

            try
            {
                KadasterNietNatuurlijkPersoonHal result = apiInstance.GetKadasterNietNatuurlijkPersoon(kadasternietnatuurlijkpersoonidentificatie, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KadasterNietNatuurlijkPersonenApi.GetKadasterNietNatuurlijkPersoon: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kadasternietnatuurlijkpersoonidentificatie** | **string**|  | 
 **fields** | **string**| Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#x27;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) | [optional] 

### Return type

[**KadasterNietNatuurlijkPersoonHal**](KadasterNietNatuurlijkPersoonHal.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/hal+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getkadasterpersonen"></a>
# **GetKadasterPersonen**
> KadasterNatuurlijkPersoonHalCollectie GetKadasterPersonen (string q, string fields)



Het zoeken van bij het kadaster geregistreerde natuurlijke personen die niet in de basisregistratie personen (BRP) zijn ingeschreven (of wel zijn ingeschreven maar niet zijn _gematched_ bij het inschrijven van de akte). Kadasternatuurlijkpersonen worden niet geactualiseerd. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetKadasterPersonenExample
    {
        public void main()
        {

            var apiInstance = new KadasterNietNatuurlijkPersonenApi();
            var q = q_example;  // string | Free query parameter. Dit endpoint evolueert naar free query zoeken. In deze versie kan alleen een combinatie van (het begin van) de geslachtsnaam en geboortedatum [YYYY-mm-dd] worden opgegeven.
            var fields = fields_example;  // string | Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma's gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) (optional) 

            try
            {
                KadasterNatuurlijkPersoonHalCollectie result = apiInstance.GetKadasterPersonen(q, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KadasterNietNatuurlijkPersonenApi.GetKadasterPersonen: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**| Free query parameter. Dit endpoint evolueert naar free query zoeken. In deze versie kan alleen een combinatie van (het begin van) de geslachtsnaam en geboortedatum [YYYY-mm-dd] worden opgegeven. | 
 **fields** | **string**| Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#x27;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) | [optional] 

### Return type

[**KadasterNatuurlijkPersoonHalCollectie**](KadasterNatuurlijkPersoonHalCollectie.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/hal+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getkadasterpersoon"></a>
# **GetKadasterPersoon**
> KadasterNatuurlijkPersoonHal GetKadasterPersoon (string kadasternatuurlijkpersoonidentificatie, string fields)



Het raadplegen van een bij het kadaster geregistreerde natuurlijke persoon die niet in de basisregistratie personen (BRP) is ingeschreven (of wel is ingeschreven maar niet is gekoppeld bij het inschrijven van de akte). Kadasternatuurlijkpersonen worden niet geactualiseerd.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetKadasterPersoonExample
    {
        public void main()
        {

            var apiInstance = new KadasterNietNatuurlijkPersonenApi();
            var kadasternatuurlijkpersoonidentificatie = kadasternatuurlijkpersoonidentificatie_example;  // string | 
            var fields = fields_example;  // string | Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma's gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) (optional) 

            try
            {
                KadasterNatuurlijkPersoonHal result = apiInstance.GetKadasterPersoon(kadasternatuurlijkpersoonidentificatie, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KadasterNietNatuurlijkPersonenApi.GetKadasterPersoon: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kadasternatuurlijkpersoonidentificatie** | **string**|  | 
 **fields** | **string**| Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#x27;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) | [optional] 

### Return type

[**KadasterNatuurlijkPersoonHal**](KadasterNatuurlijkPersoonHal.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/hal+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

