using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Het type zakelijk recht dat deze gerechtigde heeft. Afgeleid van de aard zakelijk recht:  * &#x60;beklemrechthouder&#x60; - 1 Beklemrechthouder  * &#x60;eigenaar&#x60; - 2 Eigenaar  * &#x60;erfpachter&#x60; - 3 Erfpachter  * &#x60;gebruik_bewoning&#x60; - 4 Rechthebbende van Gebruik en bewoning  * &#x60;grondrente&#x60; - 5 Grondrente gerechtigde  * &#x60;opstalhouder&#x60; - 7 Opstalhouder  * &#x60;vaderlandsrecht&#x60; - 9 Rechthebbende van Oud-vaderlandsrecht  * &#x60;stadsmeierrecht&#x60; - 11 Rechthebbende van Stadsmeierrecht  * &#x60;vruchtgebruiker&#x60; - 12 Vruchtgebruiker  * &#x60;erfpachter_opstalhouder&#x60; - 13 Erfpachter en opstalhouder  * &#x60;nutsvoorzieningen&#x60; - 14 Opstalhouder nutsvoorzieningen  * &#x60;twee_belastingen&#x60; - 20 Zakelijk Rechthebbende na twee of meer zakelijke belastingen  * &#x60;belasting_derde&#x60; - 21 Zakelijk rechthebbende belasting derde of volgende  * &#x60;bp_recht&#x60; - 22 BP-gerechtigde  * &#x60;nutsvoorzieningen_gedeelte&#x60; - 23 Opstalhouder Nutsvoorzieningen op gedeelte van perceel  * &#x60;artikel5_3b&#x60; - 24 Zakelijk gerechtigde als bedoeld in artikel 5, lid 3, onder b, van de Belemmeringenwet Privaatrecht op gedeelte van perceel
  /// </summary>
  [DataContract]
  public class TypeGerechtigdeEnum {

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TypeGerechtigdeEnum {\n");
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
