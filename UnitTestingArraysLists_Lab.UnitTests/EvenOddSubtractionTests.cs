using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingArraysLists_Lab_App;

namespace UnitTestingArraysLists_Lab.UnitTests
{

    public class EvenOddSubtractionTests
    {
        [Test]
        public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
        {
            // Arrange
            int[] emptyArray = Array.Empty<int>();

            // Act
            int result = EvenOddSubtraction.FindDifference(emptyArray);

            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
        {
            // Arrange
            int[] evenArray = new[] { 10, 10 };

            // Act
            int result = EvenOddSubtraction.FindDifference(evenArray);

            // Assert
            Assert.That(result, Is.EqualTo(20));
            Assert.IsTrue(result % 2 == 0);
        }

        [Test]
        public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnNegativeOddSum()
        {
            // Arrange
            int[] oddArray = new[] { 9, 11 };

            // Act
            int result = EvenOddSubtraction.FindDifference(oddArray);

            // Assert
            Assert.That(result, Is.EqualTo(20));
        }

        [Test]
        public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
        {
            // Arrange
            int[] mixedValuesArray = new[] { 9, 10, 13 };

            // Act
            int result = EvenOddSubtraction.FindDifference(mixedValuesArray);

            // Assert
            int assertmentsResult = Math.Abs(10 - 9 - 13);
            Assert.That(result, Is.EqualTo(12));
        }
    }

}
