using System;

namespace TeachMeSkills.DotNet.Task20
{
    class Program
    {
        public static double InputValue()
        {
            string str = Console.ReadLine();
            bool canParse = false;
            canParse = double.TryParse(str, out double parsedValue);
            return parsedValue;
        }
        public static double Calculate (double number1, double number2, double number3)
        {
            double result = (number1 + number2 + number3) / 3;
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to average application!");
            Console.Write("Input number 1: ");
            double number1 = InputValue();
            Console.Write("Input number 2: ");
            double number2 = InputValue();
            Console.Write("Input number 3: ");
            double number3 = InputValue();
            double result = Calculate(number1, number2, number3);
            Console.WriteLine($"Average value is: {result}");
            Console.ReadLine();
        }
    }
}
