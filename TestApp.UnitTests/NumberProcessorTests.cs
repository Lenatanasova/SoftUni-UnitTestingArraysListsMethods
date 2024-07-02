using NUnit.Framework;

using System.Collections.Generic;
using System.Xml.Linq;

namespace TestApp.UnitTests;

public class NumberProcessorTests
{
    [Test]
    public void Test_ProcessNumbers_SquareEvenNumbers()
    {
        // Arrange
        List<int> evenList = new() { 2, 4, 6 };
        List<double> expected = new() { 4, 16, 36 };

        // Act
        List<double> actual = NumberProcessor.ProcessNumbers(evenList);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    // TODO: finish test
    [Test]
    public void Test_ProcessNumbers_SquareRootOddNumbers()
    {
        // Arrange
        List<int> oddList = new() { 1, 9, };
        List<double> expected = new() { 1.0, 3.0 };

        // Act
        List<double> actual = NumberProcessor.ProcessNumbers(oddList);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    // TODO: finish test
    [Test]
    public void Test_ProcessNumbers_HandleZero()
    {
        // Arrange
        List<int> zeroList = new() { 0 };
        List<int> expected = new() { 0 };

        // Act
        List<double> actual = NumberProcessor.ProcessNumbers(zeroList);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_ProcessNumbers_EmptyInput()
    {
        // Arrange
        List<int> emptyList = new List<int>() { };  

        // Act
        List<double> actual = NumberProcessor.ProcessNumbers(emptyList);

        // Assert
        CollectionAssert.AreEqual(emptyList, actual);
    }
}
