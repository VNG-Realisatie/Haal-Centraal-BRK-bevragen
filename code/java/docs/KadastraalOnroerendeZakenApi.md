# KadastraalOnroerendeZakenApi

All URIs are relative to *https://service30.kadaster.nl/esd/bevragen/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getKadastraalOnroerendeZaak**](KadastraalOnroerendeZakenApi.md#getKadastraalOnroerendeZaak) | **GET** /kadastraalonroerendezaken/{kadastraalonroerendezaakidentificatie} | 
[**getKadastraalOnroerendeZaken**](KadastraalOnroerendeZakenApi.md#getKadastraalOnroerendeZaken) | **GET** /kadastraalonroerendezaken | 

<a name="getKadastraalOnroerendeZaak"></a>
# **getKadastraalOnroerendeZaak**
> KadastraalOnroerendeZaakHal getKadastraalOnroerendeZaak(kadastraalonroerendezaakidentificatie, acceptCrs, expand, fields)



Het raadplegen van een kadastrale onroerende zaak.  Met gebruik van de parameter expand kunnen zakelijkgerechtigden direct worden meegeladen. 

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.KadastraalOnroerendeZakenApi;


KadastraalOnroerendeZakenApi apiInstance = new KadastraalOnroerendeZakenApi();
String kadastraalonroerendezaakidentificatie = "kadastraalonroerendezaakidentificatie_example"; // String | De unieke identificatie van een kadastraal onroerende zaak.
String acceptCrs = "epsg:28992"; // String | Gewenste CRS van de coördinaten in de response.
String expand = "expand_example"; // String | Hiermee kun je opgeven welke gerelateerde resources meegeleverd moeten worden, en hun inhoud naar behoefte aanpassen. Hele resources of enkele properties geef je in de expand parameter kommagescheiden op. Properties die je wil ontvangen geef je op met de resource-naam gevolgd door de property naam, met daartussen een punt. In de definitie van het antwoord kun je bij _embedded zien welke gerelateerde resources meegeleverd kunnen worden. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/expand.feature).
String fields = "fields_example"; // String | Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma's gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature)
try {
    KadastraalOnroerendeZaakHal result = apiInstance.getKadastraalOnroerendeZaak(kadastraalonroerendezaakidentificatie, acceptCrs, expand, fields);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling KadastraalOnroerendeZakenApi#getKadastraalOnroerendeZaak");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kadastraalonroerendezaakidentificatie** | **String**| De unieke identificatie van een kadastraal onroerende zaak. |
 **acceptCrs** | **String**| Gewenste CRS van de coördinaten in de response. | [optional] [default to epsg:28992] [enum: epsg:28992]
 **expand** | **String**| Hiermee kun je opgeven welke gerelateerde resources meegeleverd moeten worden, en hun inhoud naar behoefte aanpassen. Hele resources of enkele properties geef je in de expand parameter kommagescheiden op. Properties die je wil ontvangen geef je op met de resource-naam gevolgd door de property naam, met daartussen een punt. In de definitie van het antwoord kun je bij _embedded zien welke gerelateerde resources meegeleverd kunnen worden. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/expand.feature). | [optional]
 **fields** | **String**| Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#x27;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) | [optional]

### Return type

[**KadastraalOnroerendeZaakHal**](KadastraalOnroerendeZaakHal.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/hal+json, application/problem+json

<a name="getKadastraalOnroerendeZaken"></a>
# **getKadastraalOnroerendeZaken**
> KadastraalOnroerendeZaakHalCollectie getKadastraalOnroerendeZaken(acceptCrs, expand, fields, kadastraleaanduiding, ingeschrevenpersoonBurgerservicenummer, persoonKadasterpersoonidentificatie, zakelijkgerechtigdeTypegerechtigde, adresPostcode, adresHuisnummer, adresHuisletter, adresHuisnummertoevoeging)



Het zoeken van kadastraal onroerende zaken door een of meer parameters op te geven uit de categorieën kadastrale aanduiding, ingeschreven persoon, kadasterpersoon of Adres. Het combineren van parameters uit verschillende categorieën is niet toegestaan. 1.  Kadastrale aanduiding 2.  Ingeschreven persoon als zakelijk gerechtigde     -  burgerservicenummer (verplicht)     -  typegerechtigde (optioneel) 3.  Niet ingeschreven persoon of niet natuurlijk persoon als zakelijk gerechtigde     -  kadasterpersoonidentificatie (verplicht)     -  typegerechtigde (optioneel) 4.  Adres     -  postcode (verplicht)     -  huisnummer (optioneel)     -  huisletter (optioneel)     -  huisnummertoevoeging (optioneel)  Met gebruik van de parameter expand kunnen zakelijkgerechtigden direct worden meegeladen.  Het maximale aantal zoekresultaten dat geretourneerd wordt is aan de provider om te bepalen. Als het resultaat van de de request dit aantal overtreft worden er geen resultaten geretourneerd en volgt er een foutmelding. 

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.KadastraalOnroerendeZakenApi;


KadastraalOnroerendeZakenApi apiInstance = new KadastraalOnroerendeZakenApi();
String acceptCrs = "epsg:28992"; // String | Gewenste CRS van de coördinaten in de response.
String expand = "expand_example"; // String | Hiermee kun je opgeven welke gerelateerde resources meegeleverd moeten worden, en hun inhoud naar behoefte aanpassen. Hele resources of enkele properties geef je in de expand parameter kommagescheiden op. Properties die je wil ontvangen geef je op met de resource-naam gevolgd door de property naam, met daartussen een punt. In de definitie van het antwoord kun je bij _embedded zien welke gerelateerde resources meegeleverd kunnen worden. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/expand.feature).
String fields = "fields_example"; // String | Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma's gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature)
String kadastraleaanduiding = "kadastraleaanduiding_example"; // String | Kadastrale aanduiding is een unieke aanduiding van een onroerende zaak. De volgorde waarin deze string wordt opgebouwd is - [Kadastrale gemeente](http://www.kadaster.nl/schemas/waardelijsten/KadastraleGemeente/). - sectie, 1 of 2 hoofdletters - perceelnummer, 1 tot 5 cijfers - appartementsrechtVolgnummer, Hoofdletter A gevolgd door 1 tot 4 cijfers (optioneel)  gescheiden door een spatie
String ingeschrevenpersoonBurgerservicenummer = "ingeschrevenpersoonBurgerservicenummer_example"; // String | Het burgerservicenummer van de persoon die een zakelijk recht op een kadastraal onroerende zaak heeft. Deze persoon is zakelijk gerechtigde van de kadastraal onroerende zaak. Door deze query-parameter te gebruiken worden Kadastraal Onroerende Zaken geretourneerd waar deze persoon een zakelijk recht op heeft.
String persoonKadasterpersoonidentificatie = "persoonKadasterpersoonidentificatie_example"; // String | De identificatie van de Kadasterpersoon, een niet-ingeschreven persoon of een rechtspersoon waarvan de gegevens door het kadaster zijn geregistreerd. Deze persoon is zakelijk gerechtigde van de Kadastraal Onroerende Zaak. Door deze query-parameter te gebruiken worden Kadastraal Onroerende Zaken geretourneerd waar deze persoon een zakelijk recht op heeft.
TypeGerechtigdeEnum zakelijkgerechtigdeTypegerechtigde = new TypeGerechtigdeEnum(); // TypeGerechtigdeEnum | Een typering van het recht dat de zakelijkgerechtigde heeft op de Kadastraal Onroerende Zaak. Door het gebruik van deze query-parameter worden Kadastraal Onroerende Zaken geretourneerd waar een recht op rust van het opgegeven type.
String adresPostcode = "adresPostcode_example"; // String | De postcode van het adres van de objectlocatie van de kadastraal onroerende zaak
Integer adresHuisnummer = 56; // Integer | Het huisnummer van het adres van de objectlocatie van de kadastraal onroerende zaak
String adresHuisletter = "adresHuisletter_example"; // String | De huisletter van het adres van de objectlocatie van de kadastraal onroerende zaak
String adresHuisnummertoevoeging = "adresHuisnummertoevoeging_example"; // String | De huisnummertoevoeging van het adres van de objectlocatie van de kadastraal onroerende zaak
try {
    KadastraalOnroerendeZaakHalCollectie result = apiInstance.getKadastraalOnroerendeZaken(acceptCrs, expand, fields, kadastraleaanduiding, ingeschrevenpersoonBurgerservicenummer, persoonKadasterpersoonidentificatie, zakelijkgerechtigdeTypegerechtigde, adresPostcode, adresHuisnummer, adresHuisletter, adresHuisnummertoevoeging);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling KadastraalOnroerendeZakenApi#getKadastraalOnroerendeZaken");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **acceptCrs** | **String**| Gewenste CRS van de coördinaten in de response. | [optional] [default to epsg:28992] [enum: epsg:28992]
 **expand** | **String**| Hiermee kun je opgeven welke gerelateerde resources meegeleverd moeten worden, en hun inhoud naar behoefte aanpassen. Hele resources of enkele properties geef je in de expand parameter kommagescheiden op. Properties die je wil ontvangen geef je op met de resource-naam gevolgd door de property naam, met daartussen een punt. In de definitie van het antwoord kun je bij _embedded zien welke gerelateerde resources meegeleverd kunnen worden. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/expand.feature). | [optional]
 **fields** | **String**| Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#x27;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature) | [optional]
 **kadastraleaanduiding** | **String**| Kadastrale aanduiding is een unieke aanduiding van een onroerende zaak. De volgorde waarin deze string wordt opgebouwd is - [Kadastrale gemeente](http://www.kadaster.nl/schemas/waardelijsten/KadastraleGemeente/). - sectie, 1 of 2 hoofdletters - perceelnummer, 1 tot 5 cijfers - appartementsrechtVolgnummer, Hoofdletter A gevolgd door 1 tot 4 cijfers (optioneel)  gescheiden door een spatie | [optional]
 **ingeschrevenpersoonBurgerservicenummer** | **String**| Het burgerservicenummer van de persoon die een zakelijk recht op een kadastraal onroerende zaak heeft. Deze persoon is zakelijk gerechtigde van de kadastraal onroerende zaak. Door deze query-parameter te gebruiken worden Kadastraal Onroerende Zaken geretourneerd waar deze persoon een zakelijk recht op heeft. | [optional]
 **persoonKadasterpersoonidentificatie** | **String**| De identificatie van de Kadasterpersoon, een niet-ingeschreven persoon of een rechtspersoon waarvan de gegevens door het kadaster zijn geregistreerd. Deze persoon is zakelijk gerechtigde van de Kadastraal Onroerende Zaak. Door deze query-parameter te gebruiken worden Kadastraal Onroerende Zaken geretourneerd waar deze persoon een zakelijk recht op heeft. | [optional]
 **zakelijkgerechtigdeTypegerechtigde** | [**TypeGerechtigdeEnum**](.md)| Een typering van het recht dat de zakelijkgerechtigde heeft op de Kadastraal Onroerende Zaak. Door het gebruik van deze query-parameter worden Kadastraal Onroerende Zaken geretourneerd waar een recht op rust van het opgegeven type. | [optional]
 **adresPostcode** | **String**| De postcode van het adres van de objectlocatie van de kadastraal onroerende zaak | [optional]
 **adresHuisnummer** | **Integer**| Het huisnummer van het adres van de objectlocatie van de kadastraal onroerende zaak | [optional] [enum: ]
 **adresHuisletter** | **String**| De huisletter van het adres van de objectlocatie van de kadastraal onroerende zaak | [optional]
 **adresHuisnummertoevoeging** | **String**| De huisnummertoevoeging van het adres van de objectlocatie van de kadastraal onroerende zaak | [optional]

### Return type

[**KadastraalOnroerendeZaakHalCollectie**](KadastraalOnroerendeZaakHalCollectie.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/hal+json, application/problem+json

