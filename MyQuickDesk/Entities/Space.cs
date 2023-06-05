﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MyQuickDesk.Entities
{
    public class Space
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty!;

        //[Display(Name = "User_Id")]
        //public int UserId { get; set; }

        //[StringLength(200)]
        //[Required(ErrorMessage = "Please provide description.")]

        public bool IsAvaible { get; set; } = true;

        public string? Description { get; set; }

        [Display(Name = "Max Capacity")]
        [Range(2, 100, ErrorMessage = "Please provide value from 2 to 100")]
        public int MaxCapacity { get; set; } = 1;

        public ICollection<Reservation> Reservations { get; set;} = new List<Reservation>();




    }
}
