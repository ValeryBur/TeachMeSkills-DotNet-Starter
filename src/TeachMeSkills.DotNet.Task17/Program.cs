using System;
using System.Threading;
using System.Globalization;

namespace TeachMeSkills.DotNet.Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Currency Converter!");
            Console.Write("Input currency sum: ");
            int currencySum = InputValue1();
            Console.Write("Input currency course (dot between): ");
            double currencyCourse = InputValue2();
            double outPutResult = CorrencyConverter(currencySum, currencyCourse);
            Console.WriteLine($"Result: {outPutResult} of another currency");
            Console.ReadLine();

        }
        public static int InputValue1 ()
        {
            string str = Console.ReadLine();
            bool canParse = false;
            canParse = int.TryParse(str, out int parsedValue1);
            return parsedValue1;
        }
        public static double InputValue2() //System.Threading и System.Globalization
        {
            string str = Console.ReadLine();
            CultureInfo tempCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            bool canParse = false;
            canParse = double.TryParse(str, out double parsedValue2);
            Thread.CurrentThread.CurrentCulture = tempCulture;
            return parsedValue2;
        }
        public static double CorrencyConverter(int currencySum, double currencyCourse)
        {
            int result = (int)(currencySum * currencyCourse);
            return result;
        }

    }
}
