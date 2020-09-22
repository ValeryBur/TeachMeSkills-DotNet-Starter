using System;

namespace TeachMeSkills.DotNet.Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Checking Application!");
            NumberChecker();
        }
        public static void NumberChecker()
        {
            Console.Write("Input number: ");
            string inputString = Console.ReadLine();
            bool canParse = false;
            canParse = int.TryParse(inputString, out int parsedNumber);
            int inputNumber = parsedNumber;
            if (inputNumber > 0)
            {
                Console.WriteLine("Number is positive!");
            }
            else if (inputNumber < 0)
            {
                Console.WriteLine("Number is negative!");
            }
            else
            {
                Console.WriteLine("Number is zero!");
            }
            int count = 0;
            for (int i = 2; i <= inputNumber; i++)
            {
                if (inputNumber % i == 0)
                {
                    count++;
                }
                else
                {
                    continue;
                }
            }
            if (count > 2)
            {
                Console.WriteLine("Number is composite!");
            }
            else
            {
                Console.WriteLine("Number is simple!");
            }
            //if (inputNumber % 2 == 0)
            //{
            //    Console.WriteLine("Number is divided by 2 without remainder");
            //}
            //else if (inputNumber % 3 == 0)
            //{
            //    Console.WriteLine("Number is divided by 3 without remainder");
            //}
            //else if (inputNumber % 5 == 0)
            //{
            //    Console.WriteLine("Number is divided by 5 without remainder");
            //}
            //else if (inputNumber % 6 == 0)
            //{
            //    Console.WriteLine("Number is divided by 6 without remainder");
            //}
            //else if (inputNumber % 9 == 0)
            //{
            //    Console.WriteLine("Number is divided by 9 without remainder");
            //}
            //else
            //{
            //    Console.WriteLine("Number is divided with remainder!");
            //}
            for (int i = 2; i <= 9; i++)
            {
                if (inputNumber % i == 0)
                {
                    if (i == 4 || i == 7 || i == 8)
                    {
                        continue;
                    }
                    Console.WriteLine($"Number is divided by {i} without remainder");
                }
                //if (i == 4 || i == 7 || i == 8)
                //{
                //    continue;
                //}
            }
            Console.ReadLine();
        }
    }
}
