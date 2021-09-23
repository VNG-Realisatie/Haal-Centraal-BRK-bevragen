# coding: utf-8

"""
    Kadaster - BRK-Bevragen API

    D.m.v. deze toepassing worden meerdere, korte bevragingen op de Basis Registratie Kadaster beschikbaar gesteld. Deze toepassing betreft het verstrekken van Kadastrale Onroerende Zaak informatie.   # noqa: E501

    The version of the OpenAPI document: 1.3.0
    Generated by: https://openapi-generator.tech
"""


import pprint
import re  # noqa: F401

import six

from openapi_client.configuration import Configuration


class Stuk(object):
    """NOTE: This class is auto generated by OpenAPI Generator.
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    """
    Attributes:
      openapi_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    openapi_types = {
        'identificatie': 'str',
        'stuk_type': 'StukTypeEnum',
        'domein': 'str',
        'toelichting_bewaarder': 'str',
        'stukdeel_identificaties': 'list[str]',
        'bewaarders_verklaring': 'str',
        'tekening_ingeschreven': 'bool',
        'tijdstip_aanbieding': 'datetime',
        'tijdstip_ondertekening': 'datetime',
        'aard': 'Waardelijst',
        'status': 'Waardelijst',
        'equivalentie_verklaarder': 'EquivalentieVerklaarder',
        'kadasterverzoeken': 'list[Kadasterverzoek]',
        'oorspronkelijk_stuk_identificatie': 'str'
    }

    attribute_map = {
        'identificatie': 'identificatie',
        'stuk_type': 'stukType',
        'domein': 'domein',
        'toelichting_bewaarder': 'toelichtingBewaarder',
        'stukdeel_identificaties': 'stukdeelIdentificaties',
        'bewaarders_verklaring': 'bewaardersVerklaring',
        'tekening_ingeschreven': 'tekeningIngeschreven',
        'tijdstip_aanbieding': 'tijdstipAanbieding',
        'tijdstip_ondertekening': 'tijdstipOndertekening',
        'aard': 'aard',
        'status': 'status',
        'equivalentie_verklaarder': 'equivalentieVerklaarder',
        'kadasterverzoeken': 'kadasterverzoeken',
        'oorspronkelijk_stuk_identificatie': 'oorspronkelijkStukIdentificatie'
    }

    def __init__(self, identificatie=None, stuk_type=None, domein=None, toelichting_bewaarder=None, stukdeel_identificaties=None, bewaarders_verklaring=None, tekening_ingeschreven=None, tijdstip_aanbieding=None, tijdstip_ondertekening=None, aard=None, status=None, equivalentie_verklaarder=None, kadasterverzoeken=None, oorspronkelijk_stuk_identificatie=None, local_vars_configuration=None):  # noqa: E501
        """Stuk - a model defined in OpenAPI"""  # noqa: E501
        if local_vars_configuration is None:
            local_vars_configuration = Configuration()
        self.local_vars_configuration = local_vars_configuration

        self._identificatie = None
        self._stuk_type = None
        self._domein = None
        self._toelichting_bewaarder = None
        self._stukdeel_identificaties = None
        self._bewaarders_verklaring = None
        self._tekening_ingeschreven = None
        self._tijdstip_aanbieding = None
        self._tijdstip_ondertekening = None
        self._aard = None
        self._status = None
        self._equivalentie_verklaarder = None
        self._kadasterverzoeken = None
        self._oorspronkelijk_stuk_identificatie = None
        self.discriminator = None

        if identificatie is not None:
            self.identificatie = identificatie
        if stuk_type is not None:
            self.stuk_type = stuk_type
        if domein is not None:
            self.domein = domein
        if toelichting_bewaarder is not None:
            self.toelichting_bewaarder = toelichting_bewaarder
        if stukdeel_identificaties is not None:
            self.stukdeel_identificaties = stukdeel_identificaties
        if bewaarders_verklaring is not None:
            self.bewaarders_verklaring = bewaarders_verklaring
        if tekening_ingeschreven is not None:
            self.tekening_ingeschreven = tekening_ingeschreven
        if tijdstip_aanbieding is not None:
            self.tijdstip_aanbieding = tijdstip_aanbieding
        if tijdstip_ondertekening is not None:
            self.tijdstip_ondertekening = tijdstip_ondertekening
        if aard is not None:
            self.aard = aard
        if status is not None:
            self.status = status
        if equivalentie_verklaarder is not None:
            self.equivalentie_verklaarder = equivalentie_verklaarder
        if kadasterverzoeken is not None:
            self.kadasterverzoeken = kadasterverzoeken
        if oorspronkelijk_stuk_identificatie is not None:
            self.oorspronkelijk_stuk_identificatie = oorspronkelijk_stuk_identificatie

    @property
    def identificatie(self):
        """Gets the identificatie of this Stuk.  # noqa: E501


        :return: The identificatie of this Stuk.  # noqa: E501
        :rtype: str
        """
        return self._identificatie

    @identificatie.setter
    def identificatie(self, identificatie):
        """Sets the identificatie of this Stuk.


        :param identificatie: The identificatie of this Stuk.  # noqa: E501
        :type: str
        """

        self._identificatie = identificatie

    @property
    def stuk_type(self):
        """Gets the stuk_type of this Stuk.  # noqa: E501


        :return: The stuk_type of this Stuk.  # noqa: E501
        :rtype: StukTypeEnum
        """
        return self._stuk_type

    @stuk_type.setter
    def stuk_type(self, stuk_type):
        """Sets the stuk_type of this Stuk.


        :param stuk_type: The stuk_type of this Stuk.  # noqa: E501
        :type: StukTypeEnum
        """

        self._stuk_type = stuk_type

    @property
    def domein(self):
        """Gets the domein of this Stuk.  # noqa: E501

        Het domein waartoe de identificatie behoort.  # noqa: E501

        :return: The domein of this Stuk.  # noqa: E501
        :rtype: str
        """
        return self._domein

    @domein.setter
    def domein(self, domein):
        """Sets the domein of this Stuk.

        Het domein waartoe de identificatie behoort.  # noqa: E501

        :param domein: The domein of this Stuk.  # noqa: E501
        :type: str
        """

        self._domein = domein

    @property
    def toelichting_bewaarder(self):
        """Gets the toelichting_bewaarder of this Stuk.  # noqa: E501

        Toelichtende tekst bij een onroerende zaak van de bewaarder. De bewaarder is iemand die bij het Kadaster werkt. Hij schrijft stukken in in de openbare registers en de basisregistratie Kadaster conform de Kadasterwet.  # noqa: E501

        :return: The toelichting_bewaarder of this Stuk.  # noqa: E501
        :rtype: str
        """
        return self._toelichting_bewaarder

    @toelichting_bewaarder.setter
    def toelichting_bewaarder(self, toelichting_bewaarder):
        """Sets the toelichting_bewaarder of this Stuk.

        Toelichtende tekst bij een onroerende zaak van de bewaarder. De bewaarder is iemand die bij het Kadaster werkt. Hij schrijft stukken in in de openbare registers en de basisregistratie Kadaster conform de Kadasterwet.  # noqa: E501

        :param toelichting_bewaarder: The toelichting_bewaarder of this Stuk.  # noqa: E501
        :type: str
        """

        self._toelichting_bewaarder = toelichting_bewaarder

    @property
    def stukdeel_identificaties(self):
        """Gets the stukdeel_identificaties of this Stuk.  # noqa: E501


        :return: The stukdeel_identificaties of this Stuk.  # noqa: E501
        :rtype: list[str]
        """
        return self._stukdeel_identificaties

    @stukdeel_identificaties.setter
    def stukdeel_identificaties(self, stukdeel_identificaties):
        """Sets the stukdeel_identificaties of this Stuk.


        :param stukdeel_identificaties: The stukdeel_identificaties of this Stuk.  # noqa: E501
        :type: list[str]
        """

        self._stukdeel_identificaties = stukdeel_identificaties

    @property
    def bewaarders_verklaring(self):
        """Gets the bewaarders_verklaring of this Stuk.  # noqa: E501

        Correctie in de openbare registers door de bewaarder. De bewaarder is iemand die bij het Kadaster werkt. Hij schrijft stukken in in de openbare registers en de basisregistratie Kadaster conform de Kadasterwet.  # noqa: E501

        :return: The bewaarders_verklaring of this Stuk.  # noqa: E501
        :rtype: str
        """
        return self._bewaarders_verklaring

    @bewaarders_verklaring.setter
    def bewaarders_verklaring(self, bewaarders_verklaring):
        """Sets the bewaarders_verklaring of this Stuk.

        Correctie in de openbare registers door de bewaarder. De bewaarder is iemand die bij het Kadaster werkt. Hij schrijft stukken in in de openbare registers en de basisregistratie Kadaster conform de Kadasterwet.  # noqa: E501

        :param bewaarders_verklaring: The bewaarders_verklaring of this Stuk.  # noqa: E501
        :type: str
        """

        self._bewaarders_verklaring = bewaarders_verklaring

    @property
    def tekening_ingeschreven(self):
        """Gets the tekening_ingeschreven of this Stuk.  # noqa: E501

        Er is sprake van een appartementstekening (splitsingstekening van appartementen) als bijlage bij het stuk.  # noqa: E501

        :return: The tekening_ingeschreven of this Stuk.  # noqa: E501
        :rtype: bool
        """
        return self._tekening_ingeschreven

    @tekening_ingeschreven.setter
    def tekening_ingeschreven(self, tekening_ingeschreven):
        """Sets the tekening_ingeschreven of this Stuk.

        Er is sprake van een appartementstekening (splitsingstekening van appartementen) als bijlage bij het stuk.  # noqa: E501

        :param tekening_ingeschreven: The tekening_ingeschreven of this Stuk.  # noqa: E501
        :type: bool
        """

        self._tekening_ingeschreven = tekening_ingeschreven

    @property
    def tijdstip_aanbieding(self):
        """Gets the tijdstip_aanbieding of this Stuk.  # noqa: E501

        Het tijdstip dat het stuk bij het kadaster is binnengekomen.  # noqa: E501

        :return: The tijdstip_aanbieding of this Stuk.  # noqa: E501
        :rtype: datetime
        """
        return self._tijdstip_aanbieding

    @tijdstip_aanbieding.setter
    def tijdstip_aanbieding(self, tijdstip_aanbieding):
        """Sets the tijdstip_aanbieding of this Stuk.

        Het tijdstip dat het stuk bij het kadaster is binnengekomen.  # noqa: E501

        :param tijdstip_aanbieding: The tijdstip_aanbieding of this Stuk.  # noqa: E501
        :type: datetime
        """

        self._tijdstip_aanbieding = tijdstip_aanbieding

    @property
    def tijdstip_ondertekening(self):
        """Gets the tijdstip_ondertekening of this Stuk.  # noqa: E501

        Het tijdstip dat het stuk is ondertekend door partijen en de notaris  # noqa: E501

        :return: The tijdstip_ondertekening of this Stuk.  # noqa: E501
        :rtype: datetime
        """
        return self._tijdstip_ondertekening

    @tijdstip_ondertekening.setter
    def tijdstip_ondertekening(self, tijdstip_ondertekening):
        """Sets the tijdstip_ondertekening of this Stuk.

        Het tijdstip dat het stuk is ondertekend door partijen en de notaris  # noqa: E501

        :param tijdstip_ondertekening: The tijdstip_ondertekening of this Stuk.  # noqa: E501
        :type: datetime
        """

        self._tijdstip_ondertekening = tijdstip_ondertekening

    @property
    def aard(self):
        """Gets the aard of this Stuk.  # noqa: E501


        :return: The aard of this Stuk.  # noqa: E501
        :rtype: Waardelijst
        """
        return self._aard

    @aard.setter
    def aard(self, aard):
        """Sets the aard of this Stuk.


        :param aard: The aard of this Stuk.  # noqa: E501
        :type: Waardelijst
        """

        self._aard = aard

    @property
    def status(self):
        """Gets the status of this Stuk.  # noqa: E501


        :return: The status of this Stuk.  # noqa: E501
        :rtype: Waardelijst
        """
        return self._status

    @status.setter
    def status(self, status):
        """Sets the status of this Stuk.


        :param status: The status of this Stuk.  # noqa: E501
        :type: Waardelijst
        """

        self._status = status

    @property
    def equivalentie_verklaarder(self):
        """Gets the equivalentie_verklaarder of this Stuk.  # noqa: E501


        :return: The equivalentie_verklaarder of this Stuk.  # noqa: E501
        :rtype: EquivalentieVerklaarder
        """
        return self._equivalentie_verklaarder

    @equivalentie_verklaarder.setter
    def equivalentie_verklaarder(self, equivalentie_verklaarder):
        """Sets the equivalentie_verklaarder of this Stuk.


        :param equivalentie_verklaarder: The equivalentie_verklaarder of this Stuk.  # noqa: E501
        :type: EquivalentieVerklaarder
        """

        self._equivalentie_verklaarder = equivalentie_verklaarder

    @property
    def kadasterverzoeken(self):
        """Gets the kadasterverzoeken of this Stuk.  # noqa: E501


        :return: The kadasterverzoeken of this Stuk.  # noqa: E501
        :rtype: list[Kadasterverzoek]
        """
        return self._kadasterverzoeken

    @kadasterverzoeken.setter
    def kadasterverzoeken(self, kadasterverzoeken):
        """Sets the kadasterverzoeken of this Stuk.


        :param kadasterverzoeken: The kadasterverzoeken of this Stuk.  # noqa: E501
        :type: list[Kadasterverzoek]
        """

        self._kadasterverzoeken = kadasterverzoeken

    @property
    def oorspronkelijk_stuk_identificatie(self):
        """Gets the oorspronkelijk_stuk_identificatie of this Stuk.  # noqa: E501

        Referentie naar het het aangeboden stuk waarop de correctie heeft plaatsgevonden die middels dit Kadasterstuk heeft geleid tot een aanpassing in de BasisRegistratie Kadaster  # noqa: E501

        :return: The oorspronkelijk_stuk_identificatie of this Stuk.  # noqa: E501
        :rtype: str
        """
        return self._oorspronkelijk_stuk_identificatie

    @oorspronkelijk_stuk_identificatie.setter
    def oorspronkelijk_stuk_identificatie(self, oorspronkelijk_stuk_identificatie):
        """Sets the oorspronkelijk_stuk_identificatie of this Stuk.

        Referentie naar het het aangeboden stuk waarop de correctie heeft plaatsgevonden die middels dit Kadasterstuk heeft geleid tot een aanpassing in de BasisRegistratie Kadaster  # noqa: E501

        :param oorspronkelijk_stuk_identificatie: The oorspronkelijk_stuk_identificatie of this Stuk.  # noqa: E501
        :type: str
        """

        self._oorspronkelijk_stuk_identificatie = oorspronkelijk_stuk_identificatie

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.openapi_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, Stuk):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, Stuk):
            return True

        return self.to_dict() != other.to_dict()
