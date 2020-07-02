# swagger_client.ZakelijkeGerechtigdenApi

All URIs are relative to *https://service30.kadaster.nl/esd/bevragen/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**get_zakelijk_gerechtigde**](ZakelijkeGerechtigdenApi.md#get_zakelijk_gerechtigde) | **GET** /kadastraalonroerendezaken/{kadastraalonroerendezaakidentificatie}/zakelijkgerechtigden/{zakelijkgerechtigdeidentificatie} | 
[**get_zakelijk_gerechtigden**](ZakelijkeGerechtigdenApi.md#get_zakelijk_gerechtigden) | **GET** /kadastraalonroerendezaken/{kadastraalonroerendezaakidentificatie}/zakelijkgerechtigden | 

# **get_zakelijk_gerechtigde**
> ZakelijkGerechtigdeHal get_zakelijk_gerechtigde(kadastraalonroerendezaakidentificatie, zakelijkgerechtigdeidentificatie, fields=fields)



Het raadplegen van een specifieke zakelijk gerechtigde van een kadastraal onroerende zaak. Het aandeel van de zakelijk gerechtigde wordt altijd geleverd in combinatie met het gezamenlijk aandeel (wanneer twee of meer personen een gezamenlijk aandeel hebben in een zakelijk recht, en ieders afzonderlijke aandeel in het gezamenlijk aandeel niet bekend is)

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ZakelijkeGerechtigdenApi()
kadastraalonroerendezaakidentificatie = 'kadastraalonroerendezaakidentificatie_example' # str | De unieke identificatie van een kadastraal onroerende zaak.
zakelijkgerechtigdeidentificatie = 'zakelijkgerechtigdeidentificatie_example' # str | De identificatie van de zakelijk gerechtigde
fields = 'fields_example' # str | Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma's gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) (optional)

try:
    api_response = api_instance.get_zakelijk_gerechtigde(kadastraalonroerendezaakidentificatie, zakelijkgerechtigdeidentificatie, fields=fields)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ZakelijkeGerechtigdenApi->get_zakelijk_gerechtigde: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kadastraalonroerendezaakidentificatie** | **str**| De unieke identificatie van een kadastraal onroerende zaak. | 
 **zakelijkgerechtigdeidentificatie** | **str**| De identificatie van de zakelijk gerechtigde | 
 **fields** | **str**| Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#x27;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) | [optional] 

### Return type

[**ZakelijkGerechtigdeHal**](ZakelijkGerechtigdeHal.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/hal+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_zakelijk_gerechtigden**
> ZakelijkGerechtigdeHalCollectie get_zakelijk_gerechtigden(kadastraalonroerendezaakidentificatie, fields=fields, typegerechtigde=typegerechtigde)



Het zoeken van zakelijk gerechtigden van een kadastraal onroerende zaak. Het aandeel van de zakelijk gerechtigde wordt altijd geleverd in combinatie met het gezamenlijk aandeel (wanneer twee of meer personen een gezamenlijk aandeel hebben in een zakelijk recht, en ieders afzonderlijke aandeel in het gezamenlijk aandeel niet bekend is)

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ZakelijkeGerechtigdenApi()
kadastraalonroerendezaakidentificatie = 'kadastraalonroerendezaakidentificatie_example' # str | De unieke identificatie van een kadastraal onroerende zaak.
fields = 'fields_example' # str | Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma's gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) (optional)
typegerechtigde = swagger_client.TypeGerechtigdeEnum() # TypeGerechtigdeEnum | Het type recht dat de zakelijk gerechtigde heeft op de kadastraal onroerende zaak. De waarden van de typering staan in een waardelijst. (optional)

try:
    api_response = api_instance.get_zakelijk_gerechtigden(kadastraalonroerendezaakidentificatie, fields=fields, typegerechtigde=typegerechtigde)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ZakelijkeGerechtigdenApi->get_zakelijk_gerechtigden: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kadastraalonroerendezaakidentificatie** | **str**| De unieke identificatie van een kadastraal onroerende zaak. | 
 **fields** | **str**| Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#x27;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) | [optional] 
 **typegerechtigde** | [**TypeGerechtigdeEnum**](.md)| Het type recht dat de zakelijk gerechtigde heeft op de kadastraal onroerende zaak. De waarden van de typering staan in een waardelijst. | [optional] 

### Return type

[**ZakelijkGerechtigdeHalCollectie**](ZakelijkGerechtigdeHalCollectie.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/hal+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

