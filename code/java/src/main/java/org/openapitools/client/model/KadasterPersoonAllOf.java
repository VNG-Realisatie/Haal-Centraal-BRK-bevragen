/*
 * Kadaster - BRK-Bevragen API
 * D.m.v. deze toepassing worden meerdere, korte bevragingen op de Basis Registratie Kadaster beschikbaar gesteld. Deze toepassing betreft het verstrekken van Kadastrale Onroerende Zaak informatie.
 *
 * The version of the OpenAPI document: 1.1.0
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
import org.openapitools.client.model.Adres;
import org.openapitools.client.model.Postadres;
import org.openapitools.client.model.Waardelijst;

/**
 * Een in de basisregistratie kadaster geregistreerde persoon.  Waardelijst in deze component : [beschikkingsbevoegdheid](http://www.kadaster.nl/schemas/waardelijsten/Beschikkingsbevoegdheid/)
 */
@ApiModel(description = "Een in de basisregistratie kadaster geregistreerde persoon.  Waardelijst in deze component : [beschikkingsbevoegdheid](http://www.kadaster.nl/schemas/waardelijsten/Beschikkingsbevoegdheid/)")
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2020-07-16T15:31:15.936+02:00[Europe/Amsterdam]")
public class KadasterPersoonAllOf {
  public static final String SERIALIZED_NAME_DOMEIN = "domein";
  @SerializedName(SERIALIZED_NAME_DOMEIN)
  private String domein;

  public static final String SERIALIZED_NAME_INDICATIE_NIET_TOONBARE_DIAKRIET = "indicatieNietToonbareDiakriet";
  @SerializedName(SERIALIZED_NAME_INDICATIE_NIET_TOONBARE_DIAKRIET)
  private Boolean indicatieNietToonbareDiakriet;

  public static final String SERIALIZED_NAME_BESCHIKKINGSBEVOEGDHEID = "beschikkingsbevoegdheid";
  @SerializedName(SERIALIZED_NAME_BESCHIKKINGSBEVOEGDHEID)
  private Waardelijst beschikkingsbevoegdheid;

  public static final String SERIALIZED_NAME_WOONADRES = "woonadres";
  @SerializedName(SERIALIZED_NAME_WOONADRES)
  private Adres woonadres;

  public static final String SERIALIZED_NAME_POSTADRES = "postadres";
  @SerializedName(SERIALIZED_NAME_POSTADRES)
  private Postadres postadres = null;

  public static final String SERIALIZED_NAME_KADASTRAAL_ONROERENDE_ZAAK_IDENTIFICATIES = "kadastraalOnroerendeZaakIdentificaties";
  @SerializedName(SERIALIZED_NAME_KADASTRAAL_ONROERENDE_ZAAK_IDENTIFICATIES)
  private List<String> kadastraalOnroerendeZaakIdentificaties = null;


  public KadasterPersoonAllOf domein(String domein) {
    
    this.domein = domein;
    return this;
  }

