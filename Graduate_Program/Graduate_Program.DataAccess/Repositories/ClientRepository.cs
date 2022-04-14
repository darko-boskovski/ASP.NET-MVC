using Graduate_Program.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graduate_Program.DataAccess.Repositories
{
    public class ClientRepository : IRepository<Client>
    {

        private readonly ProgramContextDb _dbContext;

        public ClientRepository(ProgramContextDb dbContext)
        {
            _dbContext = dbContext;
        }

        public void DeleteById(int id)
        {
            Client client = _dbContext.Clients.FirstOrDefault(x => x.Id == id);
            if (client != null)
            {
                _dbContext.Clients.Remove(client);
                _dbContext.SaveChanges();
            }
        }

        public List<Client> GetAll()
        {
            return _dbContext.Clients
                .ToList();
        }

        public Client GetById(int id)
        {
            return _dbContext.Clients
                .FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Client entity)
        {
            _dbContext.Clients.Add(entity);
            int id = _dbContext.SaveChanges();
            return id;
        }



        public void Update(Client entity)
        {
            Client client = _dbContext.Clients.FirstOrDefault(x => x.Id == entity.Id);
            if (client != null)
            {
                client.FullName = entity.FullName;
                client.MobilePhone = entity.MobilePhone;
                client.EmailAddress = entity.FullName;
                client.Company = entity.Company;
                _dbContext.Clients.Update(client);
                _dbContext.SaveChanges();
            }
        }
    }
}
