using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BookStorage
{
    public class Person
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }

        public Person(string name)
        {
            Name = name;
        }
        public Person(string name,List<Book> books):this(name)
        {
            Books = books;
        }
        public Person(string name,Book book) : this(name)
        {
            Books = new List<Book>() { book };
        }
        public override string ToString()
        {
            string output = $"{Name} owns these books\n";
            foreach(Book book in Books)
            {
                output += book.Name + "\n";
            }
            return output ;
        }
    }
}
