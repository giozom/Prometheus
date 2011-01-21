using System;
using NUnit.Framework;
using Prometheus.Tests.TestFixtures;

namespace Prometheus.Tests
{
    class BasePageTests
    {
        
        [Test]
        public void ShouldUseThePageObjectsUrl()
        {
            var testPage = new TestPage();
            Assert.That(testPage.Url(), Is.EqualTo(new Uri(@"http://www.fake-url.com")));
        }

        [Test]
        [ExpectedException(typeof(NotImplementedException), ExpectedMessage = "'Prometheus.Tests.TestFixtures.BlankPage' Does Not have a 'Url' property.")]
        public void ShouldThrowAnExceptionIfUrlNotOverridedInThePageObject()
        {
            var blankPage = new BlankPage();
            var notUsed = blankPage.Url();
        }

        [Test]
        [ExpectedException(typeof(NotImplementedException), ExpectedMessage = "'Prometheus.Tests.TestFixtures.BlankPage' Does Not have a 'ExpectedTitle' property.")]
        public void ShouldThrowAnExceptionIfTitleNotOverridedInThePageObject()
        {
            var blankPage = new BlankPage();
            var notUsed = blankPage.ExpectedTitle;
        }
    }
}
