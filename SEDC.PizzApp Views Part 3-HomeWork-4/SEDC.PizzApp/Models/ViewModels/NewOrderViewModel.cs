using SEDC.PizzApp.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzApp.Models.ViewModels
{
    public class NewOrderViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Please enter your Name")]
        public string FirstName { get; set; }
        [Display(Name = "Please enter your Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Please Enter the type of Pizza")]
        public string Pizza { get; set; }

        public double Price { get; set; }

        public bool Delivered { get; set; }

        public PizzaSize PizzaSize { get; set; }
    }
}
