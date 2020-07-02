using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Hoeveelheid geld in cijfers in een bepaalde valuta.  Waardelijst in deze component : [Valuta](http://www.kadaster.nl/schemas/waardelijsten/Valuta/)
  /// </summary>
  [DataContract]
  public class Bedrag {
    /// <summary>
    /// Het bedrag. Dit is een waarde met max. 2 decimalen.
    /// </summary>
    /// <value>Het bedrag. Dit is een waarde met max. 2 decimalen.</value>
    [DataMember(Name="som", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "som")]
    public float? Som { get; set; }

    /// <summary>
    /// Gets or Sets Valuta
    /// </summary>
    [DataMember(Name="valuta", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "valuta")]
    public Waardelijst Valuta { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Bedrag {\n");
      sb.Append("  Som: ").Append(Som).Append("\n");
      sb.Append("  Valuta: ").Append(Valuta).Append("\n");
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
