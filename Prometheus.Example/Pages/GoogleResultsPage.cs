using System;

namespace Prometheus.Example.Pages
{
    public class GoogleResultsPage : BasePage
    {
        public override Uri Url(params string[] args)
        {
            if (args.Length != 1)
            {
                throw new ArgumentException(String.Format("To navigate directly to the Google Search Results Page you should supply 1 argument to be the thing I search for. you supplied '{0}'", args.Length));
            }
            return new Uri(String.Format("http://google.com.au/search?q={0}", args[0]));
        }

        public override bool Valid()
        {
            return true;
        }

        public string ExpectedTitle()
        {
           return " - Google Search";
        }
    }
}
