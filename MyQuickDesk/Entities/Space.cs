using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MyQuickDesk.Entities
{
    public class Space
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty!;

        //[Display(Name = "User_Id")]
        //public int UserId { get; set; }

        //[StringLength(200)]
        //[Required(ErrorMessage = "Please provide description.")]

        public bool IsAvaible { get; set; }

        public string? Description { get; set; }

        public ICollection<Reservation> Reservations { get; set;} = new List<Reservation>();

        public string? CreatedById { get; set; }
        public IdentityUser? CreatedBy { get; set; }

    }
}
