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
import org.openapitools.client.model.AantekeningHypotheek;
import org.openapitools.client.model.Bedrag;
import org.openapitools.client.model.PersoonBeperkt;
import org.openapitools.client.model.TypeBreuk;
import org.openapitools.client.model.Waardelijst;

/**
 * Bij een hypotheek op de kadastraal onroerende zaak dient het eigendomsrecht van de hypotheekgever als onderpand voor een geldlening of krediet bij de hypotheekhouder (geldverstrekker).  Waardelijst in deze component : - [omschrijvingBetrokkenRecht](http://www.kadaster.nl/schemas/waardelijsten/BetrokkenRecht/) 
 */
@ApiModel(description = "Bij een hypotheek op de kadastraal onroerende zaak dient het eigendomsrecht van de hypotheekgever als onderpand voor een geldlening of krediet bij de hypotheekhouder (geldverstrekker).  Waardelijst in deze component : - [omschrijvingBetrokkenRecht](http://www.kadaster.nl/schemas/waardelijsten/BetrokkenRecht/) ")
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-07-21T07:24:37.064592Z[Etc/UTC]")
public class Hypotheek {
  public static final String SERIALIZED_NAME_IDENTIFICATIE = "identificatie";
  @SerializedName(SERIALIZED_NAME_IDENTIFICATIE)
  private String identificatie;

  public static final String SERIALIZED_NAME_DOMEIN = "domein";
  @SerializedName(SERIALIZED_NAME_DOMEIN)
  private String domein;

  public static final String SERIALIZED_NAME_AANDEEL_IN_BETROKKEN_RECHT = "aandeelInBetrokkenRecht";
  @SerializedName(SERIALIZED_NAME_AANDEEL_IN_BETROKKEN_RECHT)
  private TypeBreuk aandeelInBetrokkenRecht;

  public static final String SERIALIZED_NAME_GEDEELTELIJKE_BEZWARING_OUD_OBJECT = "gedeeltelijkeBezwaringOudObject";
  @SerializedName(SERIALIZED_NAME_GEDEELTELIJKE_BEZWARING_OUD_OBJECT)
  private Boolean gedeeltelijkeBezwaringOudObject;

  public static final String SERIALIZED_NAME_OMSCHRIJVING_BETROKKEN_RECHT = "omschrijvingBetrokkenRecht";
  @SerializedName(SERIALIZED_NAME_OMSCHRIJVING_BETROKKEN_RECHT)
  private Waardelijst omschrijvingBetrokkenRecht;

  public static final String SERIALIZED_NAME_TOELICHTING_BEWAARDER = "toelichtingBewaarder";
  @SerializedName(SERIALIZED_NAME_TOELICHTING_BEWAARDER)
  private String toelichtingBewaarder;

  public static final String SERIALIZED_NAME_BETREFT_GEDEELTE_VAN_PERCEEL = "betreftGedeelteVanPerceel";
  @SerializedName(SERIALIZED_NAME_BETREFT_GEDEELTE_VAN_PERCEEL)
  private Boolean betreftGedeelteVanPerceel;

  public static final String SERIALIZED_NAME_AANTEKENINGEN = "aantekeningen";
  @SerializedName(SERIALIZED_NAME_AANTEKENINGEN)
  private List<AantekeningHypotheek> aantekeningen = null;

  public static final String SERIALIZED_NAME_HYPOTHEEKHOUDERS = "hypotheekhouders";
  @SerializedName(SERIALIZED_NAME_HYPOTHEEKHOUDERS)
  private List<PersoonBeperkt> hypotheekhouders = null;

  public static final String SERIALIZED_NAME_BEDRAG_ZEKERHEIDSSTELLING = "bedragZekerheidsstelling";
  @SerializedName(SERIALIZED_NAME_BEDRAG_ZEKERHEIDSSTELLING)
  private Bedrag bedragZekerheidsstelling;

  public static final String SERIALIZED_NAME_STUK_IDENTIFICATIES = "stukIdentificaties";
  @SerializedName(SERIALIZED_NAME_STUK_IDENTIFICATIES)
  private List<String> stukIdentificaties = null;

  public static final String SERIALIZED_NAME_OMSCHRIJVING_GEKOZEN_WOONPLAATS = "omschrijvingGekozenWoonplaats";
  @SerializedName(SERIALIZED_NAME_OMSCHRIJVING_GEKOZEN_WOONPLAATS)
  private String omschrijvingGekozenWoonplaats;

