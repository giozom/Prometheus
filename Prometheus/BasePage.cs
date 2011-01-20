using System;
using WatiN.Core;

namespace Prometheus
{
    public abstract class BasePage
    {
        public Browser Browser { get; set; }

        public virtual Uri Url(params string[] args)
        {
            throw new NotImplementedException(string.Format("'{0}' Does Not have a 'Url' property.", GetType().FullName)); 
        }
    }
}
