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
import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.List;
import org.openapitools.client.model.AppartementsrechtBasis;
import org.openapitools.client.model.Filiatie;
import org.openapitools.client.model.KadastraalOnroerendeZaak;
import org.openapitools.client.model.KadastraalOnroerendeZaakEmbedded;
import org.openapitools.client.model.KadastraalOnroerendeZaakHalAllOf;
import org.openapitools.client.model.KadastraalOnroerendeZaakLinks;
import org.openapitools.client.model.LocatieKadastraalObject;
import org.openapitools.client.model.PerceelBasis;
import org.openapitools.client.model.PointGeoJSON;
import org.openapitools.client.model.PolygonGeoJSON;
import org.openapitools.client.model.TypeKadastraalOnroerendeZaakEnum;
import org.openapitools.client.model.TypeKoopsom;
import org.openapitools.client.model.TypeOppervlak;
import org.openapitools.client.model.TypePerceelnummerVerschuiving;
import org.openapitools.client.model.Waardelijst;

/**
 * KadastraalOnroerendeZaakHal
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-09-22T08:28:41.072015Z[Etc/UTC]")
public class KadastraalOnroerendeZaakHal {
  public static final String SERIALIZED_NAME_IDENTIFICATIE = "identificatie";
  @SerializedName(SERIALIZED_NAME_IDENTIFICATIE)
  private String identificatie;

  public static final String SERIALIZED_NAME_DOMEIN = "domein";
  @SerializedName(SERIALIZED_NAME_DOMEIN)
  private String domein;

  public static final String SERIALIZED_NAME_INDICATIE_VERVALLEN = "indicatieVervallen";
  @SerializedName(SERIALIZED_NAME_INDICATIE_VERVALLEN)
  private Boolean indicatieVervallen;

  public static final String SERIALIZED_NAME_BEGRENZING_PERCEEL = "begrenzingPerceel";
  @SerializedName(SERIALIZED_NAME_BEGRENZING_PERCEEL)
  private PolygonGeoJSON begrenzingPerceel;

  public static final String SERIALIZED_NAME_PERCEELNUMMER_ROTATIE = "perceelnummerRotatie";
  @SerializedName(SERIALIZED_NAME_PERCEELNUMMER_ROTATIE)
  private BigDecimal perceelnummerRotatie;

  public static final String SERIALIZED_NAME_PLAATSCOORDINATEN = "plaatscoordinaten";
  @SerializedName(SERIALIZED_NAME_PLAATSCOORDINATEN)
  private PointGeoJSON plaatscoordinaten;

  public static final String SERIALIZED_NAME_KOOPSOM = "koopsom";
  @SerializedName(SERIALIZED_NAME_KOOPSOM)
  private TypeKoopsom koopsom;

  public static final String SERIALIZED_NAME_TOELICHTING_BEWAARDER = "toelichtingBewaarder";
  @SerializedName(SERIALIZED_NAME_TOELICHTING_BEWAARDER)
  private String toelichtingBewaarder;

  public static final String SERIALIZED_NAME_TYPE = "type";
  @SerializedName(SERIALIZED_NAME_TYPE)
  private TypeKadastraalOnroerendeZaakEnum type;

  public static final String SERIALIZED_NAME_AARD_CULTUUR_BEBOUWD = "aardCultuurBebouwd";
  @SerializedName(SERIALIZED_NAME_AARD_CULTUUR_BEBOUWD)
  private Waardelijst aardCultuurBebouwd;

  public static final String SERIALIZED_NAME_AARD_CULTUUR_ONBEBOUWD = "aardCultuurOnbebouwd";
  @SerializedName(SERIALIZED_NAME_AARD_CULTUUR_ONBEBOUWD)
  private Waardelijst aardCultuurOnbebouwd;

  public static final String SERIALIZED_NAME_KADASTRALE_AANDUIDING = "kadastraleAanduiding";
  @SerializedName(SERIALIZED_NAME_KADASTRALE_AANDUIDING)
  private String kadastraleAanduiding;

  public static final String SERIALIZED_NAME_KADASTRALE_GROOTTE = "kadastraleGrootte";
  @SerializedName(SERIALIZED_NAME_KADASTRALE_GROOTTE)
  private TypeOppervlak kadastraleGrootte;

  public static final String SERIALIZED_NAME_PERCEELNUMMER_VERSCHUIVING = "perceelnummerVerschuiving";
  @SerializedName(SERIALIZED_NAME_PERCEELNUMMER_VERSCHUIVING)
  private TypePerceelnummerVerschuiving perceelnummerVerschuiving;

  public static final String SERIALIZED_NAME_ADRESSEN = "adressen";
  @SerializedName(SERIALIZED_NAME_ADRESSEN)
  private List<LocatieKadastraalObject> adressen = null;

  public static final String SERIALIZED_NAME_ZAKELIJK_GERECHTIGDE_IDENTIFICATIES = "zakelijkGerechtigdeIdentificaties";
  @SerializedName(SERIALIZED_NAME_ZAKELIJK_GERECHTIGDE_IDENTIFICATIES)
  private List<String> zakelijkGerechtigdeIdentificaties = null;

  public static final String SERIALIZED_NAME_PRIVAATRECHTELIJKE_BEPERKING_IDENTIFICATIES = "privaatrechtelijkeBeperkingIdentificaties";
  @SerializedName(SERIALIZED_NAME_PRIVAATRECHTELIJKE_BEPERKING_IDENTIFICATIES)
  private List<String> privaatrechtelijkeBeperkingIdentificaties = null;

  public static final String SERIALIZED_NAME_HYPOTHEEK_IDENTIFICATIES = "hypotheekIdentificaties";
  @SerializedName(SERIALIZED_NAME_HYPOTHEEK_IDENTIFICATIES)
  private List<String> hypotheekIdentificaties = null;

  public static final String SERIALIZED_NAME_BESLAG_IDENTIFICATIES = "beslagIdentificaties";
  @SerializedName(SERIALIZED_NAME_BESLAG_IDENTIFICATIES)
  private List<String> beslagIdentificaties = null;

  public static final String SERIALIZED_NAME_IS_OVERGEGAAN_IN = "isOvergegaanIn";
  @SerializedName(SERIALIZED_NAME_IS_OVERGEGAAN_IN)
  private Filiatie isOvergegaanIn;

  public static final String SERIALIZED_NAME_IS_ONTSTAAN_UIT = "isOntstaanUit";
  @SerializedName(SERIALIZED_NAME_IS_ONTSTAAN_UIT)
  private Filiatie isOntstaanUit;

  public static final String SERIALIZED_NAME_BIJBEHORENDE_GRONDPERCELEN = "bijbehorendeGrondpercelen";
  @SerializedName(SERIALIZED_NAME_BIJBEHORENDE_GRONDPERCELEN)
  private List<PerceelBasis> bijbehorendeGrondpercelen = null;

  public static final String SERIALIZED_NAME_BIJBEHORENDE_APPARTEMENTSRECHTEN = "bijbehorendeAppartementsrechten";
  @SerializedName(SERIALIZED_NAME_BIJBEHORENDE_APPARTEMENTSRECHTEN)
  private List<AppartementsrechtBasis> bijbehorendeAppartementsrechten = null;

  public static final String SERIALIZED_NAME_IS_VERMELD_IN_STUKDEEL_IDENTIFICATIES = "isVermeldInStukdeelIdentificaties";
  @SerializedName(SERIALIZED_NAME_IS_VERMELD_IN_STUKDEEL_IDENTIFICATIES)
  private List<String> isVermeldInStukdeelIdentificaties = null;

  public static final String SERIALIZED_NAME_STUK_IDENTIFICATIES = "stukIdentificaties";
  @SerializedName(SERIALIZED_NAME_STUK_IDENTIFICATIES)
  private List<String> stukIdentificaties = null;

  public static final String SERIALIZED_NAME_LINKS = "_links";
  @SerializedName(SERIALIZED_NAME_LINKS)
  private KadastraalOnroerendeZaakLinks links;

  public static final String SERIALIZED_NAME_EMBEDDED = "_embedded";
  @SerializedName(SERIALIZED_NAME_EMBEDDED)
  private KadastraalOnroerendeZaakEmbedded embedded;


  public KadastraalOnroerendeZaakHal identificatie(String identificatie) {
    
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


  public KadastraalOnroerendeZaakHal domein(String domein) {
    
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


  public KadastraalOnroerendeZaakHal indicatieVervallen(Boolean indicatieVervallen) {
    
    this.indicatieVervallen = indicatieVervallen;
    return this;
  }

   /**
   * Vervallen objecten zijn opvraagbaar met de stand van zaken direct voordat het object vervallen is verklaard. Deze informatie is nodig om de filiatie-\&quot;boom\&quot; af te kunnen lopen en inzicht te krijgen in betrokken appartementsrechten en grondpercelen. 
   * @return indicatieVervallen
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Vervallen objecten zijn opvraagbaar met de stand van zaken direct voordat het object vervallen is verklaard. Deze informatie is nodig om de filiatie-\"boom\" af te kunnen lopen en inzicht te krijgen in betrokken appartementsrechten en grondpercelen. ")

  public Boolean getIndicatieVervallen() {
    return indicatieVervallen;
  }


  public void setIndicatieVervallen(Boolean indicatieVervallen) {
    this.indicatieVervallen = indicatieVervallen;
  }


  public KadastraalOnroerendeZaakHal begrenzingPerceel(PolygonGeoJSON begrenzingPerceel) {
    
    this.begrenzingPerceel = begrenzingPerceel;
    return this;
  }

   /**
   * Get begrenzingPerceel
   * @return begrenzingPerceel
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public PolygonGeoJSON getBegrenzingPerceel() {
    return begrenzingPerceel;
  }


  public void setBegrenzingPerceel(PolygonGeoJSON begrenzingPerceel) {
    this.begrenzingPerceel = begrenzingPerceel;
  }


  public KadastraalOnroerendeZaakHal perceelnummerRotatie(BigDecimal perceelnummerRotatie) {
    
    this.perceelnummerRotatie = perceelnummerRotatie;
    return this;
  }

   /**
   * Rotatie van het perceelnummer ten behoeve van visualisatie op de kaart. Perceelnummers worden bijvoorbeeld gekanteld om in een smal perceel te passen. 
   * maximum: 999
   * @return perceelnummerRotatie
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Rotatie van het perceelnummer ten behoeve van visualisatie op de kaart. Perceelnummers worden bijvoorbeeld gekanteld om in een smal perceel te passen. ")

  public BigDecimal getPerceelnummerRotatie() {
    return perceelnummerRotatie;
  }


  public void setPerceelnummerRotatie(BigDecimal perceelnummerRotatie) {
    this.perceelnummerRotatie = perceelnummerRotatie;
  }


  public KadastraalOnroerendeZaakHal plaatscoordinaten(PointGeoJSON plaatscoordinaten) {
    
    this.plaatscoordinaten = plaatscoordinaten;
    return this;
  }

   /**
   * Get plaatscoordinaten
   * @return plaatscoordinaten
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public PointGeoJSON getPlaatscoordinaten() {
    return plaatscoordinaten;
  }


  public void setPlaatscoordinaten(PointGeoJSON plaatscoordinaten) {
    this.plaatscoordinaten = plaatscoordinaten;
  }


  public KadastraalOnroerendeZaakHal koopsom(TypeKoopsom koopsom) {
    
    this.koopsom = koopsom;
    return this;
  }

   /**
   * Get koopsom
   * @return koopsom
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public TypeKoopsom getKoopsom() {
    return koopsom;
  }


  public void setKoopsom(TypeKoopsom koopsom) {
    this.koopsom = koopsom;
  }


  public KadastraalOnroerendeZaakHal toelichtingBewaarder(String toelichtingBewaarder) {
    
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


  public KadastraalOnroerendeZaakHal type(TypeKadastraalOnroerendeZaakEnum type) {
    
    this.type = type;
    return this;
  }

   /**
   * Get type
   * @return type
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public TypeKadastraalOnroerendeZaakEnum getType() {
    return type;
  }


  public void setType(TypeKadastraalOnroerendeZaakEnum type) {
    this.type = type;
  }


  public KadastraalOnroerendeZaakHal aardCultuurBebouwd(Waardelijst aardCultuurBebouwd) {
    
    this.aardCultuurBebouwd = aardCultuurBebouwd;
    return this;
  }

   /**
   * Get aardCultuurBebouwd
   * @return aardCultuurBebouwd
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Waardelijst getAardCultuurBebouwd() {
    return aardCultuurBebouwd;
  }


  public void setAardCultuurBebouwd(Waardelijst aardCultuurBebouwd) {
    this.aardCultuurBebouwd = aardCultuurBebouwd;
  }


  public KadastraalOnroerendeZaakHal aardCultuurOnbebouwd(Waardelijst aardCultuurOnbebouwd) {
    
    this.aardCultuurOnbebouwd = aardCultuurOnbebouwd;
    return this;
  }

   /**
   * Get aardCultuurOnbebouwd
   * @return aardCultuurOnbebouwd
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Waardelijst getAardCultuurOnbebouwd() {
    return aardCultuurOnbebouwd;
  }


  public void setAardCultuurOnbebouwd(Waardelijst aardCultuurOnbebouwd) {
    this.aardCultuurOnbebouwd = aardCultuurOnbebouwd;
  }


  public KadastraalOnroerendeZaakHal kadastraleAanduiding(String kadastraleAanduiding) {
    
    this.kadastraleAanduiding = kadastraleAanduiding;
    return this;
  }

   /**
   * Get kadastraleAanduiding
   * @return kadastraleAanduiding
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getKadastraleAanduiding() {
    return kadastraleAanduiding;
  }


  public void setKadastraleAanduiding(String kadastraleAanduiding) {
    this.kadastraleAanduiding = kadastraleAanduiding;
  }


  public KadastraalOnroerendeZaakHal kadastraleGrootte(TypeOppervlak kadastraleGrootte) {
    
    this.kadastraleGrootte = kadastraleGrootte;
    return this;
  }

   /**
   * Get kadastraleGrootte
   * @return kadastraleGrootte
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public TypeOppervlak getKadastraleGrootte() {
    return kadastraleGrootte;
  }


  public void setKadastraleGrootte(TypeOppervlak kadastraleGrootte) {
    this.kadastraleGrootte = kadastraleGrootte;
  }


  public KadastraalOnroerendeZaakHal perceelnummerVerschuiving(TypePerceelnummerVerschuiving perceelnummerVerschuiving) {
    
    this.perceelnummerVerschuiving = perceelnummerVerschuiving;
    return this;
  }

   /**
   * Get perceelnummerVerschuiving
   * @return perceelnummerVerschuiving
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public TypePerceelnummerVerschuiving getPerceelnummerVerschuiving() {
    return perceelnummerVerschuiving;
  }


  public void setPerceelnummerVerschuiving(TypePerceelnummerVerschuiving perceelnummerVerschuiving) {
    this.perceelnummerVerschuiving = perceelnummerVerschuiving;
  }


  public KadastraalOnroerendeZaakHal adressen(List<LocatieKadastraalObject> adressen) {
    
    this.adressen = adressen;
    return this;
  }

  public KadastraalOnroerendeZaakHal addAdressenItem(LocatieKadastraalObject adressenItem) {
    if (this.adressen == null) {
      this.adressen = new ArrayList<>();
    }
    this.adressen.add(adressenItem);
    return this;
  }

   /**
   * Alle binnenlandse adressen gekoppeld aan deze kadastraal onroerende zaak 
   * @return adressen
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Alle binnenlandse adressen gekoppeld aan deze kadastraal onroerende zaak ")

  public List<LocatieKadastraalObject> getAdressen() {
    return adressen;
  }


  public void setAdressen(List<LocatieKadastraalObject> adressen) {
    this.adressen = adressen;
  }


  public KadastraalOnroerendeZaakHal zakelijkGerechtigdeIdentificaties(List<String> zakelijkGerechtigdeIdentificaties) {
    
    this.zakelijkGerechtigdeIdentificaties = zakelijkGerechtigdeIdentificaties;
    return this;
  }

  public KadastraalOnroerendeZaakHal addZakelijkGerechtigdeIdentificatiesItem(String zakelijkGerechtigdeIdentificatiesItem) {
    if (this.zakelijkGerechtigdeIdentificaties == null) {
      this.zakelijkGerechtigdeIdentificaties = new ArrayList<>();
    }
    this.zakelijkGerechtigdeIdentificaties.add(zakelijkGerechtigdeIdentificatiesItem);
    return this;
  }

   /**
   * Alle personen en rechtspersonen die een zakelijk recht hebben op deze kadastraal onroerende zaak 
   * @return zakelijkGerechtigdeIdentificaties
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Alle personen en rechtspersonen die een zakelijk recht hebben op deze kadastraal onroerende zaak ")

  public List<String> getZakelijkGerechtigdeIdentificaties() {
    return zakelijkGerechtigdeIdentificaties;
  }


  public void setZakelijkGerechtigdeIdentificaties(List<String> zakelijkGerechtigdeIdentificaties) {
    this.zakelijkGerechtigdeIdentificaties = zakelijkGerechtigdeIdentificaties;
  }


  public KadastraalOnroerendeZaakHal privaatrechtelijkeBeperkingIdentificaties(List<String> privaatrechtelijkeBeperkingIdentificaties) {
    
    this.privaatrechtelijkeBeperkingIdentificaties = privaatrechtelijkeBeperkingIdentificaties;
    return this;
  }

  public KadastraalOnroerendeZaakHal addPrivaatrechtelijkeBeperkingIdentificatiesItem(String privaatrechtelijkeBeperkingIdentificatiesItem) {
    if (this.privaatrechtelijkeBeperkingIdentificaties == null) {
      this.privaatrechtelijkeBeperkingIdentificaties = new ArrayList<>();
    }
    this.privaatrechtelijkeBeperkingIdentificaties.add(privaatrechtelijkeBeperkingIdentificatiesItem);
    return this;
  }

   /**
   * Alle privaatrechtelijkebeperkingen die rusten op deze kadastraal onroerende zaak 
   * @return privaatrechtelijkeBeperkingIdentificaties
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Alle privaatrechtelijkebeperkingen die rusten op deze kadastraal onroerende zaak ")

  public List<String> getPrivaatrechtelijkeBeperkingIdentificaties() {
    return privaatrechtelijkeBeperkingIdentificaties;
  }


  public void setPrivaatrechtelijkeBeperkingIdentificaties(List<String> privaatrechtelijkeBeperkingIdentificaties) {
    this.privaatrechtelijkeBeperkingIdentificaties = privaatrechtelijkeBeperkingIdentificaties;
  }


  public KadastraalOnroerendeZaakHal hypotheekIdentificaties(List<String> hypotheekIdentificaties) {
    
    this.hypotheekIdentificaties = hypotheekIdentificaties;
    return this;
  }

  public KadastraalOnroerendeZaakHal addHypotheekIdentificatiesItem(String hypotheekIdentificatiesItem) {
    if (this.hypotheekIdentificaties == null) {
      this.hypotheekIdentificaties = new ArrayList<>();
    }
    this.hypotheekIdentificaties.add(hypotheekIdentificatiesItem);
    return this;
  }

   /**
   * Alle hypotheken die rusten op deze kadastraal onroerende zaak 
   * @return hypotheekIdentificaties
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Alle hypotheken die rusten op deze kadastraal onroerende zaak ")

  public List<String> getHypotheekIdentificaties() {
    return hypotheekIdentificaties;
  }


  public void setHypotheekIdentificaties(List<String> hypotheekIdentificaties) {
    this.hypotheekIdentificaties = hypotheekIdentificaties;
  }


  public KadastraalOnroerendeZaakHal beslagIdentificaties(List<String> beslagIdentificaties) {
    
    this.beslagIdentificaties = beslagIdentificaties;
    return this;
  }

  public KadastraalOnroerendeZaakHal addBeslagIdentificatiesItem(String beslagIdentificatiesItem) {
    if (this.beslagIdentificaties == null) {
      this.beslagIdentificaties = new ArrayList<>();
    }
    this.beslagIdentificaties.add(beslagIdentificatiesItem);
    return this;
  }

   /**
   * Alle beslagen die rusten op deze kadastraal onroerende zaak 
   * @return beslagIdentificaties
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Alle beslagen die rusten op deze kadastraal onroerende zaak ")

  public List<String> getBeslagIdentificaties() {
    return beslagIdentificaties;
  }


  public void setBeslagIdentificaties(List<String> beslagIdentificaties) {
    this.beslagIdentificaties = beslagIdentificaties;
  }


  public KadastraalOnroerendeZaakHal isOvergegaanIn(Filiatie isOvergegaanIn) {
    
    this.isOvergegaanIn = isOvergegaanIn;
    return this;
  }

   /**
   * Get isOvergegaanIn
   * @return isOvergegaanIn
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Filiatie getIsOvergegaanIn() {
    return isOvergegaanIn;
  }


  public void setIsOvergegaanIn(Filiatie isOvergegaanIn) {
    this.isOvergegaanIn = isOvergegaanIn;
  }


  public KadastraalOnroerendeZaakHal isOntstaanUit(Filiatie isOntstaanUit) {
    
    this.isOntstaanUit = isOntstaanUit;
    return this;
  }

   /**
   * Get isOntstaanUit
   * @return isOntstaanUit
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Filiatie getIsOntstaanUit() {
    return isOntstaanUit;
  }


  public void setIsOntstaanUit(Filiatie isOntstaanUit) {
    this.isOntstaanUit = isOntstaanUit;
  }


  public KadastraalOnroerendeZaakHal bijbehorendeGrondpercelen(List<PerceelBasis> bijbehorendeGrondpercelen) {
    
    this.bijbehorendeGrondpercelen = bijbehorendeGrondpercelen;
    return this;
  }

  public KadastraalOnroerendeZaakHal addBijbehorendeGrondpercelenItem(PerceelBasis bijbehorendeGrondpercelenItem) {
    if (this.bijbehorendeGrondpercelen == null) {
      this.bijbehorendeGrondpercelen = new ArrayList<>();
    }
    this.bijbehorendeGrondpercelen.add(bijbehorendeGrondpercelenItem);
    return this;
  }

   /**
   * De grondpercelen die bij deze Kadastraal Onroerende Zaak (appartementsrecht) hoort 
   * @return bijbehorendeGrondpercelen
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "De grondpercelen die bij deze Kadastraal Onroerende Zaak (appartementsrecht) hoort ")

  public List<PerceelBasis> getBijbehorendeGrondpercelen() {
    return bijbehorendeGrondpercelen;
  }


  public void setBijbehorendeGrondpercelen(List<PerceelBasis> bijbehorendeGrondpercelen) {
    this.bijbehorendeGrondpercelen = bijbehorendeGrondpercelen;
  }


  public KadastraalOnroerendeZaakHal bijbehorendeAppartementsrechten(List<AppartementsrechtBasis> bijbehorendeAppartementsrechten) {
    
    this.bijbehorendeAppartementsrechten = bijbehorendeAppartementsrechten;
    return this;
  }

  public KadastraalOnroerendeZaakHal addBijbehorendeAppartementsrechtenItem(AppartementsrechtBasis bijbehorendeAppartementsrechtenItem) {
    if (this.bijbehorendeAppartementsrechten == null) {
      this.bijbehorendeAppartementsrechten = new ArrayList<>();
    }
    this.bijbehorendeAppartementsrechten.add(bijbehorendeAppartementsrechtenItem);
    return this;
  }

   /**
   * De actuele appartementsrechten die bij deze KadastraalOnroerende Zaak (grondperceel) horen 
   * @return bijbehorendeAppartementsrechten
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "De actuele appartementsrechten die bij deze KadastraalOnroerende Zaak (grondperceel) horen ")

  public List<AppartementsrechtBasis> getBijbehorendeAppartementsrechten() {
    return bijbehorendeAppartementsrechten;
  }


  public void setBijbehorendeAppartementsrechten(List<AppartementsrechtBasis> bijbehorendeAppartementsrechten) {
    this.bijbehorendeAppartementsrechten = bijbehorendeAppartementsrechten;
  }


  public KadastraalOnroerendeZaakHal isVermeldInStukdeelIdentificaties(List<String> isVermeldInStukdeelIdentificaties) {
    
    this.isVermeldInStukdeelIdentificaties = isVermeldInStukdeelIdentificaties;
    return this;
  }

  public KadastraalOnroerendeZaakHal addIsVermeldInStukdeelIdentificatiesItem(String isVermeldInStukdeelIdentificatiesItem) {
    if (this.isVermeldInStukdeelIdentificaties == null) {
      this.isVermeldInStukdeelIdentificaties = new ArrayList<>();
    }
    this.isVermeldInStukdeelIdentificaties.add(isVermeldInStukdeelIdentificatiesItem);
    return this;
  }

   /**
   * Get isVermeldInStukdeelIdentificaties
   * @return isVermeldInStukdeelIdentificaties
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<String> getIsVermeldInStukdeelIdentificaties() {
    return isVermeldInStukdeelIdentificaties;
  }


  public void setIsVermeldInStukdeelIdentificaties(List<String> isVermeldInStukdeelIdentificaties) {
    this.isVermeldInStukdeelIdentificaties = isVermeldInStukdeelIdentificaties;
  }


  public KadastraalOnroerendeZaakHal stukIdentificaties(List<String> stukIdentificaties) {
    
    this.stukIdentificaties = stukIdentificaties;
    return this;
  }

  public KadastraalOnroerendeZaakHal addStukIdentificatiesItem(String stukIdentificatiesItem) {
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


  public KadastraalOnroerendeZaakHal links(KadastraalOnroerendeZaakLinks links) {
    
    this.links = links;
    return this;
  }

   /**
   * Get links
   * @return links
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public KadastraalOnroerendeZaakLinks getLinks() {
    return links;
  }


  public void setLinks(KadastraalOnroerendeZaakLinks links) {
    this.links = links;
  }


  public KadastraalOnroerendeZaakHal embedded(KadastraalOnroerendeZaakEmbedded embedded) {
    
    this.embedded = embedded;
    return this;
  }

   /**
   * Get embedded
   * @return embedded
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public KadastraalOnroerendeZaakEmbedded getEmbedded() {
    return embedded;
  }


  public void setEmbedded(KadastraalOnroerendeZaakEmbedded embedded) {
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
    KadastraalOnroerendeZaakHal kadastraalOnroerendeZaakHal = (KadastraalOnroerendeZaakHal) o;
    return Objects.equals(this.identificatie, kadastraalOnroerendeZaakHal.identificatie) &&
        Objects.equals(this.domein, kadastraalOnroerendeZaakHal.domein) &&
        Objects.equals(this.indicatieVervallen, kadastraalOnroerendeZaakHal.indicatieVervallen) &&
        Objects.equals(this.begrenzingPerceel, kadastraalOnroerendeZaakHal.begrenzingPerceel) &&
        Objects.equals(this.perceelnummerRotatie, kadastraalOnroerendeZaakHal.perceelnummerRotatie) &&
        Objects.equals(this.plaatscoordinaten, kadastraalOnroerendeZaakHal.plaatscoordinaten) &&
        Objects.equals(this.koopsom, kadastraalOnroerendeZaakHal.koopsom) &&
        Objects.equals(this.toelichtingBewaarder, kadastraalOnroerendeZaakHal.toelichtingBewaarder) &&
        Objects.equals(this.type, kadastraalOnroerendeZaakHal.type) &&
        Objects.equals(this.aardCultuurBebouwd, kadastraalOnroerendeZaakHal.aardCultuurBebouwd) &&
        Objects.equals(this.aardCultuurOnbebouwd, kadastraalOnroerendeZaakHal.aardCultuurOnbebouwd) &&
        Objects.equals(this.kadastraleAanduiding, kadastraalOnroerendeZaakHal.kadastraleAanduiding) &&
        Objects.equals(this.kadastraleGrootte, kadastraalOnroerendeZaakHal.kadastraleGrootte) &&
        Objects.equals(this.perceelnummerVerschuiving, kadastraalOnroerendeZaakHal.perceelnummerVerschuiving) &&
        Objects.equals(this.adressen, kadastraalOnroerendeZaakHal.adressen) &&
        Objects.equals(this.zakelijkGerechtigdeIdentificaties, kadastraalOnroerendeZaakHal.zakelijkGerechtigdeIdentificaties) &&
        Objects.equals(this.privaatrechtelijkeBeperkingIdentificaties, kadastraalOnroerendeZaakHal.privaatrechtelijkeBeperkingIdentificaties) &&
        Objects.equals(this.hypotheekIdentificaties, kadastraalOnroerendeZaakHal.hypotheekIdentificaties) &&
        Objects.equals(this.beslagIdentificaties, kadastraalOnroerendeZaakHal.beslagIdentificaties) &&
        Objects.equals(this.isOvergegaanIn, kadastraalOnroerendeZaakHal.isOvergegaanIn) &&
        Objects.equals(this.isOntstaanUit, kadastraalOnroerendeZaakHal.isOntstaanUit) &&
        Objects.equals(this.bijbehorendeGrondpercelen, kadastraalOnroerendeZaakHal.bijbehorendeGrondpercelen) &&
        Objects.equals(this.bijbehorendeAppartementsrechten, kadastraalOnroerendeZaakHal.bijbehorendeAppartementsrechten) &&
        Objects.equals(this.isVermeldInStukdeelIdentificaties, kadastraalOnroerendeZaakHal.isVermeldInStukdeelIdentificaties) &&
        Objects.equals(this.stukIdentificaties, kadastraalOnroerendeZaakHal.stukIdentificaties) &&
        Objects.equals(this.links, kadastraalOnroerendeZaakHal.links) &&
        Objects.equals(this.embedded, kadastraalOnroerendeZaakHal.embedded);
  }

  @Override
  public int hashCode() {
    return Objects.hash(identificatie, domein, indicatieVervallen, begrenzingPerceel, perceelnummerRotatie, plaatscoordinaten, koopsom, toelichtingBewaarder, type, aardCultuurBebouwd, aardCultuurOnbebouwd, kadastraleAanduiding, kadastraleGrootte, perceelnummerVerschuiving, adressen, zakelijkGerechtigdeIdentificaties, privaatrechtelijkeBeperkingIdentificaties, hypotheekIdentificaties, beslagIdentificaties, isOvergegaanIn, isOntstaanUit, bijbehorendeGrondpercelen, bijbehorendeAppartementsrechten, isVermeldInStukdeelIdentificaties, stukIdentificaties, links, embedded);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class KadastraalOnroerendeZaakHal {\n");
    sb.append("    identificatie: ").append(toIndentedString(identificatie)).append("\n");
    sb.append("    domein: ").append(toIndentedString(domein)).append("\n");
    sb.append("    indicatieVervallen: ").append(toIndentedString(indicatieVervallen)).append("\n");
    sb.append("    begrenzingPerceel: ").append(toIndentedString(begrenzingPerceel)).append("\n");
    sb.append("    perceelnummerRotatie: ").append(toIndentedString(perceelnummerRotatie)).append("\n");
    sb.append("    plaatscoordinaten: ").append(toIndentedString(plaatscoordinaten)).append("\n");
    sb.append("    koopsom: ").append(toIndentedString(koopsom)).append("\n");
    sb.append("    toelichtingBewaarder: ").append(toIndentedString(toelichtingBewaarder)).append("\n");
    sb.append("    type: ").append(toIndentedString(type)).append("\n");
    sb.append("    aardCultuurBebouwd: ").append(toIndentedString(aardCultuurBebouwd)).append("\n");
    sb.append("    aardCultuurOnbebouwd: ").append(toIndentedString(aardCultuurOnbebouwd)).append("\n");
    sb.append("    kadastraleAanduiding: ").append(toIndentedString(kadastraleAanduiding)).append("\n");
    sb.append("    kadastraleGrootte: ").append(toIndentedString(kadastraleGrootte)).append("\n");
    sb.append("    perceelnummerVerschuiving: ").append(toIndentedString(perceelnummerVerschuiving)).append("\n");
    sb.append("    adressen: ").append(toIndentedString(adressen)).append("\n");
    sb.append("    zakelijkGerechtigdeIdentificaties: ").append(toIndentedString(zakelijkGerechtigdeIdentificaties)).append("\n");
    sb.append("    privaatrechtelijkeBeperkingIdentificaties: ").append(toIndentedString(privaatrechtelijkeBeperkingIdentificaties)).append("\n");
    sb.append("    hypotheekIdentificaties: ").append(toIndentedString(hypotheekIdentificaties)).append("\n");
    sb.append("    beslagIdentificaties: ").append(toIndentedString(beslagIdentificaties)).append("\n");
    sb.append("    isOvergegaanIn: ").append(toIndentedString(isOvergegaanIn)).append("\n");
    sb.append("    isOntstaanUit: ").append(toIndentedString(isOntstaanUit)).append("\n");
    sb.append("    bijbehorendeGrondpercelen: ").append(toIndentedString(bijbehorendeGrondpercelen)).append("\n");
    sb.append("    bijbehorendeAppartementsrechten: ").append(toIndentedString(bijbehorendeAppartementsrechten)).append("\n");
    sb.append("    isVermeldInStukdeelIdentificaties: ").append(toIndentedString(isVermeldInStukdeelIdentificaties)).append("\n");
    sb.append("    stukIdentificaties: ").append(toIndentedString(stukIdentificaties)).append("\n");
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

