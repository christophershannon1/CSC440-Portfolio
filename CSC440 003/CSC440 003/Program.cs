using System;

namespace CSC440_003
{
    class Program
    {
        static void Main(string[] args)
        {

            //the following code will ask the user to enter their first name and last name and output both
            //the '+' will concatinate the two strings together into one larger string
            Console.WriteLine("What is your name?");
            //unlike with 'WriteLine' 'Write' will not create a new line
            Console.Write("Type your first name: ");
            string myFirstName;
            //by using 'ReadLine' method in this instance the user can input data
            myFirstName = Console.ReadLine();

            string myLastName;
            Console.Write("Type your last name: ");
            myLastName = Console.ReadLine();

            //the two strings being added together will have a space in between them for easier reading
            Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
        }
    }
}
