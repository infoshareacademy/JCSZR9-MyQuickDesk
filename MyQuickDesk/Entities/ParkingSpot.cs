namespace MyQuickDesk.Entities
{
    public class ParkingSpot : Space
    {

        public bool HandicappedSpot { get; set; }
        public bool Charger { get; set; }
        public ICollection<Favorites> Favorites { get; set; } = new List<Favorites>();

    }
}
