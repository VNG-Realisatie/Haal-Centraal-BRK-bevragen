using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Terugmelding bij een fout. JSON representatie in lijn met [RFC7807](https://tools.ietf.org/html/rfc7807).
  /// </summary>
  [DataContract]
  public class Foutbericht {
    /// <summary>
    /// Link naar meer informatie over deze fout
    /// </summary>
    /// <value>Link naar meer informatie over deze fout</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Beschrijving van de fout
    /// </summary>
    /// <value>Beschrijving van de fout</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// Http status code
    /// </summary>
    /// <value>Http status code</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public int? Status { get; set; }

    /// <summary>
    /// Details over de fout
    /// </summary>
    /// <value>Details over de fout</value>
    [DataMember(Name="detail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "detail")]
    public string Detail { get; set; }

    /// <summary>
    /// Uri van de aanroep die de fout heeft veroorzaakt
    /// </summary>
    /// <value>Uri van de aanroep die de fout heeft veroorzaakt</value>
    [DataMember(Name="instance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "instance")]
    public string Instance { get; set; }

    /// <summary>
    /// Systeemcode die het type fout aangeeft
    /// </summary>
    /// <value>Systeemcode die het type fout aangeeft</value>
    [DataMember(Name="code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code")]
    public string Code { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Foutbericht {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Detail: ").Append(Detail).Append("\n");
      sb.Append("  Instance: ").Append(Instance).Append("\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
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
