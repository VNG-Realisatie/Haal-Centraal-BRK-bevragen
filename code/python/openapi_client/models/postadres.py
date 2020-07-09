# coding: utf-8

"""
    Kadastraal onroerende zaken

    D.m.v. deze toepassing worden meerdere, korte bevragingen op de Basis Registratie Kadaster beschikbaar gesteld. Deze toepassing betreft het verstrekken van Kadastrale Onroerende Zaak informatie.  # noqa: E501

    The version of the OpenAPI document: 1.0.0
    Generated by: https://openapi-generator.tech
"""


import pprint
import re  # noqa: F401

import six

from openapi_client.configuration import Configuration


class Postadres(object):
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
        'nummeraanduiding_identificatie': 'str',
        'huisnummer': 'int',
        'huisletter': 'str',
        'huisnummertoevoeging': 'str',
        'straat': 'str',
        'postcode': 'str',
        'woonplaats': 'str',
        'adresregel1': 'str',
        'adresregel2': 'str',
        'adresregel3': 'str',
        'land': 'Waardelijst',
        'postbusnummer': 'int'
    }

    attribute_map = {
        'nummeraanduiding_identificatie': 'nummeraanduidingIdentificatie',
        'huisnummer': 'huisnummer',
        'huisletter': 'huisletter',
        'huisnummertoevoeging': 'huisnummertoevoeging',
        'straat': 'straat',
        'postcode': 'postcode',
        'woonplaats': 'woonplaats',
        'adresregel1': 'adresregel1',
        'adresregel2': 'adresregel2',
        'adresregel3': 'adresregel3',
        'land': 'land',
        'postbusnummer': 'postbusnummer'
    }

    def __init__(self, nummeraanduiding_identificatie=None, huisnummer=None, huisletter=None, huisnummertoevoeging=None, straat=None, postcode=None, woonplaats=None, adresregel1=None, adresregel2=None, adresregel3=None, land=None, postbusnummer=None, local_vars_configuration=None):  # noqa: E501
        """Postadres - a model defined in OpenAPI"""  # noqa: E501
        if local_vars_configuration is None:
            local_vars_configuration = Configuration()
        self.local_vars_configuration = local_vars_configuration

        self._nummeraanduiding_identificatie = None
        self._huisnummer = None
        self._huisletter = None
        self._huisnummertoevoeging = None
        self._straat = None
        self._postcode = None
        self._woonplaats = None
        self._adresregel1 = None
        self._adresregel2 = None
        self._adresregel3 = None
        self._land = None
        self._postbusnummer = None
        self.discriminator = None

        if nummeraanduiding_identificatie is not None:
            self.nummeraanduiding_identificatie = nummeraanduiding_identificatie
        if huisnummer is not None:
            self.huisnummer = huisnummer
        if huisletter is not None:
            self.huisletter = huisletter
        if huisnummertoevoeging is not None:
            self.huisnummertoevoeging = huisnummertoevoeging
        if straat is not None:
            self.straat = straat
        if postcode is not None:
            self.postcode = postcode
        if woonplaats is not None:
            self.woonplaats = woonplaats
        if adresregel1 is not None:
            self.adresregel1 = adresregel1
        if adresregel2 is not None:
            self.adresregel2 = adresregel2
        if adresregel3 is not None:
            self.adresregel3 = adresregel3
        if land is not None:
            self.land = land
        if postbusnummer is not None:
            self.postbusnummer = postbusnummer

    @property
    def nummeraanduiding_identificatie(self):
        """Gets the nummeraanduiding_identificatie of this Postadres.  # noqa: E501

        identificatie van het adres in het geval dit adres in BAG geregistreerd is.  # noqa: E501

        :return: The nummeraanduiding_identificatie of this Postadres.  # noqa: E501
        :rtype: str
        """
        return self._nummeraanduiding_identificatie

    @nummeraanduiding_identificatie.setter
    def nummeraanduiding_identificatie(self, nummeraanduiding_identificatie):
        """Sets the nummeraanduiding_identificatie of this Postadres.

        identificatie van het adres in het geval dit adres in BAG geregistreerd is.  # noqa: E501

        :param nummeraanduiding_identificatie: The nummeraanduiding_identificatie of this Postadres.  # noqa: E501
        :type: str
        """

        self._nummeraanduiding_identificatie = nummeraanduiding_identificatie

    @property
    def huisnummer(self):
        """Gets the huisnummer of this Postadres.  # noqa: E501

        URI https://bag.basisregistraties.overheid.nl/doc/begrip/Huisnummer  # noqa: E501

        :return: The huisnummer of this Postadres.  # noqa: E501
        :rtype: int
        """
        return self._huisnummer

    @huisnummer.setter
    def huisnummer(self, huisnummer):
        """Sets the huisnummer of this Postadres.

        URI https://bag.basisregistraties.overheid.nl/doc/begrip/Huisnummer  # noqa: E501

        :param huisnummer: The huisnummer of this Postadres.  # noqa: E501
        :type: int
        """

        self._huisnummer = huisnummer

    @property
    def huisletter(self):
        """Gets the huisletter of this Postadres.  # noqa: E501

        URI https://bag.basisregistraties.overheid.nl/doc/begrip/Huisletter  # noqa: E501

        :return: The huisletter of this Postadres.  # noqa: E501
        :rtype: str
        """
        return self._huisletter

    @huisletter.setter
    def huisletter(self, huisletter):
        """Sets the huisletter of this Postadres.

        URI https://bag.basisregistraties.overheid.nl/doc/begrip/Huisletter  # noqa: E501

        :param huisletter: The huisletter of this Postadres.  # noqa: E501
        :type: str
        """

        self._huisletter = huisletter

    @property
    def huisnummertoevoeging(self):
        """Gets the huisnummertoevoeging of this Postadres.  # noqa: E501

        URI https://bag.basisregistraties.overheid.nl/doc/begrip/Huisnummertoevoeging  # noqa: E501

        :return: The huisnummertoevoeging of this Postadres.  # noqa: E501
        :rtype: str
        """
        return self._huisnummertoevoeging

    @huisnummertoevoeging.setter
    def huisnummertoevoeging(self, huisnummertoevoeging):
        """Sets the huisnummertoevoeging of this Postadres.

        URI https://bag.basisregistraties.overheid.nl/doc/begrip/Huisnummertoevoeging  # noqa: E501

        :param huisnummertoevoeging: The huisnummertoevoeging of this Postadres.  # noqa: E501
        :type: str
        """

        self._huisnummertoevoeging = huisnummertoevoeging

    @property
    def straat(self):
        """Gets the straat of this Postadres.  # noqa: E501


        :return: The straat of this Postadres.  # noqa: E501
        :rtype: str
        """
        return self._straat

    @straat.setter
    def straat(self, straat):
        """Sets the straat of this Postadres.


        :param straat: The straat of this Postadres.  # noqa: E501
        :type: str
        """

        self._straat = straat

    @property
    def postcode(self):
        """Gets the postcode of this Postadres.  # noqa: E501


        :return: The postcode of this Postadres.  # noqa: E501
        :rtype: str
        """
        return self._postcode

    @postcode.setter
    def postcode(self, postcode):
        """Sets the postcode of this Postadres.


        :param postcode: The postcode of this Postadres.  # noqa: E501
        :type: str
        """

        self._postcode = postcode

    @property
    def woonplaats(self):
        """Gets the woonplaats of this Postadres.  # noqa: E501


        :return: The woonplaats of this Postadres.  # noqa: E501
        :rtype: str
        """
        return self._woonplaats

    @woonplaats.setter
    def woonplaats(self, woonplaats):
        """Sets the woonplaats of this Postadres.


        :param woonplaats: The woonplaats of this Postadres.  # noqa: E501
        :type: str
        """

        self._woonplaats = woonplaats

    @property
    def adresregel1(self):
        """Gets the adresregel1 of this Postadres.  # noqa: E501

        Het eerste deel van een adres is een combinatie van de straat en huisnummer.  # noqa: E501

        :return: The adresregel1 of this Postadres.  # noqa: E501
        :rtype: str
        """
        return self._adresregel1

    @adresregel1.setter
    def adresregel1(self, adresregel1):
        """Sets the adresregel1 of this Postadres.

        Het eerste deel van een adres is een combinatie van de straat en huisnummer.  # noqa: E501

        :param adresregel1: The adresregel1 of this Postadres.  # noqa: E501
        :type: str
        """

        self._adresregel1 = adresregel1

    @property
    def adresregel2(self):
        """Gets the adresregel2 of this Postadres.  # noqa: E501

        Het tweede deel van een adres is een combinatie van woonplaats eventueel in combinatie met de postcode  # noqa: E501

        :return: The adresregel2 of this Postadres.  # noqa: E501
        :rtype: str
        """
        return self._adresregel2

    @adresregel2.setter
    def adresregel2(self, adresregel2):
        """Sets the adresregel2 of this Postadres.

        Het tweede deel van een adres is een combinatie van woonplaats eventueel in combinatie met de postcode  # noqa: E501

        :param adresregel2: The adresregel2 of this Postadres.  # noqa: E501
        :type: str
        """

        self._adresregel2 = adresregel2

    @property
    def adresregel3(self):
        """Gets the adresregel3 of this Postadres.  # noqa: E501

        Het derde deel van een adres is optioneel een of meer geografische gebieden van het adres in het buitenland  # noqa: E501

        :return: The adresregel3 of this Postadres.  # noqa: E501
        :rtype: str
        """
        return self._adresregel3

    @adresregel3.setter
    def adresregel3(self, adresregel3):
        """Sets the adresregel3 of this Postadres.

        Het derde deel van een adres is optioneel een of meer geografische gebieden van het adres in het buitenland  # noqa: E501

        :param adresregel3: The adresregel3 of this Postadres.  # noqa: E501
        :type: str
        """

        self._adresregel3 = adresregel3

    @property
    def land(self):
        """Gets the land of this Postadres.  # noqa: E501


        :return: The land of this Postadres.  # noqa: E501
        :rtype: Waardelijst
        """
        return self._land

    @land.setter
    def land(self, land):
        """Sets the land of this Postadres.


        :param land: The land of this Postadres.  # noqa: E501
        :type: Waardelijst
        """

        self._land = land

    @property
    def postbusnummer(self):
        """Gets the postbusnummer of this Postadres.  # noqa: E501


        :return: The postbusnummer of this Postadres.  # noqa: E501
        :rtype: int
        """
        return self._postbusnummer

    @postbusnummer.setter
    def postbusnummer(self, postbusnummer):
        """Sets the postbusnummer of this Postadres.


        :param postbusnummer: The postbusnummer of this Postadres.  # noqa: E501
        :type: int
        """

        self._postbusnummer = postbusnummer

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
        if not isinstance(other, Postadres):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, Postadres):
            return True

        return self.to_dict() != other.to_dict()
