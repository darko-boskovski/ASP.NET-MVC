using SEDC.PizzaApp.Domain.Enums;
using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.Services.Services.Interfaces
{
    public interface IDrinkMenuService
    {
        List<Drink> GetDrinkMenu();
        Drink GetDrinkFromDrinkMenu(string drinkName, DrinkSize size);
    }
}
