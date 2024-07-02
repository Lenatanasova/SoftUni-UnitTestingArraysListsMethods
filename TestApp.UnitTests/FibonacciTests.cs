using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        // Arrange
        int input = 0;
        int expected = 0;

        // Act
        int actual = Fibonacci.CalculateFibonacci(input);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        // ArrangeS
        int input = 7;
        int expected = 13;

        // Act
        int actual = Fibonacci.CalculateFibonacci(input);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}