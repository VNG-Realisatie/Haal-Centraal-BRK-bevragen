using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Verschuiving van het perceelnummer ten behoeve van visualisatie op een kaart. Dit voorkomt dat perceelnummers van kleine percelen elkaar overlappen.
  /// </summary>
  [DataContract]
  public class TypePerceelnummerVerschuiving {
    /// <summary>
    /// Verschuiving op de X as.
    /// </summary>
    /// <value>Verschuiving op de X as.</value>
    [DataMember(Name="deltax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deltax")]
    public decimal? Deltax { get; set; }

    /// <summary>
    /// Verschuiving op de Y as.
    /// </summary>
    /// <value>Verschuiving op de Y as.</value>
    [DataMember(Name="deltay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deltay")]
    public decimal? Deltay { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TypePerceelnummerVerschuiving {\n");
      sb.Append("  Deltax: ").Append(Deltax).Append("\n");
      sb.Append("  Deltay: ").Append(Deltay).Append("\n");
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
