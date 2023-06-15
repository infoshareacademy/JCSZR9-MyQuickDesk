namespace MyQuickDesk.Entities
{
    public class Reservation
    {
        public Guid Id { get; set; }

        public Space Space { get; set; } = null!;

        public Guid? RoomId { get; set; }
        public Room? Room { get; set; }


        public Guid? DeskId { get; set; }
        public Desk? Desk { get; set; }


        public Guid? ParkingSpotId { get; set; }
        public ParkingSpot? ParkingSpot { get; set; }


        public Guid UserId { get; set; }
        public IdentityUser User { get; set; } = null!;

        //========================================

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
