using System.Threading;
using NUnit.Framework;
using Prometheus.Example.Pages;
using TechTalk.SpecFlow;

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
            var googleResultsPage = BrowserHelper.OnPage<GoogleResultsPage>();
            var actualTitle = BrowserHelper.Browser.Title;
            var expectedEnding = googleResultsPage.ExpectedTitle();

            Assert.True(actualTitle.EndsWith(expectedEnding), "Title '{0}' doesn't end with the expected ending '{1}'", actualTitle, expectedEnding);
        }
    }
}
