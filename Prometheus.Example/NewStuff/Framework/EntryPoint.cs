namespace Prometheus.Example.NewStuff.Framework
{
    public class EntryPoint<T>
    {
        private readonly string _relativeUrl;

        public EntryPoint(string relativeUrl)
        {
            _relativeUrl = relativeUrl;
        }

        public string RelativeUrl
        {
            get { return _relativeUrl; }
        }
    }
}