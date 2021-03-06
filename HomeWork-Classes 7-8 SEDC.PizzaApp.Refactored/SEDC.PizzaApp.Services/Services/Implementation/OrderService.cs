using SEDC.PizzaApp.DataAccess.Repositories;
using SEDC.PizzaApp.DataAccess.Repositories.StaticDbRepositories;
using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.Services.Services.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _orderRepository;

        public OrderService()
        {
            _orderRepository = new OrderRepository();
        }

        public List<Order> GetAll()
        {
            return _orderRepository.GetAll();
        }

        public Order GetOrderById(int id)
        {
            return _orderRepository.GetById(id);
        }

        public void MakeNewOrder(Order order)
        {
            if (order.Pizzas == null || order.Pizzas.Count < 1)
                throw new ArgumentNullException("Pizza Value in Order cannot be null");

            _orderRepository.Insert(order);

            if (order.Drinks == null || order.Drinks.Count < 1)
                throw new ArgumentNullException("Drinks Value in Order cannot be null");
            _orderRepository.Insert(order);
        }
    }
}
