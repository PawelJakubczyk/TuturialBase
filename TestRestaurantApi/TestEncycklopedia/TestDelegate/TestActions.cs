using FluentAssertions;
using NewTututialEncyclopedia._1.Encyclopedia._11.Delegats;

namespace TuturialRestaurantApi.Tests.TestEncycklopedia.TestDelegate
{
    public class TestActionsExample
    {
        private readonly PersonAction _person = new("John", "Doe", 30, "123 Main St", new DateTime(1990, 1, 1));
        private readonly Action<string> _upperCase = str => Console.WriteLine(str.ToUpper());
        private readonly Action<string> _addExclamationMark = str => Console.WriteLine(string.Concat(str, "!"));

        [Fact]
        public void SayHello_ShouldReturnTrue_WhenPersonIsGivenAndUpperCaseActionIsGiven()
        {
            // Act
            ActionsExample.SayHello(_upperCase, _person);

            // Assert
            Console.In.ReadLine().Should().Be("HELLO JOHN!");
        }

        [Fact]
        public void SendEmail_SendEmailToPerson_WhenEmailActionIsGiven()
        {
            // Act
            ActionsExample.SendEmail("john.doe@example.com", _person, _addExclamationMark);

            // Assert
            Console.In.ReadLine().Should().Be("Hello, John Doe! How are you?");
        }

        [Fact]
        public void CelebrateBirthday_PrintHappyBirthdayMessage_AndPrintAge()
        {
            // Act
            ActionsExample.CelebrateBirthday(_person);

            // Assert
            Console.In.ReadLine().Should().Contain("Happy birthday, John!");
            Console.In.ReadLine().Should().Contain("We're celebrating your 30 birthday");
        }
    }
}

