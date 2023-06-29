using System.Collections.Generic;

namespace MyQuickDesk.Entities
{
    public class Favorites
    {
        public Guid UserId { get; set; }
        public List<ParkingSpot> ParkingSpot  { get; set; }
    }
}

