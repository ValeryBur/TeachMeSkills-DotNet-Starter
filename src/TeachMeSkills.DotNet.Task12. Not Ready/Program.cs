using System;

namespace TeachMeSkills.DotNet.Task12._Not_Ready
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = false;
            bool b = false;
            if(a || b == !(!a && !b))
            {
                Console.WriteLine("Закон Де Моргана");
            }
            Console.ReadLine();

        }
    }
}
