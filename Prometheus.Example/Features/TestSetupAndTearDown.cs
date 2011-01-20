using NUnit.Framework;
using WatiN.Core;

namespace Prometheus.Example.Features
{
    [SetUpFixture]
    class TestSetupAndTearDown
    {
        [SetUp]
        public void SetUp()
        {
            NastyStaticThing.Ie = new IE();
        }

        [TearDown]
        public void TearDown()
        {
            NastyStaticThing.Close();
        }
    }
}
