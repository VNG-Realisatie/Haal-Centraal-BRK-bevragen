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
  public class KadastraalOnroerendeZaakHalCollectie {
    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [DataMember(Name="_links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_links")]
    public HalCollectionLinks Links { get; set; }

    /// <summary>
    /// Gets or Sets Embedded
    /// </summary>
    [DataMember(Name="_embedded", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_embedded")]
    public KadastraalOnroerendeZaakHalCollectieEmbedded Embedded { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class KadastraalOnroerendeZaakHalCollectie {\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
      sb.Append("  Embedded: ").Append(Embedded).Append("\n");
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
