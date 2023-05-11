namespace MyQuickDesk.Models
{
    public class ParkingSpot:ReservationItem
    {
        public int ReservationId { get; set; }
        public bool AccesibleParkingSpot { get; set; }
        public bool Charger { get; set; }
        public bool IsAvaible { get; set; }
        
    }
}
