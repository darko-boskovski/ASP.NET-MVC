using BookLibrary_Homework.Models.Domain;
using BookLibrary_Homework.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary_Homework.Controllers
{
    public class BookController : Controller
    {

       
        [Route("Books")]
        public IActionResult Index()
        {
            ViewBag.Title = "All Available books";
            var authors = StaticDb.AuthorsList;
            var books = StaticDb.Books;
            return View(books);
        }
        public IActionResult Details(int id)
        {
            ViewData.Add("Title", "Book Details");
            var authors = StaticDb.AuthorsList;
            var books = StaticDb.Books;

            var bookDetails = new BookDetailbyID();
            bool findBook = false;

           
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Id == id)

                {
                    findBook = true;
                    bookDetails.Id = books[i].Id;
                    bookDetails.Title = books[i].Title;
                    bookDetails.YearOfPublishing = books[i].YearOfPublishing;
                    bookDetails.Authors = new List<Author>(books[i].Authors);
              
                }
               
            }

            if (!findBook) return new EmptyResult();
            return View(bookDetails);          
                                  
        }
    }
}
