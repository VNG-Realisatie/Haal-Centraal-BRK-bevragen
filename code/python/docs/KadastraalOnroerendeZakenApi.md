# swagger_client.KadastraalOnroerendeZakenApi

All URIs are relative to *https://service30.kadaster.nl/esd/bevragen/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**get_kadastraal_onroerende_zaak**](KadastraalOnroerendeZakenApi.md#get_kadastraal_onroerende_zaak) | **GET** /kadastraalonroerendezaken/{kadastraalonroerendezaakidentificatie} | 
[**get_kadastraal_onroerende_zaken**](KadastraalOnroerendeZakenApi.md#get_kadastraal_onroerende_zaken) | **GET** /kadastraalonroerendezaken | 

# **get_kadastraal_onroerende_zaak**
> KadastraalOnroerendeZaakHal get_kadastraal_onroerende_zaak(kadastraalonroerendezaakidentificatie, accept_crs=accept_crs, expand=expand, fields=fields)



Het raadplegen van een kadastrale onroerende zaak.  Met gebruik van de parameter expand kunnen zakelijkgerechtigden direct worden meegeladen. 

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.KadastraalOnroerendeZakenApi()
kadastraalonroerendezaakidentificatie = 'kadastraalonroerendezaakidentificatie_example' # str | De unieke identificatie van een kadastraal onroerende zaak.
accept_crs = 'epsg:28992' # str | Gewenste CRS van de coördinaten in de response. (optional) (default to epsg:28992)
expand = 'expand_example' # str | Hiermee kun je opgeven welke gerelateerde resources meegeleverd moeten worden, en hun inhoud naar behoefte aanpassen. Hele resources of enkele properties geef je in de expand parameter kommagescheiden op. Properties die je wil ontvangen geef je op met de resource-naam gevolgd door de property naam, met daartussen een punt. In de definitie van het antwoord kun je bij _embedded zien welke gerelateerde resources meegeleverd kunnen worden. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/expand.feature). (optional)
fields = 'fields_example' # str | Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma's gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) (optional)

try:
    api_response = api_instance.get_kadastraal_onroerende_zaak(kadastraalonroerendezaakidentificatie, accept_crs=accept_crs, expand=expand, fields=fields)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling KadastraalOnroerendeZakenApi->get_kadastraal_onroerende_zaak: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kadastraalonroerendezaakidentificatie** | **str**| De unieke identificatie van een kadastraal onroerende zaak. | 
 **accept_crs** | **str**| Gewenste CRS van de coördinaten in de response. | [optional] [default to epsg:28992]
 **expand** | **str**| Hiermee kun je opgeven welke gerelateerde resources meegeleverd moeten worden, en hun inhoud naar behoefte aanpassen. Hele resources of enkele properties geef je in de expand parameter kommagescheiden op. Properties die je wil ontvangen geef je op met de resource-naam gevolgd door de property naam, met daartussen een punt. In de definitie van het antwoord kun je bij _embedded zien welke gerelateerde resources meegeleverd kunnen worden. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/expand.feature). | [optional] 
 **fields** | **str**| Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#x27;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) | [optional] 

### Return type

