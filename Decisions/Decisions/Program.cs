using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            //the user is prompted to choose a number for a prize
            Console.WriteLine("Bob's Big Givaway");
            Console.Write("Choose a door: 1, 2, or 3: ");
            //here is the prompt for the user to input their choice
            string userValue = Console.ReadLine();

            //if they choose door number 1 they get a new car!
            if (userValue == "1")
            {
                //this is the message that is displayed
                string message = "You won a new car!";
                Console.WriteLine(message);
            }
            //after the code block for the if statement there will be an else if
            //if the first evaluation is not true the app will move on
            else if (userValue == "2")
            {
                //if the user chooses 2 they will get a message saying they won a boat
                string message = "You won a new boat!";
                Console.WriteLine(message);
            }
            else if (userValue == "3")
            {
                //if they chose 3 they won a cat
                string message = "You won a new cat!";
                Console.WriteLine(message);
            }
            //in every other case that isn't covered above, this else block will provide the following message
            else
            {
                string message = "Sorry, we didn't understand!";
                Console.WriteLine(message);
            }


            Console.ReadLine();
        }
    }
}
