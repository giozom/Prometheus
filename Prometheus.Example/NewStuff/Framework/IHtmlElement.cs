namespace Prometheus.Example.NewStuff.Framework
{
    public interface IHtmlElement : IHtmlElementSelector
    {
        string Text { get; }
        void Click();
        void Type(string text);
        void ShiftFocus();
    }
}