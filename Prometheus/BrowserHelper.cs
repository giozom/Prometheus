using System;
using WatiN.Core;

namespace Prometheus
{
    public static class BrowserHelper
    {
        public static Browser Browser { get; set; } 
 
        public static void Start()
        {
            if (Browser == null)
            {
                Browser = new IE();
            }
            Browser.BringToFront();
        }

        public static TPage GoToPage<TPage>(params string[] args) where TPage : BasePage, new()
        {
            Browser.GoTo(new TPage {Browser = Browser}.Url(args));
            return OnPage<TPage>();
        }

        public static TPage OnPage<TPage>() where TPage : BasePage, new()
        {
            var page = new TPage {Browser = Browser};
            page.Browser = Browser;
            if (page.Valid() != true)
            {
                throw new PageNotValidException(String.Format("Page '{0}' is invalid.", page.GetType().FullName));
            }
            return page;
        }
    }


}
