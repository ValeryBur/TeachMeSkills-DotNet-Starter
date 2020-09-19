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
            canParse1 = int.TryParse(userInput1, out int parsedNumber1);
            EvenOrOddV1(parsedNumber1);

            Console.WriteLine("Welcome to check out application Version 2!");
            Console.Write("Input number: ");
            string userInput2 = Console.ReadLine();
            char[] arr = userInput2.ToCharArray();
            EvenOrOddV2(arr);

            Console.WriteLine("Welcome to check out application Version 3!");
            Console.Write("Input number: ");
            string userInput3 = Console.ReadLine();
            bool canParse3 = false;
            canParse1 = int.TryParse(userInput1, out int parsedNumber3);
            const int divider = 2;
            int result;
            int residue = Math.DivRem(parsedNumber3, divider, out result);
            if(result == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
            Console.ReadLine();
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
