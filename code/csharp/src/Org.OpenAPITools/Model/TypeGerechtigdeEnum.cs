/* 
 * Kadaster - BRK-Bevragen API
 *
 * D.m.v. deze toepassing worden meerdere, korte bevragingen op de Basis Registratie Kadaster beschikbaar gesteld. Deze toepassing betreft het verstrekken van Kadastrale Onroerende Zaak informatie.
 *
 * The version of the OpenAPI document: 1.1.0
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
    /// Het type zakelijk recht dat deze gerechtigde heeft. Afgeleid van de aard zakelijk recht:  * &#x60;beklemrechthouder&#x60; - 1 Beklemrechthouder  * &#x60;eigenaar&#x60; - 2 Eigenaar  * &#x60;erfpachter&#x60; - 3 Erfpachter  * &#x60;gebruik_bewoning&#x60; - 4 Rechthebbende van Gebruik en bewoning  * &#x60;grondrente&#x60; - 5 Grondrente gerechtigde  * &#x60;opstalhouder&#x60; - 7 Opstalhouder  * &#x60;vaderlandsrecht&#x60; - 9 Rechthebbende van Oud-vaderlandsrecht  * &#x60;stadsmeierrecht&#x60; - 11 Rechthebbende van Stadsmeierrecht  * &#x60;vruchtgebruiker&#x60; - 12 Vruchtgebruiker  * &#x60;erfpachter_opstalhouder&#x60; - 13 Erfpachter en opstalhouder  * &#x60;nutsvoorzieningen&#x60; - 14 Opstalhouder nutsvoorzieningen  * &#x60;twee_belastingen&#x60; - 20 Zakelijk Rechthebbende na twee of meer zakelijke belastingen  * &#x60;belasting_derde&#x60; - 21 Zakelijk rechthebbende belasting derde of volgende  * &#x60;bp_recht&#x60; - 22 BP-gerechtigde  * &#x60;nutsvoorzieningen_gedeelte&#x60; - 23 Opstalhouder Nutsvoorzieningen op gedeelte van perceel  * &#x60;artikel5_3b&#x60; - 24 Zakelijk gerechtigde als bedoeld in artikel 5, lid 3, onder b, van de Belemmeringenwet Privaatrecht op gedeelte van perceel
    /// </summary>
    /// <value>Het type zakelijk recht dat deze gerechtigde heeft. Afgeleid van de aard zakelijk recht:  * &#x60;beklemrechthouder&#x60; - 1 Beklemrechthouder  * &#x60;eigenaar&#x60; - 2 Eigenaar  * &#x60;erfpachter&#x60; - 3 Erfpachter  * &#x60;gebruik_bewoning&#x60; - 4 Rechthebbende van Gebruik en bewoning  * &#x60;grondrente&#x60; - 5 Grondrente gerechtigde  * &#x60;opstalhouder&#x60; - 7 Opstalhouder  * &#x60;vaderlandsrecht&#x60; - 9 Rechthebbende van Oud-vaderlandsrecht  * &#x60;stadsmeierrecht&#x60; - 11 Rechthebbende van Stadsmeierrecht  * &#x60;vruchtgebruiker&#x60; - 12 Vruchtgebruiker  * &#x60;erfpachter_opstalhouder&#x60; - 13 Erfpachter en opstalhouder  * &#x60;nutsvoorzieningen&#x60; - 14 Opstalhouder nutsvoorzieningen  * &#x60;twee_belastingen&#x60; - 20 Zakelijk Rechthebbende na twee of meer zakelijke belastingen  * &#x60;belasting_derde&#x60; - 21 Zakelijk rechthebbende belasting derde of volgende  * &#x60;bp_recht&#x60; - 22 BP-gerechtigde  * &#x60;nutsvoorzieningen_gedeelte&#x60; - 23 Opstalhouder Nutsvoorzieningen op gedeelte van perceel  * &#x60;artikel5_3b&#x60; - 24 Zakelijk gerechtigde als bedoeld in artikel 5, lid 3, onder b, van de Belemmeringenwet Privaatrecht op gedeelte van perceel</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TypeGerechtigdeEnum
    {
        /// <summary>
        /// Enum Beklemrechthouder for value: beklemrechthouder
        /// </summary>
        [EnumMember(Value = "beklemrechthouder")]
        Beklemrechthouder = 1,

        /// <summary>
        /// Enum Eigenaar for value: eigenaar
        /// </summary>
        [EnumMember(Value = "eigenaar")]
        Eigenaar = 2,

        /// <summary>
        /// Enum Erfpachter for value: erfpachter
        /// </summary>
        [EnumMember(Value = "erfpachter")]
        Erfpachter = 3,

        /// <summary>
        /// Enum Gebruikbewoning for value: gebruik_bewoning
        /// </summary>
        [EnumMember(Value = "gebruik_bewoning")]
        Gebruikbewoning = 4,

        /// <summary>
        /// Enum Grondrente for value: grondrente
        /// </summary>
        [EnumMember(Value = "grondrente")]
        Grondrente = 5,

        /// <summary>
        /// Enum Opstalhouder for value: opstalhouder
        /// </summary>
        [EnumMember(Value = "opstalhouder")]
        Opstalhouder = 6,

        /// <summary>
        /// Enum Vaderlandsrecht for value: vaderlandsrecht
        /// </summary>
        [EnumMember(Value = "vaderlandsrecht")]
        Vaderlandsrecht = 7,

        /// <summary>
        /// Enum Stadsmeierrecht for value: stadsmeierrecht
        /// </summary>
        [EnumMember(Value = "stadsmeierrecht")]
        Stadsmeierrecht = 8,

        /// <summary>
        /// Enum Vruchtgebruiker for value: vruchtgebruiker
        /// </summary>
        [EnumMember(Value = "vruchtgebruiker")]
        Vruchtgebruiker = 9,

        /// <summary>
        /// Enum Erfpachteropstalhouder for value: erfpachter_opstalhouder
        /// </summary>
        [EnumMember(Value = "erfpachter_opstalhouder")]
        Erfpachteropstalhouder = 10,

        /// <summary>
        /// Enum Nutsvoorzieningen for value: nutsvoorzieningen
        /// </summary>
        [EnumMember(Value = "nutsvoorzieningen")]
        Nutsvoorzieningen = 11,

        /// <summary>
        /// Enum Tweebelastingen for value: twee_belastingen
        /// </summary>
        [EnumMember(Value = "twee_belastingen")]
        Tweebelastingen = 12,

        /// <summary>
        /// Enum Belastingderde for value: belasting_derde
        /// </summary>
        [EnumMember(Value = "belasting_derde")]
        Belastingderde = 13,

        /// <summary>
        /// Enum Bprecht for value: bp_recht
        /// </summary>
        [EnumMember(Value = "bp_recht")]
        Bprecht = 14,

        /// <summary>
        /// Enum Nutsvoorzieningengedeelte for value: nutsvoorzieningen_gedeelte
        /// </summary>
        [EnumMember(Value = "nutsvoorzieningen_gedeelte")]
        Nutsvoorzieningengedeelte = 15,

        /// <summary>
        /// Enum Artikel53b for value: artikel5_3b
        /// </summary>
        [EnumMember(Value = "artikel5_3b")]
        Artikel53b = 16

    }

}
