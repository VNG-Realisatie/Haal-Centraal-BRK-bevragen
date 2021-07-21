"""
    Kadaster - BRK-Bevragen API

    D.m.v. deze toepassing worden meerdere, korte bevragingen op de Basis Registratie Kadaster beschikbaar gesteld. Deze toepassing betreft het verstrekken van Kadastrale Onroerende Zaak informatie.   # noqa: E501

    The version of the OpenAPI document: 1.3.0
    Generated by: https://openapi-generator.tech
"""


import re  # noqa: F401
import sys  # noqa: F401

from openapi_client.api_client import ApiClient, Endpoint as _Endpoint
from openapi_client.model_utils import (  # noqa: F401
    check_allowed_values,
    check_validations,
    date,
    datetime,
    file_type,
    none_type,
    validate_and_convert_types
)
from openapi_client.model.bad_request_foutbericht import BadRequestFoutbericht
from openapi_client.model.foutbericht import Foutbericht
from openapi_client.model.type_gerechtigde_enum import TypeGerechtigdeEnum
from openapi_client.model.zakelijk_gerechtigde_hal import ZakelijkGerechtigdeHal
from openapi_client.model.zakelijk_gerechtigde_hal_collectie import ZakelijkGerechtigdeHalCollectie


class ZakelijkeGerechtigdenApi(object):
    """NOTE: This class is auto generated by OpenAPI Generator
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    def __init__(self, api_client=None):
        if api_client is None:
            api_client = ApiClient()
        self.api_client = api_client

        def __get_zakelijk_gerechtigde(
            self,
            kadastraal_onroerende_zaak_identificatie,
            zakelijk_gerechtigde_identificatie,
            **kwargs
        ):
            """get_zakelijk_gerechtigde  # noqa: E501

            Het raadplegen van een specifieke zakelijk gerechtigde van een kadastraal onroerende zaak. Het aandeel van de zakelijk gerechtigde wordt altijd geleverd in combinatie met het gezamenlijk aandeel (wanneer twee of meer personen een gezamenlijk aandeel hebben in een zakelijk recht, en ieders afzonderlijke aandeel in het gezamenlijk aandeel niet bekend is)   # noqa: E501
            This method makes a synchronous HTTP request by default. To make an
            asynchronous HTTP request, please pass async_req=True

            >>> thread = api.get_zakelijk_gerechtigde(kadastraal_onroerende_zaak_identificatie, zakelijk_gerechtigde_identificatie, async_req=True)
            >>> result = thread.get()

            Args:
                kadastraal_onroerende_zaak_identificatie (str): De unieke identificatie van een kadastraal onroerende zaak. 
                zakelijk_gerechtigde_identificatie (str): De identificatie van de zakelijk gerechtigde 

            Keyword Args:
                fields (str): Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma's gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.2.0/features/fields.feature). [optional]
                accept_crs (str): Gewenste CRS van de coördinaten in de response.. [optional] if omitted the server will use the default value of "epsg:28992"
                _return_http_data_only (bool): response data without head status
                    code and headers. Default is True.
                _preload_content (bool): if False, the urllib3.HTTPResponse object
                    will be returned without reading/decoding response data.
                    Default is True.
                _request_timeout (int/float/tuple): timeout setting for this request. If
                    one number provided, it will be total request timeout. It can also
                    be a pair (tuple) of (connection, read) timeouts.
                    Default is None.
                _check_input_type (bool): specifies if type checking
                    should be done one the data sent to the server.
                    Default is True.
                _check_return_type (bool): specifies if type checking
                    should be done one the data received from the server.
                    Default is True.
                _host_index (int/None): specifies the index of the server
                    that we want to use.
                    Default is read from the configuration.
                async_req (bool): execute request asynchronously

            Returns:
                ZakelijkGerechtigdeHal
                    If the method is called asynchronously, returns the request
                    thread.
            """
            kwargs['async_req'] = kwargs.get(
                'async_req', False
            )
            kwargs['_return_http_data_only'] = kwargs.get(
                '_return_http_data_only', True
            )
            kwargs['_preload_content'] = kwargs.get(
                '_preload_content', True
            )
            kwargs['_request_timeout'] = kwargs.get(
                '_request_timeout', None
            )
            kwargs['_check_input_type'] = kwargs.get(
                '_check_input_type', True
            )
            kwargs['_check_return_type'] = kwargs.get(
                '_check_return_type', True
            )
            kwargs['_host_index'] = kwargs.get('_host_index')
            kwargs['kadastraal_onroerende_zaak_identificatie'] = \
                kadastraal_onroerende_zaak_identificatie
            kwargs['zakelijk_gerechtigde_identificatie'] = \
                zakelijk_gerechtigde_identificatie
            return self.call_with_http_info(**kwargs)

        self.get_zakelijk_gerechtigde = _Endpoint(
            settings={
                'response_type': (ZakelijkGerechtigdeHal,),
                'auth': [
                    'apiKeyAuth'
                ],
                'endpoint_path': '/kadastraalonroerendezaken/{kadastraalOnroerendeZaakIdentificatie}/zakelijkgerechtigden/{zakelijkGerechtigdeIdentificatie}',
                'operation_id': 'get_zakelijk_gerechtigde',
                'http_method': 'GET',
                'servers': None,
            },
            params_map={
                'all': [
                    'kadastraal_onroerende_zaak_identificatie',
                    'zakelijk_gerechtigde_identificatie',
                    'fields',
                    'accept_crs',
                ],
                'required': [
                    'kadastraal_onroerende_zaak_identificatie',
                    'zakelijk_gerechtigde_identificatie',
                ],
                'nullable': [
                ],
                'enum': [
                    'accept_crs',
                ],
                'validation': [
                ]
            },
            root_map={
                'validations': {
                },
                'allowed_values': {
                    ('accept_crs',): {

                        "EPSG:28992": "epsg:28992"
                    },
                },
                'openapi_types': {
                    'kadastraal_onroerende_zaak_identificatie':
                        (str,),
                    'zakelijk_gerechtigde_identificatie':
                        (str,),
                    'fields':
                        (str,),
                    'accept_crs':
                        (str,),
                },
                'attribute_map': {
                    'kadastraal_onroerende_zaak_identificatie': 'kadastraalOnroerendeZaakIdentificatie',
                    'zakelijk_gerechtigde_identificatie': 'zakelijkGerechtigdeIdentificatie',
                    'fields': 'fields',
                    'accept_crs': 'Accept-Crs',
                },
                'location_map': {
                    'kadastraal_onroerende_zaak_identificatie': 'path',
                    'zakelijk_gerechtigde_identificatie': 'path',
                    'fields': 'query',
                    'accept_crs': 'header',
                },
                'collection_format_map': {
                }
            },
            headers_map={
                'accept': [
                    'application/hal+json',
                    'application/problem+json'
                ],
                'content_type': [],
            },
            api_client=api_client,
            callable=__get_zakelijk_gerechtigde
        )

        def __get_zakelijk_gerechtigden(
            self,
            kadastraal_onroerende_zaak_identificatie,
            **kwargs
        ):
            """get_zakelijk_gerechtigden  # noqa: E501

            Zoek zakelijk gerechtigden van een kadastraal onroerende zaak. Het aandeel van de zakelijk gerechtigde wordt altijd geleverd in combinatie met het gezamenlijk aandeel. Er is een gezamenlijk aandeel als twee of meer personen een gezamenlijk aandeel hebben in een zakelijk recht, en ieders afzonderlijke aandeel in het gezamenlijk aandeel niet bekend is.   # noqa: E501
            This method makes a synchronous HTTP request by default. To make an
            asynchronous HTTP request, please pass async_req=True

            >>> thread = api.get_zakelijk_gerechtigden(kadastraal_onroerende_zaak_identificatie, async_req=True)
            >>> result = thread.get()

            Args:
                kadastraal_onroerende_zaak_identificatie (str): De unieke identificatie van een kadastraal onroerende zaak. 

            Keyword Args:
                fields (str): Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma's gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.2.0/features/fields.feature). [optional]
                type (TypeGerechtigdeEnum): Het type recht dat de zakelijk gerechtigde heeft op de kadastraal onroerende zaak. De waarden van de typering staan in een waardelijst. . [optional]
                accept_crs (str): Gewenste CRS van de coördinaten in de response.. [optional] if omitted the server will use the default value of "epsg:28992"
                _return_http_data_only (bool): response data without head status
                    code and headers. Default is True.
                _preload_content (bool): if False, the urllib3.HTTPResponse object
                    will be returned without reading/decoding response data.
                    Default is True.
                _request_timeout (int/float/tuple): timeout setting for this request. If
                    one number provided, it will be total request timeout. It can also
                    be a pair (tuple) of (connection, read) timeouts.
                    Default is None.
                _check_input_type (bool): specifies if type checking
                    should be done one the data sent to the server.
                    Default is True.
                _check_return_type (bool): specifies if type checking
                    should be done one the data received from the server.
                    Default is True.
                _host_index (int/None): specifies the index of the server
                    that we want to use.
                    Default is read from the configuration.
                async_req (bool): execute request asynchronously

            Returns:
                ZakelijkGerechtigdeHalCollectie
                    If the method is called asynchronously, returns the request
                    thread.
            """
            kwargs['async_req'] = kwargs.get(
                'async_req', False
            )
            kwargs['_return_http_data_only'] = kwargs.get(
                '_return_http_data_only', True
            )
            kwargs['_preload_content'] = kwargs.get(
                '_preload_content', True
            )
            kwargs['_request_timeout'] = kwargs.get(
                '_request_timeout', None
            )
            kwargs['_check_input_type'] = kwargs.get(
                '_check_input_type', True
            )
            kwargs['_check_return_type'] = kwargs.get(
                '_check_return_type', True
            )
            kwargs['_host_index'] = kwargs.get('_host_index')
            kwargs['kadastraal_onroerende_zaak_identificatie'] = \
                kadastraal_onroerende_zaak_identificatie
            return self.call_with_http_info(**kwargs)

        self.get_zakelijk_gerechtigden = _Endpoint(
            settings={
                'response_type': (ZakelijkGerechtigdeHalCollectie,),
                'auth': [
                    'apiKeyAuth'
                ],
                'endpoint_path': '/kadastraalonroerendezaken/{kadastraalOnroerendeZaakIdentificatie}/zakelijkgerechtigden',
                'operation_id': 'get_zakelijk_gerechtigden',
                'http_method': 'GET',
                'servers': None,
            },
            params_map={
                'all': [
                    'kadastraal_onroerende_zaak_identificatie',
                    'fields',
                    'type',
                    'accept_crs',
                ],
                'required': [
                    'kadastraal_onroerende_zaak_identificatie',
                ],
                'nullable': [
                ],
                'enum': [
                    'accept_crs',
                ],
                'validation': [
                ]
            },
            root_map={
                'validations': {
                },
                'allowed_values': {
                    ('accept_crs',): {

                        "EPSG:28992": "epsg:28992"
                    },
                },
                'openapi_types': {
                    'kadastraal_onroerende_zaak_identificatie':
                        (str,),
                    'fields':
                        (str,),
                    'type':
                        (TypeGerechtigdeEnum,),
                    'accept_crs':
                        (str,),
                },
                'attribute_map': {
                    'kadastraal_onroerende_zaak_identificatie': 'kadastraalOnroerendeZaakIdentificatie',
                    'fields': 'fields',
                    'type': 'type',
                    'accept_crs': 'Accept-Crs',
                },
                'location_map': {
                    'kadastraal_onroerende_zaak_identificatie': 'path',
                    'fields': 'query',
                    'type': 'query',
                    'accept_crs': 'header',
                },
                'collection_format_map': {
                }
            },
            headers_map={
                'accept': [
                    'application/hal+json',
                    'application/problem+json'
                ],
                'content_type': [],
            },
            api_client=api_client,
            callable=__get_zakelijk_gerechtigden
        )
