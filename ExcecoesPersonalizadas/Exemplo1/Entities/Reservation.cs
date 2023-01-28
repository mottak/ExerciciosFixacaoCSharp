using ReservationSystem.Entities.Exceptions;

namespace ReservationSystem.Entities
{
  class Reservation
  {
    public int RoomNumber { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }

    public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
    {
      if (checkOut <= checkIn)
      {
        throw new DomainException("Check-out date must be aftercheck-in date");
      }
      RoomNumber = roomNumber;
      CheckIn = checkIn;
      CheckOut = checkOut;
    }
    public int Duration()
    {
      TimeSpan duration = CheckOut.Subtract(CheckIn);
      return (int)duration.TotalDays;
    }

    public void UpdateDates(DateTime checkIn, DateTime checkOut)
    {
      DateTime now = DateTime.Now;
      if (checkIn < now || checkOut < now)
      {
        throw new DomainException("Reservation dates for update must be future dates");
      }
      if (checkOut <= checkIn)
      {
        throw new DomainException("Check-out date must be aftercheck-in date");
      }
      CheckIn = checkIn;
      CheckOut = checkOut;
    }
    public override string ToString()
    {
      return $"Room {RoomNumber}, check-in: {CheckIn}, checkout: {CheckOut.ToString("dd/MM/yyyy")}";
    }
  }
}