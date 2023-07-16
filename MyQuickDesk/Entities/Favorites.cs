using System.Collections.Generic;

namespace MyQuickDesk.Entities
{
    public class Favorites
    {
        public User User { get; set; }
        public Guid UserId { get; set; }
        public ParkingSpot ParkingSpot { get; set; } = null!;
        public Guid ParkingId { get; set; }
    }
}

