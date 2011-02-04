using System;
using System.Collections.Generic;
using Prometheus.Example.DomainModel;
using Prometheus.ExtensionMethods;
using WatiN.Core;

namespace Prometheus.Example.Pages
{
    //If I was doing this for real I would pay attention to the map, image and youtube results
    public class GoogleResultsPage : BasePage
    {
        public List<SearchResult> SearchResults = new List<SearchResult>();
        private Div DivSearchResults { get { return HtmlPage.Div(Find.ById("res")); }}
        private IEnumerable<Div> AllSearchResults { get { return DivSearchResults.Divs.Filter(Find.ByClass("vsc")); } }

        public override string ExpectedTitle { get { return " - Google Search"; } }

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
            ParseSearchResults();
            return true;
        }
        
        private void ParseSearchResults()
        {
            foreach (var htmlResult in AllSearchResults)
            {
                var result = new SearchResult();
                var titleLink = htmlResult.Link(Find.ByClass("l"));
                result.TitleText = titleLink.ToText();
                result.TitleLink = new Uri(titleLink.Url);
                SearchResults.Add(result);
            }
        }
    }
}
