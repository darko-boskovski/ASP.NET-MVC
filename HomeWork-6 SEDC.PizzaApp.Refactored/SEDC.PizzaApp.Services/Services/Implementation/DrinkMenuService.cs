using SEDC.PizzaApp.DataAccess.Repositories;
using SEDC.PizzaApp.DataAccess.Repositories.StaticDbRepositories;
using SEDC.PizzaApp.Domain.Enums;
using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.Services.Services.Implementation
{
    public class DrinkMenuService : IDrinkMenuService
    {
        private readonly IRepository<Drink> _drinkRepository;

        public DrinkMenuService()
        {
            _drinkRepository = new DrinkRepository();
        }

        public List<Drink> GetDrinkMenu()
        {
            return _drinkRepository.GetAll();
        }

        public Drink GetDrinkFromDrinkMenu(string drinkName, DrinkSize size)
        {
            List<Drink> menu = _drinkRepository.GetAll();
            return menu.FirstOrDefault(x => x.Name == drinkName && x.DrinkSize == size);
        }

    }
}
