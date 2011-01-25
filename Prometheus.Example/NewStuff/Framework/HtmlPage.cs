namespace Prometheus.Example.NewStuff.Framework
{
    public abstract class HtmlPage : HtmlModel
    {
        private IBrowser _browser;

        public HtmlPage On(IBrowser browser)
        {
            _browser = browser;
            return this;
        }

        protected override IHtmlElement RootElement
        {
            get { return _browser.GetElement(CssSelector); }
        }

        protected override string CssSelector
        {
            get { return "html"; }
        }

        public string PageTitle
        {
            get { return Child("title").Text; }
        }
    }
}