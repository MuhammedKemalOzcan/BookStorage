using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStorage
{
    public class Book
    {
        public string Name { get; set; }
        public Author Author { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; } = 0;

        public Book(string name, Author author, double price)
        {
            Name = name;
            Author = author;
            Price = price;
        }
        public Book(string name, Author author, double price, int quantity) : this(name, author, price)
        {
            Quantity = quantity;
        }
        public override string ToString()
        {
            return $"Name: {Name}\nauthor: {Author.Name}\nPrice: {Price}\nQuantity: {Quantity}";
        }
    }
}
