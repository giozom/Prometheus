using Prometheus.Example.NewStuff.Framework;

namespace Prometheus.Example.NewStuff.Models.Google
{
    public class SearchResults : HtmlPage
    {
        public bool IsLoaded
        {
            get { return PageTitle.EndsWith(" - Google Search"); }
        }
    }
}