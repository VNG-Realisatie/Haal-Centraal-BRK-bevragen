using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Geboorte is een groep gegevens over de geboorte van een persoon.  Waardelijst in deze component : [land](http://www.kadaster.nl/schemas/waardelijsten/BRPLand/)
  /// </summary>
  [DataContract]
  public class Geboorte {
    /// <summary>
    /// De geboorteplaats is de plaats of een plaatsbepaling, die aangeeft waar de persoon is geboren
    /// </summary>
    /// <value>De geboorteplaats is de plaats of een plaatsbepaling, die aangeeft waar de persoon is geboren</value>
    [DataMember(Name="plaats", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plaats")]
    public string Plaats { get; set; }

    /// <summary>
    /// Gets or Sets Datum
    /// </summary>
    [DataMember(Name="datum", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "datum")]
    public DatumOnvolledig Datum { get; set; }

    /// <summary>
    /// Gets or Sets Land
    /// </summary>
    [DataMember(Name="land", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "land")]
    public Waardelijst Land { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Geboorte {\n");
      sb.Append("  Plaats: ").Append(Plaats).Append("\n");
      sb.Append("  Datum: ").Append(Datum).Append("\n");
      sb.Append("  Land: ").Append(Land).Append("\n");
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
