using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTstingMethods_TestApp;

namespace TestApp.UnitTests;

public class TriangleTests
{

    [Test]
    public void TestTriangleOutputMatchesExpectedSize0()
    {
        // Arrange      
        int input = 0;

        // Act
        string result = Triangle.PrintTriangle(input);

        // Assert
        Assert.That( result,Is.EqualTo (""));
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size3()
    {
        // Arrange      
        int input = 3;

        // Act
        string result = Triangle.PrintTriangle(input);
        string espectedOutPut =
           "1" + Environment.NewLine +
           "1 2" + Environment.NewLine +
           "1 2 3" + Environment.NewLine +
           "1 2" + Environment.NewLine +
           "1";

        // Assert
        Assert.That(result, Is.EqualTo( espectedOutPut));
        Assert.That(result.Length, Is.EqualTo(espectedOutPut.Length));
    }

    [Test]
    public void TestTriangleOutputMatchesExpectedSize5()
    {
        // Arrange      
        int input = 5;

        // Act
        string result = Triangle.PrintTriangle(input);
        string espectedOutPut =
           "1" + Environment.NewLine +
            "1 2" + Environment.NewLine +
            "1 2 3" + Environment.NewLine +
            "1 2 3 4" + Environment.NewLine +
            "1 2 3 4 5" + Environment.NewLine +
            "1 2 3 4" + Environment.NewLine +
            "1 2 3" + Environment.NewLine +
            "1 2" + Environment.NewLine +
            "1";

        // Assert
        Assert.That(result, Is.EqualTo (espectedOutPut));
        Assert.That(result.Length,Is.EqualTo(  espectedOutPut.Length));
    }
}
