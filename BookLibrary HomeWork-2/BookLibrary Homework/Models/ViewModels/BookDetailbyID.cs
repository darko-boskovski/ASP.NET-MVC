using BookLibrary_Homework.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary_Homework.Models.ViewModels
{
    public class BookDetailbyID
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int YearOfPublishing { get; set; }
        public List<Author> Authors { get; set; } = new List<Author>();
    }
}
