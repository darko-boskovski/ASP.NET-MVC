using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary_Homework.Models.Domain
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int YearOfPublishing { get; set; }
        public List<Author> Authors { get; set; } = new List<Author>();

    }
}
