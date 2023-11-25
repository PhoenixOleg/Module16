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
        public void Subtraction_MustReturnCorrectValue()
        {  
            Calculator calculator = new();
            Assert.True (calculator.Subtraction(2, 5) == -3);
        }

        [Test]
        public void Miltiplication_MustReturnCorrectValue()
        {
            Calculator calculator = new();
            Assert.True(calculator.Miltiplication(2, 5) == 10);
        }

        [Test]
        public void Division_MustReturnCorrectValue()
        {
            Calculator calculator = new();
            Assert.True(calculator.Division(10, 2) == 5);
        }

        //Добавлено дополнительно
        [Test]
        public void Division_MustThrowException()
        {
            Calculator calculator = new();
            Assert.Throws<DivideByZeroException>( () => calculator.Division(10, 0));
        }

        [Test]
        public void Miltiplication_MustThrowException()
        {
            Calculator calculator = new();
            Assert.Throws<OverflowException>(() => calculator.Miltiplication(int.MaxValue, 2));
        }
    }
}