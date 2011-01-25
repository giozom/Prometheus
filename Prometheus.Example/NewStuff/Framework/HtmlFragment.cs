namespace Prometheus.Example.NewStuff.Framework
{
    public abstract class HtmlFragment : HtmlModel
    {
        private readonly IHtmlElement _rootElement;

        protected HtmlFragment(IHtmlElement element)
        {
            _rootElement = element;
        }

        protected override IHtmlElement RootElement
        {
            get { return _rootElement; }
        }
    }
}