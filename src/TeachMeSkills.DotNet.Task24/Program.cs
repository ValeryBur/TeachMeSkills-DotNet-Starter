using System;
using System.Linq;

namespace TeachMeSkills.DotNet.Task24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input quantity of array elements: ");
            Random random = new Random();
            int arrayLength = ElementsInput();
            int[] array = new int[arrayLength];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 5);
                if (array[i] % 2 != 0)
                {
                    Console.WriteLine($"Odd number is: {array[i]}");
                }
            }
            Console.WriteLine($"Max value is: {array.Max()}");
            Console.WriteLine($"Min value is: {array.Min()}");
            Console.WriteLine($"Array sum is: {array.Sum()}");
            Console.WriteLine($"Average value is: {array.Average()}");



            Console.ReadLine();
        }
        public static int ElementsInput()
        {
            string str = Console.ReadLine();
            bool canParse = false;
            canParse = int.TryParse(str, out int parsedValue);
            return parsedValue;
        }
    }
}
