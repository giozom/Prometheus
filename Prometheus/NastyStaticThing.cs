using WatiN.Core;

namespace Prometheus
{
    public static class NastyStaticThing
    {
        public static Browser Ie {get; set;}

        public static void Close()
        {
            Ie.Close();
        }
    }
}
