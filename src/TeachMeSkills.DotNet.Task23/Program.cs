using System;

namespace TeachMeSkills.DotNet.Task23
{
    class Program
    {

        //habr.com/ru/post/275813/ - изучить похожие задачи!
        static void Main(string[] args)
        {
            Console.Write("Введите количество клиентов: ");
            long clientsCount = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(RecursionFunction(clientsCount));
            Console.ReadLine();
        }
        public static long RecursionFunction(long clientsCount)
        {
            // условие выхода
            // Базовый случай
            // когда остановиться повторять рекурсию ?
            if (clientsCount == 1)
            {
                return 1;
            }
            // Шаг рекурсии / рекурсивное условие
            return RecursionFunction(clientsCount - 1) * clientsCount;
        }
    }
}
