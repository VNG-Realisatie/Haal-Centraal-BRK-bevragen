using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Partnerschap is een groep gegevens over de huwelijkse- of partnerschapstatus van een persoon.
  /// </summary>
  [DataContract]
  public class HeeftPartnerschap {
    /// <summary>
    /// Gets or Sets DatumOntbinding
    /// </summary>
    [DataMember(Name="datumOntbinding", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "datumOntbinding")]
    public DatumOnvolledig DatumOntbinding { get; set; }

    /// <summary>
    /// Gets or Sets DatumSluiting
    /// </summary>
    [DataMember(Name="datumSluiting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "datumSluiting")]
    public DatumOnvolledig DatumSluiting { get; set; }

    /// <summary>
    /// Gets or Sets Naam
    /// </summary>
    [DataMember(Name="naam", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "naam")]
    public Naam Naam { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class HeeftPartnerschap {\n");
      sb.Append("  DatumOntbinding: ").Append(DatumOntbinding).Append("\n");
      sb.Append("  DatumSluiting: ").Append(DatumSluiting).Append("\n");
      sb.Append("  Naam: ").Append(Naam).Append("\n");
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