[**KadastraalOnroerendeZaakHal**](KadastraalOnroerendeZaakHal.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/hal+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_kadastraal_onroerende_zaken**
> KadastraalOnroerendeZaakHalCollectie get_kadastraal_onroerende_zaken(accept_crs=accept_crs, expand=expand, fields=fields, kadastraleaanduiding=kadastraleaanduiding, ingeschrevenpersoon__burgerservicenummer=ingeschrevenpersoon__burgerservicenummer, persoon_kadasterpersoonidentificatie=persoon_kadasterpersoonidentificatie, zakelijkgerechtigde__typegerechtigde=zakelijkgerechtigde__typegerechtigde, adres__postcode=adres__postcode, adres__huisnummer=adres__huisnummer, adres__huisletter=adres__huisletter, adres__huisnummertoevoeging=adres__huisnummertoevoeging)



Het zoeken van kadastraal onroerende zaken door een of meer parameters op te geven uit de categorieën kadastrale aanduiding, ingeschreven persoon, kadasterpersoon of Adres. Het combineren van parameters uit verschillende categorieën is niet toegestaan. 1.  Kadastrale aanduiding 2.  Ingeschreven persoon als zakelijk gerechtigde     -  burgerservicenummer (verplicht)     -  typegerechtigde (optioneel) 3.  Niet ingeschreven persoon of niet natuurlijk persoon als zakelijk gerechtigde     -  kadasterpersoonidentificatie (verplicht)     -  typegerechtigde (optioneel) 4.  Adres     -  postcode (verplicht)     -  huisnummer (optioneel)     -  huisletter (optioneel)     -  huisnummertoevoeging (optioneel)  Met gebruik van de parameter expand kunnen zakelijkgerechtigden direct worden meegeladen.  Het maximale aantal zoekresultaten dat geretourneerd wordt is aan de provider om te bepalen. Als het resultaat van de de request dit aantal overtreft worden er geen resultaten geretourneerd en volgt er een foutmelding. 

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.KadastraalOnroerendeZakenApi()
accept_crs = 'epsg:28992' # str | Gewenste CRS van de coördinaten in de response. (optional) (default to epsg:28992)
expand = 'expand_example' # str | Hiermee kun je opgeven welke gerelateerde resources meegeleverd moeten worden, en hun inhoud naar behoefte aanpassen. Hele resources of enkele properties geef je in de expand parameter kommagescheiden op. Properties die je wil ontvangen geef je op met de resource-naam gevolgd door de property naam, met daartussen een punt. In de definitie van het antwoord kun je bij _embedded zien welke gerelateerde resources meegeleverd kunnen worden. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/expand.feature). (optional)
fields = 'fields_example' # str | Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma's gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) (optional)
kadastraleaanduiding = 'kadastraleaanduiding_example' # str | Kadastrale aanduiding is een unieke aanduiding van een onroerende zaak. De volgorde waarin deze string wordt opgebouwd is - [Kadastrale gemeente](http://www.kadaster.nl/schemas/waardelijsten/KadastraleGemeente/). - sectie, 1 of 2 hoofdletters - perceelnummer, 1 tot 5 cijfers - appartementsrechtVolgnummer, Hoofdletter A gevolgd door 1 tot 4 cijfers (optioneel)  gescheiden door een spatie (optional)
ingeschrevenpersoon__burgerservicenummer = 'ingeschrevenpersoon__burgerservicenummer_example' # str | Het burgerservicenummer van de persoon die een zakelijk recht op een kadastraal onroerende zaak heeft. Deze persoon is zakelijk gerechtigde van de kadastraal onroerende zaak. Door deze query-parameter te gebruiken worden Kadastraal Onroerende Zaken geretourneerd waar deze persoon een zakelijk recht op heeft. (optional)
persoon_kadasterpersoonidentificatie = 'persoon_kadasterpersoonidentificatie_example' # str | De identificatie van de Kadasterpersoon, een niet-ingeschreven persoon of een rechtspersoon waarvan de gegevens door het kadaster zijn geregistreerd. Deze persoon is zakelijk gerechtigde van de Kadastraal Onroerende Zaak. Door deze query-parameter te gebruiken worden Kadastraal Onroerende Zaken geretourneerd waar deze persoon een zakelijk recht op heeft. (optional)
zakelijkgerechtigde__typegerechtigde = swagger_client.TypeGerechtigdeEnum() # TypeGerechtigdeEnum | Een typering van het recht dat de zakelijkgerechtigde heeft op de Kadastraal Onroerende Zaak. Door het gebruik van deze query-parameter worden Kadastraal Onroerende Zaken geretourneerd waar een recht op rust van het opgegeven type. (optional)
adres__postcode = 'adres__postcode_example' # str | De postcode van het adres van de objectlocatie van de kadastraal onroerende zaak (optional)
adres__huisnummer = 56 # int | Het huisnummer van het adres van de objectlocatie van de kadastraal onroerende zaak (optional)
adres__huisletter = 'adres__huisletter_example' # str | De huisletter van het adres van de objectlocatie van de kadastraal onroerende zaak (optional)
adres__huisnummertoevoeging = 'adres__huisnummertoevoeging_example' # str | De huisnummertoevoeging van het adres van de objectlocatie van de kadastraal onroerende zaak (optional)

try:
    api_response = api_instance.get_kadastraal_onroerende_zaken(accept_crs=accept_crs, expand=expand, fields=fields, kadastraleaanduiding=kadastraleaanduiding, ingeschrevenpersoon__burgerservicenummer=ingeschrevenpersoon__burgerservicenummer, persoon_kadasterpersoonidentificatie=persoon_kadasterpersoonidentificatie, zakelijkgerechtigde__typegerechtigde=zakelijkgerechtigde__typegerechtigde, adres__postcode=adres__postcode, adres__huisnummer=adres__huisnummer, adres__huisletter=adres__huisletter, adres__huisnummertoevoeging=adres__huisnummertoevoeging)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling KadastraalOnroerendeZakenApi->get_kadastraal_onroerende_zaken: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept_crs** | **str**| Gewenste CRS van de coördinaten in de response. | [optional] [default to epsg:28992]
 **expand** | **str**| Hiermee kun je opgeven welke gerelateerde resources meegeleverd moeten worden, en hun inhoud naar behoefte aanpassen. Hele resources of enkele properties geef je in de expand parameter kommagescheiden op. Properties die je wil ontvangen geef je op met de resource-naam gevolgd door de property naam, met daartussen een punt. In de definitie van het antwoord kun je bij _embedded zien welke gerelateerde resources meegeleverd kunnen worden. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/expand.feature). | [optional] 
 **fields** | **str**| Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#x27;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) | [optional] 
 **kadastraleaanduiding** | **str**| Kadastrale aanduiding is een unieke aanduiding van een onroerende zaak. De volgorde waarin deze string wordt opgebouwd is - [Kadastrale gemeente](http://www.kadaster.nl/schemas/waardelijsten/KadastraleGemeente/). - sectie, 1 of 2 hoofdletters - perceelnummer, 1 tot 5 cijfers - appartementsrechtVolgnummer, Hoofdletter A gevolgd door 1 tot 4 cijfers (optioneel)  gescheiden door een spatie | [optional] 
 **ingeschrevenpersoon__burgerservicenummer** | **str**| Het burgerservicenummer van de persoon die een zakelijk recht op een kadastraal onroerende zaak heeft. Deze persoon is zakelijk gerechtigde van de kadastraal onroerende zaak. Door deze query-parameter te gebruiken worden Kadastraal Onroerende Zaken geretourneerd waar deze persoon een zakelijk recht op heeft. | [optional] 
 **persoon_kadasterpersoonidentificatie** | **str**| De identificatie van de Kadasterpersoon, een niet-ingeschreven persoon of een rechtspersoon waarvan de gegevens door het kadaster zijn geregistreerd. Deze persoon is zakelijk gerechtigde van de Kadastraal Onroerende Zaak. Door deze query-parameter te gebruiken worden Kadastraal Onroerende Zaken geretourneerd waar deze persoon een zakelijk recht op heeft. | [optional] 
 **zakelijkgerechtigde__typegerechtigde** | [**TypeGerechtigdeEnum**](.md)| Een typering van het recht dat de zakelijkgerechtigde heeft op de Kadastraal Onroerende Zaak. Door het gebruik van deze query-parameter worden Kadastraal Onroerende Zaken geretourneerd waar een recht op rust van het opgegeven type. | [optional] 
 **adres__postcode** | **str**| De postcode van het adres van de objectlocatie van de kadastraal onroerende zaak | [optional] 
 **adres__huisnummer** | **int**| Het huisnummer van het adres van de objectlocatie van de kadastraal onroerende zaak | [optional] 
 **adres__huisletter** | **str**| De huisletter van het adres van de objectlocatie van de kadastraal onroerende zaak | [optional] 
 **adres__huisnummertoevoeging** | **str**| De huisnummertoevoeging van het adres van de objectlocatie van de kadastraal onroerende zaak | [optional] 

### Return type

[**KadastraalOnroerendeZaakHalCollectie**](KadastraalOnroerendeZaakHalCollectie.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/hal+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

