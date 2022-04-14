using System;
using System.Collections.Generic;
using System.Text;

namespace Graduate_Program.Domain.Models
{
    public class EmployeeProject
    {
        public int EmployeeProjectId { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
        public Project Project { get; set; }
        public int ProjectId { get; set; }
    }
}
