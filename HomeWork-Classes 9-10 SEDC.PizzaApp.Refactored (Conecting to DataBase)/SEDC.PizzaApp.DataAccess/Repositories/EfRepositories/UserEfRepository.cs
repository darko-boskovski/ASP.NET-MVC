using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.DataAccess.Repositories.EfRepositories
{
    public class UserEfRepository : IRepository<User>
    {

        private readonly PizzaDbContext _dbContext;

        public UserEfRepository(PizzaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            return _dbContext.Users.ToList();
        }

        public User GetById(int id)
        {
            var user = _dbContext.Users.FirstOrDefault(x => x.Id == id);
            return user;
        }

        public int Insert(User entity)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
