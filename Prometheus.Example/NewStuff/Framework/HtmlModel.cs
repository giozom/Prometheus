using System.Collections.Generic;

namespace Prometheus.Example.NewStuff.Framework
{
    public abstract class HtmlModel
    {
        protected abstract string CssSelector { get; }

        protected abstract IHtmlElement RootElement { get; }

        public virtual bool IsLoaded()
        {
            return true;
        }

        protected IHtmlElement Child(string cssSelector)
        {
            return RootElement.GetElement(cssSelector);
        }

        protected IEnumerable<IHtmlElement> Children(string cssSelector)
        {
            return RootElement.GetElements(cssSelector);
        }

        protected void EnsureModelIsLoaded()
        {
            Wait.For(IsLoaded, "The html model did not load correctly");
        }
    }
}