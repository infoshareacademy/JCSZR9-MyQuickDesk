using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyQuickDesk.Entities
{
    public class Reservation
    {
        public Guid Id { get; set; }

        public Space? Space { get; set; }

        public Guid? RoomId { get; set; }
        public Room? Room { get; set; }


        public Guid? DeskId { get; set; }
        public Desk? Desk { get; set; }


        public Guid? ParkingSpotId { get; set; }
        public ParkingSpot? ParkingSpot { get; set; }

        public Guid? UserId { get; set; }
        public User? User { get; set; }

        //========================================
        
        public DateTime StartTime { get; set; } = DateTime.Now;
        
        public DateTime EndTime { get; set; } = DateTime.Now;
    }
}