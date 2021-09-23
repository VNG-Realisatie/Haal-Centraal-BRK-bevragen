/*
 * Kadaster - BRK-Bevragen API
 * D.m.v. deze toepassing worden meerdere, korte bevragingen op de Basis Registratie Kadaster beschikbaar gesteld. Deze toepassing betreft het verstrekken van Kadastrale Onroerende Zaak informatie. 
 *
 * The version of the OpenAPI document: 1.3.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import org.openapitools.client.model.PolygonGeoJSON;

/**
 * AantekeningTenaamstellingAllOf
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-09-22T10:30:56.069820Z[Etc/UTC]")
public class AantekeningTenaamstellingAllOf {
  public static final String SERIALIZED_NAME_BEGRENZING = "begrenzing";
  @SerializedName(SERIALIZED_NAME_BEGRENZING)
  private PolygonGeoJSON begrenzing;

  public static final String SERIALIZED_NAME_INDICATIE_OORSPRONKELIJK_OBJECT = "indicatieOorspronkelijkObject";
  @SerializedName(SERIALIZED_NAME_INDICATIE_OORSPRONKELIJK_OBJECT)
  private Boolean indicatieOorspronkelijkObject;


  public AantekeningTenaamstellingAllOf begrenzing(PolygonGeoJSON begrenzing) {
    
    this.begrenzing = begrenzing;
    return this;
  }

   /**
   * Get begrenzing
   * @return begrenzing
   * @deprecated
  **/
  @Deprecated
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public PolygonGeoJSON getBegrenzing() {
    return begrenzing;
  }


  public void setBegrenzing(PolygonGeoJSON begrenzing) {
    this.begrenzing = begrenzing;
  }


  public AantekeningTenaamstellingAllOf indicatieOorspronkelijkObject(Boolean indicatieOorspronkelijkObject) {
    
    this.indicatieOorspronkelijkObject = indicatieOorspronkelijkObject;
    return this;
  }

   /**
   * Get indicatieOorspronkelijkObject
   * @return indicatieOorspronkelijkObject
   * @deprecated
  **/
  @Deprecated
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getIndicatieOorspronkelijkObject() {
    return indicatieOorspronkelijkObject;
  }


  public void setIndicatieOorspronkelijkObject(Boolean indicatieOorspronkelijkObject) {
    this.indicatieOorspronkelijkObject = indicatieOorspronkelijkObject;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    AantekeningTenaamstellingAllOf aantekeningTenaamstellingAllOf = (AantekeningTenaamstellingAllOf) o;
    return Objects.equals(this.begrenzing, aantekeningTenaamstellingAllOf.begrenzing) &&
        Objects.equals(this.indicatieOorspronkelijkObject, aantekeningTenaamstellingAllOf.indicatieOorspronkelijkObject);
  }

  @Override
  public int hashCode() {
    return Objects.hash(begrenzing, indicatieOorspronkelijkObject);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class AantekeningTenaamstellingAllOf {\n");
    sb.append("    begrenzing: ").append(toIndentedString(begrenzing)).append("\n");
    sb.append("    indicatieOorspronkelijkObject: ").append(toIndentedString(indicatieOorspronkelijkObject)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

