using System;

namespace TeachMeSkills.DotNet.Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Translator!");
            Console.Write("Input word: ");
            string userInput = Console.ReadLine();
            if (userInput == "солнце")
            {
                Console.WriteLine("Translate: sun");
            }
            else if (userInput == "дождь")
            {
                Console.WriteLine("Translate: rain");
            }
            else if (userInput == "ветер")
            {
                Console.WriteLine("Translate: wind");
            }
            else if (userInput == "свежий")
            {
                Console.WriteLine("Translate: fresh");
            }
            else if (userInput == "жара")
            {
                Console.WriteLine("Translate: heat");
            }
            else if (userInput == "теплый")
            {
                Console.WriteLine("Translate: warm");
            }
            else if (userInput == "облачный")
            {
                Console.WriteLine("Translate: cloudy");
            }
            else if (userInput == "морозный")
            {
                Console.WriteLine("Translate: frosty");
            }
            else if (userInput == "бриз")
            {
                Console.WriteLine("Translate: breeze");
            }
            else if (userInput == "шторм")
            {
                Console.WriteLine("Translate: storm");
            }
            else
            {
                Console.WriteLine("Unknown word!");
            }
            Console.ReadLine();
        }
        
    }
}
