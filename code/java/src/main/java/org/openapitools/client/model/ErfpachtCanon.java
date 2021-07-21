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
import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;
import org.openapitools.client.model.Bedrag;
import org.openapitools.client.model.Waardelijst;

/**
 * Het bedrag dat een erfpachter moet betalen aan de eigenaar van een stuk grond omdat hij zijn grond gebruikt.   Waardelijst in deze component :   [soortErfpachtCanon](http://www.kadaster.nl/schemas/waardelijsten/SoortErfpachtcanon/) 
 */
@ApiModel(description = "Het bedrag dat een erfpachter moet betalen aan de eigenaar van een stuk grond omdat hij zijn grond gebruikt.   Waardelijst in deze component :   [soortErfpachtCanon](http://www.kadaster.nl/schemas/waardelijsten/SoortErfpachtcanon/) ")
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-07-21T07:24:37.064592Z[Etc/UTC]")
public class ErfpachtCanon {
  public static final String SERIALIZED_NAME_SOORT_ERFPACHT_CANON = "soortErfpachtCanon";
  @SerializedName(SERIALIZED_NAME_SOORT_ERFPACHT_CANON)
  private Waardelijst soortErfpachtCanon;

  public static final String SERIALIZED_NAME_JAARLIJKS_BEDRAG = "jaarlijksBedrag";
  @SerializedName(SERIALIZED_NAME_JAARLIJKS_BEDRAG)
  private Bedrag jaarlijksBedrag;

  public static final String SERIALIZED_NAME_BETREF_MEER_ONROERENDE_ZAKEN = "betrefMeerOnroerendeZaken";
  @SerializedName(SERIALIZED_NAME_BETREF_MEER_ONROERENDE_ZAKEN)
  private Boolean betrefMeerOnroerendeZaken;

  public static final String SERIALIZED_NAME_EINDDATUM_AFKOOP = "einddatumAfkoop";
  @SerializedName(SERIALIZED_NAME_EINDDATUM_AFKOOP)
  private LocalDate einddatumAfkoop;

  public static final String SERIALIZED_NAME_INDICATIE_OUDE_ONROERENDE_ZAAK_BETROKKEN = "indicatieOudeOnroerendeZaakBetrokken";
  @SerializedName(SERIALIZED_NAME_INDICATIE_OUDE_ONROERENDE_ZAAK_BETROKKEN)
  private Boolean indicatieOudeOnroerendeZaakBetrokken;

  public static final String SERIALIZED_NAME_IS_GEBASEERD_OP_STUKDEEL_IDENTIFICATIE = "isGebaseerdOpStukdeelIdentificatie";
  @SerializedName(SERIALIZED_NAME_IS_GEBASEERD_OP_STUKDEEL_IDENTIFICATIE)
  private String isGebaseerdOpStukdeelIdentificatie;

  public static final String SERIALIZED_NAME_IS_VERMELD_IN_STUKDEEL_IDENTIFICATIES = "isVermeldInStukdeelIdentificaties";
  @SerializedName(SERIALIZED_NAME_IS_VERMELD_IN_STUKDEEL_IDENTIFICATIES)
  private List<String> isVermeldInStukdeelIdentificaties = null;

  public static final String SERIALIZED_NAME_STUK_IDENTIFICATIES = "stukIdentificaties";
  @SerializedName(SERIALIZED_NAME_STUK_IDENTIFICATIES)
  private List<String> stukIdentificaties = null;


  public ErfpachtCanon soortErfpachtCanon(Waardelijst soortErfpachtCanon) {
    
    this.soortErfpachtCanon = soortErfpachtCanon;
    return this;
  }

