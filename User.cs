using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_LibraryManagement
{
    public class User
    {
        public string Name { get; set; }
        public string Id { get; set; }

        public User(string name, string id) 
        { 
            Name = name; 
            Id = id; 
        }

    }
}
