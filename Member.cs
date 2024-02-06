using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_LibraryManagement
{
    public class Member : User, IBorrowable
    {
        public int MemberNumber { get; set; }

        // base passes the parameters to the parent constructor
        public Member(string name, string id, int memberNumber) : base(name, id)
        {
            this.MemberNumber = memberNumber;
        }

        // members borrow book and book status is updated
        public void BorrowBook(string title, List<Book> books)
        {
            {
                foreach (Book book in books)
                {
                    if (book.Title == title)
                    {
                        Console.WriteLine($"Here you go - {book.Title} by {book.Author} ({book.PublicationYear})");
                        book.IsAvailable = false;
                    }
                }
            }
        }

        public void BorrowBook(Book book)
        {
            Console.WriteLine($"{book.Title} borrowed successfully");
        }

        // members return borrowed book to inventory
        public void ReturnBook(Book book)
        {
            Console.WriteLine($"{book.Title} is returned successfully");
        }
    }
}
