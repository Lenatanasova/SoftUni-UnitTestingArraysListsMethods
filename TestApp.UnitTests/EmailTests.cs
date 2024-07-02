using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
    // TODO: finish test
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string validEmail = "test@example.com";
        bool expected = true;

        // Act
        bool actual = Email.IsValidEmail(validEmail);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        // Arrange
        string invalidEmail = "testexample.com";
        bool expected = false;

        // Act
        bool actual = Email.IsValidEmail(invalidEmail);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_IsValidEmail_NullInput()
    {
        // Arrange
        string nullInput = "";
        bool expected = false;

        // Act
        bool actual = Email.IsValidEmail(nullInput);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
