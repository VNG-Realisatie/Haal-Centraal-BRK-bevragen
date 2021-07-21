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
import org.openapitools.client.model.KadasterNatuurlijkPersoonHal;

/**
 * KadasterNatuurlijkPersoonHalCollectieEmbedded
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-07-21T07:24:37.064592Z[Etc/UTC]")
public class KadasterNatuurlijkPersoonHalCollectieEmbedded {
  public static final String SERIALIZED_NAME_KADASTER_NATUURLIJK_PERSONEN = "kadasterNatuurlijkPersonen";
  @SerializedName(SERIALIZED_NAME_KADASTER_NATUURLIJK_PERSONEN)
  private List<KadasterNatuurlijkPersoonHal> kadasterNatuurlijkPersonen = null;


  public KadasterNatuurlijkPersoonHalCollectieEmbedded kadasterNatuurlijkPersonen(List<KadasterNatuurlijkPersoonHal> kadasterNatuurlijkPersonen) {
    
    this.kadasterNatuurlijkPersonen = kadasterNatuurlijkPersonen;
    return this;
  }

  public KadasterNatuurlijkPersoonHalCollectieEmbedded addKadasterNatuurlijkPersonenItem(KadasterNatuurlijkPersoonHal kadasterNatuurlijkPersonenItem) {
    if (this.kadasterNatuurlijkPersonen == null) {
      this.kadasterNatuurlijkPersonen = new ArrayList<>();
    }
    this.kadasterNatuurlijkPersonen.add(kadasterNatuurlijkPersonenItem);
    return this;
  }

   /**
   * Get kadasterNatuurlijkPersonen
   * @return kadasterNatuurlijkPersonen
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<KadasterNatuurlijkPersoonHal> getKadasterNatuurlijkPersonen() {
    return kadasterNatuurlijkPersonen;
  }


  public void setKadasterNatuurlijkPersonen(List<KadasterNatuurlijkPersoonHal> kadasterNatuurlijkPersonen) {
    this.kadasterNatuurlijkPersonen = kadasterNatuurlijkPersonen;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    KadasterNatuurlijkPersoonHalCollectieEmbedded kadasterNatuurlijkPersoonHalCollectieEmbedded = (KadasterNatuurlijkPersoonHalCollectieEmbedded) o;
    return Objects.equals(this.kadasterNatuurlijkPersonen, kadasterNatuurlijkPersoonHalCollectieEmbedded.kadasterNatuurlijkPersonen);
  }

  @Override
  public int hashCode() {
    return Objects.hash(kadasterNatuurlijkPersonen);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class KadasterNatuurlijkPersoonHalCollectieEmbedded {\n");
    sb.append("    kadasterNatuurlijkPersonen: ").append(toIndentedString(kadasterNatuurlijkPersonen)).append("\n");
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

