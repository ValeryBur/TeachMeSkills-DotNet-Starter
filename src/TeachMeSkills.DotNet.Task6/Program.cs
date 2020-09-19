using System;
using System.Globalization;

namespace TeachMeSkills.DotNet.Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double operand1 = random.Next(1,10);
            double operand2 = random.Next(1,10);
            Console.Write("Choose operaton: ");
            string sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                    Console.WriteLine(operand1 + operand2);
                    break;
                case "-":
                    Console.WriteLine(operand1 - operand2);
                    break;
                case "*":
                    Console.WriteLine(operand1 * operand2);
                    break;
                case "/":
                    if (operand1 == 0 || operand2 == 0)
                    {
                        Console.WriteLine("Incorrect operation!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(operand1 / operand2);
                        break;
                    }
            }
            Console.ReadLine();
        }
    }
}
