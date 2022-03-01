﻿using System.ComponentModel.DataAnnotations;
using Warsztat_v2.Enum;

namespace Warsztat_v2.Models
{
    public class Employee
    {

        public int Id { get; set; }
        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        [Display(Name = "Birth Date" )]
        public DateTime DateOfBirth { get; set; }
        public double Salary { get; set; }
        public Role Role { get; set; }
    }
}
