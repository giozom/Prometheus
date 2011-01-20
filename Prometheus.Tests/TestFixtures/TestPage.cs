using System;

namespace Prometheus.Tests.TestFixtures
{
    public class TestPage : BasePage
    {
        public override Uri Url { get { return new Uri(@"http://www.fake-url.com"); } }
    }
}
