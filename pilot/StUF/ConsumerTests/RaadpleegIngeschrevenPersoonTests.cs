using NUnit.Framework;
using StUF4.Entiteiten.Gemeenschappelijk;
using StUF4.Koppelvlak.Services.NatuurlijkPersoon;

namespace ConsumerTests
{
    [TestFixture]
    public class RaadpleegIngeschrevenPersoonTests
    {
        [Test]
        public void Raadplegen_van_ingeschreven_persoon_met_alleen_verplichte_kenmerken()
        {
            const string bsn = "123456789";

            var actual = new BevraagIngeschrevenPersoonClient().RaadpleegIngeschrevenPersoon(new RaadpleegIngeschrevenPersoonFilter { burgerservicenummer = bsn });

            Assert.That(actual, Is.Not.Null);
            Assert.That(actual.burgerservicenummer, Is.EqualTo(bsn));
        }

        [Test]
        public void Raadplegen_met_een_bsn_dat_niet_is_gekoppeld_aan_een_ingeschreven_persoon()
        {
            const string bsn = "1234567890";

            var actual = new BevraagIngeschrevenPersoonClient().RaadpleegIngeschrevenPersoon(new RaadpleegIngeschrevenPersoonFilter { burgerservicenummer = bsn });

            Assert.That(actual, Is.Null);
        }

        [Test]
        public void Raadplegen_ingeschreven_persoon_met_verblijfsadres()
        {
            const string bsn = "1234567891";

            var actual = new BevraagIngeschrevenPersoonClient().RaadpleegIngeschrevenPersoon(new RaadpleegIngeschrevenPersoonFilter { burgerservicenummer = bsn });

            Assert.That(actual, Is.Not.Null);
            Assert.That(actual.burgerservicenummer, Is.EqualTo(bsn));

            Assert.That(actual.verblijfsadres, Is.Not.Null);

            var verblijfsadres = actual.verblijfsadres.adres as NummeraanduidingBeperkt;
            Assert.That(verblijfsadres, Is.Not.Null);
            Assert.That(verblijfsadres.naamOpenbareRuimte, Is.EqualTo("Spui"));
        }
    }
}
