using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using Prometheus.Example.NewStuff.Framework;

namespace Prometheus.Example.NewStuff.WebDriver
{
    public class HtmlElement : IHtmlElement
    {
        private readonly IWebElement _element;

        public HtmlElement(IWebElement element)
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
            _element.SendKeys(text);
        }

        public void ShiftFocus()
        {
            _element.SendKeys(Keys.Tab);           
        }

        public IHtmlElement GetElement(string cssSelector)
        {
            var elements = GetElements(cssSelector);
            return elements.Count() == 0 ? new NonExistentElement(cssSelector) : elements.First();
        }

        public IEnumerable<IHtmlElement> GetElements(string cssSelector)
        {
            var elements = _element.FindElements(By.CssSelector(cssSelector));
            return elements.Select(x => (IHtmlElement)new HtmlElement(x));
        }
    }
}