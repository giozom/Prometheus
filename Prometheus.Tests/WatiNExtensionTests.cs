using Moq;
using NUnit.Framework;
using WatiN.Core;
using Prometheus.ExtensionMethods;
using WatiN.Core.Native;

namespace Prometheus.Tests
{
    [TestFixture]
    public class WatiNExtensionTests
    {
        [Test]
        public void ShouldSetTheText()
        {
            var textField = new Mock<TextField>(new Mock<DomContainer>().Object, new Mock<INativeElement>().Object);
            textField.Object.Set("hello");
            textField.Verify(x => x.SetAttributeValue("value", "hello"), Times.AtLeastOnce());
        }
    }
}
