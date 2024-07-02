using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        // Arrange
        long num = 97;
        long expected = 97;

        // Act
        long actual = PrimeFactor.FindLargestPrimeFactor(num);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        // Arrange
        long num = 2369856;
        long expected = 12343;

        // Act
        long actual = PrimeFactor.FindLargestPrimeFactor(num);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
