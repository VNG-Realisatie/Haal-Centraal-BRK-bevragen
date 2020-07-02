using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Een aanduiding die aangeeft dat de ingeschrevene een man of een vrouw is, of dat het geslacht (nog) onbekend is: * &#x60;man&#x60; - Man * &#x60;vrouw&#x60; - Vrouw * &#x60;onbekend&#x60; - Onbekend
  /// </summary>
  [DataContract]
  public class GeslachtEnum {

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GeslachtEnum {\n");
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
