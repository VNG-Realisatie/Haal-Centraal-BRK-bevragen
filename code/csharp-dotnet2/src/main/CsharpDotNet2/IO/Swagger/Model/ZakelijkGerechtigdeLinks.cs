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
  public class ZakelijkGerechtigdeLinks {
    /// <summary>
    /// Gets or Sets Self
    /// </summary>
    [DataMember(Name="self", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "self")]
    public HalLink Self { get; set; }

    /// <summary>
    /// Gets or Sets Persoon
    /// </summary>
    [DataMember(Name="persoon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "persoon")]
    public HalLink Persoon { get; set; }

    /// <summary>
    /// Gets or Sets BetrokkenPartner
    /// </summary>
    [DataMember(Name="betrokkenPartner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "betrokkenPartner")]
    public HalLink BetrokkenPartner { get; set; }

    /// <summary>
    /// Gets or Sets BetrokkenSamenwerkingsverband
    /// </summary>
    [DataMember(Name="betrokkenSamenwerkingsverband", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "betrokkenSamenwerkingsverband")]
    public HalLink BetrokkenSamenwerkingsverband { get; set; }

    /// <summary>
    /// Gets or Sets BetrokkenGorzenEnAanwassen
    /// </summary>
    [DataMember(Name="betrokkenGorzenEnAanwassen", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "betrokkenGorzenEnAanwassen")]
    public HalLink BetrokkenGorzenEnAanwassen { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ZakelijkGerechtigdeLinks {\n");
      sb.Append("  Self: ").Append(Self).Append("\n");
      sb.Append("  Persoon: ").Append(Persoon).Append("\n");
      sb.Append("  BetrokkenPartner: ").Append(BetrokkenPartner).Append("\n");
      sb.Append("  BetrokkenSamenwerkingsverband: ").Append(BetrokkenSamenwerkingsverband).Append("\n");
      sb.Append("  BetrokkenGorzenEnAanwassen: ").Append(BetrokkenGorzenEnAanwassen).Append("\n");
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
