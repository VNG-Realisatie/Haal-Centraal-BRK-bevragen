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
    /// Geboorte is een groep gegevens over de geboorte van een persoon.  Waardelijst in deze component : [land](http://www.kadaster.nl/schemas/waardelijsten/BRPLand/)
    /// </summary>
    [DataContract]
    public partial class Geboorte :  IEquatable<Geboorte>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Geboorte" /> class.
        /// </summary>
        /// <param name="plaats">De geboorteplaats is de plaats of een plaatsbepaling, die aangeeft waar de persoon is geboren.</param>
        /// <param name="datum">datum.</param>
        /// <param name="land">land.</param>
        public Geboorte(string plaats = default(string), DatumOnvolledig datum = default(DatumOnvolledig), Waardelijst land = default(Waardelijst))
        {
            this.Plaats = plaats;
            this.Datum = datum;
            this.Land = land;
        }
        
        /// <summary>
        /// De geboorteplaats is de plaats of een plaatsbepaling, die aangeeft waar de persoon is geboren
        /// </summary>
        /// <value>De geboorteplaats is de plaats of een plaatsbepaling, die aangeeft waar de persoon is geboren</value>
        [DataMember(Name="plaats", EmitDefaultValue=false)]
        public string Plaats { get; set; }

        /// <summary>
        /// Gets or Sets Datum
        /// </summary>
        [DataMember(Name="datum", EmitDefaultValue=false)]
        public DatumOnvolledig Datum { get; set; }

        /// <summary>
        /// Gets or Sets Land
        /// </summary>
        [DataMember(Name="land", EmitDefaultValue=false)]
        public Waardelijst Land { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Geboorte {\n");
            sb.Append("  Plaats: ").Append(Plaats).Append("\n");
            sb.Append("  Datum: ").Append(Datum).Append("\n");
            sb.Append("  Land: ").Append(Land).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Geboorte);
        }

        /// <summary>
        /// Returns true if Geboorte instances are equal
        /// </summary>
        /// <param name="input">Instance of Geboorte to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Geboorte input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Plaats == input.Plaats ||
                    (this.Plaats != null &&
                    this.Plaats.Equals(input.Plaats))
                ) && 
                (
                    this.Datum == input.Datum ||
                    (this.Datum != null &&
                    this.Datum.Equals(input.Datum))
                ) && 
                (
                    this.Land == input.Land ||
                    (this.Land != null &&
                    this.Land.Equals(input.Land))
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
                if (this.Plaats != null)
                    hashCode = hashCode * 59 + this.Plaats.GetHashCode();
                if (this.Datum != null)
                    hashCode = hashCode * 59 + this.Datum.GetHashCode();
                if (this.Land != null)
                    hashCode = hashCode * 59 + this.Land.GetHashCode();
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
            yield break;
        }
    }

}
