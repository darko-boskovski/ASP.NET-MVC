using Graduate_Program.DataAccess.Repositories;
using Graduate_Program.Domain.Models;
using Graduate_Program.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Graduate_Program.Services.Services.Implementation
{
    public class ClientService : IClientInterface
    {
        private readonly IRepository<Client> _clientRepository;

        public ClientService(IRepository<Client> clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public void AddNewClient(Client client)
        {
            if (client.FullName == null || client.EmailAddress == null)
                throw new ArgumentNullException("Clinet must contain FullName and email");
            _clientRepository.Insert(client);
        }

        public void DeleteClient(int id)
        {
            _clientRepository.DeleteById(id);
        }

        public List<Client> GetAllClients()
        {
            return _clientRepository.GetAll();
        }

        public Client GetClientById(int id)
        {
            return _clientRepository.GetById(id);
        }

        public void UpdateExistingClient(Client client)
        {
            if (client.FullName == null || client.EmailAddress == null)
                throw new ArgumentNullException("Clinet must contain FullName and email");
            _clientRepository.Update(client);

        }
    }
}
