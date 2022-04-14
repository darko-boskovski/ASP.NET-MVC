using Graduate_Program.Services.Services.Interfaces;
using Graduate_Program.WebModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Graduate_Program_.Net_Assignment.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientInterface _clientService;



        public ClientController(IClientInterface clientService)
        {

            _clientService = clientService;
        }

        [HttpGet]
        public IActionResult GetClients()
        {

            var clients = _clientService.GetAllClients();

            var clientsViewModel = new List<ClientViewModel>();
            foreach (var client in clients)
            {
                clientsViewModel.Add(new ClientViewModel()
                {
                    FullName = client.FullName,
                    EmailAddress = client.EmailAddress,
                    Company = client.Company,
                    MobilePhone = client.MobilePhone

                });
            }
            return View(clientsViewModel);
        }
    }
}
