using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Waardelijst in deze component : [aard](http://www.kadaster.nl/schemas/waardelijsten/AardAantekening/)
  /// </summary>
  [DataContract]
  public class Aantekening {
    /// <summary>
    /// Gets or Sets Identificatie
    /// </summary>
    [DataMember(Name="identificatie", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "identificatie")]
    public string Identificatie { get; set; }

    /// <summary>
    /// Het domein waartoe de identificatie behoort.
    /// </summary>
    /// <value>Het domein waartoe de identificatie behoort.</value>
    [DataMember(Name="domein", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "domein")]
    public string Domein { get; set; }

    /// <summary>
    /// Gets or Sets Aard
    /// </summary>
    [DataMember(Name="aard", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "aard")]
    public Waardelijst Aard { get; set; }

    /// <summary>
    /// Gets or Sets Omschrijving
    /// </summary>
    [DataMember(Name="omschrijving", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "omschrijving")]
    public string Omschrijving { get; set; }

    /// <summary>
    /// Gets or Sets Begrenzing
    /// </summary>
    [DataMember(Name="begrenzing", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "begrenzing")]
    public PolygonGeoJSON Begrenzing { get; set; }

    /// <summary>
    /// Gets or Sets Einddatum
    /// </summary>
    [DataMember(Name="einddatum", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "einddatum")]
    public DateTime? Einddatum { get; set; }

    /// <summary>
    /// Gets or Sets EinddatumRecht
    /// </summary>
    [DataMember(Name="einddatumRecht", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "einddatumRecht")]
    public DateTime? EinddatumRecht { get; set; }

    /// <summary>
    /// Gets or Sets IndicatieOorspronkelijkObject
    /// </summary>
    [DataMember(Name="indicatieOorspronkelijkObject", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "indicatieOorspronkelijkObject")]
    public bool? IndicatieOorspronkelijkObject { get; set; }

    /// <summary>
    /// Gets or Sets BetreftGedeelteVanPerceel
    /// </summary>
    [DataMember(Name="betreftGedeelteVanPerceel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "betreftGedeelteVanPerceel")]
    public bool? BetreftGedeelteVanPerceel { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Aantekening {\n");
      sb.Append("  Identificatie: ").Append(Identificatie).Append("\n");
      sb.Append("  Domein: ").Append(Domein).Append("\n");
      sb.Append("  Aard: ").Append(Aard).Append("\n");
      sb.Append("  Omschrijving: ").Append(Omschrijving).Append("\n");
      sb.Append("  Begrenzing: ").Append(Begrenzing).Append("\n");
      sb.Append("  Einddatum: ").Append(Einddatum).Append("\n");
      sb.Append("  EinddatumRecht: ").Append(EinddatumRecht).Append("\n");
      sb.Append("  IndicatieOorspronkelijkObject: ").Append(IndicatieOorspronkelijkObject).Append("\n");
      sb.Append("  BetreftGedeelteVanPerceel: ").Append(BetreftGedeelteVanPerceel).Append("\n");
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
