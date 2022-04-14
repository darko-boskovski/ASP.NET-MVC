using Graduate_Program.Domain.Models;
using Graduate_Program.Services.Services.Interfaces;
using Graduate_Program.WebModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Graduate_Program_.Net_Assignment.Controllers
{
    public class ProjectController : Controller
    {


        private readonly IProjectInterface _projectService;
        private readonly IClientInterface _clientService;
        private readonly IEmployeeInterface _employeeService;



        public ProjectController(IProjectInterface projectService, IClientInterface clientService, IEmployeeInterface employeeService)
        {
            _projectService = projectService;
            _clientService = clientService;
            _employeeService = employeeService;

        }

        [HttpGet]
        public IActionResult CreateProject()
        {
            ProjectViewModel model = new ProjectViewModel();
            try
            {
                
                model.Employees = _employeeService.GetAllEmployees();
                model.Clients = _clientService.GetAllClients();

                return View(model);
            }
            catch (Exception e)
            {
                ViewBag.ErrorMessage = "Something went wrong with saving this Project, pleasee try again";
                return StatusCode(500);

            }

        }
        [HttpPost]
        public IActionResult CreateProject(ProjectViewModel model)
        {

            try
            {

                var project = new Project()
                {
                    Name = model.Name,
                    StartDate = model.StartDate,
                    EndDate = model.EndDate,
                    EmployeeProjects = model.EmployeeProjects,
                    ClientId = model.ClientId

                 };


                _projectService.AddNewProject(project);

                ProjectViewModel projectDetails = new ProjectViewModel()
                {
                    Name = project.Name,
                    StartDate = project.StartDate,
                    EndDate = project.EndDate,
                    EmployeeProjects = project.EmployeeProjects,
                    ClientId = project.ClientId,                

                };

                return RedirectToAction("ProjectDetails", "Project" );



            }
            catch (Exception e)
            {
                ViewBag.ErrorMessage = "Something went wrong with saving this Project, pleasee try again";
                return View(model);
            }

        }

        public IActionResult ProjectDetails()
        { 
            
            var project = _projectService.GetAllProjects().LastOrDefault();


            try {
            

            ProjectViewModel projectDetails = new ProjectViewModel()
            {
                Name = project.Name,
                StartDate = project.StartDate,
                EndDate = project.EndDate,
                EmployeeProjects = project.EmployeeProjects,
                ClientId = project.ClientId,
                Employees = project.EmployeeProjects.Select(x => x.Employee).ToList(),
                Client = _clientService.GetAllClients().FirstOrDefault(x=>x.Id == project.ClientId),

            };

                if(projectDetails.Client == null || projectDetails.Client.FullName == "")
                {
                    throw new ArgumentNullException("Please enter valid information");
                }

            return View(projectDetails);
            }
            catch (Exception e)
            {
                ViewBag.ErrorMessage = "Something went wrong with saving this Project, pleasee try again";
                return StatusCode(500);
            } 
     
        }




    }
}
