using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingArraysLists_Lab_App;

namespace UnitTestingArraysLists_Lab.UnitTests
{
    public class GaussTrickTests
    {
        [Test]
        public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
        {
            // Arrange
            List<int> emptyList = new();

            // Act
            List<int> result = GaussTrick.SumPairs(emptyList);

            // Assert
            CollectionAssert.AreEqual(emptyList, result);
        }

        [Test]
        public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
        {
            // Arrange
            List<int> oneElementList = new() { 2 };

            // Act
            List<int> result = GaussTrick.SumPairs(oneElementList);

            // Assert
            CollectionAssert.AreEqual(oneElementList, result);
        }


        [Test]
        public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
        {
            // Arrange
            List<int> fourElementsList = new() { 1, 2, 3, 4 };

            // Act
            List<int> result = GaussTrick.SumPairs(fourElementsList);

            // Assert 
            //1+4, 2+3
            List<int> manualAssertedResultList = new List<int>() { 5, 5 };
            CollectionAssert.AreEqual(result, manualAssertedResultList);

        }

        [Test]
        public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
        {
            // Arrange
            List<int> fiveElementsList = new() { 1, 2, 3, 4, 5 };

            // Act
            List<int> result = GaussTrick.SumPairs(fiveElementsList);

            // Assert
            //=> (1+5 ; 2+4, 3) =>, (6, 6, 3)
            List<int> manualAssertedResultList = new List<int>() { 6, 6, 3 };
            CollectionAssert.AreEqual(result, manualAssertedResultList);
        }

        [Test]
        public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
        {
            // Arrange
            List<int> tenElementsList = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Act
            List<int> result = GaussTrick.SumPairs(tenElementsList);

            // Assert
            //=> (1+10 , 2+9, 3+8, 4+7, 5+6) =>, (11, 11, 11, 11, 11)
            List<int> manualAssertedResultList = new List<int>() { 11, 11, 11, 11, 11 };
            CollectionAssert.AreEqual(result, manualAssertedResultList);
        }

        [Test]
        public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
        {
            // Arrange
            List<int> elevenElementsList = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            // Act
            List<int> result = GaussTrick.SumPairs(elevenElementsList);

            // Assert
            //=> (1+11 , 2+10, 3+9, 4+8, 5+7, 6) =>, (12, 12, 12, 12, 12, 6)
            List<int> manualAssertedResultList = new List<int>() { 12, 12, 12, 12, 12, 6 };
            CollectionAssert.AreEqual(result, manualAssertedResultList);
        }
    }

}
