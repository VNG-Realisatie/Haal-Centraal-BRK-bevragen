using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Een registratie van (een aandeel in) een zakelijk recht dat een persoon heeft, dat rust op een kadastraal onroerende zaak.  Waardelijst in deze component : [burgerlijkeStaatTenTijdeVanVerkrijging](http://www.kadaster.nl/schemas/waardelijsten/BurgerlijkeStaat/) en [verkregenNamensSamenwerkingsverband](http://www.kadaster.nl/schemas/waardelijsten/Samenwerkingsverband/)
  /// </summary>
  [DataContract]
  public class Tenaamstelling {
    /// <summary>
    /// Gets or Sets Aandeel
    /// </summary>
    [DataMember(Name="aandeel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "aandeel")]
    public TypeBreuk Aandeel { get; set; }

    /// <summary>
    /// Gets or Sets BurgerlijkeStaatTenTijdeVanVerkrijging
    /// </summary>
    [DataMember(Name="burgerlijkeStaatTenTijdeVanVerkrijging", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "burgerlijkeStaatTenTijdeVanVerkrijging")]
    public Waardelijst BurgerlijkeStaatTenTijdeVanVerkrijging { get; set; }

    /// <summary>
    /// Gets or Sets VerkregenNamensSamenwerkingsverband
    /// </summary>
    [DataMember(Name="verkregenNamensSamenwerkingsverband", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "verkregenNamensSamenwerkingsverband")]
    public Waardelijst VerkregenNamensSamenwerkingsverband { get; set; }

    /// <summary>
    /// Een aantekening is een verwijzing naar een ter inschrijving aangeboden stuk. Een aantekening op een tenaamstelling van een zakelijk recht is meestal een beperking. Bijvoorbeeld de verkrijging van een aandeel in een zakelijk recht onder opschortende voorwaarde, een beperking van de handelingsbevoegdheid van de zakelijk gerechtigde, of een koopovereenkomst
    /// </summary>
    /// <value>Een aantekening is een verwijzing naar een ter inschrijving aangeboden stuk. Een aantekening op een tenaamstelling van een zakelijk recht is meestal een beperking. Bijvoorbeeld de verkrijging van een aandeel in een zakelijk recht onder opschortende voorwaarde, een beperking van de handelingsbevoegdheid van de zakelijk gerechtigde, of een koopovereenkomst</value>
    [DataMember(Name="aantekeningen", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "aantekeningen")]
    public List<Aantekening> Aantekeningen { get; set; }

    /// <summary>
    /// Gets or Sets GezamenlijkAandeel
    /// </summary>
    [DataMember(Name="gezamenlijkAandeel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gezamenlijkAandeel")]
    public TypeBreuk GezamenlijkAandeel { get; set; }

    /// <summary>
    /// Gets or Sets BetrokkenPartner
    /// </summary>
    [DataMember(Name="betrokkenPartner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "betrokkenPartner")]
    public NatuurlijkPersoonBeperkt BetrokkenPartner { get; set; }

    /// <summary>
    /// Gets or Sets BetrokkenSamenwerkingsverband
    /// </summary>
    [DataMember(Name="betrokkenSamenwerkingsverband", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "betrokkenSamenwerkingsverband")]
    public NietNatuurlijkPersoonBeperkt BetrokkenSamenwerkingsverband { get; set; }

    /// <summary>
    /// Gets or Sets BetrokkenGorzenEnAanwassen
    /// </summary>
    [DataMember(Name="betrokkenGorzenEnAanwassen", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "betrokkenGorzenEnAanwassen")]
    public NietNatuurlijkPersoonBeperkt BetrokkenGorzenEnAanwassen { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Tenaamstelling {\n");
      sb.Append("  Aandeel: ").Append(Aandeel).Append("\n");
      sb.Append("  BurgerlijkeStaatTenTijdeVanVerkrijging: ").Append(BurgerlijkeStaatTenTijdeVanVerkrijging).Append("\n");
      sb.Append("  VerkregenNamensSamenwerkingsverband: ").Append(VerkregenNamensSamenwerkingsverband).Append("\n");
      sb.Append("  Aantekeningen: ").Append(Aantekeningen).Append("\n");
      sb.Append("  GezamenlijkAandeel: ").Append(GezamenlijkAandeel).Append("\n");
      sb.Append("  BetrokkenPartner: ").Append(BetrokkenPartner).Append("\n");
      sb.Append("  BetrokkenSamenwerkingsverband: ").Append(BetrokkenSamenwerkingsverband).Append("\n");
      sb.Append("  BetrokkenGorzenEnAanwassen: ").Append(BetrokkenGorzenEnAanwassen).Append("\n");
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
