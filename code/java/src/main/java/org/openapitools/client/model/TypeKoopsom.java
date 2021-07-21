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

/**
 * TypeKoopsom
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-07-21T07:24:37.064592Z[Etc/UTC]")
public class TypeKoopsom {
  public static final String SERIALIZED_NAME_KOOPSOM = "koopsom";
  @SerializedName(SERIALIZED_NAME_KOOPSOM)
  private Integer koopsom;

  public static final String SERIALIZED_NAME_KOOPJAAR = "koopjaar";
  @SerializedName(SERIALIZED_NAME_KOOPJAAR)
  private Integer koopjaar;

  public static final String SERIALIZED_NAME_INDICATIE_MET_MEER_OBJECTEN_VERKREGEN = "indicatieMetMeerObjectenVerkregen";
  @SerializedName(SERIALIZED_NAME_INDICATIE_MET_MEER_OBJECTEN_VERKREGEN)
  private Boolean indicatieMetMeerObjectenVerkregen;


  public TypeKoopsom koopsom(Integer koopsom) {
    
    this.koopsom = koopsom;
    return this;
  }

   /**
   * Get koopsom
   * @return koopsom
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Integer getKoopsom() {
    return koopsom;
  }


  public void setKoopsom(Integer koopsom) {
    this.koopsom = koopsom;
  }


  public TypeKoopsom koopjaar(Integer koopjaar) {
    
    this.koopjaar = koopjaar;
    return this;
  }

   /**
   * Get koopjaar
   * @return koopjaar
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Integer getKoopjaar() {
    return koopjaar;
  }


  public void setKoopjaar(Integer koopjaar) {
    this.koopjaar = koopjaar;
  }


  public TypeKoopsom indicatieMetMeerObjectenVerkregen(Boolean indicatieMetMeerObjectenVerkregen) {
    
    this.indicatieMetMeerObjectenVerkregen = indicatieMetMeerObjectenVerkregen;
    return this;
  }

   /**
   * Get indicatieMetMeerObjectenVerkregen
   * @return indicatieMetMeerObjectenVerkregen
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getIndicatieMetMeerObjectenVerkregen() {
    return indicatieMetMeerObjectenVerkregen;
  }


  public void setIndicatieMetMeerObjectenVerkregen(Boolean indicatieMetMeerObjectenVerkregen) {
    this.indicatieMetMeerObjectenVerkregen = indicatieMetMeerObjectenVerkregen;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    TypeKoopsom typeKoopsom = (TypeKoopsom) o;
    return Objects.equals(this.koopsom, typeKoopsom.koopsom) &&
        Objects.equals(this.koopjaar, typeKoopsom.koopjaar) &&
        Objects.equals(this.indicatieMetMeerObjectenVerkregen, typeKoopsom.indicatieMetMeerObjectenVerkregen);
  }

  @Override
  public int hashCode() {
    return Objects.hash(koopsom, koopjaar, indicatieMetMeerObjectenVerkregen);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class TypeKoopsom {\n");
    sb.append("    koopsom: ").append(toIndentedString(koopsom)).append("\n");
    sb.append("    koopjaar: ").append(toIndentedString(koopjaar)).append("\n");
    sb.append("    indicatieMetMeerObjectenVerkregen: ").append(toIndentedString(indicatieMetMeerObjectenVerkregen)).append("\n");
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

