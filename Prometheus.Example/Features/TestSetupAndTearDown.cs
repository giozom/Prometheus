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
        }

        [TearDown]
        public void TearDown()
        {
            BaseSteps.Browser.Close();
        }
    }
}
