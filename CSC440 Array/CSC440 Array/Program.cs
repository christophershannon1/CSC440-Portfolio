using System;

namespace CSC440_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int number1 = 4;
            int number2 = 8;
            int number3 = 15;
            int number4 = 16;
            int number5 = 23;

            if (number1 == 16)
            {

            }
            else if (number2 == 16)
            {

            }
            else if (number3 == 16)
            {

            }
            */

            //numbers will be an array containing integers
            int[] numbers = new int[5];
            //each element of the array can be assigned a value by specifying which part of the array it's using
            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;

            //if i wish to add more to the array, i will need to redefine the space of the array at the time of declaration
            //numbers[5] = 42;

            //by inserting a specific index of the array, we can use writeline to show its value
            //if the second element of the array is desired, use index 1
            Console.WriteLine(numbers[1]);

            //by running numbers.Length we can determine how many numbers are in the array
            //Console.WriteLine(numbers.Length);
            
            
            
            Console.ReadLine();
        }
    }
}
