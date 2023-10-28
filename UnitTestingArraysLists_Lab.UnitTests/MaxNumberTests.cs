using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingArraysLists_Lab_App;

namespace UnitTestingArraysLists_Lab.UnitTests
{
    public class MaxNumberTests
    {
        [Test]
        public void Test_FindMax_InputIsNull_ShouldThrowArgumentException()
        {
            // Arrange
            List<int>? nullList = null;

            // Act & Assert
            Assert.That(() => MaxNumber.FindMax(nullList), Throws.ArgumentException);
        }

        [Test]
        public void Test_FindMax_InputIsEmptyList_ShouldThrowArgumentException()
        {
            // Arrange
            List<int> emptyList = new();

            // Act & Assert
            Assert.That(() => MaxNumber.FindMax(emptyList), Throws.ArgumentException);
        }

        [Test]
        public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
        {
            // Arrange
            List<int> oneElementList = new() { 7 };

            //Act
            int result = MaxNumber.FindMax(oneElementList);

            // Assert
            Assert.That(result, Is.EqualTo(7));
        }

        [Test]
        public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
        {
            // Arrange
            List<int> positiveElementList = new() { 7, 16 };

            //Act
            int result = MaxNumber.FindMax(positiveElementList);

            // Assert
            Assert.That(result, Is.EqualTo(16));
        }

        [Test]
        public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
        {
            // Arrange
            List<int> negativeElementList = new() { -7, -16 };

            //Act
            int result = MaxNumber.FindMax(negativeElementList);

            // Assert
            Assert.That(result, Is.EqualTo(-7));
        }

        [Test]
        public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
        {
            // Arrange
            List<int> mixedElementsList = new() { 7, -16 };

            //Act
            int result = MaxNumber.FindMax(mixedElementsList);

            // Assert
            Assert.That(result, Is.EqualTo(7));
        }

        [Test]
        public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
        {
            // Arrange
            List<int> duplicatedElementsList = new() { 7, 7 };

            //Act
            int result = MaxNumber.FindMax(duplicatedElementsList);

            // Assert
            Assert.That(result, Is.EqualTo(7));
        }
    }

}
