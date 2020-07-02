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
  public class KadasterNietNatuurlijkPersoon : KadasterPersoon {
    /// <summary>
    /// Gets or Sets StatutaireNaam
    /// </summary>
    [DataMember(Name="statutaireNaam", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statutaireNaam")]
    public string StatutaireNaam { get; set; }

    /// <summary>
    /// Gets or Sets StatutaireZetel
    /// </summary>
    [DataMember(Name="statutaireZetel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statutaireZetel")]
    public string StatutaireZetel { get; set; }

    /// <summary>
    /// Gets or Sets Rechtsvorm
    /// </summary>
    [DataMember(Name="rechtsvorm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rechtsvorm")]
    public Waardelijst Rechtsvorm { get; set; }

    /// <summary>
    /// Gets or Sets KvkNummer
    /// </summary>
    [DataMember(Name="kvkNummer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kvkNummer")]
    public string KvkNummer { get; set; }

    /// <summary>
    /// Gets or Sets Rsin
    /// </summary>
    [DataMember(Name="rsin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rsin")]
    public string Rsin { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class KadasterNietNatuurlijkPersoon {\n");
      sb.Append("  StatutaireNaam: ").Append(StatutaireNaam).Append("\n");
      sb.Append("  StatutaireZetel: ").Append(StatutaireZetel).Append("\n");
      sb.Append("  Rechtsvorm: ").Append(Rechtsvorm).Append("\n");
      sb.Append("  KvkNummer: ").Append(KvkNummer).Append("\n");
      sb.Append("  Rsin: ").Append(Rsin).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public  new string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
