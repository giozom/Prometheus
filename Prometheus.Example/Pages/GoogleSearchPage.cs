using System;
using NUnit.Framework;
using WatiN.Core;

namespace Prometheus.Example.Pages
{
    class GoogleSearchPage : BasePage
    {
        private TextField TextBoxSearch { get { return Browser.TextField(Find.ByName("q")); } }
        private Button ButtonSearch { get { return Browser.Button(Find.ByName("btnG")); } }

        public override string ExpectedTitle { get { return "Google"; } }

        public override Uri Url(params string[] args)
        {
            return new Uri(@"http://www.google.com.au");
        }

        public override bool Valid()
        {
            Assert.That(Browser.Title, Is.EqualTo(ExpectedTitle));
            return true;
        }

        public void Search(string searchQuery)
        {
            TextBoxSearch.TypeText(searchQuery);
            ButtonSearch.Click();
        }
    }
}
