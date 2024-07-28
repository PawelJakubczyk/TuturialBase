using Encyclopedia.ClassesExamples;
using FluentAssertions;

namespace TestEncyklopedia.TestClassesExamples;

public class TestExtensionMethodReverseSrtring
{
    [Theory]
    [InlineData("", "")]
    [InlineData("a", "a")]
    [InlineData("ab", "ba")]
    [InlineData("king", "gnik")]
    [InlineData("1*#aS", "Sa#*1")]
    public void Reverse_ResultShouldReturnReverseString(string input, string output)
    {
        //Act
        string resoult = input.Reverse();
        // Assert
        resoult.Should().Be(output);
    }

    [Fact]
    public void Reverse_ResultShouldReturnNull_WhenInputStringIsNull()
    {
        //Arrange
        string? input = null;

        //Act
        string? resoult = input.Reverse();

        //Assert
        resoult.Should().BeNull();
    }

    [Fact]
    public void Reverse_ResultShouldReturnEmptyString_WheninputStringIsEmpty()
    {
        //Arrange
        string? input = string.Empty;

        //Act
        string? resoult = input.Reverse();

        //Assert
        resoult.Should().Be(input);
    }
}