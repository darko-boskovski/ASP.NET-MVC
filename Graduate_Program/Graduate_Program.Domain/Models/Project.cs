using System;
using System.Collections.Generic;
using System.Text;

namespace Graduate_Program.Domain.Models
{
    public class Project : BaseEntity
    {
        //nasleduva unique ID od BaseEntity
        //public int Id { get; set; }
        public string Name{ get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ClientId { get; set; }
        public List<EmployeeProject> EmployeeProjects { get; set; }
    }
}
