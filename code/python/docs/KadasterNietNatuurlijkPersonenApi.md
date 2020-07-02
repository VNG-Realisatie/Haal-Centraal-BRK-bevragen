# swagger_client.KadasterNietNatuurlijkPersonenApi

All URIs are relative to *https://service30.kadaster.nl/esd/bevragen/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**get_kadaster_niet_natuurlijk_personen**](KadasterNietNatuurlijkPersonenApi.md#get_kadaster_niet_natuurlijk_personen) | **GET** /kadasternietnatuurlijkpersonen | 
[**get_kadaster_niet_natuurlijk_persoon**](KadasterNietNatuurlijkPersonenApi.md#get_kadaster_niet_natuurlijk_persoon) | **GET** /kadasternietnatuurlijkpersonen/{kadasternietnatuurlijkpersoonidentificatie} | 
[**get_kadaster_personen**](KadasterNietNatuurlijkPersonenApi.md#get_kadaster_personen) | **GET** /kadasternatuurlijkpersonen | 
[**get_kadaster_persoon**](KadasterNietNatuurlijkPersonenApi.md#get_kadaster_persoon) | **GET** /kadasternatuurlijkpersonen/{kadasternatuurlijkpersoonidentificatie} | 

# **get_kadaster_niet_natuurlijk_personen**
> KadasterNietNatuurlijkPersoonHalCollectie get_kadaster_niet_natuurlijk_personen(q, fields=fields)



Het zoeken van bij het kadaster geregistreerde niet natuurlijke personen die al dan niet in het handelsregister (HR) zijn ingeschreven. Kadasternietnatuurlijkpersonen worden niet geactualiseerd.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.KadasterNietNatuurlijkPersonenApi()
q = 'q_example' # str | Free query parameter. Dit endpoint evolueert naar free query zoeken. In deze versie kan alleen een combinatie van (het begin van de) de statutaire naam en zetel (vestigingsplaats) worden opgegeven. Let op! Een niet natuurlijk persoon kan meerdere keren, en op meer dan één manier voorkomen in de BRK.
fields = 'fields_example' # str | Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma's gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) (optional)

try:
    api_response = api_instance.get_kadaster_niet_natuurlijk_personen(q, fields=fields)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling KadasterNietNatuurlijkPersonenApi->get_kadaster_niet_natuurlijk_personen: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **str**| Free query parameter. Dit endpoint evolueert naar free query zoeken. In deze versie kan alleen een combinatie van (het begin van de) de statutaire naam en zetel (vestigingsplaats) worden opgegeven. Let op! Een niet natuurlijk persoon kan meerdere keren, en op meer dan één manier voorkomen in de BRK. | 
 **fields** | **str**| Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#x27;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) | [optional] 

### Return type

[**KadasterNietNatuurlijkPersoonHalCollectie**](KadasterNietNatuurlijkPersoonHalCollectie.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/hal+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_kadaster_niet_natuurlijk_persoon**
> KadasterNietNatuurlijkPersoonHal get_kadaster_niet_natuurlijk_persoon(kadasternietnatuurlijkpersoonidentificatie, fields=fields)



Het raadplegen van een bij het kadaster geregistreerde niet natuurlijke persoon die al dan niet in het handelsregister (HR) is ingeschreven. Kadasternietnatuurlijkpersonen worden niet geactualiseerd.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.KadasterNietNatuurlijkPersonenApi()
kadasternietnatuurlijkpersoonidentificatie = 'kadasternietnatuurlijkpersoonidentificatie_example' # str | 
fields = 'fields_example' # str | Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma's gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) (optional)

try:
    api_response = api_instance.get_kadaster_niet_natuurlijk_persoon(kadasternietnatuurlijkpersoonidentificatie, fields=fields)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling KadasterNietNatuurlijkPersonenApi->get_kadaster_niet_natuurlijk_persoon: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kadasternietnatuurlijkpersoonidentificatie** | **str**|  | 
 **fields** | **str**| Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#x27;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) | [optional] 

### Return type

[**KadasterNietNatuurlijkPersoonHal**](KadasterNietNatuurlijkPersoonHal.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/hal+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_kadaster_personen**
> KadasterNatuurlijkPersoonHalCollectie get_kadaster_personen(q, fields=fields)



Het zoeken van bij het kadaster geregistreerde natuurlijke personen die niet in de basisregistratie personen (BRP) zijn ingeschreven (of wel zijn ingeschreven maar niet zijn _gematched_ bij het inschrijven van de akte). Kadasternatuurlijkpersonen worden niet geactualiseerd. 

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.KadasterNietNatuurlijkPersonenApi()
q = 'q_example' # str | Free query parameter. Dit endpoint evolueert naar free query zoeken. In deze versie kan alleen een combinatie van (het begin van) de geslachtsnaam en geboortedatum [YYYY-mm-dd] worden opgegeven.
fields = 'fields_example' # str | Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma's gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) (optional)

try:
    api_response = api_instance.get_kadaster_personen(q, fields=fields)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling KadasterNietNatuurlijkPersonenApi->get_kadaster_personen: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **str**| Free query parameter. Dit endpoint evolueert naar free query zoeken. In deze versie kan alleen een combinatie van (het begin van) de geslachtsnaam en geboortedatum [YYYY-mm-dd] worden opgegeven. | 
 **fields** | **str**| Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#x27;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) | [optional] 

### Return type

[**KadasterNatuurlijkPersoonHalCollectie**](KadasterNatuurlijkPersoonHalCollectie.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/hal+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_kadaster_persoon**
> KadasterNatuurlijkPersoonHal get_kadaster_persoon(kadasternatuurlijkpersoonidentificatie, fields=fields)



Het raadplegen van een bij het kadaster geregistreerde natuurlijke persoon die niet in de basisregistratie personen (BRP) is ingeschreven (of wel is ingeschreven maar niet is gekoppeld bij het inschrijven van de akte). Kadasternatuurlijkpersonen worden niet geactualiseerd.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.KadasterNietNatuurlijkPersonenApi()
kadasternatuurlijkpersoonidentificatie = 'kadasternatuurlijkpersoonidentificatie_example' # str | 
fields = 'fields_example' # str | Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma's gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) (optional)

try:
    api_response = api_instance.get_kadaster_persoon(kadasternatuurlijkpersoonidentificatie, fields=fields)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling KadasterNietNatuurlijkPersonenApi->get_kadaster_persoon: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kadasternatuurlijkpersoonidentificatie** | **str**|  | 
 **fields** | **str**| Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#x27;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) | [optional] 

### Return type

[**KadasterNatuurlijkPersoonHal**](KadasterNatuurlijkPersoonHal.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/hal+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

