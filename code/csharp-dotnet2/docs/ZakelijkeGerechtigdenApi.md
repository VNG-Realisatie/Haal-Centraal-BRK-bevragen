# IO.Swagger.Api.ZakelijkeGerechtigdenApi

All URIs are relative to *https://service30.kadaster.nl/esd/bevragen/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetZakelijkGerechtigde**](ZakelijkeGerechtigdenApi.md#getzakelijkgerechtigde) | **GET** /kadastraalonroerendezaken/{kadastraalonroerendezaakidentificatie}/zakelijkgerechtigden/{zakelijkgerechtigdeidentificatie} | 
[**GetZakelijkGerechtigden**](ZakelijkeGerechtigdenApi.md#getzakelijkgerechtigden) | **GET** /kadastraalonroerendezaken/{kadastraalonroerendezaakidentificatie}/zakelijkgerechtigden | 

<a name="getzakelijkgerechtigde"></a>
# **GetZakelijkGerechtigde**
> ZakelijkGerechtigdeHal GetZakelijkGerechtigde (string kadastraalonroerendezaakidentificatie, string zakelijkgerechtigdeidentificatie, string fields)



Het raadplegen van een specifieke zakelijk gerechtigde van een kadastraal onroerende zaak. Het aandeel van de zakelijk gerechtigde wordt altijd geleverd in combinatie met het gezamenlijk aandeel (wanneer twee of meer personen een gezamenlijk aandeel hebben in een zakelijk recht, en ieders afzonderlijke aandeel in het gezamenlijk aandeel niet bekend is)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetZakelijkGerechtigdeExample
    {
        public void main()
        {

            var apiInstance = new ZakelijkeGerechtigdenApi();
            var kadastraalonroerendezaakidentificatie = kadastraalonroerendezaakidentificatie_example;  // string | De unieke identificatie van een kadastraal onroerende zaak.
            var zakelijkgerechtigdeidentificatie = zakelijkgerechtigdeidentificatie_example;  // string | De identificatie van de zakelijk gerechtigde
            var fields = fields_example;  // string | Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma's gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) (optional) 

            try
            {
                ZakelijkGerechtigdeHal result = apiInstance.GetZakelijkGerechtigde(kadastraalonroerendezaakidentificatie, zakelijkgerechtigdeidentificatie, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZakelijkeGerechtigdenApi.GetZakelijkGerechtigde: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kadastraalonroerendezaakidentificatie** | **string**| De unieke identificatie van een kadastraal onroerende zaak. | 
 **zakelijkgerechtigdeidentificatie** | **string**| De identificatie van de zakelijk gerechtigde | 
 **fields** | **string**| Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#x27;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) | [optional] 

### Return type

[**ZakelijkGerechtigdeHal**](ZakelijkGerechtigdeHal.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/hal+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getzakelijkgerechtigden"></a>
# **GetZakelijkGerechtigden**
> ZakelijkGerechtigdeHalCollectie GetZakelijkGerechtigden (string kadastraalonroerendezaakidentificatie, string fields, TypeGerechtigdeEnum typegerechtigde)



Het zoeken van zakelijk gerechtigden van een kadastraal onroerende zaak. Het aandeel van de zakelijk gerechtigde wordt altijd geleverd in combinatie met het gezamenlijk aandeel (wanneer twee of meer personen een gezamenlijk aandeel hebben in een zakelijk recht, en ieders afzonderlijke aandeel in het gezamenlijk aandeel niet bekend is)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetZakelijkGerechtigdenExample
    {
        public void main()
        {

            var apiInstance = new ZakelijkeGerechtigdenApi();
            var kadastraalonroerendezaakidentificatie = kadastraalonroerendezaakidentificatie_example;  // string | De unieke identificatie van een kadastraal onroerende zaak.
            var fields = fields_example;  // string | Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma's gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) (optional) 
            var typegerechtigde = new TypeGerechtigdeEnum(); // TypeGerechtigdeEnum | Het type recht dat de zakelijk gerechtigde heeft op de kadastraal onroerende zaak. De waarden van de typering staan in een waardelijst. (optional) 

            try
            {
                ZakelijkGerechtigdeHalCollectie result = apiInstance.GetZakelijkGerechtigden(kadastraalonroerendezaakidentificatie, fields, typegerechtigde);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZakelijkeGerechtigdenApi.GetZakelijkGerechtigden: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kadastraalonroerendezaakidentificatie** | **string**| De unieke identificatie van een kadastraal onroerende zaak. | 
 **fields** | **string**| Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#x27;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) | [optional] 
 **typegerechtigde** | [**TypeGerechtigdeEnum**](.md)| Het type recht dat de zakelijk gerechtigde heeft op de kadastraal onroerende zaak. De waarden van de typering staan in een waardelijst. | [optional] 

### Return type

[**ZakelijkGerechtigdeHalCollectie**](ZakelijkGerechtigdeHalCollectie.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/hal+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

