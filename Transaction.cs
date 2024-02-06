using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_LibraryManagement
{
    public class Transaction
    {
        // properties to keep track of borrowed books
        public int BorrowedBooks { get; set; }
        public int ReturnedBooks { get; set; }

        // constructor for Transaction class
        public Transaction(int borrowedBooks, int returnedBooks)
        {
            this.BorrowedBooks = borrowedBooks;
            this.ReturnedBooks = returnedBooks;
        }

        public void BorrowBook(Member member, Book book)
        {
            member.BorrowBook(book);
        }
    }
}
