using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingMethodsArraysLists_Exersize_App;

namespace UnitTestingMethodsArraysLists_Exersiaze_Tests
{

    public class FakeTests
    {
        [Test]
        public void Test_RemoveStringNumbers_NullInput_ThrowsException()
        {
            // Arrange
            char[]? input = null;

            // Act + Assert
            Assert.That(() => Fake.RemoveStringNumbers(input), Throws.ArgumentException);
        }

        [Test]
        public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
        {
            // Arrange
            char[] input = new char[] { 'a', 'b', '0','1'};

            //Act
            char[] result = Fake.RemoveStringNumbers(input);

            //Assert
            Assert.That(result, Is.EqualTo(new char[] { 'a', 'b'}));
        }

        [Test]
        public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
        {
            // Arrange
            char[] input = new char[] { 'a', 'b', 'c', 'd' };

            //Act
            char[] result = Fake.RemoveStringNumbers(input);

            //Assert
            Assert.That(result, Is.EqualTo(new char[] { 'a', 'b' , 'c', 'd'}));
            Assert.That(result, Is.EqualTo(input));
        }

        [Test]
        public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
        {
            // Arrange
            char[] input = Array.Empty<char>();

            //Act
            char[] result = Fake.RemoveStringNumbers(input);

            //Assert
            Assert.That(result, Is.Empty);
        }
        [Test]
        public void Test_RemoveStringNumbers_OnlyDigits_ReturnsEmptyArray()
        {
            // Arrange
            char[] input = new char[] { '1', '2', '3', '4' };

            //Act
            char[] result = Fake.RemoveStringNumbers(input);

            //Assert
            Assert.That(result, Is.Empty);
        }
    }
}
