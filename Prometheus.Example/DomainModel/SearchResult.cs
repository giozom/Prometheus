using System;

namespace Prometheus.Example.DomainModel
{
    //If I was doing thi s for real I would add other things like the body text and footer
    public class SearchResult
    {
        public string TitleText { get; set; }
        public Uri TitleLink { get; set; }
        public string FooterTest { get; set; }
    }
}
