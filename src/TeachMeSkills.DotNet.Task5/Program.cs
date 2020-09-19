using System;

namespace TeachMeSkills.DotNet.Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 5;
            double b = 10;
            Console.WriteLine(Add(5, 10));
            Console.WriteLine(Substract(5, 10));
            Console.WriteLine(Multiply(5, 10));
            Console.WriteLine(Divide(5, 10));
            Console.ReadLine();
        }
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static double Substract(double a, double b)
        {
            return a - b;
        }
        public static double Multiply(int a, int b)
        {
            return a * b;
        }
        public static double Divide(double a, double b)
        {
            return a / b;
        }
    }
}
