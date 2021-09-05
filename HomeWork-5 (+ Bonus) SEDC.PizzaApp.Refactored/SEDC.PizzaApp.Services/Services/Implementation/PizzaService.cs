using SEDC.PizzaApp.DataAccess.Repositories;
using SEDC.PizzaApp.DataAccess.Repositories.StaticDbRepositories;
using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.Services.Services.Implementation
{
    public class PizzaService : IPizzaService
    {
        private readonly IRepository<Pizza> _pizzaRepository;
        private readonly IPizzaRepository<Pizza> _pizzaNameRepository;
        public PizzaService()
        {
            _pizzaRepository = new PizzaRepository();
            _pizzaNameRepository = new PizzaRepository();
        }
        public List<Pizza> GetAll()
        {
          return _pizzaRepository.GetAll();
        }

        public Pizza GetByName(string pizzaName)
        {
            return _pizzaNameRepository.GetByName(pizzaName);
        }

        public Pizza GetOrderById(int id)
        {
            return _pizzaRepository.GetById(id);
        }
    }
}
