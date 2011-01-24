using System;
using System.Collections.Generic;
using System.Linq;
using Prometheus.Example.NewStuff.Framework;
using WatiN.Core;
using WatiNCssSelectorExtensions;

namespace Prometheus.Example.NewStuff.WatiN
{
    public class HtmlElement : IHtmlElement
    {
        private readonly Element _element;

        public HtmlElement(Element element)
        {
            _element = element;
        }

        public string Text
        {
            get { return _element.Text; }
        }

        public void Click()
        {
            _element.Click();
        }

        public void Type(string text)
        {
            var textField = (TextField)_element;
            textField.TypeText(text);
        }

        public void ShiftFocus()
        {
            _element.Blur();
        }

        public IHtmlElement GetElement(string cssSelector)
        {
            var elements = GetElements(cssSelector);
            return elements.Count() == 0 ? new NonExistentElement(cssSelector) : elements.First();
        }

        public IEnumerable<IHtmlElement> GetElements(string cssSelector)
        {
            var elements = _element.CssSelectAll(cssSelector);
            return elements.Select(x => (IHtmlElement)new HtmlElement(x));
        }
    }
}