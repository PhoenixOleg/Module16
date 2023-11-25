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
    }
}