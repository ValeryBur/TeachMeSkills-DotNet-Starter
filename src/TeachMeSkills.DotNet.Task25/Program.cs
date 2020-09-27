using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace TeachMeSkills.DotNet.Task25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input quantity of array elements: ");
            Random random1 = new Random();
            int arrayLength = UserInput();
            int[] array = new int[arrayLength];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random1.Next(1, 5);
            }
            Array.Reverse(array);
            Console.Write("Input index: ");
            int index = UserInput();
            Console.Write("Input count: ");
            int count = UserInput();
            int[] resultArr = SubArray(array, index, count);
            Console.WriteLine("Application is finished");
            Console.ReadLine();
        }

        public static int UserInput()
        {
            string str = Console.ReadLine();
            bool canParse = false;
            canParse = int.TryParse(str, out int parsedValue);
            return parsedValue;
        }
        public static int[] SubArray(int[] array, int index, int count)
        {
            Random random2 = new Random();
            int[] newArr = new int[count];
            for (int i = 0; i < count; i++)
            {

                if (index >= array.Length)
                {
                    newArr[i] = random2.Next(1, 51);
                    index++;
                }
                else
                {
                    newArr[i] = array[index];
                    index++;
                }
            }
            return newArr;
        }
    }
}
