using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Naam is een groep gegevens met de geslachtsnaam, voorletters en voornamen die men wil gebruiken bij aanschrijving.
  /// </summary>
  [DataContract]
  public class Naam {
    /// <summary>
    /// De geslachtsnaam is de (achter)naam waarvan eventuele voorvoegsels en adellijke titel zijn afgesplitst.
    /// </summary>
    /// <value>De geslachtsnaam is de (achter)naam waarvan eventuele voorvoegsels en adellijke titel zijn afgesplitst.</value>
    [DataMember(Name="geslachtsnaam", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "geslachtsnaam")]
    public string Geslachtsnaam { get; set; }

    /// <summary>
    /// De voornamen zijn de verzameling namen die, gescheiden door spaties, aan de geslachtsnaam voorafgaat. Indien aanwezig, wordt het predikaat afgesplitst.
    /// </summary>
    /// <value>De voornamen zijn de verzameling namen die, gescheiden door spaties, aan de geslachtsnaam voorafgaat. Indien aanwezig, wordt het predikaat afgesplitst.</value>
    [DataMember(Name="voornamen", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "voornamen")]
    public string Voornamen { get; set; }

    /// <summary>
    /// Voorvoegselsgeslachtsnaam is het deel van de geslachtsnaam dat, gescheiden door een spatie, vooraf gaat aan de rest van de geslachtsnaam.
    /// </summary>
    /// <value>Voorvoegselsgeslachtsnaam is het deel van de geslachtsnaam dat, gescheiden door een spatie, vooraf gaat aan de rest van de geslachtsnaam.</value>
    [DataMember(Name="voorvoegsel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "voorvoegsel")]
    public string Voorvoegsel { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Naam {\n");
      sb.Append("  Geslachtsnaam: ").Append(Geslachtsnaam).Append("\n");
      sb.Append("  Voornamen: ").Append(Voornamen).Append("\n");
      sb.Append("  Voorvoegsel: ").Append(Voorvoegsel).Append("\n");
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
