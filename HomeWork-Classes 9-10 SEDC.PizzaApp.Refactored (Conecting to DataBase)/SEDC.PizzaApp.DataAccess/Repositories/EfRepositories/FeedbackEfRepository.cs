using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.DataAccess.Repositories.EfRepositories
{
    public class FeedbackEfRepository : IRepository<Feedback>
    {
        private readonly PizzaDbContext _dbContext;

        public FeedbackEfRepository(PizzaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feedback> GetAll()
        {
            return _dbContext.Feedbacks.ToList();
        }

        public Feedback GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Feedback entity)
        {
            _dbContext.Feedbacks.Add(entity);
            int id = _dbContext.SaveChanges();
            return id;
        }

        public void Update(Feedback entity)
        {
            throw new NotImplementedException();
        }
    }
}
