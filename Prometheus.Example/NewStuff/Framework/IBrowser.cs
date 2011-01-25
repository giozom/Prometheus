using System.Collections.Generic;

namespace Prometheus.Example.NewStuff.Framework
{
    public interface IBrowser : IHtmlElementSelector
    {
        void GoTo(string url);
    }
}