using System;
using WatiN.Core;

namespace Prometheus.Example.Pages
{
    class GoogleSearchPage : BasePage
    {
        private TextField TextBoxSearch { get { return Browser.TextField(Find.ByName("q")); } }
        private Button ButtonSearch { get { return Browser.Button(Find.ByName("btnG")); } }

        public override Uri Url { get { return new Uri(@"http://www.google.com.au");}}

        public void Search(string searchQuery)
        {
            TextBoxSearch.TypeText(searchQuery);
            ButtonSearch.Click();
        }
    }
}
