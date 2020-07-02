using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Het bedrag dat een erfpachter moet betalen aan de eigenaar van een stuk grond omdat hij zijn grond gebruikt.  Waardelijst in deze component : [soortErfpachtCanon](http://www.kadaster.nl/schemas/waardelijsten/SoortErfpachtcanon/)
  /// </summary>
  [DataContract]
  public class ErfpachtCanon {
    /// <summary>
    /// Gets or Sets SoortErfpachtCanon
    /// </summary>
    [DataMember(Name="soortErfpachtCanon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "soortErfpachtCanon")]
    public Waardelijst SoortErfpachtCanon { get; set; }

    /// <summary>
    /// Gets or Sets JaarlijksBedrag
    /// </summary>
    [DataMember(Name="jaarlijksBedrag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jaarlijksBedrag")]
    public Bedrag JaarlijksBedrag { get; set; }

    /// <summary>
    /// Gets or Sets BetrefMeerOnroerendeZaken
    /// </summary>
    [DataMember(Name="betrefMeerOnroerendeZaken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "betrefMeerOnroerendeZaken")]
    public bool? BetrefMeerOnroerendeZaken { get; set; }

    /// <summary>
    /// Gets or Sets EinddatumAfkoop
    /// </summary>
    [DataMember(Name="einddatumAfkoop", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "einddatumAfkoop")]
    public DateTime? EinddatumAfkoop { get; set; }

    /// <summary>
    /// Gets or Sets IndicatieOudeOnroerendeZaakBetrokken
    /// </summary>
    [DataMember(Name="indicatieOudeOnroerendeZaakBetrokken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "indicatieOudeOnroerendeZaakBetrokken")]
    public bool? IndicatieOudeOnroerendeZaakBetrokken { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ErfpachtCanon {\n");
      sb.Append("  SoortErfpachtCanon: ").Append(SoortErfpachtCanon).Append("\n");
      sb.Append("  JaarlijksBedrag: ").Append(JaarlijksBedrag).Append("\n");
      sb.Append("  BetrefMeerOnroerendeZaken: ").Append(BetrefMeerOnroerendeZaken).Append("\n");
      sb.Append("  EinddatumAfkoop: ").Append(EinddatumAfkoop).Append("\n");
      sb.Append("  IndicatieOudeOnroerendeZaakBetrokken: ").Append(IndicatieOudeOnroerendeZaakBetrokken).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
