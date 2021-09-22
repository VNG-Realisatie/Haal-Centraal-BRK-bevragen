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
import org.openapitools.client.model.Bedrag;
import org.openapitools.client.model.StukdeelEmbedded;
import org.openapitools.client.model.StukdeelHalAllOf;
import org.openapitools.client.model.StukdeelHalBasis;
import org.openapitools.client.model.StukdeelLinks;
import org.openapitools.client.model.Waardelijst;

/**
 * StukdeelHal
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-09-22T08:28:41.072015Z[Etc/UTC]")
public class StukdeelHal {
  public static final String SERIALIZED_NAME_IDENTIFICATIE = "identificatie";
  @SerializedName(SERIALIZED_NAME_IDENTIFICATIE)
  private String identificatie;

  public static final String SERIALIZED_NAME_DOMEIN = "domein";
  @SerializedName(SERIALIZED_NAME_DOMEIN)
  private String domein;

  public static final String SERIALIZED_NAME_AARD = "aard";
  @SerializedName(SERIALIZED_NAME_AARD)
  private Waardelijst aard;

  public static final String SERIALIZED_NAME_BEDRAG_TRANSACTIESOM_LEVERING = "bedragTransactiesomLevering";
  @SerializedName(SERIALIZED_NAME_BEDRAG_TRANSACTIESOM_LEVERING)
  private Bedrag bedragTransactiesomLevering;

  public static final String SERIALIZED_NAME_OMSCHRIJVING_KADASTRALE_OBJECTEN = "omschrijvingKadastraleObjecten";
  @SerializedName(SERIALIZED_NAME_OMSCHRIJVING_KADASTRALE_OBJECTEN)
  private String omschrijvingKadastraleObjecten;

  public static final String SERIALIZED_NAME_OMSCHRIJVING_TOPOGRAFISCHE_MUTATIE = "omschrijvingTopografischeMutatie";
  @SerializedName(SERIALIZED_NAME_OMSCHRIJVING_TOPOGRAFISCHE_MUTATIE)
  private String omschrijvingTopografischeMutatie;

  public static final String SERIALIZED_NAME_LINKS = "_links";
  @SerializedName(SERIALIZED_NAME_LINKS)
  private StukdeelLinks links;

  public static final String SERIALIZED_NAME_EMBEDDED = "_embedded";
  @SerializedName(SERIALIZED_NAME_EMBEDDED)
  private StukdeelEmbedded embedded;


  public StukdeelHal identificatie(String identificatie) {
    
    this.identificatie = identificatie;
    return this;
  }

   /**
   * Get identificatie
   * @return identificatie
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getIdentificatie() {
    return identificatie;
  }


  public void setIdentificatie(String identificatie) {
    this.identificatie = identificatie;
  }


  public StukdeelHal domein(String domein) {
    
    this.domein = domein;
    return this;
  }

   /**
   * Het domein waartoe de identificatie behoort. 
   * @return domein
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Het domein waartoe de identificatie behoort. ")

  public String getDomein() {
    return domein;
  }


  public void setDomein(String domein) {
    this.domein = domein;
  }


  public StukdeelHal aard(Waardelijst aard) {
    
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


  public StukdeelHal bedragTransactiesomLevering(Bedrag bedragTransactiesomLevering) {
    
    this.bedragTransactiesomLevering = bedragTransactiesomLevering;
    return this;
  }

   /**
   * Get bedragTransactiesomLevering
   * @return bedragTransactiesomLevering
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Bedrag getBedragTransactiesomLevering() {
    return bedragTransactiesomLevering;
  }


  public void setBedragTransactiesomLevering(Bedrag bedragTransactiesomLevering) {
    this.bedragTransactiesomLevering = bedragTransactiesomLevering;
  }


  public StukdeelHal omschrijvingKadastraleObjecten(String omschrijvingKadastraleObjecten) {
    
    this.omschrijvingKadastraleObjecten = omschrijvingKadastraleObjecten;
    return this;
  }

   /**
   * Get omschrijvingKadastraleObjecten
   * @return omschrijvingKadastraleObjecten
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getOmschrijvingKadastraleObjecten() {
    return omschrijvingKadastraleObjecten;
  }


  public void setOmschrijvingKadastraleObjecten(String omschrijvingKadastraleObjecten) {
    this.omschrijvingKadastraleObjecten = omschrijvingKadastraleObjecten;
  }


  public StukdeelHal omschrijvingTopografischeMutatie(String omschrijvingTopografischeMutatie) {
    
    this.omschrijvingTopografischeMutatie = omschrijvingTopografischeMutatie;
    return this;
  }

   /**
   * Get omschrijvingTopografischeMutatie
   * @return omschrijvingTopografischeMutatie
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getOmschrijvingTopografischeMutatie() {
    return omschrijvingTopografischeMutatie;
  }


  public void setOmschrijvingTopografischeMutatie(String omschrijvingTopografischeMutatie) {
    this.omschrijvingTopografischeMutatie = omschrijvingTopografischeMutatie;
  }


  public StukdeelHal links(StukdeelLinks links) {
    
    this.links = links;
    return this;
  }

   /**
   * Get links
   * @return links
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public StukdeelLinks getLinks() {
    return links;
  }


  public void setLinks(StukdeelLinks links) {
    this.links = links;
  }


  public StukdeelHal embedded(StukdeelEmbedded embedded) {
    
    this.embedded = embedded;
    return this;
  }

   /**
   * Get embedded
   * @return embedded
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public StukdeelEmbedded getEmbedded() {
    return embedded;
  }


  public void setEmbedded(StukdeelEmbedded embedded) {
    this.embedded = embedded;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    StukdeelHal stukdeelHal = (StukdeelHal) o;
    return Objects.equals(this.identificatie, stukdeelHal.identificatie) &&
        Objects.equals(this.domein, stukdeelHal.domein) &&
        Objects.equals(this.aard, stukdeelHal.aard) &&
        Objects.equals(this.bedragTransactiesomLevering, stukdeelHal.bedragTransactiesomLevering) &&
        Objects.equals(this.omschrijvingKadastraleObjecten, stukdeelHal.omschrijvingKadastraleObjecten) &&
        Objects.equals(this.omschrijvingTopografischeMutatie, stukdeelHal.omschrijvingTopografischeMutatie) &&
        Objects.equals(this.links, stukdeelHal.links) &&
        Objects.equals(this.embedded, stukdeelHal.embedded);
  }

  @Override
  public int hashCode() {
    return Objects.hash(identificatie, domein, aard, bedragTransactiesomLevering, omschrijvingKadastraleObjecten, omschrijvingTopografischeMutatie, links, embedded);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class StukdeelHal {\n");
    sb.append("    identificatie: ").append(toIndentedString(identificatie)).append("\n");
    sb.append("    domein: ").append(toIndentedString(domein)).append("\n");
    sb.append("    aard: ").append(toIndentedString(aard)).append("\n");
    sb.append("    bedragTransactiesomLevering: ").append(toIndentedString(bedragTransactiesomLevering)).append("\n");
    sb.append("    omschrijvingKadastraleObjecten: ").append(toIndentedString(omschrijvingKadastraleObjecten)).append("\n");
    sb.append("    omschrijvingTopografischeMutatie: ").append(toIndentedString(omschrijvingTopografischeMutatie)).append("\n");
    sb.append("    links: ").append(toIndentedString(links)).append("\n");
    sb.append("    embedded: ").append(toIndentedString(embedded)).append("\n");
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

