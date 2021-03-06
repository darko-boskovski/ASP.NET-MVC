using SEDC.PizzaApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Refactored.Models
{
    public class DrinkViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DrinkSize DrinkSize { get; set; }
        public double Price { get; set; }
    }
}
