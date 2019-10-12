using NUnit.Framework;
using Parser;

namespace ParserTests
{
    public class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(1234, 10)]
        [TestCase(0011, 2)]
        [TestCase(902, 11)]
        [TestCase(654, 15)]
        [TestCase(999999999, 81)]
        public void SumDigits_FromTestCase_ReturnExpected(long number, int expected)
        {
            var calculator = new Calculator();

            var result = calculator.SumDigits(number);

            Assert.AreEqual(expected,result);
        }
    }
}