using System.ServiceModel;
using NUnit.Framework;

namespace ConsumerTests
{
    [TestFixture]
    public class ZoekIngeschrevenPersonenOpBinnenlandsVerblijfsadresTests : BeantwoordVraagClientTestsBase
    {
        [Test]
        public void Zoek_met_verplichte_filters()
        {
            var actual = Consumer.ZoekIngeschrevenPersonenOpBinnenlandsVerblijfsadres(new StUF4.Koppelvlak.Services.NatuurlijkPersoon.ZoekIngeschrevenPersonenOpBinnenlandsVerblijfsadresFilter
            {
                naamOpenbareRuimte="leyweg",
                huisnummer=345,
                woonplaatsnaam="den haag"
            });

            Assert.That(actual, Is.Not.Empty);
            Assert.That(actual[0].geslachtsnaam, Is.EqualTo("Koning"));
        }

        [TestCase("ley%")]
        [TestCase("%weg")]
        [TestCase("%eywe%")]
        [Test]
        public void Zoeken_met_wildcard_in_openbare_ruimte_naam(string naamOpenbareRuimte)
        {
            var actual = Consumer.ZoekIngeschrevenPersonenOpBinnenlandsVerblijfsadres(new StUF4.Koppelvlak.Services.NatuurlijkPersoon.ZoekIngeschrevenPersonenOpBinnenlandsVerblijfsadresFilter
            {
                naamOpenbareRuimte = naamOpenbareRuimte,
                huisnummer = 345,
                woonplaatsnaam = "den haag"
            });

            Assert.That(actual, Is.Not.Empty);
            Assert.That(actual[0].geslachtsnaam, Is.EqualTo("Koning"));
        }

        [Test]
        public void Filter_is_null()
        {
            Assert.That(()=> Consumer.ZoekIngeschrevenPersonenOpBinnenlandsVerblijfsadres(null),
                Throws.InstanceOf<FaultException>().And.Message.Contains("filter mag niet null zijn"));
        }
    }
}
