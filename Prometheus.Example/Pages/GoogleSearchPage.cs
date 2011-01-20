using WatiN.Core;

namespace Prometheus.Example.Pages
{
    class GoogleSearchPage
    {
        private TextField TextBoxSearch { get { return BrowserHelper.Browser.TextField(Find.ByName("q")); } }
        private Button ButtonSearch { get { return BrowserHelper.Browser.Button(Find.ByName("btnG")); } }


        public void Search(string searchQuery)
        {
            TextBoxSearch.TypeText(searchQuery);
            ButtonSearch.Click();
        }
    }
}
