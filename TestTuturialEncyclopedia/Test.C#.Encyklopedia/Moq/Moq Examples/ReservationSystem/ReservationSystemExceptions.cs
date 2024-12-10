namespace TestTuturialEncyclopedia.Test.C_.Encyklopedia.Moq.Moq_Examples.ReservationSystem;

public class ReservationSystemExceptions
{
    public class RoomNotFoundException : Exception
    {
        public RoomNotFoundException(Guid roomId) : base($"Room '{roomId}' does not exist.") { }
    }

    public class RoomAlreadyReservedException : Exception
    {
        public RoomAlreadyReservedException(Guid roomId) : base($"Room '{roomId}' is already reserved.") { }
    }

    public class NoAvailableRoomsException : Exception
    {
        public NoAvailableRoomsException(int beds) : base($"No available rooms with {beds} beds.") { }
    }
}