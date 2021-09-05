using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.DataAccess.Repositories.StaticDbRepositories
{
    public class PizzaRepository : IRepository<Pizza>,IPizzaRepository<Pizza>
    {
        public void DeleteById(int id)
        {
            var pizza = StaticDb.Pizzas.FirstOrDefault(x => x.Id == id);
            if (pizza != null)
            {
                StaticDb.Pizzas.Remove(pizza);
            }
        }

        public List<Pizza> GetAll()
        {
            return StaticDb.Pizzas; ;
        }

        public Pizza GetById(int id)
        {
            var pizza = StaticDb.Pizzas.FirstOrDefault(x => x.Id == id);
            return pizza;
        }

        public Pizza GetByName(string pizzaName)
        {
            return StaticDb.Pizzas.FirstOrDefault(d => d.Name.ToUpper().Contains(pizzaName.ToUpper()));
        }

        public int Insert(Pizza entity)
        {
            var pizzaId = StaticDb.Pizzas.Max(x => x.Id) + 1;
            entity.Id = pizzaId;
            StaticDb.Pizzas.Add(entity);
            return pizzaId;
        }

        public void Update(Pizza entity)
        {
            var pizza = StaticDb.Pizzas.FirstOrDefault(x => x.Id == entity.Id);
            if (pizza != null)
            {
                int index = StaticDb.Pizzas.IndexOf(pizza);
                StaticDb.Pizzas[index] = entity;
            }
        }
    }
}
