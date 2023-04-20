using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MyQuickDesk.Models
{
    public class Room
    {
        [ReadOnly(true)]
        public int Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Please provide name")]
        public string Name { get; set; }

        [StringLength(200)]
        [Required(ErrorMessage = "Please provide description.")]
        public string Description { get; set; }

        [ReadOnly(true)]
        [Display(Name = "Owner Id")]
        public int OwnerId { get; set; }

        [Display (Name= "Interactive Board")]
        public bool InteractiveBoard { get; set; }

        [Display (Name= "Max Capacity")]
        [Range(2, 100, ErrorMessage = "Please provide value from 2 to 100")]
        public int MaxCapacity { get; set; }

        [Display(Name = "Start Date")]
        [Required(ErrorMessage = "Please provide start date.")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [Required(ErrorMessage = "Please provide end date.")]
        public DateTime EndDate { get; set; }
    }
}
