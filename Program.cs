using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_LibraryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create a list of books
            List<Book> books = new List<Book>();

            books.Add(new Book("Tales of Fire", "Emmy Jones", "2022"));
            books.Add(new Book("Water Benders", "Charles Darwin", "2021"));
            books.Add(new Book("Earth King", "John Rowland", "2009"));
            books.Add(new Book("The Air Castles", "Kenny Williams", "2012"));

            // create an instance of Member class
            // call its methods
            Member member = new Member("Bernard", "0QW234", 098222);
            member.BorrowBook("Tales of Fire", books);
            member.ReturnBook(books[0]);

            // create an instance of Librarian class
            // call its methods
            Librarian librarian = new Librarian("Theo", "0ZW343", 100);
            librarian.ManageInventory(books);
            librarian.AddBook(books[0]);
            librarian.RemoveBook(books[0]);

            Console.ReadKey();
        }
    }
}
