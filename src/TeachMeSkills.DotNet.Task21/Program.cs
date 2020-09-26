using System;

namespace TeachMeSkills.DotNet.Task21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to DivideBy5 application!");
            Console.Write("Input number 1: ");
            double number1 = InputValue();
            Console.Write("Input number 2: ");
            double number2 = InputValue();
            Console.Write("Input number 3: ");
            double number3 = InputValue();
            (double, double, double) result = Calculate(number1, number2, number3);
            Console.WriteLine($"Numbers, divided by 5 are: {result}");
            Console.ReadLine();
        }
        public static double InputValue()
        {
            string str = Console.ReadLine();
            bool canParse = false;
            canParse = double.TryParse(str, out double parsedValue);
            return parsedValue;
        }
        public static (double divideNumber1, double divideNumber2, double divideNumber3) Calculate(double number1, double number2, double number3)
        {
            double divideNumber1 = number1 / 5;
            double divideNumber2 = number2 / 5;
            double divideNumber3 = number3 / 5;
            return (divideNumber1, divideNumber2, divideNumber3);
        }
    }
}
