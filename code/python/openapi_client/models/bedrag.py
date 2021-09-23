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


class Bedrag(object):
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
        'som': 'float',
        'valuta': 'Waardelijst'
    }

    attribute_map = {
        'som': 'som',
        'valuta': 'valuta'
    }

    def __init__(self, som=None, valuta=None, local_vars_configuration=None):  # noqa: E501
        """Bedrag - a model defined in OpenAPI"""  # noqa: E501
        if local_vars_configuration is None:
            local_vars_configuration = Configuration()
        self.local_vars_configuration = local_vars_configuration

        self._som = None
        self._valuta = None
        self.discriminator = None

        if som is not None:
            self.som = som
        if valuta is not None:
            self.valuta = valuta

    @property
    def som(self):
        """Gets the som of this Bedrag.  # noqa: E501

        Het bedrag. Dit is een waarde met max. 2 decimalen.   # noqa: E501

        :return: The som of this Bedrag.  # noqa: E501
        :rtype: float
        """
        return self._som

    @som.setter
    def som(self, som):
        """Sets the som of this Bedrag.

        Het bedrag. Dit is een waarde met max. 2 decimalen.   # noqa: E501

        :param som: The som of this Bedrag.  # noqa: E501
        :type: float
        """

        self._som = som

    @property
    def valuta(self):
        """Gets the valuta of this Bedrag.  # noqa: E501


        :return: The valuta of this Bedrag.  # noqa: E501
        :rtype: Waardelijst
        """
        return self._valuta

    @valuta.setter
    def valuta(self, valuta):
        """Sets the valuta of this Bedrag.


        :param valuta: The valuta of this Bedrag.  # noqa: E501
        :type: Waardelijst
        """

        self._valuta = valuta

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
        if not isinstance(other, Bedrag):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, Bedrag):
            return True

        return self.to_dict() != other.to_dict()
