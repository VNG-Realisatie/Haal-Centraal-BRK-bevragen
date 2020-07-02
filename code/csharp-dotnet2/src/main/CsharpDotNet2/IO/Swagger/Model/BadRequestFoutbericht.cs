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
  public class BadRequestFoutbericht : Foutbericht {
    /// <summary>
    /// Foutmelding per fout in een parameter. Alle gevonden fouten worden één keer teruggemeld.
    /// </summary>
    /// <value>Foutmelding per fout in een parameter. Alle gevonden fouten worden één keer teruggemeld.</value>
    [DataMember(Name="invalidParams", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invalidParams")]
    public List<InvalidParams> InvalidParams { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BadRequestFoutbericht {\n");
      sb.Append("  InvalidParams: ").Append(InvalidParams).Append("\n");
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
