using UnitTestingMethodsArraysLists_Exersize_App;

namespace UnitTestingMethodsArraysLists_Exersiaze_Tests;

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
        // Arrange
        int n = 0;

        //Act
        int outPout = Fibonacci.CalculateFibonacci(n);

        //Assert
        Assert.That(outPout, Is.EqualTo(0));
    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput7()
    {
        // Arrange
        int n = 7;

        //Act
        int outPout = Fibonacci.CalculateFibonacci(n);


        //Assert
        Assert.That(outPout, Is.EqualTo(13));

    }
}