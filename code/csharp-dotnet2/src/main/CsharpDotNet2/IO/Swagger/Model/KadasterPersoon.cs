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
  public class KadasterPersoon : PersoonBasis {
    /// <summary>
    /// Het domein waartoe de identificatie behoort.
    /// </summary>
    /// <value>Het domein waartoe de identificatie behoort.</value>
    [DataMember(Name="domein", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "domein")]
    public string Domein { get; set; }

    /// <summary>
    /// Gets or Sets IndicatieNietToonbareDiakriet
    /// </summary>
    [DataMember(Name="indicatieNietToonbareDiakriet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "indicatieNietToonbareDiakriet")]
    public bool? IndicatieNietToonbareDiakriet { get; set; }

    /// <summary>
    /// Gets or Sets Beschikkingsbevoegdheid
    /// </summary>
    [DataMember(Name="beschikkingsbevoegdheid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "beschikkingsbevoegdheid")]
    public Waardelijst Beschikkingsbevoegdheid { get; set; }

    /// <summary>
    /// Gets or Sets Woonadres
    /// </summary>
    [DataMember(Name="woonadres", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "woonadres")]
    public Adres Woonadres { get; set; }

    /// <summary>
    /// Gets or Sets Postadres
    /// </summary>
    [DataMember(Name="postadres", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postadres")]
    public Postadres Postadres { get; set; }

    /// <summary>
    /// Gets or Sets KadastraalOnroerendeZaakIdentificaties
    /// </summary>
    [DataMember(Name="kadastraalOnroerendeZaakIdentificaties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kadastraalOnroerendeZaakIdentificaties")]
    public List<string> KadastraalOnroerendeZaakIdentificaties { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class KadasterPersoon {\n");
      sb.Append("  Domein: ").Append(Domein).Append("\n");
      sb.Append("  IndicatieNietToonbareDiakriet: ").Append(IndicatieNietToonbareDiakriet).Append("\n");
      sb.Append("  Beschikkingsbevoegdheid: ").Append(Beschikkingsbevoegdheid).Append("\n");
      sb.Append("  Woonadres: ").Append(Woonadres).Append("\n");
      sb.Append("  Postadres: ").Append(Postadres).Append("\n");
      sb.Append("  KadastraalOnroerendeZaakIdentificaties: ").Append(KadastraalOnroerendeZaakIdentificaties).Append("\n");
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
