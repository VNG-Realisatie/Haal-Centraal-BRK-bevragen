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
import org.openapitools.client.model.PrivaatrechtelijkeBeperkingHal;
import org.openapitools.client.model.ZakelijkGerechtigdeHal;

/**
 * KadastraalOnroerendeZaakEmbedded
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-07-21T07:24:37.064592Z[Etc/UTC]")
public class KadastraalOnroerendeZaakEmbedded {
  public static final String SERIALIZED_NAME_ZAKELIJK_GERECHTIGDEN = "zakelijkGerechtigden";
  @SerializedName(SERIALIZED_NAME_ZAKELIJK_GERECHTIGDEN)
  private List<ZakelijkGerechtigdeHal> zakelijkGerechtigden = null;

  public static final String SERIALIZED_NAME_PRIVAATRECHTELIJKE_BEPERKINGEN = "privaatrechtelijkeBeperkingen";
  @SerializedName(SERIALIZED_NAME_PRIVAATRECHTELIJKE_BEPERKINGEN)
  private List<PrivaatrechtelijkeBeperkingHal> privaatrechtelijkeBeperkingen = null;


  public KadastraalOnroerendeZaakEmbedded zakelijkGerechtigden(List<ZakelijkGerechtigdeHal> zakelijkGerechtigden) {
    
    this.zakelijkGerechtigden = zakelijkGerechtigden;
    return this;
  }

  public KadastraalOnroerendeZaakEmbedded addZakelijkGerechtigdenItem(ZakelijkGerechtigdeHal zakelijkGerechtigdenItem) {
    if (this.zakelijkGerechtigden == null) {
      this.zakelijkGerechtigden = new ArrayList<>();
    }
    this.zakelijkGerechtigden.add(zakelijkGerechtigdenItem);
    return this;
  }

   /**
   * Get zakelijkGerechtigden
   * @return zakelijkGerechtigden
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<ZakelijkGerechtigdeHal> getZakelijkGerechtigden() {
    return zakelijkGerechtigden;
  }


  public void setZakelijkGerechtigden(List<ZakelijkGerechtigdeHal> zakelijkGerechtigden) {
    this.zakelijkGerechtigden = zakelijkGerechtigden;
  }


  public KadastraalOnroerendeZaakEmbedded privaatrechtelijkeBeperkingen(List<PrivaatrechtelijkeBeperkingHal> privaatrechtelijkeBeperkingen) {
    
    this.privaatrechtelijkeBeperkingen = privaatrechtelijkeBeperkingen;
    return this;
  }

  public KadastraalOnroerendeZaakEmbedded addPrivaatrechtelijkeBeperkingenItem(PrivaatrechtelijkeBeperkingHal privaatrechtelijkeBeperkingenItem) {
    if (this.privaatrechtelijkeBeperkingen == null) {
      this.privaatrechtelijkeBeperkingen = new ArrayList<>();
    }
    this.privaatrechtelijkeBeperkingen.add(privaatrechtelijkeBeperkingenItem);
    return this;
  }

   /**
   * Get privaatrechtelijkeBeperkingen
   * @return privaatrechtelijkeBeperkingen
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<PrivaatrechtelijkeBeperkingHal> getPrivaatrechtelijkeBeperkingen() {
    return privaatrechtelijkeBeperkingen;
  }


  public void setPrivaatrechtelijkeBeperkingen(List<PrivaatrechtelijkeBeperkingHal> privaatrechtelijkeBeperkingen) {
    this.privaatrechtelijkeBeperkingen = privaatrechtelijkeBeperkingen;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    KadastraalOnroerendeZaakEmbedded kadastraalOnroerendeZaakEmbedded = (KadastraalOnroerendeZaakEmbedded) o;
    return Objects.equals(this.zakelijkGerechtigden, kadastraalOnroerendeZaakEmbedded.zakelijkGerechtigden) &&
        Objects.equals(this.privaatrechtelijkeBeperkingen, kadastraalOnroerendeZaakEmbedded.privaatrechtelijkeBeperkingen);
  }

  @Override
  public int hashCode() {
    return Objects.hash(zakelijkGerechtigden, privaatrechtelijkeBeperkingen);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class KadastraalOnroerendeZaakEmbedded {\n");
    sb.append("    zakelijkGerechtigden: ").append(toIndentedString(zakelijkGerechtigden)).append("\n");
    sb.append("    privaatrechtelijkeBeperkingen: ").append(toIndentedString(privaatrechtelijkeBeperkingen)).append("\n");
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

