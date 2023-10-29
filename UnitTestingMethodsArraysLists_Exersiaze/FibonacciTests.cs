using UnitTestingMethodsArraysLists_Exersize_App;

namespace UnitTestingMethodsArraysLists_Exersiaze_Tests
{
    public class FibonacciTests
    {
        [Test]
        public void Test_CalculateFibonacci_NegativeInput()
        {
            // Arrange
            int n = -1;

            // Act & Assert
            Assert.That(() => Fibonacci.CalculateFibonacci(n), Throws.ArgumentException);
        }

        [Test]
        public void Test_CalculateFibonacci_ZeroInput()
        {
            // TODO: finish the test
        }

        [Test]
        public void Test_CalculateFibonacci_PositiveInput()
        {
            // TODO: finish the test
        }
    }
}