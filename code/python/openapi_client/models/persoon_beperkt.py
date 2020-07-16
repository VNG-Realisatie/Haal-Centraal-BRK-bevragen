# coding: utf-8

"""
    Kadaster - BRK-Bevragen API

    D.m.v. deze toepassing worden meerdere, korte bevragingen op de Basis Registratie Kadaster beschikbaar gesteld. Deze toepassing betreft het verstrekken van Kadastrale Onroerende Zaak informatie.  # noqa: E501

    The version of the OpenAPI document: 1.1.0
    Generated by: https://openapi-generator.tech
"""


import pprint
import re  # noqa: F401

import six

from openapi_client.configuration import Configuration


class PersoonBeperkt(object):
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
        'omschrijving': 'str',
        'type': 'PersoonTypeEnum'
    }

    attribute_map = {
        'identificatie': 'identificatie',
        'omschrijving': 'omschrijving',
        'type': 'type'
    }

    def __init__(self, identificatie=None, omschrijving=None, type=None, local_vars_configuration=None):  # noqa: E501
        """PersoonBeperkt - a model defined in OpenAPI"""  # noqa: E501
        if local_vars_configuration is None:
            local_vars_configuration = Configuration()
        self.local_vars_configuration = local_vars_configuration

        self._identificatie = None
        self._omschrijving = None
        self._type = None
        self.discriminator = None

        if identificatie is not None:
            self.identificatie = identificatie
        if omschrijving is not None:
            self.omschrijving = omschrijving
        if type is not None:
            self.type = type

    @property
    def identificatie(self):
        """Gets the identificatie of this PersoonBeperkt.  # noqa: E501

        Unieke identificatie voor de persoon. Voor een Kadasterpersoon is dit de identificatie zoals die door het Kadaster is vastgesteld. Voor een ingeschreven natuurlijk persoon is dit het burgerservicenummer. Voor een ingeschreven niet-natuurlijk persoon is dit het RSIN. Of de waarde in identificatie een burgerservicenummer, een RSIN of een kadasterpersoonidentificatie is kan worden afgeleid uit het type persoon.  # noqa: E501

        :return: The identificatie of this PersoonBeperkt.  # noqa: E501
        :rtype: str
        """
        return self._identificatie

    @identificatie.setter
    def identificatie(self, identificatie):
        """Sets the identificatie of this PersoonBeperkt.

        Unieke identificatie voor de persoon. Voor een Kadasterpersoon is dit de identificatie zoals die door het Kadaster is vastgesteld. Voor een ingeschreven natuurlijk persoon is dit het burgerservicenummer. Voor een ingeschreven niet-natuurlijk persoon is dit het RSIN. Of de waarde in identificatie een burgerservicenummer, een RSIN of een kadasterpersoonidentificatie is kan worden afgeleid uit het type persoon.  # noqa: E501

        :param identificatie: The identificatie of this PersoonBeperkt.  # noqa: E501
        :type: str
        """

        self._identificatie = identificatie

    @property
    def omschrijving(self):
        """Gets the omschrijving of this PersoonBeperkt.  # noqa: E501

        Voor mensen leesbare, herkenbare en identificerende omschrijving van de persoon (met bijvoorbeeld de naam).  # noqa: E501

        :return: The omschrijving of this PersoonBeperkt.  # noqa: E501
        :rtype: str
        """
        return self._omschrijving

    @omschrijving.setter
    def omschrijving(self, omschrijving):
        """Sets the omschrijving of this PersoonBeperkt.

        Voor mensen leesbare, herkenbare en identificerende omschrijving van de persoon (met bijvoorbeeld de naam).  # noqa: E501

        :param omschrijving: The omschrijving of this PersoonBeperkt.  # noqa: E501
        :type: str
        """

        self._omschrijving = omschrijving

    @property
    def type(self):
        """Gets the type of this PersoonBeperkt.  # noqa: E501


        :return: The type of this PersoonBeperkt.  # noqa: E501
        :rtype: PersoonTypeEnum
        """
        return self._type

    @type.setter
    def type(self, type):
        """Sets the type of this PersoonBeperkt.


        :param type: The type of this PersoonBeperkt.  # noqa: E501
        :type: PersoonTypeEnum
        """

        self._type = type

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
        if not isinstance(other, PersoonBeperkt):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, PersoonBeperkt):
            return True

        return self.to_dict() != other.to_dict()
