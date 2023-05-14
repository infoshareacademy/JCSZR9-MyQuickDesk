using System.ComponentModel.DataAnnotations;

namespace MyQuickDesk.Models
{
    public abstract class Space
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Owner Id")]

        public int OwnerId { get; set; }

        [StringLength(200)]
        [Required(ErrorMessage = "Please provide description.")]

        public string Description { get; set; }


    }
}
