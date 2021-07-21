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
import org.openapitools.client.model.Waardelijst;

/**
 * Deel en nummer identificeren een Ter Inschrijving Aangeboden stuk door gebruik te maken van vijf gegevenselementen. Waardelijst in deze component :   [reeks(http://www.kadaster.nl/schemas/waardelijsten/Reekscode/)   [registercode](http://www.kadaster.nl/schemas/waardelijsten/Registercode/)   [soortRegister](http://www.kadaster.nl/schemas/waardelijsten/SoortRegister/) 
 */
@ApiModel(description = "Deel en nummer identificeren een Ter Inschrijving Aangeboden stuk door gebruik te maken van vijf gegevenselementen. Waardelijst in deze component :   [reeks(http://www.kadaster.nl/schemas/waardelijsten/Reekscode/)   [registercode](http://www.kadaster.nl/schemas/waardelijsten/Registercode/)   [soortRegister](http://www.kadaster.nl/schemas/waardelijsten/SoortRegister/) ")
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-07-21T07:24:37.064592Z[Etc/UTC]")
public class DeelEnNummer {
  public static final String SERIALIZED_NAME_DEEL = "deel";
  @SerializedName(SERIALIZED_NAME_DEEL)
  private String deel;

  public static final String SERIALIZED_NAME_NUMMER = "nummer";
  @SerializedName(SERIALIZED_NAME_NUMMER)
  private String nummer;

  public static final String SERIALIZED_NAME_REEKS = "reeks";
  @SerializedName(SERIALIZED_NAME_REEKS)
  private List<Waardelijst> reeks = null;

  public static final String SERIALIZED_NAME_REGISTERCODE = "registercode";
  @SerializedName(SERIALIZED_NAME_REGISTERCODE)
  private Waardelijst registercode;

  public static final String SERIALIZED_NAME_SOORT_REGISTER = "soortRegister";
  @SerializedName(SERIALIZED_NAME_SOORT_REGISTER)
  private Waardelijst soortRegister;


  public DeelEnNummer deel(String deel) {
    
    this.deel = deel;
    return this;
  }

   /**
   * Identificatie van het stuk binnen zijn soort. 
   * @return deel
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Identificatie van het stuk binnen zijn soort. ")

  public String getDeel() {
    return deel;
  }


  public void setDeel(String deel) {
    this.deel = deel;
  }


  public DeelEnNummer nummer(String nummer) {
    
    this.nummer = nummer;
    return this;
  }

   /**
   * Volgnummer van het stuk. 
   * @return nummer
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Volgnummer van het stuk. ")

  public String getNummer() {
    return nummer;
  }


  public void setNummer(String nummer) {
    this.nummer = nummer;
  }


  public DeelEnNummer reeks(List<Waardelijst> reeks) {
    
    this.reeks = reeks;
    return this;
  }

  public DeelEnNummer addReeksItem(Waardelijst reeksItem) {
    if (this.reeks == null) {
      this.reeks = new ArrayList<>();
    }
    this.reeks.add(reeksItem);
    return this;
  }

   /**
   * Mogelijke waarden zijn te vinden in deze [Waardelijst](http://www.kadaster.nl/schemas/waardelijsten/Reekscode/) 
   * @return reeks
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Mogelijke waarden zijn te vinden in deze [Waardelijst](http://www.kadaster.nl/schemas/waardelijsten/Reekscode/) ")

  public List<Waardelijst> getReeks() {
    return reeks;
  }


  public void setReeks(List<Waardelijst> reeks) {
    this.reeks = reeks;
  }


  public DeelEnNummer registercode(Waardelijst registercode) {
    
    this.registercode = registercode;
    return this;
  }

   /**
   * Get registercode
   * @return registercode
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Waardelijst getRegistercode() {
    return registercode;
  }


  public void setRegistercode(Waardelijst registercode) {
    this.registercode = registercode;
  }


  public DeelEnNummer soortRegister(Waardelijst soortRegister) {
    
    this.soortRegister = soortRegister;
    return this;
  }

   /**
   * Get soortRegister
   * @return soortRegister
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Waardelijst getSoortRegister() {
    return soortRegister;
  }


  public void setSoortRegister(Waardelijst soortRegister) {
    this.soortRegister = soortRegister;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    DeelEnNummer deelEnNummer = (DeelEnNummer) o;
    return Objects.equals(this.deel, deelEnNummer.deel) &&
        Objects.equals(this.nummer, deelEnNummer.nummer) &&
        Objects.equals(this.reeks, deelEnNummer.reeks) &&
        Objects.equals(this.registercode, deelEnNummer.registercode) &&
        Objects.equals(this.soortRegister, deelEnNummer.soortRegister);
  }

  @Override
  public int hashCode() {
    return Objects.hash(deel, nummer, reeks, registercode, soortRegister);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class DeelEnNummer {\n");
    sb.append("    deel: ").append(toIndentedString(deel)).append("\n");
    sb.append("    nummer: ").append(toIndentedString(nummer)).append("\n");
    sb.append("    reeks: ").append(toIndentedString(reeks)).append("\n");
    sb.append("    registercode: ").append(toIndentedString(registercode)).append("\n");
    sb.append("    soortRegister: ").append(toIndentedString(soortRegister)).append("\n");
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

