using NUnit.Framework;
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
    public void TestReverseWhenGivenEmptyStringReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;

        // Act
        string actualResult = StringReverse.Reverse(input);

        // Assert
        Assert.That(actualResult, Is.EqualTo(""));
    }

    [Test]
    public void TestReverseWhenGivenSingleCharacterStringReturnsSameCharacter()
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
    public void TestReverseWhenGivenNormalStringReturnsReversedString()
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
