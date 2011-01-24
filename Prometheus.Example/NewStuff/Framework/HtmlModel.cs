using System.Collections.Generic;

namespace Prometheus.Example.NewStuff.Framework
{
    public abstract class HtmlModel
    {
        protected abstract IHtmlElement RootElement { get; }

        protected IHtmlElement Child(string cssSelector)
        {
            return RootElement.GetElement(cssSelector);
        }

        protected IEnumerable<IHtmlElement> Children(string cssSelector)
        {
            return RootElement.GetElements(cssSelector);
        }
    }
}