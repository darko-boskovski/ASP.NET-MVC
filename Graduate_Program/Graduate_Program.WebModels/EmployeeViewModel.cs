using Graduate_Program.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Graduate_Program.WebModels
{
   public class EmployeeViewModel
    {
        public string FullName { get; set; }
        public long MobilePhone { get; set; }
        public string EmailAddress { get; set; }
   
        public int EmployeeNumber { get; set; }

        public List<EmployeeProject> EmployeeProjects { get; set; }
    }
}
