using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Waardelijst in deze component : [koppelingswijze](http://www.kadaster.nl/schemas/waardelijsten/Koppelingswijze)
  /// </summary>
  [DataContract]
  public class LocatieKadastraalObject {
    /// <summary>
    /// Gets or Sets NummeraanduidingIdentificatie
    /// </summary>
    [DataMember(Name="nummeraanduidingIdentificatie", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nummeraanduidingIdentificatie")]
    public string NummeraanduidingIdentificatie { get; set; }

    /// <summary>
    /// Gets or Sets Koppelingswijze
    /// </summary>
    [DataMember(Name="koppelingswijze", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "koppelingswijze")]
    public Waardelijst Koppelingswijze { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LocatieKadastraalObject {\n");
      sb.Append("  NummeraanduidingIdentificatie: ").Append(NummeraanduidingIdentificatie).Append("\n");
      sb.Append("  Koppelingswijze: ").Append(Koppelingswijze).Append("\n");
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
