using System;
using System.Collections.Generic;
using System.Linq;
using Prometheus.Example.NewStuff.Framework;
using WatiNCssSelectorExtensions;

namespace Prometheus.Example.NewStuff.WatiN
{
    public class HtmlPageElement : IHtmlElement
    {
        private readonly global::WatiN.Core.Browser _browser;

        public HtmlPageElement(global::WatiN.Core.Browser browser)
        {
            _browser = browser;
        }

        public string Text
        {
            get { throw new NotImplementedException(); }
        }

        public void Click()
        {
            throw new NotImplementedException();
        }

        public void Type(string text)
        {
            throw new NotImplementedException();
        }

        public void ShiftFocus()
        {
            throw new NotImplementedException();
        }

        public IHtmlElement GetElement(string cssSelector)
        {
            var element = _browser.CssSelect(cssSelector);

            Console.WriteLine(element.Text);

            return new HtmlElement(element);
        }

        public IEnumerable<IHtmlElement> GetElements(string cssSelector)
        {
            var elements = _browser.CssSelectAll(cssSelector);

            elements.Select(x =>
            {
                Console.WriteLine((string)x.Text);
                return x;
            });

            return elements.Select(x => new HtmlElement(x));
        }
    }
}