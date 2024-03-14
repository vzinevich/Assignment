using Assignment.Logic;

namespace UnitTests
{
    public class FibonaccierTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(2, ExpectedResult = 1)]
        [TestCase(3, ExpectedResult = 2)]
        [TestCase(5, ExpectedResult = 5)]
        [TestCase(8, ExpectedResult = 21)]
        public Task<int> Number_Test(int number)
        {
            return new Fibonaccier().GetFibonacciNumberAsync(number);
        }

        [Test]
        public void NegativeValue_Exception_Test()
        {
            Assert.ThrowsAsync(Is.TypeOf<ArgumentOutOfRangeException>()
                    .And.Message.EqualTo("fibonacciNumber ('-5') must be a non-negative value. (Parameter 'fibonacciNumber')\r\nActual value was -5."),
                () => new Fibonaccier().GetFibonacciNumberAsync(-5));
        }
    }
}