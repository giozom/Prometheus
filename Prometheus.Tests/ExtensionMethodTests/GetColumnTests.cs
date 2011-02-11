using NUnit.Framework;
using TechTalk.SpecFlow;
using Prometheus.ExtensionMethods;

namespace Prometheus.Tests.ExtensionMethodTests
{
    [TestFixture]
    class GetColumnTests
    {
   
        [Test]
        public void ShouldFindAColumn()
        {
            var exampleTable = new Table(new string[] {"FirstColumn", "SecondColumn"});
            exampleTable.AddRow(new string[] {"FirstValue", "SecondValue"});       
            Assert.That(exampleTable.Rows[0].GetColumn("FirstColumn"), Is.EqualTo("FirstValue"));
        }

        [Test]
        [ExpectedException(typeof(SpecFlowException), ExpectedMessage = "SpecFlow Couldn't find the value 'First_Column' in a table.")]
        public void ShouldTellYouWhatItsLookingForWhenItCantFindIt()
        {
            var exampleTable = new Table(new string[] { "FirstColumn", "SecondColumn" });
            exampleTable.AddRow(new string[] { "FirstValue", "SecondValue" });

            exampleTable.Rows[0].GetColumn("First_Column");   
        }

    }
}
