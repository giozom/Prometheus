using NUnit.Framework;
using TechTalk.SpecFlow;
using WatiN.Core;

namespace Prometheus.Example.Features
{
    [Binding]
    class GoogleSearchSteps
    {
        private Browser _ie = new IE();

        [Given(@"I'm on the google australia search page")]
        public void GivenImOnTheGoogleAustraliaSearchPage()
        {            
            _ie.GoTo("http://www.google.com.au");
        }

        [When(@"I search for ""(.*)""")]
        public void WhenISearchFor(string searchQuery)
        {
            _ie.TextField(Find.ByName("q")).TypeText(searchQuery);
            _ie.Button(Find.ByName("btnG")).Click();
        }

        [Then(@"the results page title should be ""(.*)""")]
        public void ThenTheResultsPageTitleShouldBe(string expectedTitle)
        {
            Assert.That(_ie.Title, Is.EqualTo(expectedTitle));
            _ie.Close();
        }
    }
}
