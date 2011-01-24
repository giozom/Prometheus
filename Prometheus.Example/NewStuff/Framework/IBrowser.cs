using System.Collections.Generic;

namespace Prometheus.Example.NewStuff.Framework
{
    public interface IBrowser
    {
        void GoTo(string url);

        IHtmlElement GetElement(string cssSelector);

        IEnumerable<IHtmlElement> GetElements(string cssSelector);
    }
}