using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Een kadastraal onroerende zaak is een perceel of een appartementsrecht. Een perceel is een stuk grond waarvan het Kadaster de grenzen heeft gemeten en dat bij het Kadaster een eigen nummer heeft. Een appartementsrecht is het recht dat iemand of een organisatie heeft om eigenaar te zijn van een deel van een gebouw of een stuk grond. In de praktijk wordt dit deel meestal een appartement genoemd.  Waardelijst in deze component : [aardCultuurBebouwd](http://www.kadaster.nl/schemas/waardelijsten/CultuurcodeBebouwd/) en [aardCultuurOnbebouwd](http://www.kadaster.nl/schemas/waardelijsten/CultuurcodeOnbebouwd/) 
  /// </summary>
  [DataContract]
  public class KadastraalOnroerendeZaak {
    /// <summary>
    /// Gets or Sets Identificatie
    /// </summary>
    [DataMember(Name="identificatie", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "identificatie")]
    public string Identificatie { get; set; }

    /// <summary>
    /// Het domein waartoe de identificatie behoort.
    /// </summary>
    /// <value>Het domein waartoe de identificatie behoort.</value>
    [DataMember(Name="domein", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "domein")]
    public string Domein { get; set; }

    /// <summary>
    /// Gets or Sets BegrenzingPerceel
    /// </summary>
    [DataMember(Name="begrenzingPerceel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "begrenzingPerceel")]
    public PolygonGeoJSON BegrenzingPerceel { get; set; }

    /// <summary>
    /// Rotatie van het perceelnummer ten behoeve van visualisatie op de kaart. Perceelnummers worden bijvoorbeeld gekanteld om in een smal perceel te passen.
    /// </summary>
    /// <value>Rotatie van het perceelnummer ten behoeve van visualisatie op de kaart. Perceelnummers worden bijvoorbeeld gekanteld om in een smal perceel te passen.</value>
    [DataMember(Name="perceelnummerRotatie", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "perceelnummerRotatie")]
    public decimal? PerceelnummerRotatie { get; set; }

    /// <summary>
    /// Gets or Sets Plaatscoordinaten
    /// </summary>
    [DataMember(Name="plaatscoordinaten", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plaatscoordinaten")]
    public PointGeoJSON Plaatscoordinaten { get; set; }

    /// <summary>
    /// Gets or Sets Koopsom
    /// </summary>
    [DataMember(Name="koopsom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "koopsom")]
    public TypeKoopsom Koopsom { get; set; }

    /// <summary>
    /// Toelichtende tekst bij een onroerende zaak van de bewaarder. De bewaarder is iemand die bij het Kadaster werkt. Hij schrijft stukken in in de openbare registers en de basisregistratie Kadaster conform de Kadasterwet.
    /// </summary>
    /// <value>Toelichtende tekst bij een onroerende zaak van de bewaarder. De bewaarder is iemand die bij het Kadaster werkt. Hij schrijft stukken in in de openbare registers en de basisregistratie Kadaster conform de Kadasterwet.</value>
    [DataMember(Name="toelichtingBewaarder", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "toelichtingBewaarder")]
    public string ToelichtingBewaarder { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public TypeKadastraalOnroerendeZaakEnum Type { get; set; }

    /// <summary>
    /// Gets or Sets AardCultuurBebouwd
    /// </summary>
    [DataMember(Name="aardCultuurBebouwd", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "aardCultuurBebouwd")]
    public Waardelijst AardCultuurBebouwd { get; set; }

    /// <summary>
    /// Gets or Sets AardCultuurOnbebouwd
    /// </summary>
    [DataMember(Name="aardCultuurOnbebouwd", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "aardCultuurOnbebouwd")]
    public Waardelijst AardCultuurOnbebouwd { get; set; }

    /// <summary>
    /// Gets or Sets KadastraleAanduiding
    /// </summary>
    [DataMember(Name="kadastraleAanduiding", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kadastraleAanduiding")]
    public string KadastraleAanduiding { get; set; }

    /// <summary>
    /// Gets or Sets KadastraleGrootte
    /// </summary>
    [DataMember(Name="kadastraleGrootte", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kadastraleGrootte")]
    public TypeOppervlak KadastraleGrootte { get; set; }

    /// <summary>
    /// Gets or Sets PerceelnummerVerschuiving
    /// </summary>
    [DataMember(Name="perceelnummerVerschuiving", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "perceelnummerVerschuiving")]
    public TypePerceelnummerVerschuiving PerceelnummerVerschuiving { get; set; }

    /// <summary>
    /// Gets or Sets Adressen
    /// </summary>
    [DataMember(Name="adressen", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "adressen")]
    public List<LocatieKadastraalObject> Adressen { get; set; }

    /// <summary>
    /// Alle personen en rechtspersonen die een zakelijk recht hebben op deze kadastaraal onroerende zaak
    /// </summary>
    /// <value>Alle personen en rechtspersonen die een zakelijk recht hebben op deze kadastaraal onroerende zaak</value>
    [DataMember(Name="zakelijkGerechtigdeIdentificaties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zakelijkGerechtigdeIdentificaties")]
    public List<string> ZakelijkGerechtigdeIdentificaties { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class KadastraalOnroerendeZaak {\n");
      sb.Append("  Identificatie: ").Append(Identificatie).Append("\n");
      sb.Append("  Domein: ").Append(Domein).Append("\n");
      sb.Append("  BegrenzingPerceel: ").Append(BegrenzingPerceel).Append("\n");
      sb.Append("  PerceelnummerRotatie: ").Append(PerceelnummerRotatie).Append("\n");
      sb.Append("  Plaatscoordinaten: ").Append(Plaatscoordinaten).Append("\n");
      sb.Append("  Koopsom: ").Append(Koopsom).Append("\n");
      sb.Append("  ToelichtingBewaarder: ").Append(ToelichtingBewaarder).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  AardCultuurBebouwd: ").Append(AardCultuurBebouwd).Append("\n");
      sb.Append("  AardCultuurOnbebouwd: ").Append(AardCultuurOnbebouwd).Append("\n");
      sb.Append("  KadastraleAanduiding: ").Append(KadastraleAanduiding).Append("\n");
      sb.Append("  KadastraleGrootte: ").Append(KadastraleGrootte).Append("\n");
      sb.Append("  PerceelnummerVerschuiving: ").Append(PerceelnummerVerschuiving).Append("\n");
      sb.Append("  Adressen: ").Append(Adressen).Append("\n");
      sb.Append("  ZakelijkGerechtigdeIdentificaties: ").Append(ZakelijkGerechtigdeIdentificaties).Append("\n");
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
