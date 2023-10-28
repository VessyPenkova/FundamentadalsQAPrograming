using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTstingMethods_TestApp;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;

        // Act
        string actualResult = StringReverse.Reverse(input);

        // Assert
        Assert.That(actualResult, Is.EqualTo(""));
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        // Arrange
        string input = "V";

        // Act
        string actualResult = StringReverse.Reverse(input);

        // Assert
        Assert.That(actualResult.Length,Is.EqualTo (1));
        Assert.That(actualResult, Is.EqualTo("V"));
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        // Arrange
        string input = "ABC";

        // Act
        string actualResult = StringReverse.Reverse(input);

        // Assert
        Assert.That(actualResult.Length, Is.EqualTo(input.Length));
        Assert.That(actualResult, Is.EqualTo("CBA"));
    }
}
