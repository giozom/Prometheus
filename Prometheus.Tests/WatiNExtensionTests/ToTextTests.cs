using Moq;
using NUnit.Framework;
using Prometheus.ExtensionMethods;
using WatiN.Core;
using WatiN.Core.Native;

namespace Prometheus.Tests.WatiNExtensionTests
{
    [TestFixture]
    public class ToTextTests
    {
        [Test]
        public void ShouldGetTheText()
        {
            var mockINativeElement = new Mock<INativeElement>();
            mockINativeElement.Setup(x => x.GetAttributeValue("value")).Returns("some text");
            var textField = new TextField(new Mock<DomContainer>().Object, mockINativeElement.Object);

            Assert.That(textField.ToText(), Is.EqualTo("some text"));
        }

        [Test]
        public void ShouldTrimTheText()
        {
            var mockINativeElement = new Mock<INativeElement>();
            mockINativeElement.Setup(x => x.GetAttributeValue("value")).Returns(" some text ");
            var textField = new TextField(new Mock<DomContainer>().Object, mockINativeElement.Object);

            Assert.That(textField.ToText(), Is.EqualTo("some text")); 
        }

        [Test]
        public void ShouldReturnNullAsEmptyString()
        {
            var textField = new TextField(new Mock<DomContainer>().Object, new Mock<INativeElement>().Object);
           
            Assert.That(textField.ToText(), Is.EqualTo(string.Empty));    
        }

    }
}

