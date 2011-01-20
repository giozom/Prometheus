using System;
using Moq;
using NUnit.Framework;
using Prometheus.Tests.TestFixtures;
using WatiN.Core;

namespace Prometheus.Tests
{
    [TestFixture]
    public class BrowserHelperTests
    {
        [Test]
        public void ShouldSetTheBrowser()
        {
            var mockBrowser = new Mock<Browser>().Object;
            BrowserHelper.Browser = mockBrowser;
            Assert.That(BrowserHelper.Browser, Is.EqualTo(mockBrowser));
        }

        [Test]
        public void ShouldKeepTheExistingBrowserIfOneExistsWhenStartCalled()
        {
            var mockBrowser = new Mock<Browser>().Object;
            BrowserHelper.Browser = mockBrowser;
            BrowserHelper.Start();
            Assert.That(BrowserHelper.Browser, Is.EqualTo(mockBrowser));   
        }

        [Test]
        public void ShouldBringTheBrowserToFrontWhenStarted()
        {
            var mockBrowser = new Mock<Browser>();
            BrowserHelper.Browser = mockBrowser.Object;
            BrowserHelper.Start();
            mockBrowser.Verify(browser => browser.BringToFront(), Times.Once());
  
        }

        [Test]
        public void GotoPageShouldReturnAPage()
        {
            var mockBrowser = new Mock<Browser>();
            BrowserHelper.Browser = mockBrowser.Object;
            BrowserHelper.Start();
            var returnedPage = BrowserHelper.GoToPage<TestPage>();
            Assert.That(returnedPage, Is.InstanceOf<TestPage>());
        }

        [Test]
        public void OnPageShouldReturnAPage()
        {
            var mockBrowser = new Mock<Browser>();
            BrowserHelper.Browser = mockBrowser.Object;
            BrowserHelper.Start();
            var returnedPage = BrowserHelper.OnPage<TestPage>();
            Assert.That(returnedPage, Is.InstanceOf<TestPage>());
        }

        [Test]
        public void GotoShouldSendTheBrowserTheUrlOfThePage()
        {
            var mockBrowser = new Mock<Browser>();
            BrowserHelper.Browser = mockBrowser.Object;
            BrowserHelper.Start();
            BrowserHelper.GoToPage<TestPage>();
            mockBrowser.Verify(browser => browser.GoTo(new Uri(@"http://www.fake-url.com")), Times.Once());
        }


    }
}
