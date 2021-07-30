using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndObjects
{
    // A constructor method is called each time a class is created to initialize the object details
    class Book
    {
        // Class attributes, public means that the attributes can be accessed by anyone
        public string title;
        public string author;
        public int pages;
        // Private means that only the code within the Book class can access the attribute
        private string bookType;
        // Static attribute, contained only in the class itself, is not unique to the objects, same for all the objects, it is about the class
        public static int bookCount = 0;

        public Book(string aTitle, string aAuthor, int aPages, string aBookType) // The constructor, you can also pass parameters in the constructor
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
            bookType = aBookType;
            bookCount++;

        }

        // You can create another constructor...YOU CAN HAVE MORE THAN ONE CONSTRUCTOR
        public Book() // This constructor does not take in any args..
        {
            bookCount++;
        } 

        // To access a class attribute from an object, you create a public method that can access the class attribute
        public int GetBookCount()
        {
            return bookCount;
        }

        // Object Methods
        public bool HasManyPages()
        {
            if( pages <= 700 ) // Will work for the different objects
            {
                return true;
            }
            return false;
        }

        // Getters and Setters define what attributes are accesssible outside of the class
        // Getters and setters allow code outside the Book class to access the attribute and set it
        // A property allows defining of a getter and setter

        public string BookType // Usually named by the same name as the atttribute but starts with a capital letter
        {
            get { return bookType; }
            set 
            {
                if (value == "Technology" || value == "Romance" || value == "Thriller") // Represents whatever is passed in
                {
                    bookType = value;
                }
                else
                {
                    bookType = "N/A";
                }
            }
        }

        // A static method belongs to the class
        // You can have a class that only contains static methods
        // You cannot create an instance of a static class, 
             // static class Test{
               // }
        public static void RecordBook(string title)
        {
            Console.WriteLine(title +" recorded");
        }
        
    }
}
