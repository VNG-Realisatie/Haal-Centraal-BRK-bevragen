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
  public class KadastraalOnroerendeZaakHalCollectieEmbedded {
    /// <summary>
    /// Gets or Sets KadastraalOnroerendeZaken
    /// </summary>
    [DataMember(Name="kadastraalOnroerendeZaken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kadastraalOnroerendeZaken")]
    public List<KadastraalOnroerendeZaakHal> KadastraalOnroerendeZaken { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class KadastraalOnroerendeZaakHalCollectieEmbedded {\n");
      sb.Append("  KadastraalOnroerendeZaken: ").Append(KadastraalOnroerendeZaken).Append("\n");
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
