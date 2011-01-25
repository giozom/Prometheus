using System;
using NUnit.Framework;
using Prometheus.Tests.TestFixtures;

namespace Prometheus.Tests
{
    internal class BasePageTests
    {
        [Test]
        public void ShouldUseThePageObjectsUrl()
        {
            var testPage = new TestPage();
            Assert.That(testPage.Url(), Is.EqualTo(new Uri(@"http://www.fake-url.com")));
        }

        [Test]
        public void ShouldThrowAnExceptionIfUrlNotOverridedInThePageObject()
        {
            var blankPage = new BlankPage();
            Assert.Throws<NotImplementedException>(() => blankPage.Url(),
                                                   "'Prometheus.Tests.TestFixtures.BlankPage' Does Not have a 'Url' property.");
//            var notUsed = blankPage.Url();
        }

        [Test]
//        [ExpectedException(typeof(NotImplementedException),
//            ExpectedMessage = "'Prometheus.Tests.TestFixtures.BlankPage' Does Not have a 'ExpectedTitle' property.")]
        public void ShouldThrowAnExceptionIfTitleNotOverridedInThePageObject()
        {
            var blankPage = new BlankPage();
            string expectedTitle;
            Assert.Throws<NotImplementedException>(() => expectedTitle = blankPage.ExpectedTitle,
                                                   "'Prometheus.Tests.TestFixtures.BlankPage' Does Not have a 'Url' property.");
        }
    }
}