using WatiN.Core;

namespace Prometheus.ExtensionMethods
{
    public static class WatiNExtensions
    {
        public static void Set(this Element element, string inputText)
        {
            element.SetAttributeValue("value", inputText);
        }
    }
}
