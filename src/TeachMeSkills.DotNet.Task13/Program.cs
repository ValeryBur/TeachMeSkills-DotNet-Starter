using System;
using System.Collections.Generic;
using System.Data;

namespace TeachMeSkills.DotNet.Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to application");
            Console.Write("Input number A: ");
            string userInput1 = Console.ReadLine();
            bool canParse1 = false;
            canParse1 = int.TryParse(userInput1, out int parsedNumber1);
            Console.Write("Input number B: ");
            string userInput2 = Console.ReadLine();
            bool canParse2 = false;
            canParse2 = int.TryParse(userInput2, out int parsedNumber2);
            int outPutSum = Sum(parsedNumber1, parsedNumber2);
            Console.WriteLine($"Sum is: {outPutSum}");
            int countOddNumbers = CountOddNumbers(parsedNumber1, parsedNumber2);
            int[] oddArray = OddNumbersArray(parsedNumber1, parsedNumber2, countOddNumbers);
            Console.WriteLine("Odd numbers are: ");
            foreach (int i in oddArray)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
        public static int Sum(int parsedNumber1, int parsedNumber2)
        {
            int sumSum = 0;
            for (int i = parsedNumber1 + 1; i < parsedNumber2; i++)
            {
                sumSum = sumSum + i;
            }
            return sumSum;
        }
        public static int CountOddNumbers(int parsedNumber1, int parsedNumber2)
        {
            int count = 0; ;
            for (int i = parsedNumber1 + 1; i < parsedNumber2; i++)
            {
                if (i % 2 > 0 || i % 2 < 0)
                {
                    count++;
                }
                else
                {
                    continue;
                }
            }
            return count;
        }
        public static int[] OddNumbersArray(int parsedNumber1, int parsedNumber2, int count)
        {
            int[] oddNumbersArray = new int[count];
            int newCount = 0;
            for (int i = parsedNumber1 + 1; i < parsedNumber2; i++)
            {
                if (i % 2 > 0 || i % 2 < 0)
                {
                    oddNumbersArray[newCount] = i;
                    newCount++;
                }
            }
            return oddNumbersArray;
        }
    }
}
