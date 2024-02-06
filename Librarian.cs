using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_LibraryManagement
{
    internal class Librarian : User, IManageable
    {
        public int NumberOfAvailableBooks;

        // constructor for librarian class
        public Librarian(string name, string id, int numberOfAvailableBooks) : base(name, id)
        {
            NumberOfAvailableBooks = numberOfAvailableBooks;
        }

        // update the number of available books in inventory
        public void ManageInventory(List<Book> books)
        {
            foreach (Book book in books)
            {
                if (book.IsAvailable)
                {
                    NumberOfAvailableBooks++;
                }
            }

            Console.WriteLine($"Number of available books - {NumberOfAvailableBooks}");
        }

        // add book to inventory
        public void AddBook(Book book)
        {
            Console.WriteLine($"{book.Title} added to library catalog");
        }

        // remove book from inventory
        public void RemoveBook(Book book)
        {
            Console.WriteLine($"{book.Title} removed from library catalog");
        }
    }
}