namespace MyQuickDesk.Models
{
    public class ParkingSpot
    {
        public int Id { get; set; }
        public int PlaceNumber { get; set; }
        public char FloorName { get; set; }
        public bool AccesibleParkingSpot { get; set; }
        public bool Charger { get; set; }
        public bool IsAvaible { get; set; }
        public DateTime? StartDate  { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
