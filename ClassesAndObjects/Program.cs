using System;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // A lot of things in the real world can't be represented in the native c# data types
            // A class is a specification for a new data type
            // An object is an instance of a class, could it be like a variable of a class? No? Ok

            Book book1 = new Book("Learning c# concepts", "JK", 400, "Technology");
            Book book2 = new Book("Lord of the Rings", "Tolkein", 700, "Thriller");
            Book book3 = new Book(); // Because of the constructor without the argument
            book3.BookType = "Test";

            Console.WriteLine(book1.title +" by " + book1.author);
            Console.WriteLine(book2.title + " by " + book2.author);
            Console.WriteLine(book2.HasManyPages());
            Console.WriteLine(book3.BookType);
            Console.WriteLine(book2.BookType);
            Console.WriteLine(Book.bookCount);
            Console.WriteLine(book1.GetBookCount());
            Book.RecordBook("Dare To Lead");

            Console.ReadLine();
        }
    }
}
