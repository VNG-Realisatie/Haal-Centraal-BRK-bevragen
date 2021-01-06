
# flake8: noqa

# Import all APIs into this package.
# If you have many APIs here with many many models used in each API this may
# raise a `RecursionError`.
# In order to avoid this, import only the API that you directly need like:
#
#   from .api.beslagen_api import BeslagenApi
#
# or import this package, but before doing it, use:
#
#   import sys
#   sys.setrecursionlimit(n)

# Import APIs into API package:
from openapi_client.api.beslagen_api import BeslagenApi
from openapi_client.api.hypotheken_api import HypothekenApi
from openapi_client.api.kadaster__niet_natuurlijk_personen_api import KadasterNietNatuurlijkPersonenApi
from openapi_client.api.kadastraal_onroerende_zaken_api import KadastraalOnroerendeZakenApi
from openapi_client.api.privaatrechtelijke_beperkingen_api import PrivaatrechtelijkeBeperkingenApi
from openapi_client.api.publiekrechtelijke_beperkingen_api import PubliekrechtelijkeBeperkingenApi
from openapi_client.api.zakelijke_gerechtigden_api import ZakelijkeGerechtigdenApi
