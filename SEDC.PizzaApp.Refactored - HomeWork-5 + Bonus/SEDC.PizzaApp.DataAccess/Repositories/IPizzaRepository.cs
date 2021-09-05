using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.DataAccess.Repositories
{
    public interface IPizzaRepository<T>
    {
        T GetByName(string pizzaName);
    }
}
