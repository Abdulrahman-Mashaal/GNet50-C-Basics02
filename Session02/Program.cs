using System.Runtime.InteropServices;
using Session02.Models;

namespace Session02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            ////-Q01. Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a
            ////variable of type object.Print it.
            //object bookObject = new Book("The Great Gatsby", 180);
            //// convert the object to a string using ToString() method and print it
            //Console.WriteLine(bookObject);
            #endregion

            #region Question 2
            //-Q02. Using the Book class above, print the result of calling ToString(), Equals() (compare book withitself), GetHashCode(), and GetType() on book.
            object bookObject = new Book("The Great Gatsby", 180);
            Console.WriteLine("ToString():");
            Console.WriteLine(bookObject.ToString());
            Console.WriteLine("\nEquals():");
            Console.WriteLine(bookObject.Equals(bookObject));
            Console.WriteLine("\nGetHashCode():");
            Console.WriteLine(bookObject.GetHashCode());
            Console.WriteLine("\nGetType():");
            Console.WriteLine(bookObject.GetType());
            #endregion

        }
    }
}
