using System.Runtime.InteropServices;
using Session02.Models;

namespace Session02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //-Q01. Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a
            //variable of type object.Print it.
            object bookObject = new Book("The Great Gatsby", 180);
            // convert the object to a string using ToString() method and print it
            Console.WriteLine(bookObject);
            #endregion

        }
    }
}
