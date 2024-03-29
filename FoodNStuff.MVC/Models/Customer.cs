﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodNStuff.MVC.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Full Name")]
        // below is same as  public string FullName => return $"{FirstName} {LastName}";
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}