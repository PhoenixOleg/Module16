using NUnit.Framework;

namespace Module16.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Additional_MustReturnCorrectValue()
        {
            Calculator calculator = new();
            Assert.AreEqual(7, calculator.Additional(2, 5));
        }

        [Test]
        public void Subtraction__MustReturnCorrectValue()
        {  
            Calculator calculator = new();
            Assert.True (calculator.Subtraction(2, 5) == -3);
        }
    }
}