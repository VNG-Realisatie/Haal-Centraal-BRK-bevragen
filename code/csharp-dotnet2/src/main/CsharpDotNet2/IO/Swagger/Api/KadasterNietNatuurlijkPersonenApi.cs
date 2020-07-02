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
    public interface IKadasterNietNatuurlijkPersonenApi
    {
        /// <summary>
        ///  Het zoeken van bij het kadaster geregistreerde niet natuurlijke personen die al dan niet in het handelsregister (HR) zijn ingeschreven. Kadasternietnatuurlijkpersonen worden niet geactualiseerd.
        /// </summary>
        /// <param name="q">Free query parameter. Dit endpoint evolueert naar free query zoeken. In deze versie kan alleen een combinatie van (het begin van de) de statutaire naam en zetel (vestigingsplaats) worden opgegeven. Let op! Een niet natuurlijk persoon kan meerdere keren, en op meer dan één manier voorkomen in de BRK.</param>
        /// <param name="fields">Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#x27;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature)</param>
        /// <returns>KadasterNietNatuurlijkPersoonHalCollectie</returns>
        KadasterNietNatuurlijkPersoonHalCollectie GetKadasterNietNatuurlijkPersonen (string q, string fields);
        /// <summary>
        ///  Het raadplegen van een bij het kadaster geregistreerde niet natuurlijke persoon die al dan niet in het handelsregister (HR) is ingeschreven. Kadasternietnatuurlijkpersonen worden niet geactualiseerd.
        /// </summary>
        /// <param name="kadasternietnatuurlijkpersoonidentificatie"></param>
        /// <param name="fields">Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#x27;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature)</param>
        /// <returns>KadasterNietNatuurlijkPersoonHal</returns>
        KadasterNietNatuurlijkPersoonHal GetKadasterNietNatuurlijkPersoon (string kadasternietnatuurlijkpersoonidentificatie, string fields);
        /// <summary>
        ///  Het zoeken van bij het kadaster geregistreerde natuurlijke personen die niet in de basisregistratie personen (BRP) zijn ingeschreven (of wel zijn ingeschreven maar niet zijn _gematched_ bij het inschrijven van de akte). Kadasternatuurlijkpersonen worden niet geactualiseerd. 
        /// </summary>
        /// <param name="q">Free query parameter. Dit endpoint evolueert naar free query zoeken. In deze versie kan alleen een combinatie van (het begin van) de geslachtsnaam en geboortedatum [YYYY-mm-dd] worden opgegeven.</param>
        /// <param name="fields">Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#x27;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature)</param>
        /// <returns>KadasterNatuurlijkPersoonHalCollectie</returns>
        KadasterNatuurlijkPersoonHalCollectie GetKadasterPersonen (string q, string fields);
        /// <summary>
        ///  Het raadplegen van een bij het kadaster geregistreerde natuurlijke persoon die niet in de basisregistratie personen (BRP) is ingeschreven (of wel is ingeschreven maar niet is gekoppeld bij het inschrijven van de akte). Kadasternatuurlijkpersonen worden niet geactualiseerd.
        /// </summary>
        /// <param name="kadasternatuurlijkpersoonidentificatie"></param>
        /// <param name="fields">Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#x27;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature)</param>
        /// <returns>KadasterNatuurlijkPersoonHal</returns>
        KadasterNatuurlijkPersoonHal GetKadasterPersoon (string kadasternatuurlijkpersoonidentificatie, string fields);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class KadasterNietNatuurlijkPersonenApi : IKadasterNietNatuurlijkPersonenApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KadasterNietNatuurlijkPersonenApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public KadasterNietNatuurlijkPersonenApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="KadasterNietNatuurlijkPersonenApi"/> class.
        /// </summary>
        /// <returns></returns>
        public KadasterNietNatuurlijkPersonenApi(String basePath)
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
        ///  Het zoeken van bij het kadaster geregistreerde niet natuurlijke personen die al dan niet in het handelsregister (HR) zijn ingeschreven. Kadasternietnatuurlijkpersonen worden niet geactualiseerd.
        /// </summary>
        /// <param name="q">Free query parameter. Dit endpoint evolueert naar free query zoeken. In deze versie kan alleen een combinatie van (het begin van de) de statutaire naam en zetel (vestigingsplaats) worden opgegeven. Let op! Een niet natuurlijk persoon kan meerdere keren, en op meer dan één manier voorkomen in de BRK.</param>
        /// <param name="fields">Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#x27;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature)</param>
        /// <returns>KadasterNietNatuurlijkPersoonHalCollectie</returns>
        public KadasterNietNatuurlijkPersoonHalCollectie GetKadasterNietNatuurlijkPersonen (string q, string fields)
        {
            // verify the required parameter 'q' is set
            if (q == null) throw new ApiException(400, "Missing required parameter 'q' when calling GetKadasterNietNatuurlijkPersonen");
    
            var path = "/kadasternietnatuurlijkpersonen";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (q != null) queryParams.Add("q", ApiClient.ParameterToString(q)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetKadasterNietNatuurlijkPersonen: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetKadasterNietNatuurlijkPersonen: " + response.ErrorMessage, response.ErrorMessage);
    
            return (KadasterNietNatuurlijkPersoonHalCollectie) ApiClient.Deserialize(response.Content, typeof(KadasterNietNatuurlijkPersoonHalCollectie), response.Headers);
        }
    
        /// <summary>
        ///  Het raadplegen van een bij het kadaster geregistreerde niet natuurlijke persoon die al dan niet in het handelsregister (HR) is ingeschreven. Kadasternietnatuurlijkpersonen worden niet geactualiseerd.
        /// </summary>
        /// <param name="kadasternietnatuurlijkpersoonidentificatie"></param>
        /// <param name="fields">Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#x27;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature)</param>
        /// <returns>KadasterNietNatuurlijkPersoonHal</returns>
        public KadasterNietNatuurlijkPersoonHal GetKadasterNietNatuurlijkPersoon (string kadasternietnatuurlijkpersoonidentificatie, string fields)
        {
            // verify the required parameter 'kadasternietnatuurlijkpersoonidentificatie' is set
            if (kadasternietnatuurlijkpersoonidentificatie == null) throw new ApiException(400, "Missing required parameter 'kadasternietnatuurlijkpersoonidentificatie' when calling GetKadasterNietNatuurlijkPersoon");
    
            var path = "/kadasternietnatuurlijkpersonen/{kadasternietnatuurlijkpersoonidentificatie}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "kadasternietnatuurlijkpersoonidentificatie" + "}", ApiClient.ParameterToString(kadasternietnatuurlijkpersoonidentificatie));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetKadasterNietNatuurlijkPersoon: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetKadasterNietNatuurlijkPersoon: " + response.ErrorMessage, response.ErrorMessage);
    
            return (KadasterNietNatuurlijkPersoonHal) ApiClient.Deserialize(response.Content, typeof(KadasterNietNatuurlijkPersoonHal), response.Headers);
        }
    
        /// <summary>
        ///  Het zoeken van bij het kadaster geregistreerde natuurlijke personen die niet in de basisregistratie personen (BRP) zijn ingeschreven (of wel zijn ingeschreven maar niet zijn _gematched_ bij het inschrijven van de akte). Kadasternatuurlijkpersonen worden niet geactualiseerd. 
        /// </summary>
        /// <param name="q">Free query parameter. Dit endpoint evolueert naar free query zoeken. In deze versie kan alleen een combinatie van (het begin van) de geslachtsnaam en geboortedatum [YYYY-mm-dd] worden opgegeven.</param>
        /// <param name="fields">Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#x27;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature)</param>
        /// <returns>KadasterNatuurlijkPersoonHalCollectie</returns>
        public KadasterNatuurlijkPersoonHalCollectie GetKadasterPersonen (string q, string fields)
        {
            // verify the required parameter 'q' is set
            if (q == null) throw new ApiException(400, "Missing required parameter 'q' when calling GetKadasterPersonen");
    
            var path = "/kadasternatuurlijkpersonen";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (q != null) queryParams.Add("q", ApiClient.ParameterToString(q)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetKadasterPersonen: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetKadasterPersonen: " + response.ErrorMessage, response.ErrorMessage);
    
            return (KadasterNatuurlijkPersoonHalCollectie) ApiClient.Deserialize(response.Content, typeof(KadasterNatuurlijkPersoonHalCollectie), response.Headers);
        }
    
        /// <summary>
        ///  Het raadplegen van een bij het kadaster geregistreerde natuurlijke persoon die niet in de basisregistratie personen (BRP) is ingeschreven (of wel is ingeschreven maar niet is gekoppeld bij het inschrijven van de akte). Kadasternatuurlijkpersonen worden niet geactualiseerd.
        /// </summary>
        /// <param name="kadasternatuurlijkpersoonidentificatie"></param>
        /// <param name="fields">Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#x27;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature)</param>
        /// <returns>KadasterNatuurlijkPersoonHal</returns>
        public KadasterNatuurlijkPersoonHal GetKadasterPersoon (string kadasternatuurlijkpersoonidentificatie, string fields)
        {
            // verify the required parameter 'kadasternatuurlijkpersoonidentificatie' is set
            if (kadasternatuurlijkpersoonidentificatie == null) throw new ApiException(400, "Missing required parameter 'kadasternatuurlijkpersoonidentificatie' when calling GetKadasterPersoon");
    
            var path = "/kadasternatuurlijkpersonen/{kadasternatuurlijkpersoonidentificatie}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "kadasternatuurlijkpersoonidentificatie" + "}", ApiClient.ParameterToString(kadasternatuurlijkpersoonidentificatie));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetKadasterPersoon: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetKadasterPersoon: " + response.ErrorMessage, response.ErrorMessage);
    
            return (KadasterNatuurlijkPersoonHal) ApiClient.Deserialize(response.Content, typeof(KadasterNatuurlijkPersoonHal), response.Headers);
        }
    
    }
}
