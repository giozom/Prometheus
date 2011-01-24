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

        [Then(@"the first result title should be ""(.*)""")]
        public void ThenTheFirstResultTitleShouldbe(string expectedTitle)
        {
            var googleResultPage = BrowserHelper.OnPage<GoogleResultsPage>();
            Assert.That(googleResultPage.SearchResults[0].TitleText, Is.EqualTo(expectedTitle));
        }



    }
}
