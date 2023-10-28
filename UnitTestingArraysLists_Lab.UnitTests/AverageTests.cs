using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingArraysLists_Lab_App;

namespace UnitTestingArraysLists_Lab.UnitTests
{
    public class AverageTests
    {
        [Test]
        public void Test_CalculateAverage_InputIsEmptyArray_ShouldThrowArgumentException()
        {
            // Arrange
            int[] emptyArray = Array.Empty<int>();

            // Act && Assert
            Assert.That(() => Average.CalculateAverage(emptyArray), Throws.ArgumentException);
        }

        [Test]
        public void Test_CalculateAverage_InputHasOneElement_ShouldReturnSameElement()
        {
            // Arrange
            int[] array = { 42 };

            // Act
            double result = Average.CalculateAverage(array);

            // Assert
            Assert.That(result, Is.EqualTo(42));
        }

        [Test]
        public void Test_CalculateAverage_InputHasPositiveIntegers_ShouldReturnCorrectAverage()
        {
            // Arrange
            int[] array = { 42, 42 };

            // Act
            double result = Average.CalculateAverage(array);

            // Assert
            Assert.That(result, Is.EqualTo(42));
        }

        [Test]
        public void Test_CalculateAverage_InputHasNegativeIntegers_ShouldReturnCorrectAverage()
        {
            // Arrange
            int[] array = { -42, -42 };

            // Act
            double result = Average.CalculateAverage(array);

            // Assert
            Assert.That(result, Is.EqualTo(-42));
        }

        [Test]
        public void Test_CalculateAverage_InputHasMixedIntegers_ShouldReturnCorrectAverage()
        {
            // Arrange
            int[] array = { -22, 42 };

            // Act
            double result = Average.CalculateAverage(array);

            // Assert = 42-22 = 20 / 2 = 10
            Assert.That(result, Is.EqualTo(10));
        }
    }

}
