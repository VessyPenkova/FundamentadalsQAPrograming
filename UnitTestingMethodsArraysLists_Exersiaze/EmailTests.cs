using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingMethodsArraysLists_Exersize_App;

namespace UnitTestingMethodsArraysLists_Exersiaze_Tests
{
    public class EmailTests
    {        
        [Test]
        public void Test_IsValidEmail_ValidEmail()
        {
            // Arrange
            string validEmail = "test@example.com";

            // Act
            bool isValidEmail = Email.IsValidEmail(validEmail);

            // Assert
            Assert.IsTrue(isValidEmail);
        }

        [Test]
        public void Test_IsValidEmail_InvalidEmail()
        {
            // Arrange
            string validEmail = "test@ex  le.com";

            // Act
            bool isValidEmail = Email.IsValidEmail(validEmail);

            // Assert
            Assert.IsFalse(isValidEmail);
        }

        [Test]
        public void Test_IsValidEmail_NullInput()
        {
            // Arrange
            string validEmail = null;

            // Act
            bool isValidEmail = Email.IsValidEmail(validEmail);

            // Assert
            Assert.IsFalse(isValidEmail);
        }
    }

}
