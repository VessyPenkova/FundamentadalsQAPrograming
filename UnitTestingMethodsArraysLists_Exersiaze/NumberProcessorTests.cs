using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingMethodsArraysLists_Exersize_App;

namespace UnitTestingMethodsArraysLists_Exersiaze_Tests;
public class NumberProcessorTests
{
    [Test]
    public void Test_ProcessNumbers_SquareEvenNumbers()
    {
        // Arrange
        List<int> input = new() { 2, 4, 6 };
        List<double> expected = new() { 4, 16, 36 };

        // Act
        List<double> actual = NumberProcessor.ProcessNumbers(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_ProcessNumbers_SquareRootOddNumbers()
    {
        // Arrange
        List<int> input = new() { 1, 9, 81 };
        List<double> expected = new() { 1, 3, 9 };

        // Act
        List<double> actual = NumberProcessor.ProcessNumbers(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_ProcessNumbers_HandleZero()
    {
        // Arrange
        List<int> input = new() { 0 };
        List<int> expected = new() { 0 };

        // Act
        List<double> actual = NumberProcessor.ProcessNumbers(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_ProcessNumbers_HandleNegativeNumbers()
    {
        // Arrange
        List<int> input = new() { -1 , - 9 };

        // Act & Assert
        Assert.That(() => NumberProcessor.ProcessNumbers(input), 
        Throws.ArgumentException);
    }

    [Test]
    public void Test_ProcessNumbers_EmptyInput()
    {
        // Arrange
        List<int> input = new();
        List<int> espected = new();

        // Act & Assert
        CollectionAssert.AreEqual(espected, input);
    }
}


