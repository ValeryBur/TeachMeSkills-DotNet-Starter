using System;

namespace TechMeSkills.DotNet.Task15._Not_Ready
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число клиентов: ");
            long clientCount = Convert.ToInt64(Console.ReadLine());
            long result = 1;

            do
            {
                result *= clientCount;
                clientCount -= 1;
            } while (clientCount > 0);
            Console.WriteLine($"Количество вариантов доставки: {result}");
            Console.ReadKey();
        }
    }
}
