using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingMethodsArraysLists_Exersize_App;

namespace UnitTestingMethodsArraysLists_Exersiaze_Tests
{
    public class PatternTests
    {
        [Test]
        public void Test_SortInPattern_NullInput_ThrowsException()
        {
            // Arrange
            int[]? inputArray = null;

            // Act + Assert
            Assert.That(() => Pattern.SortInPattern(inputArray), Throws.ArgumentException);
        }

        [Test]
        public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
        {
            //Arrange
            int[] inputArray = new[] { 1, 2, 2, 3, 4 };

            //Act
            int[] result = Pattern.SortInPattern(inputArray);

            //Assert
            Assert.That(result, Is.EqualTo(result));
            Assert.That(result, Is.EqualTo(new int[] {1, 4 , 2, 3}));

        }

        [Test]
        public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
        {
            // Arrange
            int[] inputArray = Array.Empty<int>();

            //Act
            int[] result = Pattern.SortInPattern(inputArray);

            // Act + Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
        {
            // Arrange
            int[] inputArray = new[] { 1 };

            //Act
            int[] result = Pattern.SortInPattern(inputArray);

            // Act + Assert
            Assert.That(result, Is.EqualTo(new int[] { 1}));
        }
    }

}
