﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodNStuff.MVC.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Number in Stock")]
        public int InventoryCount { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "It is food")]
        public bool IsFood { get; set; }
    }
}