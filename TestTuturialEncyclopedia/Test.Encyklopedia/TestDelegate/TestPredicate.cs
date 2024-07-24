using FluentAssertions;
using Encyclopedia.DelegatsExamples;

namespace TestEncyklopedia.TestDelegatsExamples;

public sealed class PredicateExampleTests
{
    private readonly PredicateExample _predicateExample = new();
    private readonly Predicate<int> _isOdd = number => number % 2 == 1;
    private readonly Predicate<int> _isEven = number => number % 2 == 0;

    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    public void Check_ShouldReturnTrue_ForEvenNumberAndIsEvenPredicate(int input)
    {
        // Act
        bool result = PredicateExample.Check(input, _isEven);

        // Assert
        result.Should().BeTrue();
    }

    [Theory]
    [InlineData(3)]
    [InlineData(5)]
    [InlineData(7)]
    public void Check_ShouldReturnTrue_ForOddNumberAndIsOddPredicate(int input)
    {
        // Act
        bool result = PredicateExample.Check(input, _isOdd);

        // Assert
        result.Should().BeTrue();
    }

    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    public void Check_ShouldReturnFalse_ForEvenNumberAndIsOddPredicate(int input)
    {
        // Act
        bool result = PredicateExample.Check(input, _isOdd);

        // Assert
        result.Should().BeFalse();
    }

    [Fact]
    public void Filter_ShouldReturnEvenNumbersFromDefaultList_WhenPredicateIsEvenAndThereIsNoArgumentsInMethod()
    {
        // Arrange
        List<int> expected = [2, 4, 6, 8, 10];

        // Act
        List<int> result = _predicateExample.Filter(_isEven);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Filter_ShouldReturnEvenNumbers_FromCustomListWhenPredicateIsEvenAndHaveListOfIntAsArgument()
    {
        // Arrange
        List<int> numbers = [11, 12, 13, 14, 15];
        List<int> expected = [12, 14];

        // Act
        List<int> result = _predicateExample.Filter(numbers, _isEven);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}