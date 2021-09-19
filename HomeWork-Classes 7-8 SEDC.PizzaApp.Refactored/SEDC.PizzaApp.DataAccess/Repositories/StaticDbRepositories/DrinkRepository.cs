using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.DataAccess.Repositories.StaticDbRepositories
{
    public class DrinkRepository : IRepository<Drink>
    {
        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Drink> GetAll()
        {
            return StaticDb.DrinkMenu;
        }

        public Drink GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Drink entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Drink entity)
        {
            throw new NotImplementedException();
        }
    }
}

