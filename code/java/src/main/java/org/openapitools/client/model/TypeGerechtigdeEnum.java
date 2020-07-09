/*
 * Kadastraal onroerende zaken
 * D.m.v. deze toepassing worden meerdere, korte bevragingen op de Basis Registratie Kadaster beschikbaar gesteld. Deze toepassing betreft het verstrekken van Kadastrale Onroerende Zaak informatie.
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import java.util.Objects;
import java.util.Arrays;
import io.swagger.annotations.ApiModel;
import com.google.gson.annotations.SerializedName;

import java.io.IOException;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;

/**
 * Het type zakelijk recht dat deze gerechtigde heeft. Afgeleid van de aard zakelijk recht:  * &#x60;beklemrechthouder&#x60; - 1 Beklemrechthouder  * &#x60;eigenaar&#x60; - 2 Eigenaar  * &#x60;erfpachter&#x60; - 3 Erfpachter  * &#x60;gebruik_bewoning&#x60; - 4 Rechthebbende van Gebruik en bewoning  * &#x60;grondrente&#x60; - 5 Grondrente gerechtigde  * &#x60;opstalhouder&#x60; - 7 Opstalhouder  * &#x60;vaderlandsrecht&#x60; - 9 Rechthebbende van Oud-vaderlandsrecht  * &#x60;stadsmeierrecht&#x60; - 11 Rechthebbende van Stadsmeierrecht  * &#x60;vruchtgebruiker&#x60; - 12 Vruchtgebruiker  * &#x60;erfpachter_opstalhouder&#x60; - 13 Erfpachter en opstalhouder  * &#x60;nutsvoorzieningen&#x60; - 14 Opstalhouder nutsvoorzieningen  * &#x60;twee_belastingen&#x60; - 20 Zakelijk Rechthebbende na twee of meer zakelijke belastingen  * &#x60;belasting_derde&#x60; - 21 Zakelijk rechthebbende belasting derde of volgende  * &#x60;bp_recht&#x60; - 22 BP-gerechtigde  * &#x60;nutsvoorzieningen_gedeelte&#x60; - 23 Opstalhouder Nutsvoorzieningen op gedeelte van perceel  * &#x60;artikel5_3b&#x60; - 24 Zakelijk gerechtigde als bedoeld in artikel 5, lid 3, onder b, van de Belemmeringenwet Privaatrecht op gedeelte van perceel
 */
@JsonAdapter(TypeGerechtigdeEnum.Adapter.class)
public enum TypeGerechtigdeEnum {
  
  BEKLEMRECHTHOUDER("beklemrechthouder"),
  
  EIGENAAR("eigenaar"),
  
  ERFPACHTER("erfpachter"),
  
  GEBRUIK_BEWONING("gebruik_bewoning"),
  
  GRONDRENTE("grondrente"),
  
  OPSTALHOUDER("opstalhouder"),
  
  VADERLANDSRECHT("vaderlandsrecht"),
  
  STADSMEIERRECHT("stadsmeierrecht"),
  
  VRUCHTGEBRUIKER("vruchtgebruiker"),
  
  ERFPACHTER_OPSTALHOUDER("erfpachter_opstalhouder"),
  
  NUTSVOORZIENINGEN("nutsvoorzieningen"),
  
  TWEE_BELASTINGEN("twee_belastingen"),
  
  BELASTING_DERDE("belasting_derde"),
  
  BP_RECHT("bp_recht"),
  
  NUTSVOORZIENINGEN_GEDEELTE("nutsvoorzieningen_gedeelte"),
  
  ARTIKEL5_3B("artikel5_3b");

  private String value;

  TypeGerechtigdeEnum(String value) {
    this.value = value;
  }

  public String getValue() {
    return value;
  }

  @Override
  public String toString() {
    return String.valueOf(value);
  }

  public static TypeGerechtigdeEnum fromValue(String value) {
    for (TypeGerechtigdeEnum b : TypeGerechtigdeEnum.values()) {
      if (b.value.equals(value)) {
        return b;
      }
    }
    throw new IllegalArgumentException("Unexpected value '" + value + "'");
  }

  public static class Adapter extends TypeAdapter<TypeGerechtigdeEnum> {
    @Override
    public void write(final JsonWriter jsonWriter, final TypeGerechtigdeEnum enumeration) throws IOException {
      jsonWriter.value(enumeration.getValue());
    }

    @Override
    public TypeGerechtigdeEnum read(final JsonReader jsonReader) throws IOException {
      String value = jsonReader.nextString();
      return TypeGerechtigdeEnum.fromValue(value);
    }
  }
}

