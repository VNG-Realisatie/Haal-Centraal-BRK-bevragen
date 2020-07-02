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
    public interface IZakelijkeGerechtigdenApi
    {
        /// <summary>
        ///  Het raadplegen van een specifieke zakelijk gerechtigde van een kadastraal onroerende zaak. Het aandeel van de zakelijk gerechtigde wordt altijd geleverd in combinatie met het gezamenlijk aandeel (wanneer twee of meer personen een gezamenlijk aandeel hebben in een zakelijk recht, en ieders afzonderlijke aandeel in het gezamenlijk aandeel niet bekend is)
        /// </summary>
        /// <param name="kadastraalonroerendezaakidentificatie">De unieke identificatie van een kadastraal onroerende zaak.</param>
        /// <param name="zakelijkgerechtigdeidentificatie">De identificatie van de zakelijk gerechtigde</param>
        /// <param name="fields">Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#x27;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature)</param>
        /// <returns>ZakelijkGerechtigdeHal</returns>
        ZakelijkGerechtigdeHal GetZakelijkGerechtigde (string kadastraalonroerendezaakidentificatie, string zakelijkgerechtigdeidentificatie, string fields);
        /// <summary>
        ///  Het zoeken van zakelijk gerechtigden van een kadastraal onroerende zaak. Het aandeel van de zakelijk gerechtigde wordt altijd geleverd in combinatie met het gezamenlijk aandeel (wanneer twee of meer personen een gezamenlijk aandeel hebben in een zakelijk recht, en ieders afzonderlijke aandeel in het gezamenlijk aandeel niet bekend is)
        /// </summary>
        /// <param name="kadastraalonroerendezaakidentificatie">De unieke identificatie van een kadastraal onroerende zaak.</param>
        /// <param name="fields">Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#x27;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature)</param>
        /// <param name="typegerechtigde">Het type recht dat de zakelijk gerechtigde heeft op de kadastraal onroerende zaak. De waarden van de typering staan in een waardelijst.</param>
        /// <returns>ZakelijkGerechtigdeHalCollectie</returns>
        ZakelijkGerechtigdeHalCollectie GetZakelijkGerechtigden (string kadastraalonroerendezaakidentificatie, string fields, TypeGerechtigdeEnum typegerechtigde);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ZakelijkeGerechtigdenApi : IZakelijkeGerechtigdenApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZakelijkeGerechtigdenApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ZakelijkeGerechtigdenApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ZakelijkeGerechtigdenApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ZakelijkeGerechtigdenApi(String basePath)
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
        ///  Het raadplegen van een specifieke zakelijk gerechtigde van een kadastraal onroerende zaak. Het aandeel van de zakelijk gerechtigde wordt altijd geleverd in combinatie met het gezamenlijk aandeel (wanneer twee of meer personen een gezamenlijk aandeel hebben in een zakelijk recht, en ieders afzonderlijke aandeel in het gezamenlijk aandeel niet bekend is)
        /// </summary>
        /// <param name="kadastraalonroerendezaakidentificatie">De unieke identificatie van een kadastraal onroerende zaak.</param>
        /// <param name="zakelijkgerechtigdeidentificatie">De identificatie van de zakelijk gerechtigde</param>
        /// <param name="fields">Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#x27;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature)</param>
        /// <returns>ZakelijkGerechtigdeHal</returns>
        public ZakelijkGerechtigdeHal GetZakelijkGerechtigde (string kadastraalonroerendezaakidentificatie, string zakelijkgerechtigdeidentificatie, string fields)
        {
            // verify the required parameter 'kadastraalonroerendezaakidentificatie' is set
            if (kadastraalonroerendezaakidentificatie == null) throw new ApiException(400, "Missing required parameter 'kadastraalonroerendezaakidentificatie' when calling GetZakelijkGerechtigde");
            // verify the required parameter 'zakelijkgerechtigdeidentificatie' is set
            if (zakelijkgerechtigdeidentificatie == null) throw new ApiException(400, "Missing required parameter 'zakelijkgerechtigdeidentificatie' when calling GetZakelijkGerechtigde");
    
            var path = "/kadastraalonroerendezaken/{kadastraalonroerendezaakidentificatie}/zakelijkgerechtigden/{zakelijkgerechtigdeidentificatie}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "kadastraalonroerendezaakidentificatie" + "}", ApiClient.ParameterToString(kadastraalonroerendezaakidentificatie));
path = path.Replace("{" + "zakelijkgerechtigdeidentificatie" + "}", ApiClient.ParameterToString(zakelijkgerechtigdeidentificatie));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetZakelijkGerechtigde: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetZakelijkGerechtigde: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ZakelijkGerechtigdeHal) ApiClient.Deserialize(response.Content, typeof(ZakelijkGerechtigdeHal), response.Headers);
        }
    
        /// <summary>
        ///  Het zoeken van zakelijk gerechtigden van een kadastraal onroerende zaak. Het aandeel van de zakelijk gerechtigde wordt altijd geleverd in combinatie met het gezamenlijk aandeel (wanneer twee of meer personen een gezamenlijk aandeel hebben in een zakelijk recht, en ieders afzonderlijke aandeel in het gezamenlijk aandeel niet bekend is)
        /// </summary>
        /// <param name="kadastraalonroerendezaakidentificatie">De unieke identificatie van een kadastraal onroerende zaak.</param>
        /// <param name="fields">Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#x27;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.0.0/features/fields.feature)</param>
        /// <param name="typegerechtigde">Het type recht dat de zakelijk gerechtigde heeft op de kadastraal onroerende zaak. De waarden van de typering staan in een waardelijst.</param>
        /// <returns>ZakelijkGerechtigdeHalCollectie</returns>
        public ZakelijkGerechtigdeHalCollectie GetZakelijkGerechtigden (string kadastraalonroerendezaakidentificatie, string fields, TypeGerechtigdeEnum typegerechtigde)
        {
            // verify the required parameter 'kadastraalonroerendezaakidentificatie' is set
            if (kadastraalonroerendezaakidentificatie == null) throw new ApiException(400, "Missing required parameter 'kadastraalonroerendezaakidentificatie' when calling GetZakelijkGerechtigden");
    
            var path = "/kadastraalonroerendezaken/{kadastraalonroerendezaakidentificatie}/zakelijkgerechtigden";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "kadastraalonroerendezaakidentificatie" + "}", ApiClient.ParameterToString(kadastraalonroerendezaakidentificatie));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (typegerechtigde != null) queryParams.Add("typegerechtigde", ApiClient.ParameterToString(typegerechtigde)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetZakelijkGerechtigden: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetZakelijkGerechtigden: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ZakelijkGerechtigdeHalCollectie) ApiClient.Deserialize(response.Content, typeof(ZakelijkGerechtigdeHalCollectie), response.Headers);
        }
    
    }
}