  public static final String SERIALIZED_NAME_IS_GEBASEERD_OP_STUKDEEL_IDENTIFICATIE = "isGebaseerdOpStukdeelIdentificatie";
  @SerializedName(SERIALIZED_NAME_IS_GEBASEERD_OP_STUKDEEL_IDENTIFICATIE)
  private String isGebaseerdOpStukdeelIdentificatie;

  public static final String SERIALIZED_NAME_IS_VERMELD_IN_STUKDEEL_IDENTIFICATIES = "isVermeldInStukdeelIdentificaties";
  @SerializedName(SERIALIZED_NAME_IS_VERMELD_IN_STUKDEEL_IDENTIFICATIES)
  private List<String> isVermeldInStukdeelIdentificaties = null;


  public Hypotheek identificatie(String identificatie) {
    
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


  public Hypotheek domein(String domein) {
    
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


  public Hypotheek aandeelInBetrokkenRecht(TypeBreuk aandeelInBetrokkenRecht) {
    
    this.aandeelInBetrokkenRecht = aandeelInBetrokkenRecht;
    return this;
  }

   /**
   * Get aandeelInBetrokkenRecht
   * @return aandeelInBetrokkenRecht
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public TypeBreuk getAandeelInBetrokkenRecht() {
    return aandeelInBetrokkenRecht;
  }


  public void setAandeelInBetrokkenRecht(TypeBreuk aandeelInBetrokkenRecht) {
    this.aandeelInBetrokkenRecht = aandeelInBetrokkenRecht;
  }


  public Hypotheek gedeeltelijkeBezwaringOudObject(Boolean gedeeltelijkeBezwaringOudObject) {
    
    this.gedeeltelijkeBezwaringOudObject = gedeeltelijkeBezwaringOudObject;
    return this;
  }

   /**
   * Get gedeeltelijkeBezwaringOudObject
   * @return gedeeltelijkeBezwaringOudObject
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getGedeeltelijkeBezwaringOudObject() {
    return gedeeltelijkeBezwaringOudObject;
  }


  public void setGedeeltelijkeBezwaringOudObject(Boolean gedeeltelijkeBezwaringOudObject) {
    this.gedeeltelijkeBezwaringOudObject = gedeeltelijkeBezwaringOudObject;
  }


  public Hypotheek omschrijvingBetrokkenRecht(Waardelijst omschrijvingBetrokkenRecht) {
    
    this.omschrijvingBetrokkenRecht = omschrijvingBetrokkenRecht;
    return this;
  }

   /**
   * Get omschrijvingBetrokkenRecht
   * @return omschrijvingBetrokkenRecht
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Waardelijst getOmschrijvingBetrokkenRecht() {
    return omschrijvingBetrokkenRecht;
  }


  public void setOmschrijvingBetrokkenRecht(Waardelijst omschrijvingBetrokkenRecht) {
    this.omschrijvingBetrokkenRecht = omschrijvingBetrokkenRecht;
  }


  public Hypotheek toelichtingBewaarder(String toelichtingBewaarder) {
    
    this.toelichtingBewaarder = toelichtingBewaarder;
    return this;
  }

   /**
   * Toelichtende tekst van de bewaarder. De bewaarder is iemand die bij het Kadaster werkt. Hij schrijft stukken in in de openbare registers en de basisregistratie Kadaster conform de Kadasterwet. 
   * @return toelichtingBewaarder
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Toelichtende tekst van de bewaarder. De bewaarder is iemand die bij het Kadaster werkt. Hij schrijft stukken in in de openbare registers en de basisregistratie Kadaster conform de Kadasterwet. ")

  public String getToelichtingBewaarder() {
    return toelichtingBewaarder;
  }


  public void setToelichtingBewaarder(String toelichtingBewaarder) {
    this.toelichtingBewaarder = toelichtingBewaarder;
  }


  public Hypotheek betreftGedeelteVanPerceel(Boolean betreftGedeelteVanPerceel) {
    
    this.betreftGedeelteVanPerceel = betreftGedeelteVanPerceel;
    return this;
  }

   /**
   * Get betreftGedeelteVanPerceel
   * @return betreftGedeelteVanPerceel
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getBetreftGedeelteVanPerceel() {
    return betreftGedeelteVanPerceel;
  }


  public void setBetreftGedeelteVanPerceel(Boolean betreftGedeelteVanPerceel) {
    this.betreftGedeelteVanPerceel = betreftGedeelteVanPerceel;
  }


  public Hypotheek aantekeningen(List<AantekeningHypotheek> aantekeningen) {
    
    this.aantekeningen = aantekeningen;
    return this;
  }

  public Hypotheek addAantekeningenItem(AantekeningHypotheek aantekeningenItem) {
    if (this.aantekeningen == null) {
      this.aantekeningen = new ArrayList<>();
    }
    this.aantekeningen.add(aantekeningenItem);
    return this;
  }

   /**
   * Get aantekeningen
   * @return aantekeningen
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<AantekeningHypotheek> getAantekeningen() {
    return aantekeningen;
  }


  public void setAantekeningen(List<AantekeningHypotheek> aantekeningen) {
    this.aantekeningen = aantekeningen;
  }


  public Hypotheek hypotheekhouders(List<PersoonBeperkt> hypotheekhouders) {
    
    this.hypotheekhouders = hypotheekhouders;
    return this;
  }

  public Hypotheek addHypotheekhoudersItem(PersoonBeperkt hypotheekhoudersItem) {
    if (this.hypotheekhouders == null) {
      this.hypotheekhouders = new ArrayList<>();
    }
    this.hypotheekhouders.add(hypotheekhoudersItem);
    return this;
  }

   /**
   * Een hypotheekhouder vestigt als geldverstrekker een recht van hypotheek als zekerheid voor de lening. 
   * @return hypotheekhouders
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Een hypotheekhouder vestigt als geldverstrekker een recht van hypotheek als zekerheid voor de lening. ")

  public List<PersoonBeperkt> getHypotheekhouders() {
    return hypotheekhouders;
  }


  public void setHypotheekhouders(List<PersoonBeperkt> hypotheekhouders) {
    this.hypotheekhouders = hypotheekhouders;
  }


  public Hypotheek bedragZekerheidsstelling(Bedrag bedragZekerheidsstelling) {
    
    this.bedragZekerheidsstelling = bedragZekerheidsstelling;
    return this;
  }

   /**
   * Get bedragZekerheidsstelling
   * @return bedragZekerheidsstelling
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Bedrag getBedragZekerheidsstelling() {
    return bedragZekerheidsstelling;
  }


  public void setBedragZekerheidsstelling(Bedrag bedragZekerheidsstelling) {
    this.bedragZekerheidsstelling = bedragZekerheidsstelling;
  }


  public Hypotheek stukIdentificaties(List<String> stukIdentificaties) {
    
    this.stukIdentificaties = stukIdentificaties;
    return this;
  }

  public Hypotheek addStukIdentificatiesItem(String stukIdentificatiesItem) {
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


  public Hypotheek omschrijvingGekozenWoonplaats(String omschrijvingGekozenWoonplaats) {
    
    this.omschrijvingGekozenWoonplaats = omschrijvingGekozenWoonplaats;
    return this;
  }

   /**
   * Get omschrijvingGekozenWoonplaats
   * @return omschrijvingGekozenWoonplaats
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getOmschrijvingGekozenWoonplaats() {
    return omschrijvingGekozenWoonplaats;
  }


  public void setOmschrijvingGekozenWoonplaats(String omschrijvingGekozenWoonplaats) {
    this.omschrijvingGekozenWoonplaats = omschrijvingGekozenWoonplaats;
  }


  public Hypotheek isGebaseerdOpStukdeelIdentificatie(String isGebaseerdOpStukdeelIdentificatie) {
    
    this.isGebaseerdOpStukdeelIdentificatie = isGebaseerdOpStukdeelIdentificatie;
    return this;
  }

   /**
   * De identificatie van het stukdeel (paragraaf in een akte met een rechtsfeit) waarop deze hypotheek is gebaseerd. 
   * @return isGebaseerdOpStukdeelIdentificatie
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "De identificatie van het stukdeel (paragraaf in een akte met een rechtsfeit) waarop deze hypotheek is gebaseerd. ")

  public String getIsGebaseerdOpStukdeelIdentificatie() {
    return isGebaseerdOpStukdeelIdentificatie;
  }


  public void setIsGebaseerdOpStukdeelIdentificatie(String isGebaseerdOpStukdeelIdentificatie) {
    this.isGebaseerdOpStukdeelIdentificatie = isGebaseerdOpStukdeelIdentificatie;
  }


  public Hypotheek isVermeldInStukdeelIdentificaties(List<String> isVermeldInStukdeelIdentificaties) {
    
    this.isVermeldInStukdeelIdentificaties = isVermeldInStukdeelIdentificaties;
    return this;
  }

  public Hypotheek addIsVermeldInStukdeelIdentificatiesItem(String isVermeldInStukdeelIdentificatiesItem) {
    if (this.isVermeldInStukdeelIdentificaties == null) {
      this.isVermeldInStukdeelIdentificaties = new ArrayList<>();
    }
    this.isVermeldInStukdeelIdentificaties.add(isVermeldInStukdeelIdentificatiesItem);
    return this;
  }

   /**
   * De identificaties van de stukdelen (paragrafen in een akte met een rechtsfeit) waarin deze hypotheek is vermeld 
   * @return isVermeldInStukdeelIdentificaties
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "De identificaties van de stukdelen (paragrafen in een akte met een rechtsfeit) waarin deze hypotheek is vermeld ")

  public List<String> getIsVermeldInStukdeelIdentificaties() {
    return isVermeldInStukdeelIdentificaties;
  }


  public void setIsVermeldInStukdeelIdentificaties(List<String> isVermeldInStukdeelIdentificaties) {
    this.isVermeldInStukdeelIdentificaties = isVermeldInStukdeelIdentificaties;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Hypotheek hypotheek = (Hypotheek) o;
    return Objects.equals(this.identificatie, hypotheek.identificatie) &&
        Objects.equals(this.domein, hypotheek.domein) &&
        Objects.equals(this.aandeelInBetrokkenRecht, hypotheek.aandeelInBetrokkenRecht) &&
        Objects.equals(this.gedeeltelijkeBezwaringOudObject, hypotheek.gedeeltelijkeBezwaringOudObject) &&
        Objects.equals(this.omschrijvingBetrokkenRecht, hypotheek.omschrijvingBetrokkenRecht) &&
        Objects.equals(this.toelichtingBewaarder, hypotheek.toelichtingBewaarder) &&
        Objects.equals(this.betreftGedeelteVanPerceel, hypotheek.betreftGedeelteVanPerceel) &&
        Objects.equals(this.aantekeningen, hypotheek.aantekeningen) &&
        Objects.equals(this.hypotheekhouders, hypotheek.hypotheekhouders) &&
        Objects.equals(this.bedragZekerheidsstelling, hypotheek.bedragZekerheidsstelling) &&
        Objects.equals(this.stukIdentificaties, hypotheek.stukIdentificaties) &&
        Objects.equals(this.omschrijvingGekozenWoonplaats, hypotheek.omschrijvingGekozenWoonplaats) &&
        Objects.equals(this.isGebaseerdOpStukdeelIdentificatie, hypotheek.isGebaseerdOpStukdeelIdentificatie) &&
        Objects.equals(this.isVermeldInStukdeelIdentificaties, hypotheek.isVermeldInStukdeelIdentificaties);
  }

  @Override
  public int hashCode() {
    return Objects.hash(identificatie, domein, aandeelInBetrokkenRecht, gedeeltelijkeBezwaringOudObject, omschrijvingBetrokkenRecht, toelichtingBewaarder, betreftGedeelteVanPerceel, aantekeningen, hypotheekhouders, bedragZekerheidsstelling, stukIdentificaties, omschrijvingGekozenWoonplaats, isGebaseerdOpStukdeelIdentificatie, isVermeldInStukdeelIdentificaties);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Hypotheek {\n");
    sb.append("    identificatie: ").append(toIndentedString(identificatie)).append("\n");
    sb.append("    domein: ").append(toIndentedString(domein)).append("\n");
    sb.append("    aandeelInBetrokkenRecht: ").append(toIndentedString(aandeelInBetrokkenRecht)).append("\n");
    sb.append("    gedeeltelijkeBezwaringOudObject: ").append(toIndentedString(gedeeltelijkeBezwaringOudObject)).append("\n");
    sb.append("    omschrijvingBetrokkenRecht: ").append(toIndentedString(omschrijvingBetrokkenRecht)).append("\n");
    sb.append("    toelichtingBewaarder: ").append(toIndentedString(toelichtingBewaarder)).append("\n");
    sb.append("    betreftGedeelteVanPerceel: ").append(toIndentedString(betreftGedeelteVanPerceel)).append("\n");
    sb.append("    aantekeningen: ").append(toIndentedString(aantekeningen)).append("\n");
    sb.append("    hypotheekhouders: ").append(toIndentedString(hypotheekhouders)).append("\n");
    sb.append("    bedragZekerheidsstelling: ").append(toIndentedString(bedragZekerheidsstelling)).append("\n");
    sb.append("    stukIdentificaties: ").append(toIndentedString(stukIdentificaties)).append("\n");
    sb.append("    omschrijvingGekozenWoonplaats: ").append(toIndentedString(omschrijvingGekozenWoonplaats)).append("\n");
    sb.append("    isGebaseerdOpStukdeelIdentificatie: ").append(toIndentedString(isGebaseerdOpStukdeelIdentificatie)).append("\n");
    sb.append("    isVermeldInStukdeelIdentificaties: ").append(toIndentedString(isVermeldInStukdeelIdentificaties)).append("\n");
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

