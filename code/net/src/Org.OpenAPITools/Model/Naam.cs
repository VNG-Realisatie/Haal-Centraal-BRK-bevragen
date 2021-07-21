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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Naam is een groep gegevens met de geslachtsnaam, voorletters en voornamen die men wil gebruiken bij aanschrijving. 
    /// </summary>
    [DataContract]
    public partial class Naam :  IEquatable<Naam>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Naam" /> class.
        /// </summary>
        /// <param name="geslachtsnaam">De geslachtsnaam is de (achter)naam waarvan eventuele voorvoegsels en adellijke titel zijn afgesplitst. .</param>
        /// <param name="voornamen">De voornamen zijn de verzameling namen die, gescheiden door spaties, aan de geslachtsnaam voorafgaat. Indien aanwezig, wordt het predikaat afgesplitst. .</param>
        /// <param name="voorvoegsel">Voorvoegselsgeslachtsnaam is het deel van de geslachtsnaam dat, gescheiden door een spatie, vooraf gaat aan de rest van de geslachtsnaam. .</param>
        public Naam(string geslachtsnaam = default(string), string voornamen = default(string), string voorvoegsel = default(string))
        {
            this.Geslachtsnaam = geslachtsnaam;
            this.Voornamen = voornamen;
            this.Voorvoegsel = voorvoegsel;
        }

        /// <summary>
        /// De geslachtsnaam is de (achter)naam waarvan eventuele voorvoegsels en adellijke titel zijn afgesplitst. 
        /// </summary>
        /// <value>De geslachtsnaam is de (achter)naam waarvan eventuele voorvoegsels en adellijke titel zijn afgesplitst. </value>
        [DataMember(Name="geslachtsnaam", EmitDefaultValue=false)]
        public string Geslachtsnaam { get; set; }

        /// <summary>
        /// De voornamen zijn de verzameling namen die, gescheiden door spaties, aan de geslachtsnaam voorafgaat. Indien aanwezig, wordt het predikaat afgesplitst. 
        /// </summary>
        /// <value>De voornamen zijn de verzameling namen die, gescheiden door spaties, aan de geslachtsnaam voorafgaat. Indien aanwezig, wordt het predikaat afgesplitst. </value>
        [DataMember(Name="voornamen", EmitDefaultValue=false)]
        public string Voornamen { get; set; }

        /// <summary>
        /// Voorvoegselsgeslachtsnaam is het deel van de geslachtsnaam dat, gescheiden door een spatie, vooraf gaat aan de rest van de geslachtsnaam. 
        /// </summary>
        /// <value>Voorvoegselsgeslachtsnaam is het deel van de geslachtsnaam dat, gescheiden door een spatie, vooraf gaat aan de rest van de geslachtsnaam. </value>
        [DataMember(Name="voorvoegsel", EmitDefaultValue=false)]
        public string Voorvoegsel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Naam {\n");
            sb.Append("  Geslachtsnaam: ").Append(Geslachtsnaam).Append("\n");
            sb.Append("  Voornamen: ").Append(Voornamen).Append("\n");
            sb.Append("  Voorvoegsel: ").Append(Voorvoegsel).Append("\n");
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
            return this.Equals(input as Naam);
        }

        /// <summary>
        /// Returns true if Naam instances are equal
        /// </summary>
        /// <param name="input">Instance of Naam to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Naam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Geslachtsnaam == input.Geslachtsnaam ||
                    (this.Geslachtsnaam != null &&
                    this.Geslachtsnaam.Equals(input.Geslachtsnaam))
                ) && 
                (
                    this.Voornamen == input.Voornamen ||
                    (this.Voornamen != null &&
                    this.Voornamen.Equals(input.Voornamen))
                ) && 
                (
                    this.Voorvoegsel == input.Voorvoegsel ||
                    (this.Voorvoegsel != null &&
                    this.Voorvoegsel.Equals(input.Voorvoegsel))
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
                if (this.Geslachtsnaam != null)
                    hashCode = hashCode * 59 + this.Geslachtsnaam.GetHashCode();
                if (this.Voornamen != null)
                    hashCode = hashCode * 59 + this.Voornamen.GetHashCode();
                if (this.Voorvoegsel != null)
                    hashCode = hashCode * 59 + this.Voorvoegsel.GetHashCode();
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
