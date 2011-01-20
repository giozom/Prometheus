using System;

namespace Prometheus.Tests.TestFixtures
{
    public class TestPage : BasePage
    {
        public override Uri Url(params string[] args)
        {
            return new Uri(@"http://www.fake-url.com");
        }
    }
}
