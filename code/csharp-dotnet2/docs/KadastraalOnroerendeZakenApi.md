# IO.Swagger.Api.KadastraalOnroerendeZakenApi

All URIs are relative to *https://service30.kadaster.nl/esd/bevragen/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetKadastraalOnroerendeZaak**](KadastraalOnroerendeZakenApi.md#getkadastraalonroerendezaak) | **GET** /kadastraalonroerendezaken/{kadastraalonroerendezaakidentificatie} | 
[**GetKadastraalOnroerendeZaken**](KadastraalOnroerendeZakenApi.md#getkadastraalonroerendezaken) | **GET** /kadastraalonroerendezaken | 

<a name="getkadastraalonroerendezaak"></a>
# **GetKadastraalOnroerendeZaak**
> KadastraalOnroerendeZaakHal GetKadastraalOnroerendeZaak (string kadastraalonroerendezaakidentificatie, string acceptCrs, string expand, string fields)



Het raadplegen van een kadastrale onroerende zaak.  Met gebruik van de parameter expand kunnen zakelijkgerechtigden direct worden meegeladen. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetKadastraalOnroerendeZaakExample
    {
        public void main()
        {

            var apiInstance = new KadastraalOnroerendeZakenApi();
            var kadastraalonroerendezaakidentificatie = kadastraalonroerendezaakidentificatie_example;  // string | De unieke identificatie van een kadastraal onroerende zaak.
            var acceptCrs = acceptCrs_example;  // string | Gewenste CRS van de coördinaten in de response. (optional)  (default to epsg:28992)
            var expand = expand_example;  // string | Hiermee kun je opgeven welke gerelateerde resources meegeleverd moeten worden, en hun inhoud naar behoefte aanpassen. Hele resources of enkele properties geef je in de expand parameter kommagescheiden op. Properties die je wil ontvangen geef je op met de resource-naam gevolgd door de property naam, met daartussen een punt. In de definitie van het antwoord kun je bij _embedded zien welke gerelateerde resources meegeleverd kunnen worden. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/expand.feature). (optional) 
            var fields = fields_example;  // string | Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma's gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) (optional) 

            try
            {
                KadastraalOnroerendeZaakHal result = apiInstance.GetKadastraalOnroerendeZaak(kadastraalonroerendezaakidentificatie, acceptCrs, expand, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KadastraalOnroerendeZakenApi.GetKadastraalOnroerendeZaak: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kadastraalonroerendezaakidentificatie** | **string**| De unieke identificatie van een kadastraal onroerende zaak. | 
 **acceptCrs** | **string**| Gewenste CRS van de coördinaten in de response. | [optional] [default to epsg:28992]
 **expand** | **string**| Hiermee kun je opgeven welke gerelateerde resources meegeleverd moeten worden, en hun inhoud naar behoefte aanpassen. Hele resources of enkele properties geef je in de expand parameter kommagescheiden op. Properties die je wil ontvangen geef je op met de resource-naam gevolgd door de property naam, met daartussen een punt. In de definitie van het antwoord kun je bij _embedded zien welke gerelateerde resources meegeleverd kunnen worden. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/expand.feature). | [optional] 
 **fields** | **string**| Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#x27;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) | [optional] 

### Return type

[**KadastraalOnroerendeZaakHal**](KadastraalOnroerendeZaakHal.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/hal+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getkadastraalonroerendezaken"></a>
# **GetKadastraalOnroerendeZaken**
> KadastraalOnroerendeZaakHalCollectie GetKadastraalOnroerendeZaken (string acceptCrs, string expand, string fields, string kadastraleaanduiding, string ingeschrevenpersoonBurgerservicenummer, string persoonKadasterpersoonidentificatie, TypeGerechtigdeEnum zakelijkgerechtigdeTypegerechtigde, string adresPostcode, int? adresHuisnummer, string adresHuisletter, string adresHuisnummertoevoeging)



Het zoeken van kadastraal onroerende zaken door een of meer parameters op te geven uit de categorieën kadastrale aanduiding, ingeschreven persoon, kadasterpersoon of Adres. Het combineren van parameters uit verschillende categorieën is niet toegestaan. 1.  Kadastrale aanduiding 2.  Ingeschreven persoon als zakelijk gerechtigde     -  burgerservicenummer (verplicht)     -  typegerechtigde (optioneel) 3.  Niet ingeschreven persoon of niet natuurlijk persoon als zakelijk gerechtigde     -  kadasterpersoonidentificatie (verplicht)     -  typegerechtigde (optioneel) 4.  Adres     -  postcode (verplicht)     -  huisnummer (optioneel)     -  huisletter (optioneel)     -  huisnummertoevoeging (optioneel)  Met gebruik van de parameter expand kunnen zakelijkgerechtigden direct worden meegeladen.  Het maximale aantal zoekresultaten dat geretourneerd wordt is aan de provider om te bepalen. Als het resultaat van de de request dit aantal overtreft worden er geen resultaten geretourneerd en volgt er een foutmelding. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetKadastraalOnroerendeZakenExample
    {
        public void main()
        {

            var apiInstance = new KadastraalOnroerendeZakenApi();
            var acceptCrs = acceptCrs_example;  // string | Gewenste CRS van de coördinaten in de response. (optional)  (default to epsg:28992)
            var expand = expand_example;  // string | Hiermee kun je opgeven welke gerelateerde resources meegeleverd moeten worden, en hun inhoud naar behoefte aanpassen. Hele resources of enkele properties geef je in de expand parameter kommagescheiden op. Properties die je wil ontvangen geef je op met de resource-naam gevolgd door de property naam, met daartussen een punt. In de definitie van het antwoord kun je bij _embedded zien welke gerelateerde resources meegeleverd kunnen worden. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/expand.feature). (optional) 
            var fields = fields_example;  // string | Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma's gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) (optional) 
            var kadastraleaanduiding = kadastraleaanduiding_example;  // string | Kadastrale aanduiding is een unieke aanduiding van een onroerende zaak. De volgorde waarin deze string wordt opgebouwd is - [Kadastrale gemeente](http://www.kadaster.nl/schemas/waardelijsten/KadastraleGemeente/). - sectie, 1 of 2 hoofdletters - perceelnummer, 1 tot 5 cijfers - appartementsrechtVolgnummer, Hoofdletter A gevolgd door 1 tot 4 cijfers (optioneel)  gescheiden door een spatie (optional) 
            var ingeschrevenpersoonBurgerservicenummer = ingeschrevenpersoonBurgerservicenummer_example;  // string | Het burgerservicenummer van de persoon die een zakelijk recht op een kadastraal onroerende zaak heeft. Deze persoon is zakelijk gerechtigde van de kadastraal onroerende zaak. Door deze query-parameter te gebruiken worden Kadastraal Onroerende Zaken geretourneerd waar deze persoon een zakelijk recht op heeft. (optional) 
            var persoonKadasterpersoonidentificatie = persoonKadasterpersoonidentificatie_example;  // string | De identificatie van de Kadasterpersoon, een niet-ingeschreven persoon of een rechtspersoon waarvan de gegevens door het kadaster zijn geregistreerd. Deze persoon is zakelijk gerechtigde van de Kadastraal Onroerende Zaak. Door deze query-parameter te gebruiken worden Kadastraal Onroerende Zaken geretourneerd waar deze persoon een zakelijk recht op heeft. (optional) 
            var zakelijkgerechtigdeTypegerechtigde = new TypeGerechtigdeEnum(); // TypeGerechtigdeEnum | Een typering van het recht dat de zakelijkgerechtigde heeft op de Kadastraal Onroerende Zaak. Door het gebruik van deze query-parameter worden Kadastraal Onroerende Zaken geretourneerd waar een recht op rust van het opgegeven type. (optional) 
            var adresPostcode = adresPostcode_example;  // string | De postcode van het adres van de objectlocatie van de kadastraal onroerende zaak (optional) 
            var adresHuisnummer = 56;  // int? | Het huisnummer van het adres van de objectlocatie van de kadastraal onroerende zaak (optional) 
            var adresHuisletter = adresHuisletter_example;  // string | De huisletter van het adres van de objectlocatie van de kadastraal onroerende zaak (optional) 
            var adresHuisnummertoevoeging = adresHuisnummertoevoeging_example;  // string | De huisnummertoevoeging van het adres van de objectlocatie van de kadastraal onroerende zaak (optional) 

            try
            {
                KadastraalOnroerendeZaakHalCollectie result = apiInstance.GetKadastraalOnroerendeZaken(acceptCrs, expand, fields, kadastraleaanduiding, ingeschrevenpersoonBurgerservicenummer, persoonKadasterpersoonidentificatie, zakelijkgerechtigdeTypegerechtigde, adresPostcode, adresHuisnummer, adresHuisletter, adresHuisnummertoevoeging);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KadastraalOnroerendeZakenApi.GetKadastraalOnroerendeZaken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **acceptCrs** | **string**| Gewenste CRS van de coördinaten in de response. | [optional] [default to epsg:28992]
 **expand** | **string**| Hiermee kun je opgeven welke gerelateerde resources meegeleverd moeten worden, en hun inhoud naar behoefte aanpassen. Hele resources of enkele properties geef je in de expand parameter kommagescheiden op. Properties die je wil ontvangen geef je op met de resource-naam gevolgd door de property naam, met daartussen een punt. In de definitie van het antwoord kun je bij _embedded zien welke gerelateerde resources meegeleverd kunnen worden. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/expand.feature). | [optional] 
 **fields** | **string**| Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#x27;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) | [optional] 
 **kadastraleaanduiding** | **string**| Kadastrale aanduiding is een unieke aanduiding van een onroerende zaak. De volgorde waarin deze string wordt opgebouwd is - [Kadastrale gemeente](http://www.kadaster.nl/schemas/waardelijsten/KadastraleGemeente/). - sectie, 1 of 2 hoofdletters - perceelnummer, 1 tot 5 cijfers - appartementsrechtVolgnummer, Hoofdletter A gevolgd door 1 tot 4 cijfers (optioneel)  gescheiden door een spatie | [optional] 
 **ingeschrevenpersoonBurgerservicenummer** | **string**| Het burgerservicenummer van de persoon die een zakelijk recht op een kadastraal onroerende zaak heeft. Deze persoon is zakelijk gerechtigde van de kadastraal onroerende zaak. Door deze query-parameter te gebruiken worden Kadastraal Onroerende Zaken geretourneerd waar deze persoon een zakelijk recht op heeft. | [optional] 
 **persoonKadasterpersoonidentificatie** | **string**| De identificatie van de Kadasterpersoon, een niet-ingeschreven persoon of een rechtspersoon waarvan de gegevens door het kadaster zijn geregistreerd. Deze persoon is zakelijk gerechtigde van de Kadastraal Onroerende Zaak. Door deze query-parameter te gebruiken worden Kadastraal Onroerende Zaken geretourneerd waar deze persoon een zakelijk recht op heeft. | [optional] 
 **zakelijkgerechtigdeTypegerechtigde** | [**TypeGerechtigdeEnum**](.md)| Een typering van het recht dat de zakelijkgerechtigde heeft op de Kadastraal Onroerende Zaak. Door het gebruik van deze query-parameter worden Kadastraal Onroerende Zaken geretourneerd waar een recht op rust van het opgegeven type. | [optional] 
 **adresPostcode** | **string**| De postcode van het adres van de objectlocatie van de kadastraal onroerende zaak | [optional] 
 **adresHuisnummer** | **int?**| Het huisnummer van het adres van de objectlocatie van de kadastraal onroerende zaak | [optional] 
 **adresHuisletter** | **string**| De huisletter van het adres van de objectlocatie van de kadastraal onroerende zaak | [optional] 
 **adresHuisnummertoevoeging** | **string**| De huisnummertoevoeging van het adres van de objectlocatie van de kadastraal onroerende zaak | [optional] 

### Return type

[**KadastraalOnroerendeZaakHalCollectie**](KadastraalOnroerendeZaakHalCollectie.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/hal+json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

