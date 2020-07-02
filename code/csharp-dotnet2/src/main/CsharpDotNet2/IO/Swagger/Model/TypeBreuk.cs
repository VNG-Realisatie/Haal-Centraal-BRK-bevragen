using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Een deling van twee gehele getallen
  /// </summary>
  [DataContract]
  public class TypeBreuk {
    /// <summary>
    /// De noemer van het deel.
    /// </summary>
    /// <value>De noemer van het deel.</value>
    [DataMember(Name="noemer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "noemer")]
    public int? Noemer { get; set; }

    /// <summary>
    /// Het aantal delen. De teller is altijd lager dan de noemer.
    /// </summary>
    /// <value>Het aantal delen. De teller is altijd lager dan de noemer.</value>
    [DataMember(Name="teller", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "teller")]
    public int? Teller { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TypeBreuk {\n");
      sb.Append("  Noemer: ").Append(Noemer).Append("\n");
      sb.Append("  Teller: ").Append(Teller).Append("\n");
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
