using Moq;
using NUnit.Framework;
using Prometheus.ExtensionMethods;
using WatiN.Core;
using WatiN.Core.Native;

namespace Prometheus.Tests.WatiNExtensionTests
{
    [TestFixture]
    public class SetTests
    {
        [Test]
        public void ShouldSetTheText()
        {
            var textField = new Mock<TextField>(new Mock<DomContainer>().Object, new Mock<INativeElement>().Object);
            textField.Object.Set("hello");

            textField.Verify(x => x.SetAttributeValue("value", "hello"), Times.Once());
        }

        [Test]
        public void ShouldSetTheTextToBlank()
        {
            var textField = new Mock<TextField>(new Mock<DomContainer>().Object, new Mock<INativeElement>().Object);
            textField.Object.Set(string.Empty);

            textField.Verify(x => x.SetAttributeValue("value", string.Empty), Times.Once());    
        }
    }
}
