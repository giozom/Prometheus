namespace Prometheus.Example.NewStuff.Framework
{
    public abstract class HtmlPage : HtmlModel
    {
        private IBrowser _browser;

        public HtmlPage OnBrowser(IBrowser browser)
        {
            _browser = browser;
            return this;
        }

        protected override IHtmlElement RootElement
        {
            get { return _browser.GetElement("html"); }
        }

        public string PageTitle
        {
            get { return Child("title").Text; }
        }
    }
}