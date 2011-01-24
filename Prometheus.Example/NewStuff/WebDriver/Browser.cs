using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using Prometheus.Example.NewStuff.Framework;

namespace Prometheus.Example.NewStuff.WebDriver
{
    public class Browser : IBrowser
    {
        private readonly IWebDriver _driver = new FirefoxDriver();

        public void GoTo(string url)
        {
            Uri uri;
            if (!Uri.TryCreate(url, UriKind.Absolute, out uri))
            {
                throw new ArgumentOutOfRangeException("url", "Url needs to be a valie Uri");
            }
            _driver.Navigate().GoToUrl(uri);
        }

        public IHtmlElement GetElement(string cssSelector)
        {
            return new HtmlElement(_driver.FindElement(By.CssSelector(cssSelector)));
        }

        public IEnumerable<IHtmlElement> GetElements(string cssSelector)
        {
            return _driver.FindElements(By.CssSelector(cssSelector)).Select(x => new HtmlElement(x));
        }

        public void Quit()
        {
            _driver.Quit();
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