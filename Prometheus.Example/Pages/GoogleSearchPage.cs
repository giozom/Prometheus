using System;
using NUnit.Framework;
using Prometheus.ExtensionMethods;
using WatiN.Core;

namespace Prometheus.Example.Pages
{
    class GoogleSearchPage : BasePage
    {
        private TextField TextBoxSearch { get { return HtmlPage.TextField(Find.ByName("q")); } }
        private Button ButtonSearch { get { return HtmlPage.Button(Find.ByName("btnG")); } }

        public override string ExpectedTitle { get { return "Google"; } }

        public override Uri Url(params string[] args)
        {
            return new Uri(@"http://www.google.com.au");
        }

        public override bool Valid()
        {
            Assert.That(HtmlPage.Title, Is.EqualTo(ExpectedTitle));
            return true;
        }

        public void Search(string searchQuery)
        {
            TextBoxSearch.Set(searchQuery);
            ButtonSearch.Click();
        }
    }
}
