namespace MyQuickDesk.Entities
{
    public class Reservation
    {
        public int Id { get; set; }

        public Space Space { get; set; } = null!;

        public int? RoomId { get; set; }
        public Room? Room { get; set; }


        public int? DeskId { get; set; }
        public Desk? Desk { get; set; }


        public int? ParkingSpotId { get; set; }
        public ParkingSpot? ParkingSpot { get; set; }


        public int UserId { get; set; }
        public User User { get; set; } = null!;

        //========================================

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
