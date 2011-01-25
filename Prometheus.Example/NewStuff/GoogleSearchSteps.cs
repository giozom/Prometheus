using NUnit.Framework;
using Prometheus.Example.NewStuff.Framework;
using Prometheus.Example.NewStuff.Models.Google;
using TechTalk.SpecFlow;

namespace Prometheus.Example.NewStuff
{
    [Binding]
    public class GoogleSearchSteps : WebStepsBase
    {
        private static readonly EntryPoint<Home> GoogleHomePage = new EntryPoint<Home>("http://www.google.com.au");  

        [Given(@"I'm on the google australia search page again")]
        public void AmOnTheGoogleAustraliaSearchPage()
        {
            GoTo(GoogleHomePage);
        }

        [When(@"I search again for ""(.*)""")]
        public void SearchFor(string searchQuery)
        {
            On<Home>().SearchFor(searchQuery);

            Wait.For(On<SearchResults>().IsLoaded, "The search result page did not load");
        }

        [Then(@"the results page title should be ""(.*)"" again")]
        public void TheResultsPageTitleShouldBe(string expectedTitle)
        {
            Assert.That(On<SearchResults>().PageTitle, Is.EqualTo(expectedTitle));
        }
    }
}