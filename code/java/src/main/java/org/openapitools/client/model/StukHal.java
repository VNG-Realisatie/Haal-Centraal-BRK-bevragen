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
import org.openapitools.client.model.DeelEnNummer;
import org.openapitools.client.model.EquivalentieVerklaarder;
import org.openapitools.client.model.Kadasterverzoek;
import org.openapitools.client.model.StukEmbedded;
import org.openapitools.client.model.StukHalAllOf;
import org.openapitools.client.model.StukHalBasis;
import org.openapitools.client.model.StukLinks;
import org.openapitools.client.model.Waardelijst;

/**
 * StukHal
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-09-22T10:30:56.069820Z[Etc/UTC]")
public class StukHal {
  public static final String SERIALIZED_NAME_IDENTIFICATIE = "identificatie";
  @SerializedName(SERIALIZED_NAME_IDENTIFICATIE)
  private String identificatie;

  public static final String SERIALIZED_NAME_DEEL_EN_NUMMER = "deelEnNummer";
  @SerializedName(SERIALIZED_NAME_DEEL_EN_NUMMER)
  private DeelEnNummer deelEnNummer;

  public static final String SERIALIZED_NAME_DOMEIN = "domein";
  @SerializedName(SERIALIZED_NAME_DOMEIN)
  private String domein;

  public static final String SERIALIZED_NAME_TOELICHTING_BEWAARDER = "toelichtingBewaarder";
  @SerializedName(SERIALIZED_NAME_TOELICHTING_BEWAARDER)
  private String toelichtingBewaarder;

  public static final String SERIALIZED_NAME_STUKDEEL_IDENTIFICATIES = "stukdeelIdentificaties";
  @SerializedName(SERIALIZED_NAME_STUKDEEL_IDENTIFICATIES)
  private List<String> stukdeelIdentificaties = null;

  public static final String SERIALIZED_NAME_BEWAARDERS_VERKLARING = "bewaardersVerklaring";
  @SerializedName(SERIALIZED_NAME_BEWAARDERS_VERKLARING)
  private String bewaardersVerklaring;

  public static final String SERIALIZED_NAME_INDICATIE_TEKENING_BIJGEVOEGD = "indicatieTekeningBijgevoegd";
  @SerializedName(SERIALIZED_NAME_INDICATIE_TEKENING_BIJGEVOEGD)
  private Boolean indicatieTekeningBijgevoegd;

  public static final String SERIALIZED_NAME_AARD = "aard";
  @SerializedName(SERIALIZED_NAME_AARD)
  private Waardelijst aard;

  public static final String SERIALIZED_NAME_STATUS = "status";
  @SerializedName(SERIALIZED_NAME_STATUS)
  private Waardelijst status;

  public static final String SERIALIZED_NAME_EQUIVALENTIE_VERKLAARDER = "equivalentieVerklaarder";
  @SerializedName(SERIALIZED_NAME_EQUIVALENTIE_VERKLAARDER)
  private EquivalentieVerklaarder equivalentieVerklaarder;

  public static final String SERIALIZED_NAME_KADASTERVERZOEKEN = "kadasterverzoeken";
  @SerializedName(SERIALIZED_NAME_KADASTERVERZOEKEN)
  private List<Kadasterverzoek> kadasterverzoeken = null;

  public static final String SERIALIZED_NAME_LINKS = "_links";
  @SerializedName(SERIALIZED_NAME_LINKS)
  private StukLinks links;

  public static final String SERIALIZED_NAME_EMBEDDED = "_embedded";
  @SerializedName(SERIALIZED_NAME_EMBEDDED)
  private StukEmbedded embedded;


  public StukHal identificatie(String identificatie) {
    
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


  public StukHal deelEnNummer(DeelEnNummer deelEnNummer) {
    
    this.deelEnNummer = deelEnNummer;
    return this;
  }

   /**
   * Get deelEnNummer
   * @return deelEnNummer
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public DeelEnNummer getDeelEnNummer() {
    return deelEnNummer;
  }


  public void setDeelEnNummer(DeelEnNummer deelEnNummer) {
    this.deelEnNummer = deelEnNummer;
  }


  public StukHal domein(String domein) {
    
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


  public StukHal toelichtingBewaarder(String toelichtingBewaarder) {
    
    this.toelichtingBewaarder = toelichtingBewaarder;
    return this;
  }

   /**
   * Toelichtende tekst bij een onroerende zaak van de bewaarder. De bewaarder is iemand die bij het Kadaster werkt. Hij schrijft stukken in in de openbare registers en de basisregistratie Kadaster conform de Kadasterwet. 
   * @return toelichtingBewaarder
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Toelichtende tekst bij een onroerende zaak van de bewaarder. De bewaarder is iemand die bij het Kadaster werkt. Hij schrijft stukken in in de openbare registers en de basisregistratie Kadaster conform de Kadasterwet. ")

  public String getToelichtingBewaarder() {
    return toelichtingBewaarder;
  }


  public void setToelichtingBewaarder(String toelichtingBewaarder) {
    this.toelichtingBewaarder = toelichtingBewaarder;
  }


  public StukHal stukdeelIdentificaties(List<String> stukdeelIdentificaties) {
    
    this.stukdeelIdentificaties = stukdeelIdentificaties;
    return this;
  }

  public StukHal addStukdeelIdentificatiesItem(String stukdeelIdentificatiesItem) {
    if (this.stukdeelIdentificaties == null) {
      this.stukdeelIdentificaties = new ArrayList<>();
    }
    this.stukdeelIdentificaties.add(stukdeelIdentificatiesItem);
    return this;
  }

   /**
   * Get stukdeelIdentificaties
   * @return stukdeelIdentificaties
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<String> getStukdeelIdentificaties() {
    return stukdeelIdentificaties;
  }


  public void setStukdeelIdentificaties(List<String> stukdeelIdentificaties) {
    this.stukdeelIdentificaties = stukdeelIdentificaties;
  }


  public StukHal bewaardersVerklaring(String bewaardersVerklaring) {
    
    this.bewaardersVerklaring = bewaardersVerklaring;
    return this;
  }

   /**
   * Correctie in de openbare registers door de bewaarder. De bewaarder is iemand die bij het Kadaster werkt. Hij schrijft stukken in in de openbare registers en de basisregistratie Kadaster conform de Kadasterwet. 
   * @return bewaardersVerklaring
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Correctie in de openbare registers door de bewaarder. De bewaarder is iemand die bij het Kadaster werkt. Hij schrijft stukken in in de openbare registers en de basisregistratie Kadaster conform de Kadasterwet. ")

  public String getBewaardersVerklaring() {
    return bewaardersVerklaring;
  }


  public void setBewaardersVerklaring(String bewaardersVerklaring) {
    this.bewaardersVerklaring = bewaardersVerklaring;
  }


  public StukHal indicatieTekeningBijgevoegd(Boolean indicatieTekeningBijgevoegd) {
    
    this.indicatieTekeningBijgevoegd = indicatieTekeningBijgevoegd;
    return this;
  }

   /**
   * Geeft aan dat er een tekening van het appartement als bijlage bij het stuk aanwezig is. 
   * @return indicatieTekeningBijgevoegd
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Geeft aan dat er een tekening van het appartement als bijlage bij het stuk aanwezig is. ")

  public Boolean getIndicatieTekeningBijgevoegd() {
    return indicatieTekeningBijgevoegd;
  }


  public void setIndicatieTekeningBijgevoegd(Boolean indicatieTekeningBijgevoegd) {
    this.indicatieTekeningBijgevoegd = indicatieTekeningBijgevoegd;
  }


  public StukHal aard(Waardelijst aard) {
    
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


  public StukHal status(Waardelijst status) {
    
    this.status = status;
    return this;
  }

   /**
   * Get status
   * @return status
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Waardelijst getStatus() {
    return status;
  }


  public void setStatus(Waardelijst status) {
    this.status = status;
  }


  public StukHal equivalentieVerklaarder(EquivalentieVerklaarder equivalentieVerklaarder) {
    
    this.equivalentieVerklaarder = equivalentieVerklaarder;
    return this;
  }

   /**
   * Get equivalentieVerklaarder
   * @return equivalentieVerklaarder
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public EquivalentieVerklaarder getEquivalentieVerklaarder() {
    return equivalentieVerklaarder;
  }


  public void setEquivalentieVerklaarder(EquivalentieVerklaarder equivalentieVerklaarder) {
    this.equivalentieVerklaarder = equivalentieVerklaarder;
  }


  public StukHal kadasterverzoeken(List<Kadasterverzoek> kadasterverzoeken) {
    
    this.kadasterverzoeken = kadasterverzoeken;
    return this;
  }

  public StukHal addKadasterverzoekenItem(Kadasterverzoek kadasterverzoekenItem) {
    if (this.kadasterverzoeken == null) {
      this.kadasterverzoeken = new ArrayList<>();
    }
    this.kadasterverzoeken.add(kadasterverzoekenItem);
    return this;
  }

   /**
   * Get kadasterverzoeken
   * @return kadasterverzoeken
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<Kadasterverzoek> getKadasterverzoeken() {
    return kadasterverzoeken;
  }


  public void setKadasterverzoeken(List<Kadasterverzoek> kadasterverzoeken) {
    this.kadasterverzoeken = kadasterverzoeken;
  }


  public StukHal links(StukLinks links) {
    
    this.links = links;
    return this;
  }

   /**
   * Get links
   * @return links
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public StukLinks getLinks() {
    return links;
  }


  public void setLinks(StukLinks links) {
    this.links = links;
  }


  public StukHal embedded(StukEmbedded embedded) {
    
    this.embedded = embedded;
    return this;
  }

   /**
   * Get embedded
   * @return embedded
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public StukEmbedded getEmbedded() {
    return embedded;
  }


  public void setEmbedded(StukEmbedded embedded) {
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
    StukHal stukHal = (StukHal) o;
    return Objects.equals(this.identificatie, stukHal.identificatie) &&
        Objects.equals(this.deelEnNummer, stukHal.deelEnNummer) &&
        Objects.equals(this.domein, stukHal.domein) &&
        Objects.equals(this.toelichtingBewaarder, stukHal.toelichtingBewaarder) &&
        Objects.equals(this.stukdeelIdentificaties, stukHal.stukdeelIdentificaties) &&
        Objects.equals(this.bewaardersVerklaring, stukHal.bewaardersVerklaring) &&
        Objects.equals(this.indicatieTekeningBijgevoegd, stukHal.indicatieTekeningBijgevoegd) &&
        Objects.equals(this.aard, stukHal.aard) &&
        Objects.equals(this.status, stukHal.status) &&
        Objects.equals(this.equivalentieVerklaarder, stukHal.equivalentieVerklaarder) &&
        Objects.equals(this.kadasterverzoeken, stukHal.kadasterverzoeken) &&
        Objects.equals(this.links, stukHal.links) &&
        Objects.equals(this.embedded, stukHal.embedded);
  }

  @Override
  public int hashCode() {
    return Objects.hash(identificatie, deelEnNummer, domein, toelichtingBewaarder, stukdeelIdentificaties, bewaardersVerklaring, indicatieTekeningBijgevoegd, aard, status, equivalentieVerklaarder, kadasterverzoeken, links, embedded);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class StukHal {\n");
    sb.append("    identificatie: ").append(toIndentedString(identificatie)).append("\n");
    sb.append("    deelEnNummer: ").append(toIndentedString(deelEnNummer)).append("\n");
    sb.append("    domein: ").append(toIndentedString(domein)).append("\n");
    sb.append("    toelichtingBewaarder: ").append(toIndentedString(toelichtingBewaarder)).append("\n");
    sb.append("    stukdeelIdentificaties: ").append(toIndentedString(stukdeelIdentificaties)).append("\n");
    sb.append("    bewaardersVerklaring: ").append(toIndentedString(bewaardersVerklaring)).append("\n");
    sb.append("    indicatieTekeningBijgevoegd: ").append(toIndentedString(indicatieTekeningBijgevoegd)).append("\n");
    sb.append("    aard: ").append(toIndentedString(aard)).append("\n");
    sb.append("    status: ").append(toIndentedString(status)).append("\n");
    sb.append("    equivalentieVerklaarder: ").append(toIndentedString(equivalentieVerklaarder)).append("\n");
    sb.append("    kadasterverzoeken: ").append(toIndentedString(kadasterverzoeken)).append("\n");
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

