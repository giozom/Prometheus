using WatiN.Core;

namespace Prometheus.Example.Pages
{
    class GoogleSearchPage
    {
        private TextField TextBoxSearch { get { return NastyStaticThing.Ie.TextField(Find.ByName("q")); } }
        private Button ButtonSearch { get { return NastyStaticThing.Ie.Button(Find.ByName("btnG")); } }


        public void Search(string searchQuery)
        {
            TextBoxSearch.TypeText(searchQuery);
            ButtonSearch.Click();
        }
    }
}
