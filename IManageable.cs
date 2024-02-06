using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_LibraryManagement
{
    internal interface IManageable
    {
        void AddBook(Book book);
        void RemoveBook(Book book);
    }
}
