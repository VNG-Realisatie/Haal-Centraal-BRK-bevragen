using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Overlijden is een groep gegevens over het overlijden van een persoon.
  /// </summary>
  [DataContract]
  public class Overlijden {
    /// <summary>
    /// Gets or Sets Datum
    /// </summary>
    [DataMember(Name="datum", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "datum")]
    public DatumOnvolledig Datum { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Overlijden {\n");
      sb.Append("  Datum: ").Append(Datum).Append("\n");
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
