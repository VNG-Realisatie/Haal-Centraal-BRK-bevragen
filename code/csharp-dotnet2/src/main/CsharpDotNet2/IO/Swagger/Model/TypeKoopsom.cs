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
  public class TypeKoopsom {
    /// <summary>
    /// Gets or Sets Koopsom
    /// </summary>
    [DataMember(Name="koopsom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "koopsom")]
    public int? Koopsom { get; set; }

    /// <summary>
    /// Gets or Sets Koopjaar
    /// </summary>
    [DataMember(Name="koopjaar", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "koopjaar")]
    public int? Koopjaar { get; set; }

    /// <summary>
    /// Gets or Sets IndicatieMetMeerObjectenVerkregen
    /// </summary>
    [DataMember(Name="indicatieMetMeerObjectenVerkregen", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "indicatieMetMeerObjectenVerkregen")]
    public bool? IndicatieMetMeerObjectenVerkregen { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TypeKoopsom {\n");
      sb.Append("  Koopsom: ").Append(Koopsom).Append("\n");
      sb.Append("  Koopjaar: ").Append(Koopjaar).Append("\n");
      sb.Append("  IndicatieMetMeerObjectenVerkregen: ").Append(IndicatieMetMeerObjectenVerkregen).Append("\n");
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
