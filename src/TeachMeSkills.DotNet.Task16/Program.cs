using System;

namespace TeachMeSkills.DotNet.Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rectangle");
            Console.Write("Input rectangle number of side A: ");
            int rectangleSideA = InputNumber();
            Console.Write("Input rectangle number of side B: ");
            int rectangleSideB = InputNumber();
            Rectangle(rectangleSideA, rectangleSideB);
        }
        public static int InputNumber()
        {
            string userInput = Console.ReadLine();
            bool canParse = false;
            canParse = int.TryParse(userInput, out int parsedNumber);
            return parsedNumber;
        }
        public static void Rectangle(int sideA, int sideB)
        {
            for (int i = 0; i < sideA; i++)
            {
                for (int j = 0; j < sideB; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
    }
}
