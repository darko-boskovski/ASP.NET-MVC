using Graduate_Program.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Graduate_Program.WebModels
{
    public class ProjectViewModel
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public List<EmployeeProject> EmployeeProjects { get; set; } = new List<EmployeeProject>();
        public List<Client> Clients { get; set; } = new List<Client>();
        public List<Employee> Employees { get; set; } = new List<Employee>(); 
    }
}
