using NUnit.Framework;

namespace Module16.Tests
{
    [TestFixture]
    class CalculatorTest
    {

        // Тесты умножения
        [Test]
        public void MultiplicationMustReturnCorrectValue()
        {
            var calculatior = new Calculator();
            Assert.AreEqual(8, calculatior.Multiplication(2,4));
        }

        [Test]
        public void MultiplicationMustThrowOverflowException()
        {
            var calculatior = new Calculator();
            Assert.Throws<OverflowException> (() => calculatior.Multiplication(2,int.MaxValue));
        }

        // Тесты деления
        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            var calculatior = new Calculator();
            Assert.AreEqual(5, calculatior.Division(20,4));
        }

        [Test]
        public void DivisionMustThrowDivideByZeroException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException> (() =>  calculator.Division(20,0));
        }

        //Тесты вычитания
        [Test]
        public void SubstractionMustReturnCorrectValue()
        {
            var calculatior = new Calculator();
            Assert.AreEqual(16, calculatior.Substraction(20,4));    // Проверит положительные числа в результате
            Assert.AreEqual(-10, calculatior.Substraction(20, 30)); // Проверит отрицательные числа в результате
        }

        // Тесты сложения
        [Test]
        public void SummationMustReturnCorrectValue()
        {
            var calculatior = new Calculator();
            Assert.AreEqual(16, calculatior.Summation(10,6));                  // Проверит положительные числа в результате
            Assert.AreEqual(-300000, calculatior.Summation(-600000, 300000));  // Проверит отрицательные числа в результате
        }
    }
}
