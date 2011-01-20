using System;
using NUnit.Framework;

namespace Prometheus.Tests
{
    class BasePageTests
    {
        private class BlankPage : BasePage {}

        private class TestPage :BasePage
        {
            public override string Url { get { return @"http://www.fake-url.com"; } }
        }

        [Test]
        public void ShouldUseThePageObjectsUrl()
        {
            var testPage = new TestPage();
            Assert.That(testPage.Url, Is.EqualTo(@"http://www.fake-url.com"));
        }

        [Test]
        [ExpectedException(typeof(NotImplementedException), ExpectedMessage = "'Prometheus.Tests.BasePageTests+BlankPage' Does Not have a URL.")]
        public void ShouldThrowAnExceptionIfUrlNotOverridedInThePageObject()
        {
            var blankPage = new BlankPage();
            var notUsed = blankPage.Url;
        }

    }
}
