using System;
using System.Data;

namespace TeachMeSkills.DotNet.Task19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Number Checker!");
            Console.Write("Input the first range number: ");
            uint firstRangeNumber = InputValue();
            Console.Write("Input the second range number: ");
            uint secondRangeNumber = InputValue();
            Console.WriteLine($"Simple numbers are:\t");
            for (uint i = firstRangeNumber; i <= secondRangeNumber; i++)
            {
                if (i == 1)
                {
                    break;
                }
                if (IsSimple(i))
                {
                    Console.Write($"\t{i}");
                }
            }
            Console.WriteLine($"\nComposite numbers are:");
            for (uint i = firstRangeNumber; i <= secondRangeNumber; i++)
            {
                if (i == 1 || IsSimple(i) == false)
                {
                    Console.Write($"\t{i}");
                }
                if (IsSimple(i))
                {
                    continue;
                }
            }
            Console.ReadLine();

        }

        public static bool IsSimple(uint number)
        {
            bool result = true;
            if (number > 1)
            {
                for (uint i = 2; i < number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }
            return result;
        }

        public static uint InputValue()
        {
            string str = Console.ReadLine();
            bool canParse = false;
            canParse = uint.TryParse(str, out uint parsedValue);
            return parsedValue;
        }
    }
}
