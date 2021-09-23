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


class Filiatie(object):
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
        'aard': 'Waardelijst',
        'overgangsgrootte': 'int',
        'kadastraal_onroerende_zaak_identificatie': 'str',
        'indicatie_vervallen_kadastraal_onroerende_zaak': 'bool'
    }

    attribute_map = {
        'aard': 'aard',
        'overgangsgrootte': 'overgangsgrootte',
        'kadastraal_onroerende_zaak_identificatie': 'kadastraalOnroerendeZaakIdentificatie',
        'indicatie_vervallen_kadastraal_onroerende_zaak': 'indicatieVervallenKadastraalOnroerendeZaak'
    }

    def __init__(self, aard=None, overgangsgrootte=None, kadastraal_onroerende_zaak_identificatie=None, indicatie_vervallen_kadastraal_onroerende_zaak=None, local_vars_configuration=None):  # noqa: E501
        """Filiatie - a model defined in OpenAPI"""  # noqa: E501
        if local_vars_configuration is None:
            local_vars_configuration = Configuration()
        self.local_vars_configuration = local_vars_configuration

        self._aard = None
        self._overgangsgrootte = None
        self._kadastraal_onroerende_zaak_identificatie = None
        self._indicatie_vervallen_kadastraal_onroerende_zaak = None
        self.discriminator = None

        if aard is not None:
            self.aard = aard
        if overgangsgrootte is not None:
            self.overgangsgrootte = overgangsgrootte
        if kadastraal_onroerende_zaak_identificatie is not None:
            self.kadastraal_onroerende_zaak_identificatie = kadastraal_onroerende_zaak_identificatie
        if indicatie_vervallen_kadastraal_onroerende_zaak is not None:
            self.indicatie_vervallen_kadastraal_onroerende_zaak = indicatie_vervallen_kadastraal_onroerende_zaak

    @property
    def aard(self):
        """Gets the aard of this Filiatie.  # noqa: E501


        :return: The aard of this Filiatie.  # noqa: E501
        :rtype: Waardelijst
        """
        return self._aard

    @aard.setter
    def aard(self, aard):
        """Sets the aard of this Filiatie.


        :param aard: The aard of this Filiatie.  # noqa: E501
        :type: Waardelijst
        """

        self._aard = aard

    @property
    def overgangsgrootte(self):
        """Gets the overgangsgrootte of this Filiatie.  # noqa: E501

        De oppervlakte van het gedeelte van het oude perceel dat is opgegaan in de nieuwe Onroerende zaak.   # noqa: E501

        :return: The overgangsgrootte of this Filiatie.  # noqa: E501
        :rtype: int
        """
        return self._overgangsgrootte

    @overgangsgrootte.setter
    def overgangsgrootte(self, overgangsgrootte):
        """Sets the overgangsgrootte of this Filiatie.

        De oppervlakte van het gedeelte van het oude perceel dat is opgegaan in de nieuwe Onroerende zaak.   # noqa: E501

        :param overgangsgrootte: The overgangsgrootte of this Filiatie.  # noqa: E501
        :type: int
        """

        self._overgangsgrootte = overgangsgrootte

    @property
    def kadastraal_onroerende_zaak_identificatie(self):
        """Gets the kadastraal_onroerende_zaak_identificatie of this Filiatie.  # noqa: E501

        De identificatie(s) van de Kadastraal Onroerende Za(a)k(en).   # noqa: E501

        :return: The kadastraal_onroerende_zaak_identificatie of this Filiatie.  # noqa: E501
        :rtype: str
        """
        return self._kadastraal_onroerende_zaak_identificatie

    @kadastraal_onroerende_zaak_identificatie.setter
    def kadastraal_onroerende_zaak_identificatie(self, kadastraal_onroerende_zaak_identificatie):
        """Sets the kadastraal_onroerende_zaak_identificatie of this Filiatie.

        De identificatie(s) van de Kadastraal Onroerende Za(a)k(en).   # noqa: E501

        :param kadastraal_onroerende_zaak_identificatie: The kadastraal_onroerende_zaak_identificatie of this Filiatie.  # noqa: E501
        :type: str
        """

        self._kadastraal_onroerende_zaak_identificatie = kadastraal_onroerende_zaak_identificatie

    @property
    def indicatie_vervallen_kadastraal_onroerende_zaak(self):
        """Gets the indicatie_vervallen_kadastraal_onroerende_zaak of this Filiatie.  # noqa: E501

        Geeft aan of de filiatie verwijst naar een vervallen kadastraal onroerende zaak.   # noqa: E501

        :return: The indicatie_vervallen_kadastraal_onroerende_zaak of this Filiatie.  # noqa: E501
        :rtype: bool
        """
        return self._indicatie_vervallen_kadastraal_onroerende_zaak

    @indicatie_vervallen_kadastraal_onroerende_zaak.setter
    def indicatie_vervallen_kadastraal_onroerende_zaak(self, indicatie_vervallen_kadastraal_onroerende_zaak):
        """Sets the indicatie_vervallen_kadastraal_onroerende_zaak of this Filiatie.

        Geeft aan of de filiatie verwijst naar een vervallen kadastraal onroerende zaak.   # noqa: E501

        :param indicatie_vervallen_kadastraal_onroerende_zaak: The indicatie_vervallen_kadastraal_onroerende_zaak of this Filiatie.  # noqa: E501
        :type: bool
        """

        self._indicatie_vervallen_kadastraal_onroerende_zaak = indicatie_vervallen_kadastraal_onroerende_zaak

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
        if not isinstance(other, Filiatie):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, Filiatie):
            return True

        return self.to_dict() != other.to_dict()
