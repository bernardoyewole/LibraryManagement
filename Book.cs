using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_LibraryManagement
{
    public class Book
    {
        public string Title;
        public string Author;
        public string PublicationYear;
        public bool IsAvailable;

        public Book()
        {
            // default Book constructor
        }

        // parameterised Book constructor
        public Book(string title, string author, string publicationYear)
        {
            this.Title = title;
            this.Author = author;
            this.PublicationYear = publicationYear;
            this.IsAvailable = true;
        }

    }
}
