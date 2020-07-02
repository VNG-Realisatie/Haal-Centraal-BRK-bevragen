using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Waardelijst is een samengesteld datatype voor het weergeven van een gegeven binnen een extern beheerde referentielijst. De waardelijsten zijn beschikbaargesteld op [deze locatie](http://www.kadaster.nl/schemas/waardelijsten/)
  /// </summary>
  [DataContract]
  public class Waardelijst {
    /// <summary>
    /// Gets or Sets Code
    /// </summary>
    [DataMember(Name="code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code")]
    public string Code { get; set; }

    /// <summary>
    /// Gets or Sets Waarde
    /// </summary>
    [DataMember(Name="waarde", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "waarde")]
    public string Waarde { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Waardelijst {\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  Waarde: ").Append(Waarde).Append("\n");
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
