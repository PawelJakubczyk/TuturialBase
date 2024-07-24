using FluentAssertions;
using NewTututialEncyclopedia._1.Encyclopedia._11.Delegats;

namespace TuturialRestaurantApi.Tests.TestEncycklopedia.TestDelegate;

public class TestActionsExample
{
    private readonly PersonAction _person = new("John", "Doe", 30, "123 Main St", new DateTime(1990, 1, 1));
    private readonly Action<string> _upperCase = str => Console.WriteLine(str.ToUpper());
    private readonly Action<string> _addExclamationMark = str => Console.WriteLine(string.Concat(str, "!"));

    [Fact]
    public void SayHello_ShouldPrintUpperCaseHelloMessage_WhenActionIsUpperCase()
    {
        // Arrange
        var output = new StringWriter();
        Console.SetOut(output);

        // Act
        ActionsExample.SayHello(_upperCase, _person);

        // Assert
        output.ToString().Trim().Should().Be("HELLO! JOHN!");
    }

    [Fact]
    public void SendEmail_ShouldPrintFormattedEmailMessage_WhenActionIsAddExclamationMark()
    {
        // Arrange
        var output = new StringWriter();
        Console.SetOut(output);

        // Act
        ActionsExample.SendEmail("john.doe@example.com", _person, _addExclamationMark);

        // Assert
        output.ToString().Trim().Should().Be("Hello, John Doe! How are you?!");
    }

    [Fact]
    public void CelebrateBirthday_ShouldPrintBirthdayMessages()
    {
        // Arrange
        var output = new StringWriter();
        Console.SetOut(output);

        // Act
        ActionsExample.CelebrateBirthday(_person);

        // Assert
        var lines = output.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
        lines[0].Should().Be("Happy birthday, John!");
        lines[1].Should().Be("We're celebrating your 30 birthday");
    }
}

