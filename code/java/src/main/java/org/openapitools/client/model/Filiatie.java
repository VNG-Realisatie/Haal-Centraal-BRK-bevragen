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
import java.util.ArrayList;
import java.util.List;
import org.openapitools.client.model.KadastraalOnroerendeZaakFiliatie;
import org.openapitools.client.model.Waardelijst;

/**
 * Filiatie
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-07-21T07:24:37.064592Z[Etc/UTC]")
public class Filiatie {
  public static final String SERIALIZED_NAME_AARD = "aard";
  @SerializedName(SERIALIZED_NAME_AARD)
  private Waardelijst aard;

  public static final String SERIALIZED_NAME_KADASTRAAL_ONROERENDE_ZAKEN = "kadastraalOnroerendeZaken";
  @SerializedName(SERIALIZED_NAME_KADASTRAAL_ONROERENDE_ZAKEN)
  private List<KadastraalOnroerendeZaakFiliatie> kadastraalOnroerendeZaken = null;


  public Filiatie aard(Waardelijst aard) {
    
    this.aard = aard;
    return this;
  }

   /**
   * Get aard
   * @return aard
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Waardelijst getAard() {
    return aard;
  }


  public void setAard(Waardelijst aard) {
    this.aard = aard;
  }


  public Filiatie kadastraalOnroerendeZaken(List<KadastraalOnroerendeZaakFiliatie> kadastraalOnroerendeZaken) {
    
    this.kadastraalOnroerendeZaken = kadastraalOnroerendeZaken;
    return this;
  }

  public Filiatie addKadastraalOnroerendeZakenItem(KadastraalOnroerendeZaakFiliatie kadastraalOnroerendeZakenItem) {
    if (this.kadastraalOnroerendeZaken == null) {
      this.kadastraalOnroerendeZaken = new ArrayList<>();
    }
    this.kadastraalOnroerendeZaken.add(kadastraalOnroerendeZakenItem);
    return this;
  }

   /**
   * Get kadastraalOnroerendeZaken
   * @return kadastraalOnroerendeZaken
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<KadastraalOnroerendeZaakFiliatie> getKadastraalOnroerendeZaken() {
    return kadastraalOnroerendeZaken;
  }


  public void setKadastraalOnroerendeZaken(List<KadastraalOnroerendeZaakFiliatie> kadastraalOnroerendeZaken) {
    this.kadastraalOnroerendeZaken = kadastraalOnroerendeZaken;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Filiatie filiatie = (Filiatie) o;
    return Objects.equals(this.aard, filiatie.aard) &&
        Objects.equals(this.kadastraalOnroerendeZaken, filiatie.kadastraalOnroerendeZaken);
  }

  @Override
  public int hashCode() {
    return Objects.hash(aard, kadastraalOnroerendeZaken);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Filiatie {\n");
    sb.append("    aard: ").append(toIndentedString(aard)).append("\n");
    sb.append("    kadastraalOnroerendeZaken: ").append(toIndentedString(kadastraalOnroerendeZaken)).append("\n");
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

