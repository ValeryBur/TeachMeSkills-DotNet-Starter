using System;
using System.Linq;

namespace TeachMeSkills.DotNet.Task9
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to check out application Version 1!");
            Console.Write("Input number: ");
            string userInput1 = Console.ReadLine();
            bool canParse1 = false;
            canParse1 = int.TryParse(userInput1, out int parsedNumber);
            EvenOrOddV1(parsedNumber);

            Console.WriteLine("Welcome to check out application Version 2!");
            Console.Write("Input number: ");
            string userInput = Console.ReadLine();
            char[] arr = userInput.ToCharArray();
            EvenOrOddV2(arr);
        }

            public static void EvenOrOddV1(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
            Console.ReadLine();
        }
        public static void EvenOrOddV2(char[] arr)
        {

            if (arr.Last() == '0' || arr.Last() == '2' || arr.Last() == '4' || arr.Last() == '6' || arr.Last() == '8')
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
            Console.ReadLine();
        }
    }
}
