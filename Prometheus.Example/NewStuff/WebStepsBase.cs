using Prometheus.Example.NewStuff.Framework;
using Prometheus.Example.NewStuff.WebDriver;

namespace Prometheus.Example.NewStuff
{
    public abstract class WebStepsBase
    {
        private IBrowser _browser;

        protected IBrowser Browser
        {
            get { return _browser ?? NewBrowser(); }
        }

        private IBrowser NewBrowser()
        {
            return _browser = new Browser();
        }

        protected T GoTo<T>(EntryPoint<T> content) where T : HtmlPage, new()
        {
            Browser.GoTo(content.RelativeUrl);
            return On<T>();
        }

        protected T On<T>() where T : HtmlPage, new()
        {
            return (T)new T().On(Browser);
        }
    }
}