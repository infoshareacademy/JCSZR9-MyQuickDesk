using System.ComponentModel.DataAnnotations;

namespace MyQuickDesk.Models
{
    public abstract class ReservationItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Owner Id")]

        public int OwnerId { get; set; }

        [StringLength(200)]
        [Required(ErrorMessage = "Please provide description.")]

        public string Description { get; set; }

        [Display(Name = "Start Date")]
        [Required(ErrorMessage = "Please provide start date.")]

        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [Required(ErrorMessage = "Please provide end date.")]

        public DateTime EndDate { get; set; }
    }
}
