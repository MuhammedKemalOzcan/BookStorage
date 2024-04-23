namespace BookStorage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author("Muhammed","Muhammed@gmail.com",Gender.Male);
            Console.WriteLine(author);
            Console.WriteLine();

            Book csBook = new Book("C# Programming",author,30,10);
            Book javaBook = new Book("Java Programming",author,30,10);
            Book cppBook = new Book("C++ Programming",author,30,10);
            Console.WriteLine(csBook);
            Console.WriteLine();

            List<Book> books = new List<Book>() { csBook,javaBook,cppBook};

            Person person = new Person("Kemal", books);
            Console.WriteLine(person);



            Console.ReadLine();
        }
    }
}
