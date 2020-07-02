using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Een persoon kan een natuurlijk persoon of een niet-natuurlijk persoon zijn. Kan zowel een ingeschreven persoon (in resp. BRP of KvK) of Kadasterpersoon zijn.
  /// </summary>
  [DataContract]
  public class PersoonBasis {
    /// <summary>
    /// Unieke identificatie voor de persoon. Voor een Kadasterpersoon is dit de identificatie zoals die door het Kadaster is vastgesteld. Voor een ingeschreven natuurlijk persoon is dit het burgerservicenummer. Voor een ingeschreven niet-natuurlijk persoon is dit het RSIN. Of de waarde in identificatie een burgerservicenummer, een RSIN of een kadasterpersoonidentificatie is kan worden afgeleid uit het type persoon.
    /// </summary>
    /// <value>Unieke identificatie voor de persoon. Voor een Kadasterpersoon is dit de identificatie zoals die door het Kadaster is vastgesteld. Voor een ingeschreven natuurlijk persoon is dit het burgerservicenummer. Voor een ingeschreven niet-natuurlijk persoon is dit het RSIN. Of de waarde in identificatie een burgerservicenummer, een RSIN of een kadasterpersoonidentificatie is kan worden afgeleid uit het type persoon.</value>
    [DataMember(Name="identificatie", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "identificatie")]
    public string Identificatie { get; set; }

    /// <summary>
    /// Voor mensen leesbare, herkenbare en identificerende omschrijving van de persoon (met bijvoorbeeld de naam).
    /// </summary>
    /// <value>Voor mensen leesbare, herkenbare en identificerende omschrijving van de persoon (met bijvoorbeeld de naam).</value>
    [DataMember(Name="omschrijving", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "omschrijving")]
    public string Omschrijving { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PersoonBasis {\n");
      sb.Append("  Identificatie: ").Append(Identificatie).Append("\n");
      sb.Append("  Omschrijving: ").Append(Omschrijving).Append("\n");
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
