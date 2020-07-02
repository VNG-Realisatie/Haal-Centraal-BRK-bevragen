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
  public class KadastraalOnroerendeZaakLinks {
    /// <summary>
    /// Gets or Sets Self
    /// </summary>
    [DataMember(Name="self", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "self")]
    public HalLink Self { get; set; }

    /// <summary>
    /// Gets or Sets ZakelijkGerechtigden
    /// </summary>
    [DataMember(Name="zakelijkGerechtigden", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zakelijkGerechtigden")]
    public List<HalLink> ZakelijkGerechtigden { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class KadastraalOnroerendeZaakLinks {\n");
      sb.Append("  Self: ").Append(Self).Append("\n");
      sb.Append("  ZakelijkGerechtigden: ").Append(ZakelijkGerechtigden).Append("\n");
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
