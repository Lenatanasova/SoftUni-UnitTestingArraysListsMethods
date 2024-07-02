using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        // Arrange
        char[] digitsArray = new char[] { 'p', '4', 'e', '6', 'l'};
        char[] expected = new char[] { 'p', 'e', 'l' };

        // Act
        char[] actual = Fake.RemoveStringNumbers(digitsArray);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        // Arrange
        char[] noDigitsArray = new char[] { 'p', 'u', 'e', 'k', 'l' };
        char[] expected = new char[] { 'p', 'u', 'e', 'k', 'l' };

        // Act
        char[] actual = Fake.RemoveStringNumbers(noDigitsArray);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        char[] emptyArray = Array.Empty<char>();
        
        // Act
        char[] actual = Fake.RemoveStringNumbers(emptyArray);

        // Assert
        Assert.That(actual, Is.EqualTo(emptyArray));
    }
}
