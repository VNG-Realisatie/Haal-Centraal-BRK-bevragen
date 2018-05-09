using NUnit.Framework;
using StUF4.Koppelvlak.Services.NatuurlijkPersoon;

namespace ConsumerTests
{
    [TestFixture]
    public class RaadpleegBewoningTests
    {
        [Test]
        public void Zoeken_op_bagid_nummeraanduiding()
        {
            var actual = new BevraagIngeschrevenPersoonClient().RaadpleegBewoning(new RaadpleegBewoningFilter
            {
                identificatieNummeraanduiding = "1"
            });

            Assert.That(actual.Count, Is.EqualTo(2));

            foreach(var persoon in actual)
            {
                Assert.That(persoon.burgerservicenummer, Is.Not.Empty);
            }
        }

        [Test]
        public void Zoeken_op_bagid_nummeraanduiding_inclusief_overledenen()
        {
            var actual = new BevraagIngeschrevenPersoonClient().RaadpleegBewoning(new RaadpleegBewoningFilter
            {
                identificatieNummeraanduiding = "1",
                inclusiefOverledenPersonen = true
            });

            Assert.That(actual.Count, Is.EqualTo(3));
        }
    }
}
