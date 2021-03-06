/*
 * Kadaster - BRK-Bevragen API
 * D.m.v. deze toepassing worden meerdere, korte bevragingen op de Basis Registratie Kadaster beschikbaar gesteld. Deze toepassing betreft het verstrekken van Kadastrale Onroerende Zaak informatie. 
 *
 * The version of the OpenAPI document: 1.2.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.annotations.SerializedName;

import java.io.IOException;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;

/**
 * Gets or Sets TypeKadastraalOnroerendeZaakEnum
 */
@JsonAdapter(TypeKadastraalOnroerendeZaakEnum.Adapter.class)
public enum TypeKadastraalOnroerendeZaakEnum {
  
  APPARTEMENTSRECHT("appartementsrecht"),
  
  PERCEEL("perceel");

  private String value;

  TypeKadastraalOnroerendeZaakEnum(String value) {
    this.value = value;
  }

  public String getValue() {
    return value;
  }

  @Override
  public String toString() {
    return String.valueOf(value);
  }

  public static TypeKadastraalOnroerendeZaakEnum fromValue(String value) {
    for (TypeKadastraalOnroerendeZaakEnum b : TypeKadastraalOnroerendeZaakEnum.values()) {
      if (b.value.equals(value)) {
        return b;
      }
    }
    throw new IllegalArgumentException("Unexpected value '" + value + "'");
  }

  public static class Adapter extends TypeAdapter<TypeKadastraalOnroerendeZaakEnum> {
    @Override
    public void write(final JsonWriter jsonWriter, final TypeKadastraalOnroerendeZaakEnum enumeration) throws IOException {
      jsonWriter.value(enumeration.getValue());
    }

    @Override
    public TypeKadastraalOnroerendeZaakEnum read(final JsonReader jsonReader) throws IOException {
      String value = jsonReader.nextString();
      return TypeKadastraalOnroerendeZaakEnum.fromValue(value);
    }
  }
}

