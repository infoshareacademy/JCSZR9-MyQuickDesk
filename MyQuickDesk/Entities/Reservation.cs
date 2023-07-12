using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyQuickDesk.Entities
{
    public class Reservation
    {
        public Guid Id { get; set; }
        
        
        public Space? Space { get; set; }

        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public Guid? ParkingSpotId { get; set; }
        public ParkingSpot? ParkingSpot { get; set; }
        [Display(Name ="Start Time")]
        public DateTime StartTime { get; set; }= DateTime.Today;
        [Display(Name = "End Time")]
        public DateTime EndTime { get; set; } = DateTime.Today;
    }
}
