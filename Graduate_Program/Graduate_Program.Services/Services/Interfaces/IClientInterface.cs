using Graduate_Program.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Graduate_Program.Services.Services.Interfaces
{
    public interface IClientInterface
    {
        Client GetClientById(int id);
        List<Client> GetAllClients();
        public void AddNewClient(Client client);
        public void UpdateExistingClient(Client client);
        public void DeleteClient(int id);

    }
}
