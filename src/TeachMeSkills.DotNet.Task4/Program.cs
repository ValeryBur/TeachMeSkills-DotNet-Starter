using System;

namespace TeachMeSkills.DotNet.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pi = 3.141592653M;
            decimal r = 2.3M;
            decimal h = 4.5M;
            decimal v = pi * r * 2 * h;
            decimal s = 2 * pi *r*(r + h);
            Console.WriteLine(v);
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
