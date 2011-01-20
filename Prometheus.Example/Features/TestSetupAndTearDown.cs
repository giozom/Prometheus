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
            BrowserHelper.Start();
        }

        [TearDown]
        public void TearDown()
        {
            BrowserHelper.Browser.Close();
        }
    }
}
