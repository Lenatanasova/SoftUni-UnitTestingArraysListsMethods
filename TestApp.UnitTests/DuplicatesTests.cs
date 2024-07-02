using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class DuplicatesTests
{
    
    [Test]
    public void Test_RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();
        int[] expected = new int[]{ };

        // Act
        int [] actual = Duplicates.RemoveDuplicates(numbers);

        // Assert
        Assert.AreEqual(actual, expected);
    }

    
    [Test]
    public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
    {
        // Arrange
        int[] noDuplicatesArray = new int[] { 1, 6, 8, 9 };
        int[] expected = new int[] { 1, 6, 8, 9 };

        // Act
        int[] actual = Duplicates.RemoveDuplicates(noDuplicatesArray);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
    {
        // Arrange
        int[] duplicatesArray = new int[] { 1, 2, 6, 9, 9, 2 };
        int[] expected = new int[] { 1, 2, 6, 9};

        // Act
        int[] actual = Duplicates.RemoveDuplicates(duplicatesArray);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
    {
        // Arrange
        int[] allDuplicatesArray = new int[] { 2, 2, 2, 2 };
        int[] expected = new int[] { 2 };

        // Act
        int[] actual = Duplicates.RemoveDuplicates(allDuplicatesArray);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
