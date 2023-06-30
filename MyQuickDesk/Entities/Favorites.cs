using System.Collections.Generic;

namespace MyQuickDesk.Entities
{
    public class Favorites
    {
        public User User { get; set; }
        public Guid UserId { get; set; }
        public List<ParkingSpot> ParkingSpot  { get; set; }
        public Guid ParkingId { get; set; }
    }
}

