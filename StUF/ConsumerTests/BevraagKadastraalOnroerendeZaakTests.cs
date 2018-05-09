using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumerTests
{
    [TestFixture]
    public class BevraagKadastraalOnroerendeZaakTests
    {
        [Test]
        public void RaadpleegKadastraleOnroerendeZaak()
        {
            using(var client = new StUF4.Koppelvlak.Services.KadastraleOnroerendeZaak.BevraagKadastraleOnroerendeZaakClient())
            {
                var actual = client.RaadpleegKadastraleOnroerendeZaak("koz1234");

                Assert.That(actual, Is.Not.Null);
                Assert.That(actual.kadastraleIdentificatie, Is.EqualTo("koz1234"));
            }
        }
    }
}
