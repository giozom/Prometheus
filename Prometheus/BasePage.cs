using System;
using WatiN.Core;
namespace Prometheus
{
    public abstract class BasePage
    {
        public Browser HtmlPage { get; set; }

        public virtual string ExpectedTitle { get { throw new NotImplementedException(string.Format("'{0}' Does Not have a 'ExpectedTitle' property.", GetType().FullName)); } }


        public virtual Uri Url(params string[] args)
        {
            throw new NotImplementedException(string.Format("'{0}' Does Not have a 'Url' property.", GetType().FullName)); 
        }

        public abstract bool Valid();
    }
}
