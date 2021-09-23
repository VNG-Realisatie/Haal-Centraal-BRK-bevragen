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


class Adres(object):
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
        'straat': 'str',
        'huisnummer': 'int',
        'huisletter': 'str',
        'huisnummertoevoeging': 'str',
        'postcode': 'str',
        'woonplaats': 'str'
    }

    attribute_map = {
        'straat': 'straat',
        'huisnummer': 'huisnummer',
        'huisletter': 'huisletter',
        'huisnummertoevoeging': 'huisnummertoevoeging',
        'postcode': 'postcode',
        'woonplaats': 'woonplaats'
    }

    def __init__(self, straat=None, huisnummer=None, huisletter=None, huisnummertoevoeging=None, postcode=None, woonplaats=None, local_vars_configuration=None):  # noqa: E501
        """Adres - a model defined in OpenAPI"""  # noqa: E501
        if local_vars_configuration is None:
            local_vars_configuration = Configuration()
        self.local_vars_configuration = local_vars_configuration

        self._straat = None
        self._huisnummer = None
        self._huisletter = None
        self._huisnummertoevoeging = None
        self._postcode = None
        self._woonplaats = None
        self.discriminator = None

        if straat is not None:
            self.straat = straat
        if huisnummer is not None:
            self.huisnummer = huisnummer
        if huisletter is not None:
            self.huisletter = huisletter
        if huisnummertoevoeging is not None:
            self.huisnummertoevoeging = huisnummertoevoeging
        if postcode is not None:
            self.postcode = postcode
        if woonplaats is not None:
            self.woonplaats = woonplaats

    @property
    def straat(self):
        """Gets the straat of this Adres.  # noqa: E501

        Een naam die door de gemeente aan een openbare ruimte is gegeven.  # noqa: E501

        :return: The straat of this Adres.  # noqa: E501
        :rtype: str
        """
        return self._straat

    @straat.setter
    def straat(self, straat):
        """Sets the straat of this Adres.

        Een naam die door de gemeente aan een openbare ruimte is gegeven.  # noqa: E501

        :param straat: The straat of this Adres.  # noqa: E501
        :type: str
        """

        self._straat = straat

    @property
    def huisnummer(self):
        """Gets the huisnummer of this Adres.  # noqa: E501

        Een nummer dat door de gemeente aan een adresseerbaar object is gegeven.  # noqa: E501

        :return: The huisnummer of this Adres.  # noqa: E501
        :rtype: int
        """
        return self._huisnummer

    @huisnummer.setter
    def huisnummer(self, huisnummer):
        """Sets the huisnummer of this Adres.

        Een nummer dat door de gemeente aan een adresseerbaar object is gegeven.  # noqa: E501

        :param huisnummer: The huisnummer of this Adres.  # noqa: E501
        :type: int
        """

        self._huisnummer = huisnummer

    @property
    def huisletter(self):
        """Gets the huisletter of this Adres.  # noqa: E501

        Een toevoeging aan een huisnummer in de vorm van een letter die door de gemeente aan een adresseerbaar object is gegeven.  # noqa: E501

        :return: The huisletter of this Adres.  # noqa: E501
        :rtype: str
        """
        return self._huisletter

    @huisletter.setter
    def huisletter(self, huisletter):
        """Sets the huisletter of this Adres.

        Een toevoeging aan een huisnummer in de vorm van een letter die door de gemeente aan een adresseerbaar object is gegeven.  # noqa: E501

        :param huisletter: The huisletter of this Adres.  # noqa: E501
        :type: str
        """

        self._huisletter = huisletter

    @property
    def huisnummertoevoeging(self):
        """Gets the huisnummertoevoeging of this Adres.  # noqa: E501

        Een toevoeging aan een huisnummer of een combinatie van huisnummer en huisletter die door de gemeente aan een adresseerbaar object is gegeven.  # noqa: E501

        :return: The huisnummertoevoeging of this Adres.  # noqa: E501
        :rtype: str
        """
        return self._huisnummertoevoeging

    @huisnummertoevoeging.setter
    def huisnummertoevoeging(self, huisnummertoevoeging):
        """Sets the huisnummertoevoeging of this Adres.

        Een toevoeging aan een huisnummer of een combinatie van huisnummer en huisletter die door de gemeente aan een adresseerbaar object is gegeven.  # noqa: E501

        :param huisnummertoevoeging: The huisnummertoevoeging of this Adres.  # noqa: E501
        :type: str
        """

        self._huisnummertoevoeging = huisnummertoevoeging

    @property
    def postcode(self):
        """Gets the postcode of this Adres.  # noqa: E501

        De door PostNL vastgestelde code die bij een bepaalde combinatie van een straatnaam en een huisnummer hoort.  # noqa: E501

        :return: The postcode of this Adres.  # noqa: E501
        :rtype: str
        """
        return self._postcode

    @postcode.setter
    def postcode(self, postcode):
        """Sets the postcode of this Adres.

        De door PostNL vastgestelde code die bij een bepaalde combinatie van een straatnaam en een huisnummer hoort.  # noqa: E501

        :param postcode: The postcode of this Adres.  # noqa: E501
        :type: str
        """

        self._postcode = postcode

    @property
    def woonplaats(self):
        """Gets the woonplaats of this Adres.  # noqa: E501

        Een woonplaats is een gedeelte van het grondgebied van de gemeente met een naam.  # noqa: E501

        :return: The woonplaats of this Adres.  # noqa: E501
        :rtype: str
        """
        return self._woonplaats

    @woonplaats.setter
    def woonplaats(self, woonplaats):
        """Sets the woonplaats of this Adres.

        Een woonplaats is een gedeelte van het grondgebied van de gemeente met een naam.  # noqa: E501

        :param woonplaats: The woonplaats of this Adres.  # noqa: E501
        :type: str
        """

        self._woonplaats = woonplaats

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
        if not isinstance(other, Adres):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, Adres):
            return True

        return self.to_dict() != other.to_dict()
