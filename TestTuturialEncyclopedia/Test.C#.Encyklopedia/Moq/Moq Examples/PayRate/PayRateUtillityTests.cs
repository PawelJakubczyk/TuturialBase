using FluentAssertions;
using Moq;

namespace TestTuturialEncyclopedia.Test.C_.Encyklopedia.Moq.Moq_Examples;

public sealed class PayRateUtillityTests
{
    [Fact]
    public void GetPayRate_ShouldReturnBaseRate_WhenTodayIsSunday()
    {
        // Arrange
        var mockDateTimeProvider = new Mock<IDateTimeProvider>();
        mockDateTimeProvider.Setup(provider => provider.TodayDay()).Returns(DayOfWeek.Sunday);

        var payRateUtility = new PayRateUtilityWrapper(mockDateTimeProvider.Object);
        decimal baseRate = 100m;

        // Act
        decimal result = payRateUtility.GetPayRate(baseRate);

        // Assert
        result.Should().Be(baseRate);
    }

    [Fact]
    public void GetPayRate_ShouldReturnIncreasedRate_WhenTodayIsNotSunday()
    {
        // Arrange
        var mockDateTimeProvider = new Mock<IDateTimeProvider>();
        mockDateTimeProvider.Setup(provider => provider.TodayDay()).Returns(DayOfWeek.Monday);

        var payRateUtility = new PayRateUtilityWrapper(mockDateTimeProvider.Object);
        decimal baseRate = 100m;

        // Act
        decimal result = payRateUtility.GetPayRate(baseRate);

        // Assert
        result.Should().Be(baseRate * 1.25m);
    }

    private class PayRateUtilityWrapper : PayRateUtility
    {
        private readonly IDateTimeProvider _dateTimeProvider;

        public PayRateUtilityWrapper(IDateTimeProvider dateTimeProvider)
        {
            _dateTimeProvider = dateTimeProvider;
        }

        public override DayOfWeek TodayDay()
        {
            return _dateTimeProvider.TodayDay();
        }
    }
}