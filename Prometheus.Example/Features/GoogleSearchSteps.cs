using NUnit.Framework;
using Prometheus.Example.Pages;
using TechTalk.SpecFlow;
using WatiN.Core;

namespace Prometheus.Example.Features
{
    [Binding]
    class GoogleSearchSteps
    {

        [Given(@"I'm on the google australia search page")]
        public void GivenImOnTheGoogleAustraliaSearchPage()
        {            
           BrowserHelper.GoToPage<GoogleSearchPage>();
        }

        [When(@"I search for ""(.*)""")]
        public void WhenISearchFor(string searchQuery)
        {
            BrowserHelper.OnPage<GoogleSearchPage>().Search(searchQuery);
        }

        [Then(@"the results page title should be ""(.*)""")]
        public void ThenTheResultsPageTitleShouldBe(string expectedTitle)
        {
            Assert.That(BrowserHelper.Browser.Title, Is.EqualTo(expectedTitle));
        }
    }
}
