using Graduate_Program.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Graduate_Program.WebModels
{
    public class ProjectDetailsViewModel
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ClientId { get; set; }
        public List<EmployeeProject> EmployeeProjects { get; set; }
    }
}
