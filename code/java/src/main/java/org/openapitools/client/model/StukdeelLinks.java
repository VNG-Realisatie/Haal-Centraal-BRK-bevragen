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
import org.openapitools.client.model.HalLink;

/**
 * StukdeelLinks
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-09-22T10:30:56.069820Z[Etc/UTC]")
public class StukdeelLinks {
  public static final String SERIALIZED_NAME_SELF = "self";
  @SerializedName(SERIALIZED_NAME_SELF)
  private HalLink self;

  public static final String SERIALIZED_NAME_STUK = "stuk";
  @SerializedName(SERIALIZED_NAME_STUK)
  private HalLink stuk;


  public StukdeelLinks self(HalLink self) {
    
    this.self = self;
    return this;
  }

   /**
   * Get self
   * @return self
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public HalLink getSelf() {
    return self;
  }


  public void setSelf(HalLink self) {
    this.self = self;
  }


  public StukdeelLinks stuk(HalLink stuk) {
    
    this.stuk = stuk;
    return this;
  }

   /**
   * Get stuk
   * @return stuk
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public HalLink getStuk() {
    return stuk;
  }


  public void setStuk(HalLink stuk) {
    this.stuk = stuk;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    StukdeelLinks stukdeelLinks = (StukdeelLinks) o;
    return Objects.equals(this.self, stukdeelLinks.self) &&
        Objects.equals(this.stuk, stukdeelLinks.stuk);
  }

  @Override
  public int hashCode() {
    return Objects.hash(self, stuk);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class StukdeelLinks {\n");
    sb.append("    self: ").append(toIndentedString(self)).append("\n");
    sb.append("    stuk: ").append(toIndentedString(stuk)).append("\n");
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