   /**
   * Het domein waartoe de identificatie behoort.
   * @return domein
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Het domein waartoe de identificatie behoort.")

  public String getDomein() {
    return domein;
  }


  public void setDomein(String domein) {
    this.domein = domein;
  }


  public KadasterPersoonAllOf indicatieNietToonbareDiakriet(Boolean indicatieNietToonbareDiakriet) {
    
    this.indicatieNietToonbareDiakriet = indicatieNietToonbareDiakriet;
    return this;
  }

   /**
   * Get indicatieNietToonbareDiakriet
   * @return indicatieNietToonbareDiakriet
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getIndicatieNietToonbareDiakriet() {
    return indicatieNietToonbareDiakriet;
  }


  public void setIndicatieNietToonbareDiakriet(Boolean indicatieNietToonbareDiakriet) {
    this.indicatieNietToonbareDiakriet = indicatieNietToonbareDiakriet;
  }


  public KadasterPersoonAllOf beschikkingsbevoegdheid(Waardelijst beschikkingsbevoegdheid) {
    
    this.beschikkingsbevoegdheid = beschikkingsbevoegdheid;
    return this;
  }

   /**
   * Get beschikkingsbevoegdheid
   * @return beschikkingsbevoegdheid
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Waardelijst getBeschikkingsbevoegdheid() {
    return beschikkingsbevoegdheid;
  }


  public void setBeschikkingsbevoegdheid(Waardelijst beschikkingsbevoegdheid) {
    this.beschikkingsbevoegdheid = beschikkingsbevoegdheid;
  }


  public KadasterPersoonAllOf woonadres(Adres woonadres) {
    
    this.woonadres = woonadres;
    return this;
  }

   /**
   * Get woonadres
   * @return woonadres
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Adres getWoonadres() {
    return woonadres;
  }


  public void setWoonadres(Adres woonadres) {
    this.woonadres = woonadres;
  }


  public KadasterPersoonAllOf postadres(Postadres postadres) {
    
    this.postadres = postadres;
    return this;
  }

   /**
   * Get postadres
   * @return postadres
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Postadres getPostadres() {
    return postadres;
  }


  public void setPostadres(Postadres postadres) {
    this.postadres = postadres;
  }


  public KadasterPersoonAllOf kadastraalOnroerendeZaakIdentificaties(List<String> kadastraalOnroerendeZaakIdentificaties) {
    
    this.kadastraalOnroerendeZaakIdentificaties = kadastraalOnroerendeZaakIdentificaties;
    return this;
  }

  public KadasterPersoonAllOf addKadastraalOnroerendeZaakIdentificatiesItem(String kadastraalOnroerendeZaakIdentificatiesItem) {
    if (this.kadastraalOnroerendeZaakIdentificaties == null) {
      this.kadastraalOnroerendeZaakIdentificaties = new ArrayList<>();
    }
    this.kadastraalOnroerendeZaakIdentificaties.add(kadastraalOnroerendeZaakIdentificatiesItem);
    return this;
  }

   /**
   * Get kadastraalOnroerendeZaakIdentificaties
   * @return kadastraalOnroerendeZaakIdentificaties
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<String> getKadastraalOnroerendeZaakIdentificaties() {
    return kadastraalOnroerendeZaakIdentificaties;
  }


  public void setKadastraalOnroerendeZaakIdentificaties(List<String> kadastraalOnroerendeZaakIdentificaties) {
    this.kadastraalOnroerendeZaakIdentificaties = kadastraalOnroerendeZaakIdentificaties;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    KadasterPersoonAllOf kadasterPersoonAllOf = (KadasterPersoonAllOf) o;
    return Objects.equals(this.domein, kadasterPersoonAllOf.domein) &&
        Objects.equals(this.indicatieNietToonbareDiakriet, kadasterPersoonAllOf.indicatieNietToonbareDiakriet) &&
        Objects.equals(this.beschikkingsbevoegdheid, kadasterPersoonAllOf.beschikkingsbevoegdheid) &&
        Objects.equals(this.woonadres, kadasterPersoonAllOf.woonadres) &&
        Objects.equals(this.postadres, kadasterPersoonAllOf.postadres) &&
        Objects.equals(this.kadastraalOnroerendeZaakIdentificaties, kadasterPersoonAllOf.kadastraalOnroerendeZaakIdentificaties);
  }

  @Override
  public int hashCode() {
    return Objects.hash(domein, indicatieNietToonbareDiakriet, beschikkingsbevoegdheid, woonadres, postadres, kadastraalOnroerendeZaakIdentificaties);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class KadasterPersoonAllOf {\n");
    sb.append("    domein: ").append(toIndentedString(domein)).append("\n");
    sb.append("    indicatieNietToonbareDiakriet: ").append(toIndentedString(indicatieNietToonbareDiakriet)).append("\n");
    sb.append("    beschikkingsbevoegdheid: ").append(toIndentedString(beschikkingsbevoegdheid)).append("\n");
    sb.append("    woonadres: ").append(toIndentedString(woonadres)).append("\n");
    sb.append("    postadres: ").append(toIndentedString(postadres)).append("\n");
    sb.append("    kadastraalOnroerendeZaakIdentificaties: ").append(toIndentedString(kadastraalOnroerendeZaakIdentificaties)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

