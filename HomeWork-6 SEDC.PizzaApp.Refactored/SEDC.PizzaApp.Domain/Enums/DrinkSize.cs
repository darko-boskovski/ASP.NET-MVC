using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SEDC.PizzaApp.Domain.Enums
{
    
      public enum DrinkSize
    {
        [Display(Name = "0,2l")]
        Small,
        [Display(Name = "0,33l")]
        Medium,
        [Display(Name = "0,5l")]
        Large,
    }

}
