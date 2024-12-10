using static TestTuturialEncyclopedia.Test.C_.Encyklopedia.Moq.Moq_Examples.ReservationSystem.ReservationSystemExceptions;

namespace TestTuturialEncyclopedia.Test.C_.Encyklopedia.Moq.Moq_Examples.ReservationSystem;

public class ReservationSystem(IBookingService bookingService)
{
    private readonly IBookingService bookingService = bookingService;

    public async Task ReserveAsync(int amountOfBeds)
    {
        var rooms = await bookingService.GetRoomsAsync(amountOfBeds);

        var firstAvailableRoom = rooms.FirstOrDefault(room => !room.IsReserved);

        if (firstAvailableRoom is null)
        {
            throw new NoAvailableRoomsException(amountOfBeds);
        }

        await bookingService.ReserveRoomAsync(firstAvailableRoom.RoomId);
    }
}

public interface IBookingService
{
    public Task<IEnumerable<Room>> GetRoomsAsync(int beds);
    public Task ReserveRoomAsync(Guid roomId);
}

public sealed class Room
{
    public Guid RoomId { get; set; } = Guid.NewGuid();
    public string? RoomName { get; set; }
    public int Beds { get; set; }
    public bool IsReserved { get; set; } = false;
}