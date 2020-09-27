using System;
using System.Linq;

namespace TeachMeSkills.DotNet.Task27
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 30);
            }
            Array.Reverse(arr);
            foreach (var item in arr)
            {
                Console.Write($"\t{item}");
            }
            Console.ReadLine();
        }
    }
}
