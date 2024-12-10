using FluentAssertions;
using FluentAssertions.Extensions;
using Moq;
using System.Collections.Generic;
using static TestTuturialEncyclopedia.Test.C_.Encyklopedia.Moq.Moq_Examples.ReservationSystem.ReservationSystemExceptions;

namespace TestTuturialEncyclopedia.Test.C_.Encyklopedia.Moq.Moq_Examples.ReservationSystem;

public sealed class ReservationSystemTests
{
    private readonly ReservationSystem _reservationSystem;
    private readonly Mock<IBookingService> mockBookingService = new();

    public ReservationSystemTests()
    {
        _reservationSystem = new ReservationSystem(mockBookingService.Object);
    }

    [Fact]
    public async Task ReserveAsync_ShouldThrowNoAvailableRoomsException_WhenNoRoomsAreAvailable()
    {
        // Arrange
        var mockBookingService = new Mock<IBookingService>();
        mockBookingService.Setup(x => x.GetRoomsAsync(10)).ReturnsAsync([]);

        // Act
        Func<Task> act = async () => await _reservationSystem.ReserveAsync(10);

        // Assert
        await act.Should().ThrowAsync<NoAvailableRoomsException>();
    }

    [Fact]
    public async Task ReserveAsync_ShouldReturnFirstAvalibleRoom_WhenRoomsAreAvailable()
    {
        // Arrange
        var room1 = new Room { RoomName = "Deluxe Suite", Beds = 2, IsReserved = true };
        var room2 = new Room { RoomName = "Standard Room", Beds = 2, IsReserved = false };
        var room3 = new Room { RoomName = "Family Room", Beds = 4, IsReserved = true };
        var room4 = new Room { RoomName = "Single Room", Beds = 1, IsReserved = false };

        IEnumerable<Room> rooms = [room1, room2, room3, room4];

        mockBookingService.Setup(x => x.GetRoomsAsync(2)).ReturnsAsync(rooms);

        // Act
        await _reservationSystem.ReserveAsync(2);

        // Assert
        mockBookingService.Verify(x => x.ReserveRoomAsync(room2.RoomId), Times.Once);
        room2.IsReserved.Should().BeTrue();
    }
}