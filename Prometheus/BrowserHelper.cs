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
    }
}
