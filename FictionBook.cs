using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_LibraryManagement
{
    internal class FictionBook : Book
    {
        // FictionBook unique attributes
        string mainCharacter;
        bool isSeries;

        public FictionBook(string mainCharacter, bool isSeries)
        {
            this.mainCharacter = mainCharacter;
            this.isSeries = isSeries;
        }
    }
}
