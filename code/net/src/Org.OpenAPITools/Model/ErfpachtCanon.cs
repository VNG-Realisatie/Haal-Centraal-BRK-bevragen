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
    /// Het bedrag dat een erfpachter moet betalen aan de eigenaar van een stuk grond omdat hij zijn grond gebruikt.   Waardelijst in deze component :   [soortErfpachtCanon](http://www.kadaster.nl/schemas/waardelijsten/SoortErfpachtcanon/) 
    /// </summary>
    [DataContract]
    public partial class ErfpachtCanon :  IEquatable<ErfpachtCanon>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErfpachtCanon" /> class.
        /// </summary>
        /// <param name="soortErfpachtCanon">soortErfpachtCanon.</param>
        /// <param name="jaarlijksBedrag">jaarlijksBedrag.</param>
        /// <param name="betrefMeerOnroerendeZaken">Indicatie waarmee wordt aangegeven dat het jaarlijks bedrag meerdere onroerende zaken betreft. .</param>
        /// <param name="einddatumAfkoop">einddatumAfkoop.</param>
        /// <param name="indicatieOudeOnroerendeZaakBetrokken">Indicatie waarmee wordt aangegeven dat de erfpacht oorspronkelijk gevestigd is bij een perceel dat later is verenigd met een ander perceel. .</param>
        /// <param name="isGebaseerdOpStukdeelIdentificatie">De identificatie van het stukdeel (paragraaf in een akte met een rechtsfeit) waarop deze erfpachtcanon is gebaseerd. .</param>
        /// <param name="isVermeldInStukdeelIdentificaties">De identificaties van de stukdelen (paragrafen in een akte met een rechtsfeit) waarin deze erfpachtcanon is vermeld .</param>
        /// <param name="stukIdentificaties">Identificatie van het stuk. Een stuk is een brondocument dat aanleiding geeft tot een wijziging van de gegevens in een basisregistratie. Dit kan een aangeboden stuk of een kadasterstuk zijn. .</param>
        public ErfpachtCanon(Waardelijst soortErfpachtCanon = default(Waardelijst), Bedrag jaarlijksBedrag = default(Bedrag), bool betrefMeerOnroerendeZaken = default(bool), DateTime einddatumAfkoop = default(DateTime), bool indicatieOudeOnroerendeZaakBetrokken = default(bool), string isGebaseerdOpStukdeelIdentificatie = default(string), List<string> isVermeldInStukdeelIdentificaties = default(List<string>), List<string> stukIdentificaties = default(List<string>))
        {
            this.SoortErfpachtCanon = soortErfpachtCanon;
            this.JaarlijksBedrag = jaarlijksBedrag;
            this.BetrefMeerOnroerendeZaken = betrefMeerOnroerendeZaken;
            this.EinddatumAfkoop = einddatumAfkoop;
            this.IndicatieOudeOnroerendeZaakBetrokken = indicatieOudeOnroerendeZaakBetrokken;
            this.IsGebaseerdOpStukdeelIdentificatie = isGebaseerdOpStukdeelIdentificatie;
            this.IsVermeldInStukdeelIdentificaties = isVermeldInStukdeelIdentificaties;
            this.StukIdentificaties = stukIdentificaties;
        }

        /// <summary>
        /// Gets or Sets SoortErfpachtCanon
        /// </summary>
        [DataMember(Name="soortErfpachtCanon", EmitDefaultValue=false)]
        public Waardelijst SoortErfpachtCanon { get; set; }

        /// <summary>
        /// Gets or Sets JaarlijksBedrag
        /// </summary>
        [DataMember(Name="jaarlijksBedrag", EmitDefaultValue=false)]
        public Bedrag JaarlijksBedrag { get; set; }

        /// <summary>
        /// Indicatie waarmee wordt aangegeven dat het jaarlijks bedrag meerdere onroerende zaken betreft. 
        /// </summary>
        /// <value>Indicatie waarmee wordt aangegeven dat het jaarlijks bedrag meerdere onroerende zaken betreft. </value>
        [DataMember(Name="betrefMeerOnroerendeZaken", EmitDefaultValue=false)]
        public bool BetrefMeerOnroerendeZaken { get; set; }

        /// <summary>
        /// Gets or Sets EinddatumAfkoop
        /// </summary>
        [DataMember(Name="einddatumAfkoop", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime EinddatumAfkoop { get; set; }

        /// <summary>
        /// Indicatie waarmee wordt aangegeven dat de erfpacht oorspronkelijk gevestigd is bij een perceel dat later is verenigd met een ander perceel. 
        /// </summary>
        /// <value>Indicatie waarmee wordt aangegeven dat de erfpacht oorspronkelijk gevestigd is bij een perceel dat later is verenigd met een ander perceel. </value>
        [DataMember(Name="indicatieOudeOnroerendeZaakBetrokken", EmitDefaultValue=false)]
        public bool IndicatieOudeOnroerendeZaakBetrokken { get; set; }

        /// <summary>
        /// De identificatie van het stukdeel (paragraaf in een akte met een rechtsfeit) waarop deze erfpachtcanon is gebaseerd. 
        /// </summary>
        /// <value>De identificatie van het stukdeel (paragraaf in een akte met een rechtsfeit) waarop deze erfpachtcanon is gebaseerd. </value>
        [DataMember(Name="isGebaseerdOpStukdeelIdentificatie", EmitDefaultValue=false)]
        public string IsGebaseerdOpStukdeelIdentificatie { get; set; }

        /// <summary>
        /// De identificaties van de stukdelen (paragrafen in een akte met een rechtsfeit) waarin deze erfpachtcanon is vermeld 
        /// </summary>
        /// <value>De identificaties van de stukdelen (paragrafen in een akte met een rechtsfeit) waarin deze erfpachtcanon is vermeld </value>
        [DataMember(Name="isVermeldInStukdeelIdentificaties", EmitDefaultValue=false)]
        public List<string> IsVermeldInStukdeelIdentificaties { get; set; }

        /// <summary>
        /// Identificatie van het stuk. Een stuk is een brondocument dat aanleiding geeft tot een wijziging van de gegevens in een basisregistratie. Dit kan een aangeboden stuk of een kadasterstuk zijn. 
        /// </summary>
        /// <value>Identificatie van het stuk. Een stuk is een brondocument dat aanleiding geeft tot een wijziging van de gegevens in een basisregistratie. Dit kan een aangeboden stuk of een kadasterstuk zijn. </value>
        [DataMember(Name="stukIdentificaties", EmitDefaultValue=false)]
        public List<string> StukIdentificaties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErfpachtCanon {\n");
            sb.Append("  SoortErfpachtCanon: ").Append(SoortErfpachtCanon).Append("\n");
            sb.Append("  JaarlijksBedrag: ").Append(JaarlijksBedrag).Append("\n");
            sb.Append("  BetrefMeerOnroerendeZaken: ").Append(BetrefMeerOnroerendeZaken).Append("\n");
            sb.Append("  EinddatumAfkoop: ").Append(EinddatumAfkoop).Append("\n");
            sb.Append("  IndicatieOudeOnroerendeZaakBetrokken: ").Append(IndicatieOudeOnroerendeZaakBetrokken).Append("\n");
            sb.Append("  IsGebaseerdOpStukdeelIdentificatie: ").Append(IsGebaseerdOpStukdeelIdentificatie).Append("\n");
            sb.Append("  IsVermeldInStukdeelIdentificaties: ").Append(IsVermeldInStukdeelIdentificaties).Append("\n");
            sb.Append("  StukIdentificaties: ").Append(StukIdentificaties).Append("\n");
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
            return this.Equals(input as ErfpachtCanon);
        }

        /// <summary>
        /// Returns true if ErfpachtCanon instances are equal
        /// </summary>
        /// <param name="input">Instance of ErfpachtCanon to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErfpachtCanon input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SoortErfpachtCanon == input.SoortErfpachtCanon ||
                    (this.SoortErfpachtCanon != null &&
                    this.SoortErfpachtCanon.Equals(input.SoortErfpachtCanon))
                ) && 
                (
                    this.JaarlijksBedrag == input.JaarlijksBedrag ||
                    (this.JaarlijksBedrag != null &&
                    this.JaarlijksBedrag.Equals(input.JaarlijksBedrag))
                ) && 
                (
                    this.BetrefMeerOnroerendeZaken == input.BetrefMeerOnroerendeZaken ||
                    (this.BetrefMeerOnroerendeZaken != null &&
                    this.BetrefMeerOnroerendeZaken.Equals(input.BetrefMeerOnroerendeZaken))
                ) && 
                (
                    this.EinddatumAfkoop == input.EinddatumAfkoop ||
                    (this.EinddatumAfkoop != null &&
                    this.EinddatumAfkoop.Equals(input.EinddatumAfkoop))
                ) && 
                (
                    this.IndicatieOudeOnroerendeZaakBetrokken == input.IndicatieOudeOnroerendeZaakBetrokken ||
                    (this.IndicatieOudeOnroerendeZaakBetrokken != null &&
                    this.IndicatieOudeOnroerendeZaakBetrokken.Equals(input.IndicatieOudeOnroerendeZaakBetrokken))
                ) && 
                (
                    this.IsGebaseerdOpStukdeelIdentificatie == input.IsGebaseerdOpStukdeelIdentificatie ||
                    (this.IsGebaseerdOpStukdeelIdentificatie != null &&
                    this.IsGebaseerdOpStukdeelIdentificatie.Equals(input.IsGebaseerdOpStukdeelIdentificatie))
                ) && 
                (
                    this.IsVermeldInStukdeelIdentificaties == input.IsVermeldInStukdeelIdentificaties ||
                    this.IsVermeldInStukdeelIdentificaties != null &&
                    input.IsVermeldInStukdeelIdentificaties != null &&
                    this.IsVermeldInStukdeelIdentificaties.SequenceEqual(input.IsVermeldInStukdeelIdentificaties)
                ) && 
                (
                    this.StukIdentificaties == input.StukIdentificaties ||
                    this.StukIdentificaties != null &&
                    input.StukIdentificaties != null &&
                    this.StukIdentificaties.SequenceEqual(input.StukIdentificaties)
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
                if (this.SoortErfpachtCanon != null)
                    hashCode = hashCode * 59 + this.SoortErfpachtCanon.GetHashCode();
                if (this.JaarlijksBedrag != null)
                    hashCode = hashCode * 59 + this.JaarlijksBedrag.GetHashCode();
                if (this.BetrefMeerOnroerendeZaken != null)
                    hashCode = hashCode * 59 + this.BetrefMeerOnroerendeZaken.GetHashCode();
                if (this.EinddatumAfkoop != null)
                    hashCode = hashCode * 59 + this.EinddatumAfkoop.GetHashCode();
                if (this.IndicatieOudeOnroerendeZaakBetrokken != null)
                    hashCode = hashCode * 59 + this.IndicatieOudeOnroerendeZaakBetrokken.GetHashCode();
                if (this.IsGebaseerdOpStukdeelIdentificatie != null)
                    hashCode = hashCode * 59 + this.IsGebaseerdOpStukdeelIdentificatie.GetHashCode();
                if (this.IsVermeldInStukdeelIdentificaties != null)
                    hashCode = hashCode * 59 + this.IsVermeldInStukdeelIdentificaties.GetHashCode();
                if (this.StukIdentificaties != null)
                    hashCode = hashCode * 59 + this.StukIdentificaties.GetHashCode();
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
