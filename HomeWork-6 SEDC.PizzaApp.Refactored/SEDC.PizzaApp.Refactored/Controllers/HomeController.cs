﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.Refactored.Models;
using SEDC.PizzaApp.Services.Services.Implementation;
using SEDC.PizzaApp.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Refactored.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMenuService _menuService;
        private readonly IUserService _userService;
        private readonly IDrinkMenuService _drinkMenuService;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _menuService = new MenuService();
            _userService = new UserService();
            _drinkMenuService = new DrinkMenuService();
        }

        [HttpGet]
        public IActionResult Index()
        {
            OrderHomeViewModel model = new OrderHomeViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(OrderHomeViewModel model)
        {
            return RedirectToAction("Order", "Order", new { numberOfPizzas = model.NumberOfPizzas, numberOfDrinks = model.NumberOfDrinks });
        }

        public IActionResult Menu()
        {
            var menu = _menuService.GetMenu();
            var menuViewModel = new MenuViewModel();

            var drinkMenu = _drinkMenuService.GetDrinkMenu();

            menuViewModel.Menu = new List<PizzaViewModel>();
            menuViewModel.DrinkMenu = new List<DrinkViewModel>();

            // mapping
            foreach (var pizza in menu)
            {
                menuViewModel.Menu.Add(new PizzaViewModel()
                {
                    Id = pizza.Id,
                    Name = pizza.Name,
                    Size = pizza.Size,
                    Price = pizza.Price
                });
            }
            foreach (var drink in drinkMenu)
            {
                menuViewModel.DrinkMenu.Add(new DrinkViewModel()
                {
                    Id = drink.Id,
                    Name = drink.Name,
                    DrinkSize = drink.DrinkSize,
                    Price = drink.Price
                    
                });
            }

            return View(menuViewModel);
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Feedback()
        {
            FeedbackViewModel model = new FeedbackViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Feedback(FeedbackViewModel model)
        {
            Feedback feedback = new Feedback()
            {
                Name = model.Name,
                Email = model.Email,
                Message = model.Message
            };

            _userService.GiveFeedback(feedback);

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}