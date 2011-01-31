using System;
using WatiN.Core;

namespace Prometheus
{
    public class BaseSteps
    {
        public static TPage GoTo<TPage>(params string[] args) where TPage : BasePage, new()
        {
            Browser.GoTo(new TPage { Browser = Browser }.Url(args));
            return On<TPage>();
        }

        public static TPage On<TPage>() where TPage : BasePage, new()
        {
            var page = new TPage { Browser = Browser };
            page.Browser = Browser;
            if (page.Valid() != true)
            {
                throw new PageNotValidException(String.Format("Page '{0}' is invalid.", page.GetType().FullName));
            }
            return page;
        }

        private static Browser _browser;

        public static Browser Browser
        {
            get
            {
                if (_browser == null)
                {
                    _browser = new IE();
                    _browser.BringToFront();
                }
                
                return _browser;
            }
            set { _browser = value; }
        }
    }
}