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
  public class KadasterPersoonLinks {
    /// <summary>
    /// Gets or Sets Self
    /// </summary>
    [DataMember(Name="self", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "self")]
    public HalLink Self { get; set; }

    /// <summary>
    /// Gets or Sets Woonadres
    /// </summary>
    [DataMember(Name="woonadres", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "woonadres")]
    public HalLink Woonadres { get; set; }

    /// <summary>
    /// Gets or Sets Postadres
    /// </summary>
    [DataMember(Name="postadres", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postadres")]
    public HalLink Postadres { get; set; }

    /// <summary>
    /// Gets or Sets KadastraalOnroerendeZaken
    /// </summary>
    [DataMember(Name="kadastraalOnroerendeZaken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kadastraalOnroerendeZaken")]
    public List<HalLink> KadastraalOnroerendeZaken { get; set; }

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
      sb.Append("class KadasterPersoonLinks {\n");
      sb.Append("  Self: ").Append(Self).Append("\n");
      sb.Append("  Woonadres: ").Append(Woonadres).Append("\n");
      sb.Append("  Postadres: ").Append(Postadres).Append("\n");
      sb.Append("  KadastraalOnroerendeZaken: ").Append(KadastraalOnroerendeZaken).Append("\n");
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
