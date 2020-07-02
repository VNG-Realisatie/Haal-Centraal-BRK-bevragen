using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Waardelijst in deze component : [land](http://www.kadaster.nl/schemas/waardelijsten/BRPLand/)
  /// </summary>
  [DataContract]
  public class Adres {
    /// <summary>
    /// identificatie van het adres in het geval dit adres in BAG geregistreerd is.
    /// </summary>
    /// <value>identificatie van het adres in het geval dit adres in BAG geregistreerd is.</value>
    [DataMember(Name="nummeraanduidingIdentificatie", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nummeraanduidingIdentificatie")]
    public string NummeraanduidingIdentificatie { get; set; }

    /// <summary>
    /// URI https://bag.basisregistraties.overheid.nl/doc/begrip/Huisnummer
    /// </summary>
    /// <value>URI https://bag.basisregistraties.overheid.nl/doc/begrip/Huisnummer</value>
    [DataMember(Name="huisnummer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "huisnummer")]
    public int? Huisnummer { get; set; }

    /// <summary>
    /// URI https://bag.basisregistraties.overheid.nl/doc/begrip/Huisletter
    /// </summary>
    /// <value>URI https://bag.basisregistraties.overheid.nl/doc/begrip/Huisletter</value>
    [DataMember(Name="huisletter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "huisletter")]
    public string Huisletter { get; set; }

    /// <summary>
    /// URI https://bag.basisregistraties.overheid.nl/doc/begrip/Huisnummertoevoeging
    /// </summary>
    /// <value>URI https://bag.basisregistraties.overheid.nl/doc/begrip/Huisnummertoevoeging</value>
    [DataMember(Name="huisnummertoevoeging", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "huisnummertoevoeging")]
    public string Huisnummertoevoeging { get; set; }

    /// <summary>
    /// Gets or Sets Straat
    /// </summary>
    [DataMember(Name="straat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "straat")]
    public string Straat { get; set; }

    /// <summary>
    /// Gets or Sets Postcode
    /// </summary>
    [DataMember(Name="postcode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postcode")]
    public string Postcode { get; set; }

    /// <summary>
    /// Gets or Sets Woonplaats
    /// </summary>
    [DataMember(Name="woonplaats", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "woonplaats")]
    public string Woonplaats { get; set; }

    /// <summary>
    /// Het eerste deel van een adres is een combinatie van de straat en huisnummer.
    /// </summary>
    /// <value>Het eerste deel van een adres is een combinatie van de straat en huisnummer.</value>
    [DataMember(Name="adresregel1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "adresregel1")]
    public string Adresregel1 { get; set; }

    /// <summary>
    /// Het tweede deel van een adres is een combinatie van woonplaats eventueel in combinatie met de postcode
    /// </summary>
    /// <value>Het tweede deel van een adres is een combinatie van woonplaats eventueel in combinatie met de postcode</value>
    [DataMember(Name="adresregel2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "adresregel2")]
    public string Adresregel2 { get; set; }

    /// <summary>
    /// Het derde deel van een adres is optioneel een of meer geografische gebieden van het adres in het buitenland
    /// </summary>
    /// <value>Het derde deel van een adres is optioneel een of meer geografische gebieden van het adres in het buitenland</value>
    [DataMember(Name="adresregel3", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "adresregel3")]
    public string Adresregel3 { get; set; }

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
      sb.Append("class Adres {\n");
      sb.Append("  NummeraanduidingIdentificatie: ").Append(NummeraanduidingIdentificatie).Append("\n");
      sb.Append("  Huisnummer: ").Append(Huisnummer).Append("\n");
      sb.Append("  Huisletter: ").Append(Huisletter).Append("\n");
      sb.Append("  Huisnummertoevoeging: ").Append(Huisnummertoevoeging).Append("\n");
      sb.Append("  Straat: ").Append(Straat).Append("\n");
      sb.Append("  Postcode: ").Append(Postcode).Append("\n");
      sb.Append("  Woonplaats: ").Append(Woonplaats).Append("\n");
      sb.Append("  Adresregel1: ").Append(Adresregel1).Append("\n");
      sb.Append("  Adresregel2: ").Append(Adresregel2).Append("\n");
      sb.Append("  Adresregel3: ").Append(Adresregel3).Append("\n");
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
