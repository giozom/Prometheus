using System;

namespace Prometheus.Tests.TestFixtures
{
    public class TestPage : BasePage
    {
        public int NumberOfTimesVaildCalled { get; set; }
        public override Uri Url(params string[] args)
        {
            return new Uri(@"http://www.fake-url.com");
        }

        public override bool Valid()
        {
            NumberOfTimesVaildCalled++;
            return true;
        }
    }
}
