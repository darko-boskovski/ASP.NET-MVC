using Graduate_Program.Services.Services.Implementation;
using Graduate_Program.Services.Services.Interfaces;
using Graduate_Program_.Net_Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Graduate_Program_.Net_Assignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeInterface _employeeService;
        private readonly IProjectInterface _projectService;
        private readonly IClientInterface _clienttService;


        public HomeController(ILogger<HomeController> logger, IEmployeeInterface employeeService, IProjectInterface projectService, IClientInterface clientService)
        {
            _logger = logger;
            _employeeService = employeeService;
            _projectService = projectService;
            _clienttService = clientService;
        }

        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Darko Boshkovski";

            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
