using System;
using System.Collections.Generic;
using System.Linq;
using Prometheus.Example.NewStuff.Framework;
using WatiN.Core;
using WatiNCssSelectorExtensions;

namespace Prometheus.Example.NewStuff.WatiN
{
    public class Browser : IBrowser
    {
        private readonly IE _browser = new IE();

        public void GoTo(string url)
        {
            _browser.GoTo(url);
        }

        public IHtmlElement GetElement(string cssSelector)
        {
            if (cssSelector == "html")
            {
                return new HtmlPageElement(_browser);
            }
            var element = _browser.CssSelect(cssSelector);

            Console.WriteLine(element.Text);

            return new HtmlElement(element);
        }

        public IEnumerable<IHtmlElement> GetElements(string cssSelector)
        {
            var elements = _browser.CssSelectAll(cssSelector);

            elements.Select(x =>
            {
                Console.WriteLine(x.Text);
                return x;
            });

            return elements.Select(x => new HtmlElement(x));
        }

        public void Quit()
        {
            _browser.Close();
        }

        ~Browser()
        {
            try
            {
                Quit();
            }
            catch
            {
            }
        }
    }
}