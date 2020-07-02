using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class KadasterNatuurlijkPersoon : KadasterPersoon {
    /// <summary>
    /// Aanduiding die aangeeft dat gegevens van een persoon wel of niet verstrekt mogen worden.
    /// </summary>
    /// <value>Aanduiding die aangeeft dat gegevens van een persoon wel of niet verstrekt mogen worden.</value>
    [DataMember(Name="geheimhoudingPersoonsgegevens", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "geheimhoudingPersoonsgegevens")]
    public bool? GeheimhoudingPersoonsgegevens { get; set; }

    /// <summary>
    /// Gets or Sets LandWaarnaarVertrokken
    /// </summary>
    [DataMember(Name="landWaarnaarVertrokken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "landWaarnaarVertrokken")]
    public Waardelijst LandWaarnaarVertrokken { get; set; }

    /// <summary>
    /// Gets or Sets Geslachtsaanduiding
    /// </summary>
    [DataMember(Name="geslachtsaanduiding", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "geslachtsaanduiding")]
    public GeslachtEnum Geslachtsaanduiding { get; set; }

    /// <summary>
    /// Gets or Sets HeeftPartnerschap
    /// </summary>
    [DataMember(Name="heeftPartnerschap", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "heeftPartnerschap")]
    public List<HeeftPartnerschap> HeeftPartnerschap { get; set; }

    /// <summary>
    /// Gets or Sets Naam
    /// </summary>
    [DataMember(Name="naam", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "naam")]
    public Naam Naam { get; set; }

    /// <summary>
    /// Gets or Sets Geboorte
    /// </summary>
    [DataMember(Name="geboorte", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "geboorte")]
    public Geboorte Geboorte { get; set; }

    /// <summary>
    /// Gets or Sets Overlijden
    /// </summary>
    [DataMember(Name="overlijden", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "overlijden")]
    public Overlijden Overlijden { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class KadasterNatuurlijkPersoon {\n");
      sb.Append("  GeheimhoudingPersoonsgegevens: ").Append(GeheimhoudingPersoonsgegevens).Append("\n");
      sb.Append("  LandWaarnaarVertrokken: ").Append(LandWaarnaarVertrokken).Append("\n");
      sb.Append("  Geslachtsaanduiding: ").Append(Geslachtsaanduiding).Append("\n");
      sb.Append("  HeeftPartnerschap: ").Append(HeeftPartnerschap).Append("\n");
      sb.Append("  Naam: ").Append(Naam).Append("\n");
      sb.Append("  Geboorte: ").Append(Geboorte).Append("\n");
      sb.Append("  Overlijden: ").Append(Overlijden).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public  new string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
