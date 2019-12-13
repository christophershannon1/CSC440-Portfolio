using System;

namespace CSC_440_004
{
    class Program
    {
        static void Main(string[] args)
        {
            //for statement is used to execute code until a specific condition is true
            //after it is true the line of code will continue to the next line
            //so long as the i is less than 10 the value of i will increase by 1 until it isn't
            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine(i);


                //in the following code block i have it set up so that once the value of i gets to 7,
                //a message will be provided stating that seven was found
                if (i == 7)
                {
                    Console.WriteLine("Found seven!");
                    //the break function is used to "break out" of the iteration
                    //once break is reached the for loop will be considered finished
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
