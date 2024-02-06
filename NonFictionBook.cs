using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_LibraryManagement
{
    internal class NonFictionBook : Book
    {
        // NonFictionBook unique attributes
        string topic;
        bool isAcademic;

        public NonFictionBook(string topic, bool isAcademic)
        {
            this.topic = topic;
            this.isAcademic = isAcademic;
        }
    }
}
