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
            int firstRangeNumber = InputValue();
            Console.Write("Input the second range number: ");
            int secondRangeNumber = InputValue();
            CheckNumber(firstRangeNumber, secondRangeNumber);
            Console.ReadLine();

        }
        public static (int[], int[]) CheckNumber(int firstRangeNumber, int secondRangeNumber)
        {
            int countSimple = 0;
            int countComposite = 0;
            int tempSimpleCount = 0;
            for (int i = firstRangeNumber + 1; i < secondRangeNumber; i++)
            {
                if(i == 1)
                {
                    countComposite++;
                    break;
                }
                for (int j = 2; j < i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        countComposite++;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine($"Composite numbers count is: {countComposite}");
            Console.ReadLine();
            for (int i = firstRangeNumber + 1; i < secondRangeNumber; i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    if (i % j != 0)
                    {
                        tempSimpleCount++;
                        continue;
                    }
                    else if (i % j == 0 && i == j)
                    {
                        tempSimpleCount++;
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                if (tempSimpleCount == (i - 1))
                {
                    countSimple++;
                    tempSimpleCount = 0;
                }
            }

            Console.WriteLine($"Simple numbers count is: {countSimple}");
            Console.ReadLine();
            int[] a = new int[countComposite];
            int[] b = new int[countSimple];

            return (a, b);


            //int[] simpleNumbers;

            //int[] compositeNumbers = new int [countComposite];
            //return;
        }
        public static int InputValue()
        {
            string str = Console.ReadLine();
            bool canParse = false;
            canParse = int.TryParse(str, out int parsedValue);
            return parsedValue;
        }
    }
}
