using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> validPalindrome = new List<string>() { "level", "madam", "noon" };

        // Act
        bool actual = Palindrome.IsPalindrome(validPalindrome);

        // Assert
        Assert.IsTrue(actual);
    }

    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> emptyList = new();

        // Act
        bool actual = Palindrome.IsPalindrome(emptyList);

        // Assert
        Assert.IsTrue(actual);
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        // Arrange
        List<string> singleWordList = new List<string>() {"level"} ;

        // Act
        bool actual = Palindrome.IsPalindrome(singleWordList);

        // Assert
        Assert.IsTrue(actual);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        // Arrange
        List<string> nonPalidromeList = new List<string>() { "hello" };

        // Act
        bool actual = Palindrome.IsPalindrome(nonPalidromeList);

        // Assert
        Assert.IsFalse(actual);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> mixedLetters = new List<string>() { "lEVel"};

        // Act
        bool actual = Palindrome.IsPalindrome(mixedLetters);

        // Assert
        Assert.IsTrue(actual);
    }
}
