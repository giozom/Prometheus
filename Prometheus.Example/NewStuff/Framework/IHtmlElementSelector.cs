using System.Collections.Generic;

namespace Prometheus.Example.NewStuff.Framework
{
    public interface IHtmlElementSelector
    {
        IHtmlElement GetElement(string cssSelector);
        IEnumerable<IHtmlElement> GetElements(string cssSelector);
    }
}