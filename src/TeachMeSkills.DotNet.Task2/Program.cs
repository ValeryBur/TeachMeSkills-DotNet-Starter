using System;

namespace TeachMeSkills.DotNet.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "\nмоя строка 1";//переход на новую строку
            string str2 = "\tмоя строка 2";//табуляция - небольшой доступ
            string str3 = "\aмоя строка 3";//звуковой сигнал
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.ReadLine();
        }
    }
}
