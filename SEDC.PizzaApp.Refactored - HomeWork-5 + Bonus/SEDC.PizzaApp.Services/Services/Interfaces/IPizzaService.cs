using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.Services.Services.Interfaces
{
    public interface IPizzaService
    {
        Pizza GetOrderById(int id);
        List<Pizza> GetAll();
        Pizza GetByName(string pizzaName);
    }
}

