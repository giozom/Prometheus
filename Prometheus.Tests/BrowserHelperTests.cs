using Moq;
using NUnit.Framework;
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

    }
}
