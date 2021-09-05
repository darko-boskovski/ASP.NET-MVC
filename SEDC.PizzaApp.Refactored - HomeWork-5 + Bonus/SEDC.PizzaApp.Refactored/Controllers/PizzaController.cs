using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Refactored.Models;
using SEDC.PizzaApp.Services.Services.Interfaces;
using SEDC.PizzaApp.Services.Services.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Refactored.Controllers
{
    public class PizzaController : Controller
    {
        private readonly IPizzaService _pizzaService;
        public PizzaController()
        {
            _pizzaService = new PizzaService();
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/menu")]
        public IActionResult GetAll()
        {

            var pizzas = _pizzaService.GetAll();

            var pizzaItems = new List<PizzasViewModel>();

            foreach (var pizza in pizzas)
            {
                pizzaItems.Add(new PizzasViewModel()
                {
                    Id = pizza.Id,
                    Name = pizza.Name,
                    Size = pizza.Size,
                    Price = pizza.Price

                });
            }

            return View(pizzaItems);
        }
        [HttpGet("/menu/{pizzaName}")]
        public IActionResult GetByName(string pizzaName)
        {
            var pizza = _pizzaService.GetByName(pizzaName);
            if (pizza == null) return new EmptyResult();
            var pizzaViewModel = new PizzasViewModel()
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Size = pizza.Size,
                Price = pizza.Price
               
            };

            if (pizza == null) return new EmptyResult();
            return View(pizzaViewModel);
        }

    }
}
