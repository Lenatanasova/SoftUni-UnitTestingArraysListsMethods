using NUnit.Framework;

using System;
using System.Linq;

namespace TestApp.UnitTests;

//public static string[] ReverseStrings(string[] arr)
//{
//    return arr.Select(s => new string(s.Reverse().ToArray())).ToArray();
//}

public class ReverserTests
{
    [Test]
    public void Test_ReverseStrings_WithEmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        string[] inputArray = Array.Empty<string>();

        // Act
        string[] result = Reverser.ReverseStrings(inputArray);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_ReverseStrings_WithSingleString_ReturnsReversedString()
    {
        // Arrange
        string[] singleStringArray = new string[] {"Hello"};
        string [] expected = new string[] {"olleH"};

        // Act
        string[] actual = Reverser.ReverseStrings(singleStringArray);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseStrings_WithMultipleStrings_ReturnsReversedStrings()
    {
        // Arrange
        string[] multiStringArray = new string[] { "Hello", "Lena", "Atanasova" };
        string[] expected = new string[] { "olleH", "aneL", "avosanatA" };

        // Act
        string[] actual = Reverser.ReverseStrings(multiStringArray);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseStrings_WithSpecialCharacters_ReturnsReversedSpecialCharacters()
    {
        // Arrange
        string[] specialStringArray = new string[] { "Hello!", "Lena:)", "Atanasova&" };
        string[] expected = new string[] { "!olleH", "):aneL", "&avosanatA" };

        // Act
        string[] actual = Reverser.ReverseStrings(specialStringArray);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
