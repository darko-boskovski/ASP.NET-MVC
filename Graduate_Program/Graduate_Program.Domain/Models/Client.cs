using System;
using System.Collections.Generic;
using System.Text;

namespace Graduate_Program.Domain.Models
{
    public class Client : BaseEntity
    {
        //nasleduva unique ID od BaseEntity
        //public int Id { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string Company { get; set; }
        public long MobilePhone { get; set; }
    }
}
