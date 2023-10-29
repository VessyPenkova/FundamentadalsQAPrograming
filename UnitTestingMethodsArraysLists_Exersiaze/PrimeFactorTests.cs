using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingMethodsArraysLists_Exersize_App;

namespace UnitTestingMethodsArraysLists_Exersiaze_Tests
{
    public class PrimeFactorTests
    {
        [Test]
        public void Test_FindLargestPrimeFactor_NumberLowerThanTwo()
        {
            //Arrange
            long n = -2;

            //Act & Assert
            Assert.That(() => PrimeFactor.FindLargestPrimeFactor(n), Throws.ArgumentException);
        }

        [Test]
        public void Test_FindLargestPrimeFactor_PrimeNumber()
        {
            //Arrange
            long n = 5;

            //Act
            long result = PrimeFactor.FindLargestPrimeFactor(n);

            //Act & Assert
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Test_FindLargestPrimeFactor_LargeNumber()
        {
            //Arrange
            long n = 10;

            //Act
            long result = PrimeFactor.FindLargestPrimeFactor(n);

            //Act & Assert
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void Test_FindLargestPrimeFactor_LargeNumber123456789()
        {
            //Arrange
            long n = 123456789 ;

            //Act
            long result = PrimeFactor.FindLargestPrimeFactor(n);

            //Act & Assert
            Assert.That(result, Is.EqualTo(3803));
        }
    }
}
