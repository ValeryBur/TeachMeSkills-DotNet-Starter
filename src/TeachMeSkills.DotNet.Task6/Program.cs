using System;
using System.Globalization;

namespace TeachMeSkills.DotNet.Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int operand1 = 3;
            int operand2 = 5;
            Console.Write("Choose operaton");
            string sign = Console.ReadLine();
            switch(sign)
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
                    if(operand1==0 || operand2==0)
                    {
                        Console.WriteLine("Incorrect operation!");
                        break;
                    }
                    Console.WriteLine(operand1 / operand2);

                    break;

            }


            Console.WriteLine("Hello World!");
        }
    }
}
