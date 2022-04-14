using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Graduate_Program.Domain.Models
{
    public class Employee : BaseEntity
    {
        //nasleduva unique ID od BaseEntity
        //public int Id { get; set; }
        public string FullName { get; set; }
        public long MobilePhone { get; set; }
        public string EmailAddress { get; set; }
        [Unique]
        public int EmployeeNumber { get; set; }

        public List<EmployeeProject> EmployeeProjects { get; set; }
    }
}
