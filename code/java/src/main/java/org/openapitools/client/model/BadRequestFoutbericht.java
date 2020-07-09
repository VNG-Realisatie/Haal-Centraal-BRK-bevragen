/*
 * Kadastraal onroerende zaken
 * D.m.v. deze toepassing worden meerdere, korte bevragingen op de Basis Registratie Kadaster beschikbaar gesteld. Deze toepassing betreft het verstrekken van Kadastrale Onroerende Zaak informatie.
 *
 * The version of the OpenAPI document: 1.0.0
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
import java.net.URI;
import java.util.ArrayList;
import java.util.List;
import org.openapitools.client.model.BadRequestFoutberichtAllOf;
import org.openapitools.client.model.Foutbericht;
import org.openapitools.client.model.InvalidParams;

/**
 * BadRequestFoutbericht
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2020-07-08T15:06:35.604+02:00[Europe/Amsterdam]")
public class BadRequestFoutbericht {
  public static final String SERIALIZED_NAME_TYPE = "type";
  @SerializedName(SERIALIZED_NAME_TYPE)
  private URI type;

  public static final String SERIALIZED_NAME_TITLE = "title";
  @SerializedName(SERIALIZED_NAME_TITLE)
  private String title;

  public static final String SERIALIZED_NAME_STATUS = "status";
  @SerializedName(SERIALIZED_NAME_STATUS)
  private Integer status;

  public static final String SERIALIZED_NAME_DETAIL = "detail";
  @SerializedName(SERIALIZED_NAME_DETAIL)
  private String detail;

  public static final String SERIALIZED_NAME_INSTANCE = "instance";
  @SerializedName(SERIALIZED_NAME_INSTANCE)
  private URI instance;

  public static final String SERIALIZED_NAME_CODE = "code";
  @SerializedName(SERIALIZED_NAME_CODE)
  private String code;

  public static final String SERIALIZED_NAME_INVALID_PARAMS = "invalidParams";
  @SerializedName(SERIALIZED_NAME_INVALID_PARAMS)
  private List<InvalidParams> invalidParams = null;


  public BadRequestFoutbericht type(URI type) {
    
    this.type = type;
    return this;
  }

   /**
   * Link naar meer informatie over deze fout
   * @return type
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Link naar meer informatie over deze fout")

  public URI getType() {
    return type;
  }


  public void setType(URI type) {
    this.type = type;
  }


  public BadRequestFoutbericht title(String title) {
    
    this.title = title;
    return this;
  }

   /**
   * Beschrijving van de fout
   * @return title
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Beschrijving van de fout")

  public String getTitle() {
    return title;
  }


  public void setTitle(String title) {
    this.title = title;
  }


  public BadRequestFoutbericht status(Integer status) {
    
    this.status = status;
    return this;
  }

   /**
   * Http status code
   * @return status
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Http status code")

  public Integer getStatus() {
    return status;
  }


  public void setStatus(Integer status) {
    this.status = status;
  }


  public BadRequestFoutbericht detail(String detail) {
    
    this.detail = detail;
    return this;
  }

   /**
   * Details over de fout
   * @return detail
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Details over de fout")

  public String getDetail() {
    return detail;
  }


  public void setDetail(String detail) {
    this.detail = detail;
  }


  public BadRequestFoutbericht instance(URI instance) {
    
    this.instance = instance;
    return this;
  }

   /**
   * Uri van de aanroep die de fout heeft veroorzaakt
   * @return instance
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Uri van de aanroep die de fout heeft veroorzaakt")

  public URI getInstance() {
    return instance;
  }


  public void setInstance(URI instance) {
    this.instance = instance;
  }


  public BadRequestFoutbericht code(String code) {
    
    this.code = code;
    return this;
  }

   /**
   * Systeemcode die het type fout aangeeft
   * @return code
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Systeemcode die het type fout aangeeft")

  public String getCode() {
    return code;
  }


  public void setCode(String code) {
    this.code = code;
  }


  public BadRequestFoutbericht invalidParams(List<InvalidParams> invalidParams) {
    
    this.invalidParams = invalidParams;
    return this;
  }

  public BadRequestFoutbericht addInvalidParamsItem(InvalidParams invalidParamsItem) {
    if (this.invalidParams == null) {
      this.invalidParams = new ArrayList<>();
    }
    this.invalidParams.add(invalidParamsItem);
    return this;
  }

   /**
   * Foutmelding per fout in een parameter. Alle gevonden fouten worden één keer teruggemeld.
   * @return invalidParams
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Foutmelding per fout in een parameter. Alle gevonden fouten worden één keer teruggemeld.")

  public List<InvalidParams> getInvalidParams() {
    return invalidParams;
  }


  public void setInvalidParams(List<InvalidParams> invalidParams) {
    this.invalidParams = invalidParams;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    BadRequestFoutbericht badRequestFoutbericht = (BadRequestFoutbericht) o;
    return Objects.equals(this.type, badRequestFoutbericht.type) &&
        Objects.equals(this.title, badRequestFoutbericht.title) &&
        Objects.equals(this.status, badRequestFoutbericht.status) &&
        Objects.equals(this.detail, badRequestFoutbericht.detail) &&
        Objects.equals(this.instance, badRequestFoutbericht.instance) &&
        Objects.equals(this.code, badRequestFoutbericht.code) &&
        Objects.equals(this.invalidParams, badRequestFoutbericht.invalidParams);
  }

  @Override
  public int hashCode() {
    return Objects.hash(type, title, status, detail, instance, code, invalidParams);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class BadRequestFoutbericht {\n");
    sb.append("    type: ").append(toIndentedString(type)).append("\n");
    sb.append("    title: ").append(toIndentedString(title)).append("\n");
    sb.append("    status: ").append(toIndentedString(status)).append("\n");
    sb.append("    detail: ").append(toIndentedString(detail)).append("\n");
    sb.append("    instance: ").append(toIndentedString(instance)).append("\n");
    sb.append("    code: ").append(toIndentedString(code)).append("\n");
    sb.append("    invalidParams: ").append(toIndentedString(invalidParams)).append("\n");
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

