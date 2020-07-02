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
  public class ZakelijkGerechtigde {
    /// <summary>
    /// Identificatie van de zakelijk gerechtigde.
    /// </summary>
    /// <value>Identificatie van de zakelijk gerechtigde.</value>
    [DataMember(Name="identificatie", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "identificatie")]
    public string Identificatie { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public TypeGerechtigdeEnum Type { get; set; }

    /// <summary>
    /// Datum waarop het zakelijk recht van kracht is geworden. 
    /// </summary>
    /// <value>Datum waarop het zakelijk recht van kracht is geworden. </value>
    [DataMember(Name="aanvangsdatum", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "aanvangsdatum")]
    public DateTime? Aanvangsdatum { get; set; }

    /// <summary>
    /// Gets or Sets ErfpachtCanon
    /// </summary>
    [DataMember(Name="erfpachtCanon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "erfpachtCanon")]
    public ErfpachtCanon ErfpachtCanon { get; set; }

    /// <summary>
    /// Gets or Sets Tenaamstelling
    /// </summary>
    [DataMember(Name="tenaamstelling", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tenaamstelling")]
    public Tenaamstelling Tenaamstelling { get; set; }

    /// <summary>
    /// Gets or Sets Persoon
    /// </summary>
    [DataMember(Name="persoon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "persoon")]
    public PersoonBeperkt Persoon { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ZakelijkGerechtigde {\n");
      sb.Append("  Identificatie: ").Append(Identificatie).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Aanvangsdatum: ").Append(Aanvangsdatum).Append("\n");
      sb.Append("  ErfpachtCanon: ").Append(ErfpachtCanon).Append("\n");
      sb.Append("  Tenaamstelling: ").Append(Tenaamstelling).Append("\n");
      sb.Append("  Persoon: ").Append(Persoon).Append("\n");
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
