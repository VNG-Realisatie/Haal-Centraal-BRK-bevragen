using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IKadastraalOnroerendeZakenApi
    {
        /// <summary>
        ///  Het raadplegen van een kadastrale onroerende zaak.  Met gebruik van de parameter expand kunnen zakelijkgerechtigden direct worden meegeladen. 
        /// </summary>
        /// <param name="kadastraalonroerendezaakidentificatie">De unieke identificatie van een kadastraal onroerende zaak.</param>
        /// <param name="acceptCrs">Gewenste CRS van de coördinaten in de response.</param>
        /// <param name="expand">Hiermee kun je opgeven welke gerelateerde resources meegeleverd moeten worden, en hun inhoud naar behoefte aanpassen. Hele resources of enkele properties geef je in de expand parameter kommagescheiden op. Properties die je wil ontvangen geef je op met de resource-naam gevolgd door de property naam, met daartussen een punt. In de definitie van het antwoord kun je bij _embedded zien welke gerelateerde resources meegeleverd kunnen worden. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/expand.feature).</param>
        /// <param name="fields">Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#x27;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature)</param>
        /// <returns>KadastraalOnroerendeZaakHal</returns>
        KadastraalOnroerendeZaakHal GetKadastraalOnroerendeZaak (string kadastraalonroerendezaakidentificatie, string acceptCrs, string expand, string fields);
        /// <summary>
        ///  Het zoeken van kadastraal onroerende zaken door een of meer parameters op te geven uit de categorieën kadastrale aanduiding, ingeschreven persoon, kadasterpersoon of Adres. Het combineren van parameters uit verschillende categorieën is niet toegestaan. 1.  Kadastrale aanduiding 2.  Ingeschreven persoon als zakelijk gerechtigde     -  burgerservicenummer (verplicht)     -  typegerechtigde (optioneel) 3.  Niet ingeschreven persoon of niet natuurlijk persoon als zakelijk gerechtigde     -  kadasterpersoonidentificatie (verplicht)     -  typegerechtigde (optioneel) 4.  Adres     -  postcode (verplicht)     -  huisnummer (optioneel)     -  huisletter (optioneel)     -  huisnummertoevoeging (optioneel)  Met gebruik van de parameter expand kunnen zakelijkgerechtigden direct worden meegeladen.  Het maximale aantal zoekresultaten dat geretourneerd wordt is aan de provider om te bepalen. Als het resultaat van de de request dit aantal overtreft worden er geen resultaten geretourneerd en volgt er een foutmelding. 
        /// </summary>
        /// <param name="acceptCrs">Gewenste CRS van de coördinaten in de response.</param>
        /// <param name="expand">Hiermee kun je opgeven welke gerelateerde resources meegeleverd moeten worden, en hun inhoud naar behoefte aanpassen. Hele resources of enkele properties geef je in de expand parameter kommagescheiden op. Properties die je wil ontvangen geef je op met de resource-naam gevolgd door de property naam, met daartussen een punt. In de definitie van het antwoord kun je bij _embedded zien welke gerelateerde resources meegeleverd kunnen worden. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/expand.feature).</param>
        /// <param name="fields">Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#x27;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature)</param>
        /// <param name="kadastraleaanduiding">Kadastrale aanduiding is een unieke aanduiding van een onroerende zaak. De volgorde waarin deze string wordt opgebouwd is - [Kadastrale gemeente](http://www.kadaster.nl/schemas/waardelijsten/KadastraleGemeente/). - sectie, 1 of 2 hoofdletters - perceelnummer, 1 tot 5 cijfers - appartementsrechtVolgnummer, Hoofdletter A gevolgd door 1 tot 4 cijfers (optioneel)  gescheiden door een spatie</param>
        /// <param name="ingeschrevenpersoonBurgerservicenummer">Het burgerservicenummer van de persoon die een zakelijk recht op een kadastraal onroerende zaak heeft. Deze persoon is zakelijk gerechtigde van de kadastraal onroerende zaak. Door deze query-parameter te gebruiken worden Kadastraal Onroerende Zaken geretourneerd waar deze persoon een zakelijk recht op heeft.</param>
        /// <param name="persoonKadasterpersoonidentificatie">De identificatie van de Kadasterpersoon, een niet-ingeschreven persoon of een rechtspersoon waarvan de gegevens door het kadaster zijn geregistreerd. Deze persoon is zakelijk gerechtigde van de Kadastraal Onroerende Zaak. Door deze query-parameter te gebruiken worden Kadastraal Onroerende Zaken geretourneerd waar deze persoon een zakelijk recht op heeft.</param>
        /// <param name="zakelijkgerechtigdeTypegerechtigde">Een typering van het recht dat de zakelijkgerechtigde heeft op de Kadastraal Onroerende Zaak. Door het gebruik van deze query-parameter worden Kadastraal Onroerende Zaken geretourneerd waar een recht op rust van het opgegeven type.</param>
        /// <param name="adresPostcode">De postcode van het adres van de objectlocatie van de kadastraal onroerende zaak</param>
        /// <param name="adresHuisnummer">Het huisnummer van het adres van de objectlocatie van de kadastraal onroerende zaak</param>
        /// <param name="adresHuisletter">De huisletter van het adres van de objectlocatie van de kadastraal onroerende zaak</param>
        /// <param name="adresHuisnummertoevoeging">De huisnummertoevoeging van het adres van de objectlocatie van de kadastraal onroerende zaak</param>
        /// <returns>KadastraalOnroerendeZaakHalCollectie</returns>
        KadastraalOnroerendeZaakHalCollectie GetKadastraalOnroerendeZaken (string acceptCrs, string expand, string fields, string kadastraleaanduiding, string ingeschrevenpersoonBurgerservicenummer, string persoonKadasterpersoonidentificatie, TypeGerechtigdeEnum zakelijkgerechtigdeTypegerechtigde, string adresPostcode, int? adresHuisnummer, string adresHuisletter, string adresHuisnummertoevoeging);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class KadastraalOnroerendeZakenApi : IKadastraalOnroerendeZakenApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KadastraalOnroerendeZakenApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public KadastraalOnroerendeZakenApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="KadastraalOnroerendeZakenApi"/> class.
        /// </summary>
        /// <returns></returns>
        public KadastraalOnroerendeZakenApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        ///  Het raadplegen van een kadastrale onroerende zaak.  Met gebruik van de parameter expand kunnen zakelijkgerechtigden direct worden meegeladen. 
        /// </summary>
        /// <param name="kadastraalonroerendezaakidentificatie">De unieke identificatie van een kadastraal onroerende zaak.</param>
        /// <param name="acceptCrs">Gewenste CRS van de coördinaten in de response.</param>
        /// <param name="expand">Hiermee kun je opgeven welke gerelateerde resources meegeleverd moeten worden, en hun inhoud naar behoefte aanpassen. Hele resources of enkele properties geef je in de expand parameter kommagescheiden op. Properties die je wil ontvangen geef je op met de resource-naam gevolgd door de property naam, met daartussen een punt. In de definitie van het antwoord kun je bij _embedded zien welke gerelateerde resources meegeleverd kunnen worden. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/expand.feature).</param>
        /// <param name="fields">Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#x27;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature)</param>
        /// <returns>KadastraalOnroerendeZaakHal</returns>
        public KadastraalOnroerendeZaakHal GetKadastraalOnroerendeZaak (string kadastraalonroerendezaakidentificatie, string acceptCrs, string expand, string fields)
        {
            // verify the required parameter 'kadastraalonroerendezaakidentificatie' is set
            if (kadastraalonroerendezaakidentificatie == null) throw new ApiException(400, "Missing required parameter 'kadastraalonroerendezaakidentificatie' when calling GetKadastraalOnroerendeZaak");
    
            var path = "/kadastraalonroerendezaken/{kadastraalonroerendezaakidentificatie}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "kadastraalonroerendezaakidentificatie" + "}", ApiClient.ParameterToString(kadastraalonroerendezaakidentificatie));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (expand != null) queryParams.Add("expand", ApiClient.ParameterToString(expand)); // query parameter
 if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
             if (acceptCrs != null) headerParams.Add("Accept-Crs", ApiClient.ParameterToString(acceptCrs)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetKadastraalOnroerendeZaak: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetKadastraalOnroerendeZaak: " + response.ErrorMessage, response.ErrorMessage);
    
            return (KadastraalOnroerendeZaakHal) ApiClient.Deserialize(response.Content, typeof(KadastraalOnroerendeZaakHal), response.Headers);
        }
    
        /// <summary>
        ///  Het zoeken van kadastraal onroerende zaken door een of meer parameters op te geven uit de categorieën kadastrale aanduiding, ingeschreven persoon, kadasterpersoon of Adres. Het combineren van parameters uit verschillende categorieën is niet toegestaan. 1.  Kadastrale aanduiding 2.  Ingeschreven persoon als zakelijk gerechtigde     -  burgerservicenummer (verplicht)     -  typegerechtigde (optioneel) 3.  Niet ingeschreven persoon of niet natuurlijk persoon als zakelijk gerechtigde     -  kadasterpersoonidentificatie (verplicht)     -  typegerechtigde (optioneel) 4.  Adres     -  postcode (verplicht)     -  huisnummer (optioneel)     -  huisletter (optioneel)     -  huisnummertoevoeging (optioneel)  Met gebruik van de parameter expand kunnen zakelijkgerechtigden direct worden meegeladen.  Het maximale aantal zoekresultaten dat geretourneerd wordt is aan de provider om te bepalen. Als het resultaat van de de request dit aantal overtreft worden er geen resultaten geretourneerd en volgt er een foutmelding. 
        /// </summary>
        /// <param name="acceptCrs">Gewenste CRS van de coördinaten in de response.</param>
        /// <param name="expand">Hiermee kun je opgeven welke gerelateerde resources meegeleverd moeten worden, en hun inhoud naar behoefte aanpassen. Hele resources of enkele properties geef je in de expand parameter kommagescheiden op. Properties die je wil ontvangen geef je op met de resource-naam gevolgd door de property naam, met daartussen een punt. In de definitie van het antwoord kun je bij _embedded zien welke gerelateerde resources meegeleverd kunnen worden. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/expand.feature).</param>
        /// <param name="fields">Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#x27;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature)</param>
        /// <param name="kadastraleaanduiding">Kadastrale aanduiding is een unieke aanduiding van een onroerende zaak. De volgorde waarin deze string wordt opgebouwd is - [Kadastrale gemeente](http://www.kadaster.nl/schemas/waardelijsten/KadastraleGemeente/). - sectie, 1 of 2 hoofdletters - perceelnummer, 1 tot 5 cijfers - appartementsrechtVolgnummer, Hoofdletter A gevolgd door 1 tot 4 cijfers (optioneel)  gescheiden door een spatie</param>
        /// <param name="ingeschrevenpersoonBurgerservicenummer">Het burgerservicenummer van de persoon die een zakelijk recht op een kadastraal onroerende zaak heeft. Deze persoon is zakelijk gerechtigde van de kadastraal onroerende zaak. Door deze query-parameter te gebruiken worden Kadastraal Onroerende Zaken geretourneerd waar deze persoon een zakelijk recht op heeft.</param>
        /// <param name="persoonKadasterpersoonidentificatie">De identificatie van de Kadasterpersoon, een niet-ingeschreven persoon of een rechtspersoon waarvan de gegevens door het kadaster zijn geregistreerd. Deze persoon is zakelijk gerechtigde van de Kadastraal Onroerende Zaak. Door deze query-parameter te gebruiken worden Kadastraal Onroerende Zaken geretourneerd waar deze persoon een zakelijk recht op heeft.</param>
        /// <param name="zakelijkgerechtigdeTypegerechtigde">Een typering van het recht dat de zakelijkgerechtigde heeft op de Kadastraal Onroerende Zaak. Door het gebruik van deze query-parameter worden Kadastraal Onroerende Zaken geretourneerd waar een recht op rust van het opgegeven type.</param>
        /// <param name="adresPostcode">De postcode van het adres van de objectlocatie van de kadastraal onroerende zaak</param>
        /// <param name="adresHuisnummer">Het huisnummer van het adres van de objectlocatie van de kadastraal onroerende zaak</param>
        /// <param name="adresHuisletter">De huisletter van het adres van de objectlocatie van de kadastraal onroerende zaak</param>
        /// <param name="adresHuisnummertoevoeging">De huisnummertoevoeging van het adres van de objectlocatie van de kadastraal onroerende zaak</param>
        /// <returns>KadastraalOnroerendeZaakHalCollectie</returns>
        public KadastraalOnroerendeZaakHalCollectie GetKadastraalOnroerendeZaken (string acceptCrs, string expand, string fields, string kadastraleaanduiding, string ingeschrevenpersoonBurgerservicenummer, string persoonKadasterpersoonidentificatie, TypeGerechtigdeEnum zakelijkgerechtigdeTypegerechtigde, string adresPostcode, int? adresHuisnummer, string adresHuisletter, string adresHuisnummertoevoeging)
        {
    
            var path = "/kadastraalonroerendezaken";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (expand != null) queryParams.Add("expand", ApiClient.ParameterToString(expand)); // query parameter
 if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (kadastraleaanduiding != null) queryParams.Add("kadastraleaanduiding", ApiClient.ParameterToString(kadastraleaanduiding)); // query parameter
 if (ingeschrevenpersoonBurgerservicenummer != null) queryParams.Add("ingeschrevenpersoon__burgerservicenummer", ApiClient.ParameterToString(ingeschrevenpersoonBurgerservicenummer)); // query parameter
 if (persoonKadasterpersoonidentificatie != null) queryParams.Add("persoon_kadasterpersoonidentificatie", ApiClient.ParameterToString(persoonKadasterpersoonidentificatie)); // query parameter
 if (zakelijkgerechtigdeTypegerechtigde != null) queryParams.Add("zakelijkgerechtigde__typegerechtigde", ApiClient.ParameterToString(zakelijkgerechtigdeTypegerechtigde)); // query parameter
 if (adresPostcode != null) queryParams.Add("adres__postcode", ApiClient.ParameterToString(adresPostcode)); // query parameter
 if (adresHuisnummer != null) queryParams.Add("adres__huisnummer", ApiClient.ParameterToString(adresHuisnummer)); // query parameter
 if (adresHuisletter != null) queryParams.Add("adres__huisletter", ApiClient.ParameterToString(adresHuisletter)); // query parameter
 if (adresHuisnummertoevoeging != null) queryParams.Add("adres__huisnummertoevoeging", ApiClient.ParameterToString(adresHuisnummertoevoeging)); // query parameter
             if (acceptCrs != null) headerParams.Add("Accept-Crs", ApiClient.ParameterToString(acceptCrs)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetKadastraalOnroerendeZaken: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetKadastraalOnroerendeZaken: " + response.ErrorMessage, response.ErrorMessage);
    
            return (KadastraalOnroerendeZaakHalCollectie) ApiClient.Deserialize(response.Content, typeof(KadastraalOnroerendeZaakHalCollectie), response.Headers);
        }
    
    }
}
