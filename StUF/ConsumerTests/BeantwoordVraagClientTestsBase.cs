using NUnit.Framework;
using StUF4.Koppelvlak.Services.NatuurlijkPersoon;
using System;

namespace ConsumerTests
{
    [TestFixture]
    public class BeantwoordVraagClientTestsBase
    {
        protected BevraagIngeschrevenPersoonClient _Consumer;
        protected BevraagIngeschrevenPersoonClient Consumer
        {
            get { return _Consumer; }
        }

        [SetUp]
        public void Setup()
        {
            _Consumer = new BevraagIngeschrevenPersoonClient();
        }

        [TearDown]
        public void TearDown()
        {
            if (_Consumer != null)
            {
                ((IDisposable)_Consumer).Dispose();

            }
        }
    }
}