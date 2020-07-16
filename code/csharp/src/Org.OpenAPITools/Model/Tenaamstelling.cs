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
    /// Een registratie van (een aandeel in) een zakelijk recht dat een persoon heeft, dat rust op een kadastraal onroerende zaak.  Waardelijst in deze component : [burgerlijkeStaatTenTijdeVanVerkrijging](http://www.kadaster.nl/schemas/waardelijsten/BurgerlijkeStaat/) en [verkregenNamensSamenwerkingsverband](http://www.kadaster.nl/schemas/waardelijsten/Samenwerkingsverband/)
    /// </summary>
    [DataContract]
    public partial class Tenaamstelling :  IEquatable<Tenaamstelling>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tenaamstelling" /> class.
        /// </summary>
        /// <param name="aandeel">aandeel.</param>
        /// <param name="burgerlijkeStaatTenTijdeVanVerkrijging">burgerlijkeStaatTenTijdeVanVerkrijging.</param>
        /// <param name="verkregenNamensSamenwerkingsverband">verkregenNamensSamenwerkingsverband.</param>
        /// <param name="aantekeningen">Een aantekening is een verwijzing naar een ter inschrijving aangeboden stuk. Een aantekening op een tenaamstelling van een zakelijk recht is meestal een beperking. Bijvoorbeeld de verkrijging van een aandeel in een zakelijk recht onder opschortende voorwaarde, een beperking van de handelingsbevoegdheid van de zakelijk gerechtigde, of een koopovereenkomst.</param>
        /// <param name="gezamenlijkAandeel">gezamenlijkAandeel.</param>
        /// <param name="betrokkenPartner">betrokkenPartner.</param>
        /// <param name="betrokkenSamenwerkingsverband">betrokkenSamenwerkingsverband.</param>
        /// <param name="betrokkenGorzenEnAanwassen">betrokkenGorzenEnAanwassen.</param>
        public Tenaamstelling(TypeBreuk aandeel = default(TypeBreuk), Waardelijst burgerlijkeStaatTenTijdeVanVerkrijging = default(Waardelijst), Waardelijst verkregenNamensSamenwerkingsverband = default(Waardelijst), List<Aantekening> aantekeningen = default(List<Aantekening>), TypeBreuk gezamenlijkAandeel = default(TypeBreuk), NatuurlijkPersoonBeperkt betrokkenPartner = default(NatuurlijkPersoonBeperkt), NietNatuurlijkPersoonBeperkt betrokkenSamenwerkingsverband = default(NietNatuurlijkPersoonBeperkt), NietNatuurlijkPersoonBeperkt betrokkenGorzenEnAanwassen = default(NietNatuurlijkPersoonBeperkt))
        {
            this.Aandeel = aandeel;
            this.BurgerlijkeStaatTenTijdeVanVerkrijging = burgerlijkeStaatTenTijdeVanVerkrijging;
            this.VerkregenNamensSamenwerkingsverband = verkregenNamensSamenwerkingsverband;
            this.Aantekeningen = aantekeningen;
            this.GezamenlijkAandeel = gezamenlijkAandeel;
            this.BetrokkenPartner = betrokkenPartner;
            this.BetrokkenSamenwerkingsverband = betrokkenSamenwerkingsverband;
            this.BetrokkenGorzenEnAanwassen = betrokkenGorzenEnAanwassen;
        }
        
        /// <summary>
        /// Gets or Sets Aandeel
        /// </summary>
        [DataMember(Name="aandeel", EmitDefaultValue=false)]
        public TypeBreuk Aandeel { get; set; }

        /// <summary>
        /// Gets or Sets BurgerlijkeStaatTenTijdeVanVerkrijging
        /// </summary>
        [DataMember(Name="burgerlijkeStaatTenTijdeVanVerkrijging", EmitDefaultValue=false)]
        public Waardelijst BurgerlijkeStaatTenTijdeVanVerkrijging { get; set; }

        /// <summary>
        /// Gets or Sets VerkregenNamensSamenwerkingsverband
        /// </summary>
        [DataMember(Name="verkregenNamensSamenwerkingsverband", EmitDefaultValue=false)]
        public Waardelijst VerkregenNamensSamenwerkingsverband { get; set; }

        /// <summary>
        /// Een aantekening is een verwijzing naar een ter inschrijving aangeboden stuk. Een aantekening op een tenaamstelling van een zakelijk recht is meestal een beperking. Bijvoorbeeld de verkrijging van een aandeel in een zakelijk recht onder opschortende voorwaarde, een beperking van de handelingsbevoegdheid van de zakelijk gerechtigde, of een koopovereenkomst
        /// </summary>
        /// <value>Een aantekening is een verwijzing naar een ter inschrijving aangeboden stuk. Een aantekening op een tenaamstelling van een zakelijk recht is meestal een beperking. Bijvoorbeeld de verkrijging van een aandeel in een zakelijk recht onder opschortende voorwaarde, een beperking van de handelingsbevoegdheid van de zakelijk gerechtigde, of een koopovereenkomst</value>
        [DataMember(Name="aantekeningen", EmitDefaultValue=false)]
        public List<Aantekening> Aantekeningen { get; set; }

        /// <summary>
        /// Gets or Sets GezamenlijkAandeel
        /// </summary>
        [DataMember(Name="gezamenlijkAandeel", EmitDefaultValue=false)]
        public TypeBreuk GezamenlijkAandeel { get; set; }

        /// <summary>
        /// Gets or Sets BetrokkenPartner
        /// </summary>
        [DataMember(Name="betrokkenPartner", EmitDefaultValue=false)]
        public NatuurlijkPersoonBeperkt BetrokkenPartner { get; set; }

        /// <summary>
        /// Gets or Sets BetrokkenSamenwerkingsverband
        /// </summary>
        [DataMember(Name="betrokkenSamenwerkingsverband", EmitDefaultValue=false)]
        public NietNatuurlijkPersoonBeperkt BetrokkenSamenwerkingsverband { get; set; }

        /// <summary>
        /// Gets or Sets BetrokkenGorzenEnAanwassen
        /// </summary>
        [DataMember(Name="betrokkenGorzenEnAanwassen", EmitDefaultValue=false)]
        public NietNatuurlijkPersoonBeperkt BetrokkenGorzenEnAanwassen { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Tenaamstelling {\n");
            sb.Append("  Aandeel: ").Append(Aandeel).Append("\n");
            sb.Append("  BurgerlijkeStaatTenTijdeVanVerkrijging: ").Append(BurgerlijkeStaatTenTijdeVanVerkrijging).Append("\n");
            sb.Append("  VerkregenNamensSamenwerkingsverband: ").Append(VerkregenNamensSamenwerkingsverband).Append("\n");
            sb.Append("  Aantekeningen: ").Append(Aantekeningen).Append("\n");
            sb.Append("  GezamenlijkAandeel: ").Append(GezamenlijkAandeel).Append("\n");
            sb.Append("  BetrokkenPartner: ").Append(BetrokkenPartner).Append("\n");
            sb.Append("  BetrokkenSamenwerkingsverband: ").Append(BetrokkenSamenwerkingsverband).Append("\n");
            sb.Append("  BetrokkenGorzenEnAanwassen: ").Append(BetrokkenGorzenEnAanwassen).Append("\n");
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
            return this.Equals(input as Tenaamstelling);
        }

        /// <summary>
        /// Returns true if Tenaamstelling instances are equal
        /// </summary>
        /// <param name="input">Instance of Tenaamstelling to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tenaamstelling input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Aandeel == input.Aandeel ||
                    (this.Aandeel != null &&
                    this.Aandeel.Equals(input.Aandeel))
                ) && 
                (
                    this.BurgerlijkeStaatTenTijdeVanVerkrijging == input.BurgerlijkeStaatTenTijdeVanVerkrijging ||
                    (this.BurgerlijkeStaatTenTijdeVanVerkrijging != null &&
                    this.BurgerlijkeStaatTenTijdeVanVerkrijging.Equals(input.BurgerlijkeStaatTenTijdeVanVerkrijging))
                ) && 
                (
                    this.VerkregenNamensSamenwerkingsverband == input.VerkregenNamensSamenwerkingsverband ||
                    (this.VerkregenNamensSamenwerkingsverband != null &&
                    this.VerkregenNamensSamenwerkingsverband.Equals(input.VerkregenNamensSamenwerkingsverband))
                ) && 
                (
                    this.Aantekeningen == input.Aantekeningen ||
                    this.Aantekeningen != null &&
                    input.Aantekeningen != null &&
                    this.Aantekeningen.SequenceEqual(input.Aantekeningen)
                ) && 
                (
                    this.GezamenlijkAandeel == input.GezamenlijkAandeel ||
                    (this.GezamenlijkAandeel != null &&
                    this.GezamenlijkAandeel.Equals(input.GezamenlijkAandeel))
                ) && 
                (
                    this.BetrokkenPartner == input.BetrokkenPartner ||
                    (this.BetrokkenPartner != null &&
                    this.BetrokkenPartner.Equals(input.BetrokkenPartner))
                ) && 
                (
                    this.BetrokkenSamenwerkingsverband == input.BetrokkenSamenwerkingsverband ||
                    (this.BetrokkenSamenwerkingsverband != null &&
                    this.BetrokkenSamenwerkingsverband.Equals(input.BetrokkenSamenwerkingsverband))
                ) && 
                (
                    this.BetrokkenGorzenEnAanwassen == input.BetrokkenGorzenEnAanwassen ||
                    (this.BetrokkenGorzenEnAanwassen != null &&
                    this.BetrokkenGorzenEnAanwassen.Equals(input.BetrokkenGorzenEnAanwassen))
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
                if (this.Aandeel != null)
                    hashCode = hashCode * 59 + this.Aandeel.GetHashCode();
                if (this.BurgerlijkeStaatTenTijdeVanVerkrijging != null)
                    hashCode = hashCode * 59 + this.BurgerlijkeStaatTenTijdeVanVerkrijging.GetHashCode();
                if (this.VerkregenNamensSamenwerkingsverband != null)
                    hashCode = hashCode * 59 + this.VerkregenNamensSamenwerkingsverband.GetHashCode();
                if (this.Aantekeningen != null)
                    hashCode = hashCode * 59 + this.Aantekeningen.GetHashCode();
                if (this.GezamenlijkAandeel != null)
                    hashCode = hashCode * 59 + this.GezamenlijkAandeel.GetHashCode();
                if (this.BetrokkenPartner != null)
                    hashCode = hashCode * 59 + this.BetrokkenPartner.GetHashCode();
                if (this.BetrokkenSamenwerkingsverband != null)
                    hashCode = hashCode * 59 + this.BetrokkenSamenwerkingsverband.GetHashCode();
                if (this.BetrokkenGorzenEnAanwassen != null)
                    hashCode = hashCode * 59 + this.BetrokkenGorzenEnAanwassen.GetHashCode();
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
