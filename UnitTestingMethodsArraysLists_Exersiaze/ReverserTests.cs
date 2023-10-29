using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingMethodsArraysLists_Exersize_App;

namespace UnitTestingMethodsArraysLists_Exersiaze_Tests
{

    public class ReverserTests
    {
        [Test]
        public void Test_ReverseStrings_WithEmptyArray_ReturnsEmptyArray()
        {
            // Arrange
            string[] inputArray = Array.Empty<string>();

            // Act
            string[] result = Reverser.ReverseStrings(inputArray);

            // Assert
            Assert.That(result, Is.Empty);
        }

        // TODO: finish test
        [Test]
        public void Test_ReverseStrings_WithSingleString_ReturnsReversedString()
        {
            // Arrange
            string[] input = new string[1] { "Hello" };

            // Act
            string[] result = Reverser.ReverseStrings(input);

            // Assert
            Assert.That(result, Is.EqualTo(new[] { "olleH" }));
        }

        [Test]
        public void Test_ReverseStrings_WithMultipleStrings_ReturnsReversedStrings()
        {
            // Arrange
            string[] input = new string[2] { "Hello", "folks" };

            // Act
            string[] result = Reverser.ReverseStrings(input);

            // Assert
            Assert.That(result, Is.EqualTo(new[] { "olleH", "sklof" }));
        }
        [Test]
        public void Test_ReverseStrings_WithSpecialCharacters_ReturnsReversedSpecialCharacters()
        {
            // Arrange
            string[] input = new string[2] { "Hello!", "folks!" };

            // Act
            string[] result = Reverser.ReverseStrings(input);

            // Assert
            Assert.That(result, Is.EqualTo(new[] { "!olleH", "!sklof" }));
        }
    }

}
