using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using StUF4.Entiteiten.AdressenEnGebouwen;
using StUF4.Koppelvlak.Services.AdressenEnGebouwen;

namespace Provider
{
    public class AdressenEnGebouwenService : BevraagAdressenGebouwen
    {
        [return: MessageParameter(Name = "ligplaats")]
        public Ligplaats RaadpleegLigplaatsNummeraanduidingOpLigplaatsIdentificatie(RaadpleegLigplaatsNummeraanduidingOpLigplaatsIdentificatieFilter filter)
        {
            throw new NotImplementedException();
        }

        [return: MessageParameter(Name = "pand")]
        public Pand RaadpleegPandVerblijfsobjectNummeraanduidingOpPandIdentificatie(RaadpleegPandVerblijfsobjectNummeraanduidingOpPandIdentificatieFilter filter)
        {
            throw new NotImplementedException();
        }

        [return: MessageParameter(Name = "standplaats")]
        public Standplaats RaadpleegStandplaatsNummeraanduidingOpStandplaatsIdentificatie(RaadpleegStandplaatsNummeraanduidingOpStandplaatsIdentificatieFilter filter)
        {
            throw new NotImplementedException();
        }

        [return: MessageParameter(Name = "verblijfsobject")]
        public Verblijfsobject RaadpleegVerblijfsobjectLigplaatsStandplaatsOpNummeraanduiding(RaadpleegVerblijfsobjectLigplaatsStandplaatsOpNummeraanduidingFilter filter)
        {
            throw new NotImplementedException();
        }

        [return: MessageParameter(Name = "verblijfsobject")]
        public Verblijfsobject RaadpleegVerblijfsobjectOpVerblijfsobjectIdentificatie(string verblijfsobjectIdentificatie)
        {
            throw new NotImplementedException();
        }

        [return: MessageParameter(Name = "nummeraanduidingen")]
        public Nummeraanduidingen ZoekNummeraanduidingOpNaamOpenbareRuimte(ZoekNummeraanduidingOpNaamOpenbareRuimteFilter filter)
        {
            throw new NotImplementedException();
        }

        [return: MessageParameter(Name = "nummeraanduidingen")]
        public Nummeraanduidingen ZoekNummeraanduidingOpPostcodeEnHuisnummer(ZoekNummeraanduidingOpPostcodeEnHuisnummerFilter filter)
        {
            throw new NotImplementedException();
        }

        [return: MessageParameter(Name = "openbareruimtes")]
        public Openbareruimtes ZoekOpenbareruimteOpNaam(string naamOpenbareRuimte)
        {
            throw new NotImplementedException();
        }
    }
}