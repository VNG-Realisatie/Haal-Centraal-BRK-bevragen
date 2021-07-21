/*
 * Kadaster - BRK-Bevragen API
 *
 * D.m.v. deze toepassing worden meerdere, korte bevragingen op de Basis Registratie Kadaster beschikbaar gesteld. Deze toepassing betreft het verstrekken van Kadastrale Onroerende Zaak informatie. 
 *
 * The version of the OpenAPI document: 1.3.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// PerceelFiliatie
    /// </summary>
    [DataContract(Name = "PerceelFiliatie")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(AppartementsrechtFiliatie), "appartementsrecht")]
    [JsonSubtypes.KnownSubType(typeof(PerceelFiliatie), "perceel")]
    public partial class PerceelFiliatie : KadastraalOnroerendeZaakFiliatie, IEquatable<PerceelFiliatie>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PerceelFiliatie" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PerceelFiliatie() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PerceelFiliatie" /> class.
        /// </summary>
        /// <param name="indicatieVervallen">Geeft aan of de filiatie verwijst naar een vervallen kadastraal onroerende zaak. .</param>
        /// <param name="identificatie">De identificatie van de Kadastraal Onroerende Zaak. .</param>
        /// <param name="type">type (required) (default to &quot;PerceelFiliatie&quot;).</param>
        public PerceelFiliatie(bool indicatieVervallen = default(bool), string identificatie = default(string), TypeKadastraalOnroerendeZaakEnum type = "PerceelFiliatie") : base(identificatie, type)
        {
            this.IndicatieVervallen = indicatieVervallen;
        }

        /// <summary>
        /// Geeft aan of de filiatie verwijst naar een vervallen kadastraal onroerende zaak. 
        /// </summary>
        /// <value>Geeft aan of de filiatie verwijst naar een vervallen kadastraal onroerende zaak. </value>
        [DataMember(Name = "indicatieVervallen", EmitDefaultValue = true)]
        public bool IndicatieVervallen { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PerceelFiliatie {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  IndicatieVervallen: ").Append(IndicatieVervallen).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PerceelFiliatie);
        }

        /// <summary>
        /// Returns true if PerceelFiliatie instances are equal
        /// </summary>
        /// <param name="input">Instance of PerceelFiliatie to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PerceelFiliatie input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.IndicatieVervallen == input.IndicatieVervallen ||
                    this.IndicatieVervallen.Equals(input.IndicatieVervallen)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                hashCode = hashCode * 59 + this.IndicatieVervallen.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}