   /**
   * Get soortErfpachtCanon
   * @return soortErfpachtCanon
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Waardelijst getSoortErfpachtCanon() {
    return soortErfpachtCanon;
  }


  public void setSoortErfpachtCanon(Waardelijst soortErfpachtCanon) {
    this.soortErfpachtCanon = soortErfpachtCanon;
  }


  public ErfpachtCanon jaarlijksBedrag(Bedrag jaarlijksBedrag) {
    
    this.jaarlijksBedrag = jaarlijksBedrag;
    return this;
  }

   /**
   * Get jaarlijksBedrag
   * @return jaarlijksBedrag
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Bedrag getJaarlijksBedrag() {
    return jaarlijksBedrag;
  }


  public void setJaarlijksBedrag(Bedrag jaarlijksBedrag) {
    this.jaarlijksBedrag = jaarlijksBedrag;
  }


  public ErfpachtCanon betrefMeerOnroerendeZaken(Boolean betrefMeerOnroerendeZaken) {
    
    this.betrefMeerOnroerendeZaken = betrefMeerOnroerendeZaken;
    return this;
  }

   /**
   * Indicatie waarmee wordt aangegeven dat het jaarlijks bedrag meerdere onroerende zaken betreft. 
   * @return betrefMeerOnroerendeZaken
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Indicatie waarmee wordt aangegeven dat het jaarlijks bedrag meerdere onroerende zaken betreft. ")

  public Boolean getBetrefMeerOnroerendeZaken() {
    return betrefMeerOnroerendeZaken;
  }


  public void setBetrefMeerOnroerendeZaken(Boolean betrefMeerOnroerendeZaken) {
    this.betrefMeerOnroerendeZaken = betrefMeerOnroerendeZaken;
  }


  public ErfpachtCanon einddatumAfkoop(LocalDate einddatumAfkoop) {
    
    this.einddatumAfkoop = einddatumAfkoop;
    return this;
  }

   /**
   * Get einddatumAfkoop
   * @return einddatumAfkoop
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public LocalDate getEinddatumAfkoop() {
    return einddatumAfkoop;
  }


  public void setEinddatumAfkoop(LocalDate einddatumAfkoop) {
    this.einddatumAfkoop = einddatumAfkoop;
  }


  public ErfpachtCanon indicatieOudeOnroerendeZaakBetrokken(Boolean indicatieOudeOnroerendeZaakBetrokken) {
    
    this.indicatieOudeOnroerendeZaakBetrokken = indicatieOudeOnroerendeZaakBetrokken;
    return this;
  }

   /**
   * Indicatie waarmee wordt aangegeven dat de erfpacht oorspronkelijk gevestigd is bij een perceel dat later is verenigd met een ander perceel. 
   * @return indicatieOudeOnroerendeZaakBetrokken
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Indicatie waarmee wordt aangegeven dat de erfpacht oorspronkelijk gevestigd is bij een perceel dat later is verenigd met een ander perceel. ")

  public Boolean getIndicatieOudeOnroerendeZaakBetrokken() {
    return indicatieOudeOnroerendeZaakBetrokken;
  }


  public void setIndicatieOudeOnroerendeZaakBetrokken(Boolean indicatieOudeOnroerendeZaakBetrokken) {
    this.indicatieOudeOnroerendeZaakBetrokken = indicatieOudeOnroerendeZaakBetrokken;
  }


  public ErfpachtCanon isGebaseerdOpStukdeelIdentificatie(String isGebaseerdOpStukdeelIdentificatie) {
    
    this.isGebaseerdOpStukdeelIdentificatie = isGebaseerdOpStukdeelIdentificatie;
    return this;
  }

   /**
   * De identificatie van het stukdeel (paragraaf in een akte met een rechtsfeit) waarop deze erfpachtcanon is gebaseerd. 
   * @return isGebaseerdOpStukdeelIdentificatie
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "De identificatie van het stukdeel (paragraaf in een akte met een rechtsfeit) waarop deze erfpachtcanon is gebaseerd. ")

  public String getIsGebaseerdOpStukdeelIdentificatie() {
    return isGebaseerdOpStukdeelIdentificatie;
  }


  public void setIsGebaseerdOpStukdeelIdentificatie(String isGebaseerdOpStukdeelIdentificatie) {
    this.isGebaseerdOpStukdeelIdentificatie = isGebaseerdOpStukdeelIdentificatie;
  }


  public ErfpachtCanon isVermeldInStukdeelIdentificaties(List<String> isVermeldInStukdeelIdentificaties) {
    
    this.isVermeldInStukdeelIdentificaties = isVermeldInStukdeelIdentificaties;
    return this;
  }

  public ErfpachtCanon addIsVermeldInStukdeelIdentificatiesItem(String isVermeldInStukdeelIdentificatiesItem) {
    if (this.isVermeldInStukdeelIdentificaties == null) {
      this.isVermeldInStukdeelIdentificaties = new ArrayList<>();
    }
    this.isVermeldInStukdeelIdentificaties.add(isVermeldInStukdeelIdentificatiesItem);
    return this;
  }

   /**
   * De identificaties van de stukdelen (paragrafen in een akte met een rechtsfeit) waarin deze erfpachtcanon is vermeld 
   * @return isVermeldInStukdeelIdentificaties
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "De identificaties van de stukdelen (paragrafen in een akte met een rechtsfeit) waarin deze erfpachtcanon is vermeld ")

  public List<String> getIsVermeldInStukdeelIdentificaties() {
    return isVermeldInStukdeelIdentificaties;
  }


  public void setIsVermeldInStukdeelIdentificaties(List<String> isVermeldInStukdeelIdentificaties) {
    this.isVermeldInStukdeelIdentificaties = isVermeldInStukdeelIdentificaties;
  }


  public ErfpachtCanon stukIdentificaties(List<String> stukIdentificaties) {
    
    this.stukIdentificaties = stukIdentificaties;
    return this;
  }

  public ErfpachtCanon addStukIdentificatiesItem(String stukIdentificatiesItem) {
    if (this.stukIdentificaties == null) {
      this.stukIdentificaties = new ArrayList<>();
    }
    this.stukIdentificaties.add(stukIdentificatiesItem);
    return this;
  }

   /**
   * Identificatie van het stuk. Een stuk is een brondocument dat aanleiding geeft tot een wijziging van de gegevens in een basisregistratie. Dit kan een aangeboden stuk of een kadasterstuk zijn. 
   * @return stukIdentificaties
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Identificatie van het stuk. Een stuk is een brondocument dat aanleiding geeft tot een wijziging van de gegevens in een basisregistratie. Dit kan een aangeboden stuk of een kadasterstuk zijn. ")

  public List<String> getStukIdentificaties() {
    return stukIdentificaties;
  }


  public void setStukIdentificaties(List<String> stukIdentificaties) {
    this.stukIdentificaties = stukIdentificaties;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ErfpachtCanon erfpachtCanon = (ErfpachtCanon) o;
    return Objects.equals(this.soortErfpachtCanon, erfpachtCanon.soortErfpachtCanon) &&
        Objects.equals(this.jaarlijksBedrag, erfpachtCanon.jaarlijksBedrag) &&
        Objects.equals(this.betrefMeerOnroerendeZaken, erfpachtCanon.betrefMeerOnroerendeZaken) &&
        Objects.equals(this.einddatumAfkoop, erfpachtCanon.einddatumAfkoop) &&
        Objects.equals(this.indicatieOudeOnroerendeZaakBetrokken, erfpachtCanon.indicatieOudeOnroerendeZaakBetrokken) &&
        Objects.equals(this.isGebaseerdOpStukdeelIdentificatie, erfpachtCanon.isGebaseerdOpStukdeelIdentificatie) &&
        Objects.equals(this.isVermeldInStukdeelIdentificaties, erfpachtCanon.isVermeldInStukdeelIdentificaties) &&
        Objects.equals(this.stukIdentificaties, erfpachtCanon.stukIdentificaties);
  }

  @Override
  public int hashCode() {
    return Objects.hash(soortErfpachtCanon, jaarlijksBedrag, betrefMeerOnroerendeZaken, einddatumAfkoop, indicatieOudeOnroerendeZaakBetrokken, isGebaseerdOpStukdeelIdentificatie, isVermeldInStukdeelIdentificaties, stukIdentificaties);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ErfpachtCanon {\n");
    sb.append("    soortErfpachtCanon: ").append(toIndentedString(soortErfpachtCanon)).append("\n");
    sb.append("    jaarlijksBedrag: ").append(toIndentedString(jaarlijksBedrag)).append("\n");
    sb.append("    betrefMeerOnroerendeZaken: ").append(toIndentedString(betrefMeerOnroerendeZaken)).append("\n");
    sb.append("    einddatumAfkoop: ").append(toIndentedString(einddatumAfkoop)).append("\n");
    sb.append("    indicatieOudeOnroerendeZaakBetrokken: ").append(toIndentedString(indicatieOudeOnroerendeZaakBetrokken)).append("\n");
    sb.append("    isGebaseerdOpStukdeelIdentificatie: ").append(toIndentedString(isGebaseerdOpStukdeelIdentificatie)).append("\n");
    sb.append("    isVermeldInStukdeelIdentificaties: ").append(toIndentedString(isVermeldInStukdeelIdentificaties)).append("\n");
    sb.append("    stukIdentificaties: ").append(toIndentedString(stukIdentificaties)).append("\n");
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

