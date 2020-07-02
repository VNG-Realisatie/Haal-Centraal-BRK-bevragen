using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Gegevens over de datums die mogelijk niet volledig zijn, maar waarvan de bekende gedeeltes wel moeten kunnen worden uitgewisseld. Als de volledige datum bekend is worden alle elementen gevuld.
  /// </summary>
  [DataContract]
  public class DatumOnvolledig {
    /// <summary>
    /// De dag. Als de dag van de datum bekend is wordt deze hier ingevuld. Ook als de volledige datum bekend is.
    /// </summary>
    /// <value>De dag. Als de dag van de datum bekend is wordt deze hier ingevuld. Ook als de volledige datum bekend is.</value>
    [DataMember(Name="dag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dag")]
    public int? Dag { get; set; }

    /// <summary>
    /// De volledige datum die in de `date` definitie past. Dit element wordt alleen gevuld als de volledige datum bekend is.
    /// </summary>
    /// <value>De volledige datum die in de `date` definitie past. Dit element wordt alleen gevuld als de volledige datum bekend is.</value>
    [DataMember(Name="datum", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "datum")]
    public DateTime? Datum { get; set; }

    /// <summary>
    /// Het jaar van de datum. Als het jaar bekend is wordt dit element gevuld, ook als de volledige datum bekend is.
    /// </summary>
    /// <value>Het jaar van de datum. Als het jaar bekend is wordt dit element gevuld, ook als de volledige datum bekend is.</value>
    [DataMember(Name="jaar", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jaar")]
    public int? Jaar { get; set; }

    /// <summary>
    /// De maand. Als de maand van een datum bekend is wordt deze hier ingevuld. Ook als de volledige datum is ingevuld.
    /// </summary>
    /// <value>De maand. Als de maand van een datum bekend is wordt deze hier ingevuld. Ook als de volledige datum is ingevuld.</value>
    [DataMember(Name="maand", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maand")]
    public int? Maand { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DatumOnvolledig {\n");
      sb.Append("  Dag: ").Append(Dag).Append("\n");
      sb.Append("  Datum: ").Append(Datum).Append("\n");
      sb.Append("  Jaar: ").Append(Jaar).Append("\n");
      sb.Append("  Maand: ").Append(Maand).Append("\n");
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
