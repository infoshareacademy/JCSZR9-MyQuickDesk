using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MyQuickDesk.Models
{
    public class Room:ReservationItem
    {
        public int ReservationId { get; set; }

        [Display (Name= "Interactive Board")]

        public bool InteractiveBoard { get; set; }

        [Display (Name= "Max Capacity")]
        [Range(2, 100, ErrorMessage = "Please provide value from 2 to 100")]

        public int MaxCapacity { get; set; }

    }
}
