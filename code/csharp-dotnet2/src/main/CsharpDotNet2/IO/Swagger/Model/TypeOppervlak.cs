using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Oppervlakte  Waardelijst in deze component : [soortGrootte](http://www.kadaster.nl/schemas/waardelijsten/SoortGrootte/)
  /// </summary>
  [DataContract]
  public class TypeOppervlak {
    /// <summary>
    /// Gets or Sets SoortGrootte
    /// </summary>
    [DataMember(Name="soortGrootte", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "soortGrootte")]
    public Waardelijst SoortGrootte { get; set; }

    /// <summary>
    /// Oppervlak grootte, in vierkante meters
    /// </summary>
    /// <value>Oppervlak grootte, in vierkante meters</value>
    [DataMember(Name="waarde", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "waarde")]
    public int? Waarde { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TypeOppervlak {\n");
      sb.Append("  SoortGrootte: ").Append(SoortGrootte).Append("\n");
      sb.Append("  Waarde: ").Append(Waarde).Append("\n");
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
