using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTstingMethods_TestApp;

namespace TestApp.UnitTests;

public class FactorialTests
{
    [Test]
    public void Test_CalculateFactorial_InputZero_ReturnsOne()
    {
        // Arrange
        int input = 0;

        // Act
        int result = Factorial.CalculateFactorial(input);

        // Assert
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]

    public void Test_CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial()
    {
        // Arrange
        int input = 3;

        // Act
        int result = Factorial.CalculateFactorial(input);

        // Assert
        Assert.That(result, Is.EqualTo(6));
    }

    [Test]
    public void Test_CalculateFactorial_InputNegativeNumber_ThrowsException()
    {
        // Arrange
        int input = -1;

        // Act +Assert      
        Assert.Throws<ArgumentOutOfRangeException>
            (() => { Factorial.CalculateFactorial(input); });
    }
}


