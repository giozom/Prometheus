using System;
using System.Threading;

namespace Prometheus.Example.NewStuff.Framework
{
    public static class Wait
    {
        private static readonly TimeSpan OneSecond = new TimeSpan(0, 0, 0, 1);
        private static readonly TimeSpan DefaultTotalTime = new TimeSpan(0, 0, 0, 10);

        public static void For(Func<bool> action, string failureMessage)
        {
            For(action, failureMessage, DefaultTotalTime);
        }

        public static void For(Func<bool> action, string failureMessage, TimeSpan defaultTotalTime)
        {
            var amountOfTimeLeft = defaultTotalTime;
            while (amountOfTimeLeft > TimeSpan.Zero)
            {
                try
                {
                    if (action())
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wait.For() swallowed an exception : {0} : {1}s", ex.Message, amountOfTimeLeft.TotalSeconds);
                    continue;
                }
                finally
                {
                    Thread.Sleep(OneSecond);
                    amountOfTimeLeft -= OneSecond;
                }
            }
            throw new TimeoutException(failureMessage);
        }
    }
}