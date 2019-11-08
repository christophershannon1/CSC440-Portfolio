using System;

namespace CSC440_002
{
    class Program
    {
        static void Main(string[] args)
        {

            //variables need to be declared before they can be used
            //the 'int' before the variables indicate that i wish to assign integer values into the variables
            //the value of the integer in C# can be between -2,147,000,000 and 2,147,000,000
            int x;
            int y;

            //the '=' is called an assignment operator.
            //the assignment operator takes what is on the right hand side and assigns that into whatever is on the left hand side.
            x = 7;
            y = x + 3;

            //the following line of code outputs the value of the y variable
            Console.WriteLine(y);
            Console.ReadLine();

        }
    }
}
