﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingMethodsArraysLists_Exersize_App;

namespace UnitTestingMethodsArraysLists_Exersiaze_Tests
{
    public class DuplicatesTests
    {

        [Test]
        public void Test_RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
        {
            // Arrange
            int[] numbers = Array.Empty<int>();

            // Act
            int[] result = Duplicates.RemoveDuplicates(numbers);

            // Assert
            Assert.That(result , Is.Empty);
        }


        [Test]
        public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
        {
            // Arrange
            int[] numbers = new[] { 1, 2, 3, 4, 5 };

            // Act
            int[] result = Duplicates.RemoveDuplicates(numbers);

            // Assert
            Assert.That(result, Is.EqualTo(numbers));
        }

        [Test]
        public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
        {
            // Arrange
            int[] numbers = new[] {1 ,1 ,2 ,3 ,3 ,4 ,5 };

            // Act
            int[] result = Duplicates.RemoveDuplicates(numbers);

            // Assert
            Assert.That(result, Is.EqualTo(new int[] { 1, 2, 3, 4, 5 }));
        }

        [Test]
        public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
        {
            // Arrange
            int[] numbers = new[] { 1, 1, 1, 1, 1, 1, 1 };

            // Act
            int[] result = Duplicates.RemoveDuplicates(numbers);

            // Assert
            Assert.That(result, Is.EqualTo(new int[] { 1}));
        }
    }

}
