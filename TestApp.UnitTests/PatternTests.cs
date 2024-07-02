using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        // Arrange
        int[] input = new int[] { 4, 8, 14, 1, 7, 1 };
        int[] expected = new int[] { 1, 14, 4, 8, 7 };

        // Act
        int[] actual = Pattern.SortInPattern(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] input = Array.Empty<int>();
        
        // Act
        int[] actual = Pattern.SortInPattern(input);

        // Assert
        Assert.That(actual, Is.Empty);

    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        // Arrange
        int[] input = new int[] { 12 };
        int[] expected = new int[] { 12 };

        // Act
        int[] actual = Pattern.SortInPattern(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
