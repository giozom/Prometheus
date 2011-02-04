using WatiN.Core;

namespace Prometheus.ExtensionMethods
{
    public static class WatiNExtensions
    {
        public static void Set(this Element element, string inputText)
        {
            element.SetAttributeValue("value", inputText);
        }

        public static string ToText(this Element element)
        {
            var text = element.Text;
            if (string.IsNullOrEmpty(text))
            {
                text = string.Empty;
            }
            
            return text.Trim();
        }
    }
}
