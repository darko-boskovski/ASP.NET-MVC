using Graduate_Program.Services.Services.Interfaces;
using Graduate_Program.WebModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Graduate_Program_.Net_Assignment.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly IEmployeeInterface _employeeService;



        public EmployeeController( IEmployeeInterface employeeService)
        {
       
            _employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {

            var employees = _employeeService.GetAllEmployees();

            var employeesViewModel = new List<EmployeeViewModel>();
            foreach (var employee in employees)
            {
                employeesViewModel.Add(new EmployeeViewModel()
                {
                  FullName = employee.FullName,
                  EmailAddress = employee.EmailAddress,
                  EmployeeNumber = employee.EmployeeNumber,
                  MobilePhone = employee.MobilePhone
              
                });
            }
            return View(employeesViewModel);
        }



    }
}
