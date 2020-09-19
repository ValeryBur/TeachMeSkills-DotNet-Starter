using System;

namespace TeachMeSkills.DotNet.Task10
{
    class Program /*Обязательно спросить у Миши, как здесь сделать Эксепшн!!!!!!!!!!!!!!!!!!!!!*/
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi there!");
            double countSalary = InputSalary();
            double countExperience = InputWorkingExperience();
            double countPremium = Premium(countSalary, countExperience);
        }
        public static double InputSalary()
        {
            Console.Write("Input your salary: ");
            string userInput1 = Console.ReadLine();
            bool canParse1 = false;
            canParse1 = double.TryParse(userInput1, out double parsedNumber1);
            double salary = parsedNumber1;
            return salary;
        }
        public static double InputWorkingExperience()
        {
            Console.Write("Input your working experience in our organization: ");
            string userInput2 = Console.ReadLine();
            bool canParse2 = false;
            canParse2 = double.TryParse(userInput2, out double parsedNumber2);
            double experience = parsedNumber2;
            return experience;
        }
        public static double Premium(double salary, double countExperience)
        {
            double premium;
            if (countExperience < 5)
            {
                premium = salary * 0.1;
                Console.WriteLine($"Your premium is: {premium}");
                Console.ReadLine();
                return premium;
            }
            else if (countExperience >= 5 && countExperience < 10)
            {
                premium = salary * 0.15;
                Console.WriteLine($"Your premium is: {premium}");
                Console.ReadLine();
                return premium;
            }
            else if (countExperience >= 10 && countExperience < 15)
            {
                premium = salary * 0.25;
                Console.WriteLine($"Your premium is: {premium}");
                Console.ReadLine();
                return premium;
            }
            else if (countExperience >= 15 && countExperience < 20)
            {
                premium = salary * 0.35;
                Console.WriteLine($"Your premium is: {premium}");
                Console.ReadLine();
                return premium;
            }
            else if (countExperience >= 20 && countExperience < 25)
            {
                premium = salary * 0.45;
                Console.WriteLine($"Your premium is: {premium}");
                Console.ReadLine();
                return premium;
            }
            else if (countExperience >= 25)
            {
                premium = salary * 0.5;
                Console.WriteLine($"Your premium is: {premium}");
                Console.ReadLine();
                return premium;
            }
            else
            {
                premium = salary * 0;
                Console.WriteLine("You've got no premium!");
                Console.ReadLine();
                return premium;
            }
        }
    }
}

