using System;

namespace TeachMeSkills.DotNet.Task26._Not_Ready
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            int newSize1 = 6;
            Array.Resize(ref arr, newSize1);
            arr[5] = 6;
            foreach (var item in arr)
            {
                Console.Write($"\t{item}");
            }
            Console.ReadLine();

            int[] arr1 = { 1, 2, 3, 4, 5 };
            int value = 10;
            int [] remakeArray = RemakeArray(arr1, value);
            foreach (var item in remakeArray)
            {
                Console.Write($"\t{item}");
            }
            Console.ReadLine();
        }
        public static int[] RemakeArray(int[] arr1, int value)
        {
            int newSize2 = 6;
            Array.Resize(ref arr1, newSize2);
            int[] newArr = arr1;
            int tempValue1 = 0;
            int tempValue2 = 0;
            for (int i = 0; i < newSize2; i++)
            {
                if (i < 1)
                {
                    tempValue1 = newArr[i];
                    newArr[i] = value;
                }
                else
                {
                    tempValue2 = newArr[i];
                    newArr[i] = tempValue1;
                    tempValue1 = tempValue2;
                }
            }
            return newArr;
        }
    }
}
