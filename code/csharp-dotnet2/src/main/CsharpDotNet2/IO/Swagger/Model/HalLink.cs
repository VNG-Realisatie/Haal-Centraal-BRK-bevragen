using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// De Link Object zoals gespecificeerd in https://tools.ietf.org/html/draft-kelly-json-hal-08#section-5
  /// </summary>
  [DataContract]
  public class HalLink {
    /// <summary>
    /// Gets or Sets Href
    /// </summary>
    [DataMember(Name="href", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "href")]
    public Href Href { get; set; }

    /// <summary>
    /// Gets or Sets Templated
    /// </summary>
    [DataMember(Name="templated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "templated")]
    public bool? Templated { get; set; }

    /// <summary>
    /// Voor mens leesbaar label bij de link
    /// </summary>
    /// <value>Voor mens leesbaar label bij de link</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class HalLink {\n");
      sb.Append("  Href: ").Append(Href).Append("\n");
      sb.Append("  Templated: ").Append(Templated).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
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
