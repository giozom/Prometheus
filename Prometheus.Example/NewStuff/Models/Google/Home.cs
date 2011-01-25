using Prometheus.Example.NewStuff.Framework;

namespace Prometheus.Example.NewStuff.Models.Google
{
    public class Home : HtmlPage
    {
        public void SearchFor(string searchQuery)
        {
            var searchBox = Child("input[name='q']");
            searchBox.Type(searchQuery);
            searchBox.ShiftFocus();

            var searchButton = Child("input[name='btnG']");
            searchButton.Click();
        }
    }
}