using NUnit.Framework;
using WatiN.Core;

namespace Prometheus.Example
{
    [TestFixture]
    public class TestStuff
    {
        [Test]
        public void DoSomethingWithGoogle()
        {
            Browser ie = new IE();
            ie.GoTo("http://www.google.com.au");
            ie.TextField(Find.ByName("q")).TypeText("hello");
            ie.Button(Find.ByName("btnG")).Click();

            Assert.That(ie.Title, Is.EqualTo("hello - Google Search")); 
            ie.Close();
        }
    }
}
