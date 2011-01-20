
using System;

namespace Prometheus.Tests.TestFixtures
{
    class UrlParamPage : BasePage
    {
        public override Uri Url(params string[] args)
        {
            if (args.Length != 1)
            {
               throw new ArgumentException(String.Format("Only ever pass me one argument, you passed me '{0}'",args.Length));
            }

            return new Uri(String.Format("http://www.fake-url.com?input={0}", args[0]));
        }

        public override bool Valid() { return true; }
    }
}
