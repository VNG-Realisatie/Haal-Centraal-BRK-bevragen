/*
 * Kadaster - BRK-Bevragen API
 *
 * D.m.v. deze toepassing worden meerdere, korte bevragingen op de Basis Registratie Kadaster beschikbaar gesteld. Deze toepassing betreft het verstrekken van Kadastrale Onroerende Zaak informatie. 
 *
 * The version of the OpenAPI document: 1.3.0
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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// KadastraalOnroerendeZaakFiliatie
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(PerceelFiliatie), "PerceelFiliatie")]
    [JsonSubtypes.KnownSubType(typeof(AppartementsrechtFiliatie), "AppartementsrechtFiliatie")]
    public partial class KadastraalOnroerendeZaakFiliatie :  IEquatable<KadastraalOnroerendeZaakFiliatie>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeKadastraalOnroerendeZaakEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KadastraalOnroerendeZaakFiliatie" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KadastraalOnroerendeZaakFiliatie() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KadastraalOnroerendeZaakFiliatie" /> class.
        /// </summary>
        /// <param name="identificatie">De identificatie van de Kadastraal Onroerende Zaak. .</param>
        /// <param name="type">type (required).</param>
        public KadastraalOnroerendeZaakFiliatie(string identificatie = default(string), TypeKadastraalOnroerendeZaakEnum type = default(TypeKadastraalOnroerendeZaakEnum))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for KadastraalOnroerendeZaakFiliatie and cannot be null");
            }
            else
            {
                this.Type = type;
            }

            this.Identificatie = identificatie;
        }

        /// <summary>
        /// De identificatie van de Kadastraal Onroerende Zaak. 
        /// </summary>
        /// <value>De identificatie van de Kadastraal Onroerende Zaak. </value>
        [DataMember(Name="identificatie", EmitDefaultValue=false)]
        public string Identificatie { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KadastraalOnroerendeZaakFiliatie {\n");
            sb.Append("  Identificatie: ").Append(Identificatie).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as KadastraalOnroerendeZaakFiliatie);
        }

        /// <summary>
        /// Returns true if KadastraalOnroerendeZaakFiliatie instances are equal
        /// </summary>
        /// <param name="input">Instance of KadastraalOnroerendeZaakFiliatie to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KadastraalOnroerendeZaakFiliatie input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Identificatie == input.Identificatie ||
                    (this.Identificatie != null &&
                    this.Identificatie.Equals(input.Identificatie))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                int hashCode = 41;
                if (this.Identificatie != null)
                    hashCode = hashCode * 59 + this.Identificatie.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
            yield break;
        }
    }

}
