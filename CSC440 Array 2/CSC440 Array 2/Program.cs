using System;

namespace CSC440_Array_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //instead of assigning values to the array per index we can make an array this way instead
            int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };

            //instead of using integers we can use strings in our array!
            string[] names = new string[] { "Eddie", "Alex", "Michael", "David Lee" };
            */

            /*
            // we can use the for loop to go through each item in the array
            //using the for loop we can list all of the elements in the array into the console window
            for (int i = 0; i < names.Length; i++)
            {

                Console.WriteLine(names[i]);
            }
            */


            /*
            //in this foreach block we can copy each element into the temporary variable 'name'
            //this is easier to do than just the for loop
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            */


            //Making an array reverse itself
            string zig = "You can get what you want out of life" +
                "if you help enough other people get what they want.";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }


            Console.ReadLine();
        }
    }
}
