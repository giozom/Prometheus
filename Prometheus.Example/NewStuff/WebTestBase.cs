using Prometheus.Example.NewStuff.Framework;
using Prometheus.Example.NewStuff.WatiN;

namespace Prometheus.Example.NewStuff
{
    public abstract class WebTestBase
    {
        private IBrowser _browser;

        protected IBrowser Browser
        {
            get { return _browser ?? (_browser = new Browser()); }
        }

        protected T Launch<T>(EntryPoint<T> content) where T : HtmlPage, new()
        {
            Browser.GoTo(content.RelativeUrl);
            return On<T>();
        }

        protected T On<T>() where T : HtmlPage, new()
        {
            return (T)new T().OnBrowser(Browser);
        }
    }
}