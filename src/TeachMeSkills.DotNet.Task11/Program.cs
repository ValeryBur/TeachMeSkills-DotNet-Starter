using System;

namespace TeachMeSkills.DotNet.Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            uint checkValue = InputNumber();
            bool result;
            for (int i = 1; i < 33; i++)
            {
                if(checkValue==Math.Pow(2, i))
                {
                    result = true;
                    Console.WriteLine($"Result is: {result}");
                    break;
                }
                else
                {
                    continue;
                }
            }
            Console.ReadLine();
        }
        public static uint InputNumber()
        {
            Console.Write("Input your number: ");
            string userInput = Console.ReadLine();
            bool canParse = false;
            canParse = uint.TryParse(userInput, out uint parsedNumber);
            return parsedNumber;
        }
    }
}
