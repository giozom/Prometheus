using System;

namespace Prometheus
{
    public class PageNotValidException : System.ApplicationException
    {
        public PageNotValidException(string msg) : base(msg)
        {
        }
    }
}
