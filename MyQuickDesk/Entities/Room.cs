using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MyQuickDesk.Entities
{
    public class Room : Space
    {
        [Display(Name = "Max Capacity")]
        [Range(2, 100, ErrorMessage = "Please provide value from 2 to 100")]
        public int MaxCapacity { get; set; }
    }
}
