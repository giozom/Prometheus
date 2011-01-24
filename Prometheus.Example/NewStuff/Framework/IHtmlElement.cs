using System.Collections.Generic;

namespace Prometheus.Example.NewStuff.Framework
{
    public interface IHtmlElement
    {
        string Text { get; }
        void Click();
        void Type(string text);
        void ShiftFocus();

        IHtmlElement GetElement(string cssSelector);
        IEnumerable<IHtmlElement> GetElements(string cssSelector);
    }
}