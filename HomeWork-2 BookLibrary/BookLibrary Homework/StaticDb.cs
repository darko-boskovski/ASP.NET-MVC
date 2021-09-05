using BookLibrary_Homework.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary_Homework
{
    public static class StaticDb
    {
        public static List<Book> Books;
        public static List<Author> AuthorsList;

        static StaticDb()
        {

            Books = new List<Book>()
            {
                new Book()
                {
                    Id = 1,
                    Title = "Harry Potter",
                    YearOfPublishing = 1997,
                    Authors = new List<Author>()
                    {
                       new Author()
                        {
                         Id = 1,
                         FirstName = "Bukovski",
                         LastName = "Charles"

                        },
                        new Author()
                         {
                          Id = 2,
                          FirstName = "John",
                          LastName = "Doe"

                        }
                    }


                },
                new Book()
                {
                    Id = 2,
                    Title = "Book 2",
                    YearOfPublishing = 2000,
                    Authors = new List<Author>()
                    {
                       new Author()
                        {
                      Id = 3,
                 FirstName = "Pero",
                 LastName = "Blazevski"
                        },
                        new Author()
                         {
                 Id = 4,
                 FirstName = "Trajce",
                 LastName = "Petkovski"

                        }
                    }


                },
                new Book()
                {
                    Id = 3,
                    Title = "Book 3",
                    YearOfPublishing = 2010,
                    Authors = new List<Author>()
                    {
                 new Author()
                {
                    Id = 5,
                 FirstName = "Risto",
                 LastName = "Perovski"


                },
                 new Author()
                {
                 Id = 6,
                 FirstName = "Stanko",
                 LastName = "Petko"

                }


                },


                }
            };
            AuthorsList = new List<Author>()
            {
                   new Author()
                {
                 Id = 1,
                 FirstName = "Bukovski",
                 LastName = "Charles"

                },
                  new Author()
                {
                  Id = 2,
                 FirstName = "John",
                 LastName = "Doe"

                },
                  new Author()
                {
                 Id = 3,
                 FirstName = "Pero",
                 LastName = "Blazevski"

                },
                 new Author()
                {
                 Id = 4,
                 FirstName = "Trajce",
                 LastName = "Petkovski"

                },
                 new Author()
                {
                 Id = 5,
                 FirstName = "Risto",
                 LastName = "Perovski"

                },
                 new Author()
                {
                 Id = 6,
                 FirstName = "Stanko",
                 LastName = "Petko"

                }


            };

        }

    }
}

