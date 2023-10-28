using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTstingMethods_TestApp;

namespace TestApp.UnitTests;


public class GradesTests
{
    [TestCase(2.00, "Fail")]
    [TestCase(2.99, "Fail")]

    [TestCase(3.00, "Average")]
    [TestCase(3.49, "Average")]

    [TestCase(3.50, "Good")]
    [TestCase(3.99, "Good")]

    [TestCase(4.00, "Very Good")]
    [TestCase(4.49, "Very Good")]

    [TestCase(4.50, "Excellent")]
    [TestCase(5.00, "Excellent")]

    public void Test_GradeAsWords_ReturnsCorrectString(double grade, string expected)
    {
        // Arrange

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(1.45, "Invalid!")]
    [TestCase(1.99, "Invalid!")]
    [TestCase(1.999, "Invalid!")]
    [TestCase(0.00, "Invalid!")]
    [TestCase(7.00, "Invalid!")]
    [TestCase(77.00, "Invalid!")]
    [TestCase(-2.00, "Invalid!")]

    public void Test_GradeAsWords_ReturnsCorrectString_EdgeCases(double grade, string expected)
    {
        // Arrange

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
