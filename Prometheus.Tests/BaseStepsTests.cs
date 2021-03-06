﻿using System;
using Moq;
using NUnit.Framework;
using Prometheus.Tests.TestFixtures;
using WatiN.Core;

namespace Prometheus.Tests
{
    [TestFixture]
    public class BaseStepsTests
    {
        [Test]
        public void ShouldSetTheBrowser()
        {
            var mockBrowser = new Mock<Browser>().Object;
            BaseSteps.Browser = mockBrowser;
            Assert.That(BaseSteps.Browser, Is.EqualTo(mockBrowser));
        }

        [Test]
        public void ShouldKeepTheExistingBrowserIfOneExistsWhenStartCalled()
        {
            var mockBrowser = new Mock<Browser>().Object;
            BaseSteps.Browser = mockBrowser;
            Assert.That(BaseSteps.Browser, Is.EqualTo(mockBrowser));   
        }

        [Test]
        public void OnPageShouldPassInTheBrowser()
        {
            var mockBrowser = new Mock<Browser>();
            BaseSteps.Browser = mockBrowser.Object;
            var returnedPage = BaseSteps.GoTo<TestPage>();
            Assert.That(returnedPage.HtmlPage, Is.EqualTo(mockBrowser.Object));
        }

        [Test]
        public void OnPageShouldReturnAPage()
        {
            var mockBrowser = new Mock<Browser>();
            BaseSteps.Browser = mockBrowser.Object;
            var returnedPage = BaseSteps.On<TestPage>();
            Assert.That(returnedPage, Is.InstanceOf<TestPage>());
        }

        [Test]
        public void GotoShouldSendTheBrowserTheUrlOfThePage()
        {
            var mockBrowser = new Mock<Browser>();
            BaseSteps.Browser = mockBrowser.Object;
            BaseSteps.GoTo<TestPage>();
            mockBrowser.Verify(browser => browser.GoTo(new Uri(@"http://www.fake-url.com")), Times.Once());
        }

        [Test]
        public void ShouldCallThePagesValidMethod()
        {
            var mockBrowser = new Mock<Browser>();
            BaseSteps.Browser = mockBrowser.Object;
            var testPage = BaseSteps.On<TestPage>();
            Assert.That(testPage.NumberOfTimesVaildCalled, Is.EqualTo(1));
        }

        [Test]
        public void GotoPageShouldPassArgumentsOnToTheUrlMethod()
        {
            var mockBrowser = new Mock<Browser>();
            BaseSteps.Browser = mockBrowser.Object;
            BaseSteps.GoTo<UrlParamPage>("hello");
            mockBrowser.Verify(browser => browser.GoTo(new Uri(@"http://www.fake-url.com?input=hello")), Times.Once());
        }

        [Test]
        [ExpectedException(typeof(PageNotValidException), ExpectedMessage = "Page 'Prometheus.Tests.TestFixtures.InvalidPage' is invalid.")]
        public void ShouldThrowAnExceptionWithAnInvalidPage()
        {
            var mockBrowser = new Mock<Browser>();
            BaseSteps.Browser = mockBrowser.Object;
            BaseSteps.On<InvalidPage>();
        } 
    }
}
