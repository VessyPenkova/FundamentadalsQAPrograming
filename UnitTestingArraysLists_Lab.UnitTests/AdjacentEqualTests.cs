using NUnit.Framework;
using UnitTestingArraysLists_Lab_App;

namespace UnitTestingArraysLists_Lab.UnitTests
{
    public class AdjacentEqualTests
    {
        [Test]
        public void Test_Sum_InputIsNull_ShouldThrowArgumentException()
        {
            // Arrange
            List<int>? nullList = null;

            // Act & Assert
            Assert.That(() => AdjacentEqual.Sum(nullList), Throws.ArgumentException);
        }

        [Test]
        public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
        {
            // Arrange
            List<int> emptyList = new();

            // Act
            string result = AdjacentEqual.Sum(emptyList);

            // Assert
            Assert.That("", Is.EqualTo(result));
            //Assert.That(result, Is.Empty);Second variant to the same test
            //Assert.IsEmpty(result);Tird variant to the same test
        }

        [Test]
        public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
        {
            // Arrange
            List<int> distinctNumbersList = new() { 1, 2, 3, 4, 5 };

            // Act
            string result = AdjacentEqual.Sum(distinctNumbersList);


            // Assert
            Assert.That(result, Is.EqualTo("1 2 3 4 5"));
        }

        [Test]
        public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
        {
            // Arrange
            List<int> mixedNumbersList = new() { 1, 2, 2, 4, 3, 8 };

            // Act
            string result = AdjacentEqual.Sum(mixedNumbersList);


            // Assert
            Assert.That(result, Is.EqualTo("1 8 3 8"));
        }

        [Test]
        public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
        {
            // Arrange
            List<int> allnumbersDuplicatedNumbersList = new() { 2, 2, 4 };

            // Act
            string result = AdjacentEqual.Sum(allnumbersDuplicatedNumbersList);


            // Assert
            Assert.That(result, Is.EqualTo("8"));
        }

        [Test]
        public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
        {
            // Arrange
            List<int> numbersDuplicatedAtBeginingNumbersList = new() { 1, 1, 3, 4 };

            // Act
            string result = AdjacentEqual.Sum(numbersDuplicatedAtBeginingNumbersList);


            // Assert
            Assert.That(result, Is.EqualTo("2 3 4"));
        }

        [Test]
        public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
        {
            // Arrange
            List<int> numbersDuplicatedAtEndNumbersList = new() { 1, 3, 4, 4 };

            // Act
            string result = AdjacentEqual.Sum(numbersDuplicatedAtEndNumbersList);

            // Assert
            Assert.That(result, Is.EqualTo("1 3 8"));
        }

        [Test]
        public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
        {
            // Arrange
            List<int> numbersDuplicatedAtMiddleNumbersList = new() { 1, 3, 4, 4, 1 };

            // Act
            string result = AdjacentEqual.Sum(numbersDuplicatedAtMiddleNumbersList);

            // Assert
            Assert.That(result, Is.EqualTo("1 3 8 1"));
        }
    }

}