# coding: utf-8

# flake8: noqa
"""
    Kadaster - BRK-Bevragen API

    D.m.v. deze toepassing worden meerdere, korte bevragingen op de Basis Registratie Kadaster beschikbaar gesteld. Deze toepassing betreft het verstrekken van Kadastrale Onroerende Zaak informatie.  # noqa: E501

    The version of the OpenAPI document: 1.1.0
    Generated by: https://openapi-generator.tech
"""


from __future__ import absolute_import

# import models into model package
from openapi_client.models.aantekening import Aantekening
from openapi_client.models.adres import Adres
from openapi_client.models.bad_request_foutbericht import BadRequestFoutbericht
from openapi_client.models.bad_request_foutbericht_all_of import BadRequestFoutberichtAllOf
from openapi_client.models.bedrag import Bedrag
from openapi_client.models.datum_onvolledig import DatumOnvolledig
from openapi_client.models.erfpacht_canon import ErfpachtCanon
from openapi_client.models.foutbericht import Foutbericht
from openapi_client.models.geboorte import Geboorte
from openapi_client.models.geslacht_enum import GeslachtEnum
from openapi_client.models.hal_collection_links import HalCollectionLinks
from openapi_client.models.hal_link import HalLink
from openapi_client.models.heeft_partnerschap import HeeftPartnerschap
from openapi_client.models.invalid_params import InvalidParams
from openapi_client.models.kadaster_natuurlijk_persoon import KadasterNatuurlijkPersoon
from openapi_client.models.kadaster_natuurlijk_persoon_all_of import KadasterNatuurlijkPersoonAllOf
from openapi_client.models.kadaster_natuurlijk_persoon_hal import KadasterNatuurlijkPersoonHal
from openapi_client.models.kadaster_natuurlijk_persoon_hal_all_of import KadasterNatuurlijkPersoonHalAllOf
from openapi_client.models.kadaster_natuurlijk_persoon_hal_collectie import KadasterNatuurlijkPersoonHalCollectie
from openapi_client.models.kadaster_natuurlijk_persoon_hal_collectie_embedded import KadasterNatuurlijkPersoonHalCollectieEmbedded
from openapi_client.models.kadaster_niet_natuurlijk_persoon import KadasterNietNatuurlijkPersoon
from openapi_client.models.kadaster_niet_natuurlijk_persoon_all_of import KadasterNietNatuurlijkPersoonAllOf
from openapi_client.models.kadaster_niet_natuurlijk_persoon_hal import KadasterNietNatuurlijkPersoonHal
from openapi_client.models.kadaster_niet_natuurlijk_persoon_hal_collectie import KadasterNietNatuurlijkPersoonHalCollectie
from openapi_client.models.kadaster_niet_natuurlijk_persoon_hal_collectie_embedded import KadasterNietNatuurlijkPersoonHalCollectieEmbedded
from openapi_client.models.kadaster_persoon import KadasterPersoon
from openapi_client.models.kadaster_persoon_all_of import KadasterPersoonAllOf
from openapi_client.models.kadaster_persoon_links import KadasterPersoonLinks
from openapi_client.models.kadastraal_onroerende_zaak import KadastraalOnroerendeZaak
from openapi_client.models.kadastraal_onroerende_zaak_embedded import KadastraalOnroerendeZaakEmbedded
from openapi_client.models.kadastraal_onroerende_zaak_hal import KadastraalOnroerendeZaakHal
from openapi_client.models.kadastraal_onroerende_zaak_hal_all_of import KadastraalOnroerendeZaakHalAllOf
from openapi_client.models.kadastraal_onroerende_zaak_hal_collectie import KadastraalOnroerendeZaakHalCollectie
from openapi_client.models.kadastraal_onroerende_zaak_hal_collectie_embedded import KadastraalOnroerendeZaakHalCollectieEmbedded
from openapi_client.models.kadastraal_onroerende_zaak_links import KadastraalOnroerendeZaakLinks
from openapi_client.models.locatie_kadastraal_object import LocatieKadastraalObject
from openapi_client.models.naam import Naam
from openapi_client.models.natuurlijk_persoon_beperkt import NatuurlijkPersoonBeperkt
from openapi_client.models.natuurlijk_persoon_beperkt_all_of import NatuurlijkPersoonBeperktAllOf
from openapi_client.models.natuurlijk_persoon_type_enum import NatuurlijkPersoonTypeEnum
from openapi_client.models.niet_natuurlijk_persoon_beperkt import NietNatuurlijkPersoonBeperkt
from openapi_client.models.niet_natuurlijk_persoon_beperkt_all_of import NietNatuurlijkPersoonBeperktAllOf
from openapi_client.models.niet_natuurlijk_persoon_type_enum import NietNatuurlijkPersoonTypeEnum
from openapi_client.models.overlijden import Overlijden
from openapi_client.models.persoon_basis import PersoonBasis
from openapi_client.models.persoon_beperkt import PersoonBeperkt
from openapi_client.models.persoon_beperkt_all_of import PersoonBeperktAllOf
from openapi_client.models.persoon_type_enum import PersoonTypeEnum
from openapi_client.models.point_geo_json import PointGeoJSON
from openapi_client.models.polygon_geo_json import PolygonGeoJSON
from openapi_client.models.postadres import Postadres
from openapi_client.models.postadres_all_of import PostadresAllOf
from openapi_client.models.tenaamstelling import Tenaamstelling
from openapi_client.models.type_breuk import TypeBreuk
from openapi_client.models.type_gerechtigde_enum import TypeGerechtigdeEnum
from openapi_client.models.type_kadastraal_onroerende_zaak_enum import TypeKadastraalOnroerendeZaakEnum
from openapi_client.models.type_koopsom import TypeKoopsom
from openapi_client.models.type_oppervlak import TypeOppervlak
from openapi_client.models.type_perceelnummer_verschuiving import TypePerceelnummerVerschuiving
from openapi_client.models.waardelijst import Waardelijst
from openapi_client.models.zakelijk_gerechtigde import ZakelijkGerechtigde
from openapi_client.models.zakelijk_gerechtigde_hal import ZakelijkGerechtigdeHal
from openapi_client.models.zakelijk_gerechtigde_hal_all_of import ZakelijkGerechtigdeHalAllOf
from openapi_client.models.zakelijk_gerechtigde_hal_collectie import ZakelijkGerechtigdeHalCollectie
from openapi_client.models.zakelijk_gerechtigde_hal_collectie_embedded import ZakelijkGerechtigdeHalCollectieEmbedded
from openapi_client.models.zakelijk_gerechtigde_links import ZakelijkGerechtigdeLinks
