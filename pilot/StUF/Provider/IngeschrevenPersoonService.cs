using Core;
using StUF4.Koppelvlak.Services.NatuurlijkPersoon;
using System.Diagnostics;
using StUF4.Entiteiten.IngeschrevenPersoon;
using System.Linq;
using System.ServiceModel;
using StUF4.Entiteiten.Gemeenschappelijk;

namespace Provider
{
    public class IngeschrevenPersoonService : BevraagIngeschrevenPersoon
    {
        Repository Repository { get; set; }
        public IngeschrevenPersoonService()
        {
            Repository = new Repository();
        }

        [return: MessageParameter(Name = "ingeschrevenPersonen")]
        public IngeschrevenPersonenBeperkt ZoekIngeschrevenPersonenOpGeslachtsnaam(ZoekIngeschrevenPersonenOpGeslachtsnaamFilter filter)
        {
            Debug.WriteLine(filter.SerializeToXml());

            return new IngeschrevenPersonenBeperkt();
        }

        [return: MessageParameter(Name = "ingeschrevenPersonen")]
        public IngeschrevenPersonenBeperkt ZoekIngeschrevenPersonenOpPostcodeHuisnummer(ZoekIngeschrevenPersonenOpPostcodeHuisnummerFilter filter)
        {
            Debug.WriteLine(filter.SerializeToXml());

            return new IngeschrevenPersonenBeperkt();
        }

        [return: MessageParameter(Name = "ingeschrevenPersonen")]
        public IngeschrevenPersonenBeperkt ZoekIngeschrevenPersonenOpBinnenlandsVerblijfsadres(ZoekIngeschrevenPersonenOpBinnenlandsVerblijfsadresFilter filter)
        {
            if(filter == null)
            {
                throw new FaultException("filter mag niet null zijn");
            }

            var ingeschrevenPersonen = Repository.SelecteerIngeschrevenPersonenVoorZoekenOpBinnenlandsVerblijfsadres();

            var retval = new IngeschrevenPersonenBeperkt();

            // wildcard search: naam openbare ruimte bevat string in filter
            if (filter.naamOpenbareRuimte.StartsWith("%") && filter.naamOpenbareRuimte.EndsWith("%"))
            {
                retval.AddRange(from i in ingeschrevenPersonen
                                where i.verblijfsadres != null &&
                                      ((NummeraanduidingBeperkt)i.verblijfsadres.adres).naamOpenbareRuimte.ToLowerInvariant().Contains(filter.naamOpenbareRuimte.ToLowerInvariant().Replace("%", "")) &&
                                                           ((NummeraanduidingBeperkt)i.verblijfsadres.adres).huisnummer == filter.huisnummer
                                select i);
            }
            // wildcard search: naam openbare ruimte eindigt met string in filter
            else if (filter.naamOpenbareRuimte.StartsWith("%"))
            {
                retval.AddRange(from i in ingeschrevenPersonen
                                where i.verblijfsadres != null &&
                                      ((NummeraanduidingBeperkt)i.verblijfsadres.adres).naamOpenbareRuimte.ToLowerInvariant().EndsWith(filter.naamOpenbareRuimte.ToLowerInvariant().Replace("%", "")) &&
                                                           ((NummeraanduidingBeperkt)i.verblijfsadres.adres).huisnummer == filter.huisnummer
                                select i);
            }
            // wildcard search: naam openbare ruimte begint met string in filter
            else if (filter.naamOpenbareRuimte.EndsWith("%"))
            {
                retval.AddRange(from i in ingeschrevenPersonen
                                where i.verblijfsadres != null &&
                                      ((NummeraanduidingBeperkt)i.verblijfsadres.adres).naamOpenbareRuimte.ToLowerInvariant().StartsWith(filter.naamOpenbareRuimte.ToLowerInvariant().Replace("%", "")) &&
                                                           ((NummeraanduidingBeperkt)i.verblijfsadres.adres).huisnummer == filter.huisnummer
                                select i);
            }
            // geen wildcard search
            else
            {
                retval.AddRange(ingeschrevenPersonen.Where(i => i.verblijfsadres != null &&
                                                       ((NummeraanduidingBeperkt)i.verblijfsadres.adres).naamOpenbareRuimte.ToLowerInvariant() == filter.naamOpenbareRuimte.ToLowerInvariant() &&
                                                       ((NummeraanduidingBeperkt)i.verblijfsadres.adres).huisnummer == filter.huisnummer));
            }

            return retval;
        }

        [return: MessageParameter(Name = "ingeschrevenPersonen")]
        public IngeschrevenPersonenBeperkt RaadpleegBewoning(RaadpleegBewoningFilter filter)
        {
            var ingeschrevenPersonen = Repository.SelecteerIngeschrevenPersonenVoorRaadpleegBewoning(filter.periode);

            var retval = new IngeschrevenPersonenBeperkt();

            if (filter.inclusiefOverledenPersonen)
            {
                retval.AddRange(from persoon in ingeschrevenPersonen
                                where ((NummeraanduidingBeperkt)persoon.verblijfsadres.adres).identificatieNummeraanduiding == filter.identificatieNummeraanduiding
                                select persoon);
            }
            else
            {
                retval.AddRange(from persoon in ingeschrevenPersonen
                                where ((NummeraanduidingBeperkt)persoon.verblijfsadres.adres).identificatieNummeraanduiding == filter.identificatieNummeraanduiding &&
                                      persoon.overlijden == null
                                select persoon);
            }
            // geen filtering op periode

            // IngeschrevenPersoon worden automatisch gedowncast naar IngeschrevenPersoonBeperkt
            return retval;
        }

        [return: MessageParameter(Name = "IngeschrevenPersoon")]
        public IngeschrevenPersoon RaadpleegIngeschrevenPersoon(RaadpleegIngeschrevenPersoonFilter filter)
        {
            if(filter.burgerservicenummer == "1234567890") { return null; }

            var retval = Repository.SelecteerIngeschrevenPersoonMetAlleenVerplichteKenmerken(filter.burgerservicenummer, "Janssen");

            if(filter.burgerservicenummer == "1234567891")
            {
                retval.verblijfsadres = Repository.SelecteerVerblijfsAdresVoor(filter.periode);
            }
            return retval;
        }
    }
}