using SEDC.PizzaApp.DataAccess.Repositories;
using SEDC.PizzaApp.DataAccess.Repositories.StaticDbRepositories;
using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.Services.Services.Implementation
{
    public class UserService : IUserService
    {
        //private readonly IRepository<User> _userRepository;
        //private readonly IRepository<Feedback> _feedbackRepository;



        //public UserService()
        //{
        //    _userRepository = new UserRepository();
        //    _feedbackRepository = new FeedbackRepository();
        //}

        private readonly IRepository<Feedback> _feedbackRepository;
        private readonly IRepository<User> _userRepository;
        public UserService(IRepository<User> userRepository,IRepository<Feedback> feedbackRepository)
        {

              _userRepository = userRepository;
              _feedbackRepository = feedbackRepository;
        }


        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public void GiveFeedback(Feedback feedback)
        {
            _feedbackRepository.Insert(feedback);
        }

        public List<Feedback> GetAllFeedbacks()
        {
            return _feedbackRepository.GetAll();
        }
    }
}
