using System;

namespace Prometheus
{
    public abstract class BasePage
    {
        public virtual string Url
        {
            get { throw new NotImplementedException(string.Format("'{0}' Does Not have a URL.", GetType().FullName)); }
            private set { ; }
        }
    }
}
