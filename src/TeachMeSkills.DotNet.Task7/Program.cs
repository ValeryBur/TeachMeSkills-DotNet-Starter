using System;

namespace TeachMeSkills.DotNet.Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to define solution!");
            Console.Write("Enter your number from 1 to 100: ");
            string userInput = Console.ReadLine();
            bool canParse = false;
            canParse = int.TryParse(userInput, out int parsedNumber);
            if (parsedNumber > 0 && parsedNumber < 14)
            {
                Console.WriteLine("Your number is between [0-14]");
            }
            else if (parsedNumber > 15 && parsedNumber < 35)
            {
                Console.WriteLine("Your number is between [15-35]");
            }
            else if (parsedNumber > 36 && parsedNumber < 50)
            {
                Console.WriteLine("Your number is between [36-50]");
            }
            else if (parsedNumber > 50 && parsedNumber < 100)
            {
                Console.WriteLine("Your number is between [50-100]");
            }
            else if (parsedNumber < 0 || parsedNumber > 100)
            {
                Console.WriteLine("Number is out of range!");
            }
                Console.ReadLine();


        }

    }
}
