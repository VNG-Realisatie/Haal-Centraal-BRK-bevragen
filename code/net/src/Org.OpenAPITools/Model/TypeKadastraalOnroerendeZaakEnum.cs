/* 
 * Kadaster - BRK-Bevragen API
 *
 * D.m.v. deze toepassing worden meerdere, korte bevragingen op de Basis Registratie Kadaster beschikbaar gesteld. Deze toepassing betreft het verstrekken van Kadastrale Onroerende Zaak informatie. 
 *
 * The version of the OpenAPI document: 1.2.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Defines TypeKadastraalOnroerendeZaakEnum
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TypeKadastraalOnroerendeZaakEnum
    {
        /// <summary>
        /// Enum Appartementsrecht for value: appartementsrecht
        /// </summary>
        [EnumMember(Value = "appartementsrecht")]
        Appartementsrecht = 1,

        /// <summary>
        /// Enum Perceel for value: perceel
        /// </summary>
        [EnumMember(Value = "perceel")]
        Perceel = 2

    }

}
