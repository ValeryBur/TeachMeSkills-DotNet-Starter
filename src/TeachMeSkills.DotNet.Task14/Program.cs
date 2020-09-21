using System;

namespace TeachMeSkills.DotNet.Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Figure Application!");
            Console.WriteLine("Rectangle");
            Console.Write("Input rectangle number of side A: ");
            int rectangleSideA = InputNumber();
            Console.Write("Input rectangle number of side B: ");
            int rectangleSideB = InputNumber();
            Rectangle(rectangleSideA, rectangleSideB);
            Console.WriteLine("Right Triangle");
            Console.Write("Input right triangle number of side A: ");
            int rightTriangleSideA = InputNumber();
            Console.Write("Input right triangle number of side B: ");
            int rightTriangleSideB = InputNumber();
            RightTriangle(rightTriangleSideA, rightTriangleSideB);
            Console.WriteLine("Equilateral Triangle");
            Console.Write("Input equilateral triangle height: ");
            int equilateralTriangleHeight = InputNumber();
            EquilateralTriangle(equilateralTriangleHeight);

            Console.ReadLine();

        }
        public static int InputNumber()
        {
            string userInput = Console.ReadLine();
            bool canParse = false;
            canParse = int.TryParse(userInput, out int parsedNumber);
            return parsedNumber;
        }
        public static void Rectangle(int sideA, int sideB)
        {
            for (int i = 0; i < sideA; i++)
            {
                for (int j = 0; j < sideB; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
        public static void RightTriangle(int sideA, int sideB)
        {
            for (int i = 0; i < sideA; i++)
            {
                for (int j = 0; j < sideB; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
                sideB--;
            }
            Console.ReadLine();
        }
        public static void EquilateralTriangle(int equilateralTriangleHeight)
        {
            for (int i = 0; i < equilateralTriangleHeight; i++)
            {
                for (int j = equilateralTriangleHeight / 2; j < equilateralTriangleHeight; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
//        int h, h1, h2, h3, h4, h5, h6; - равносторонний треугольник и ромб!!!!!  изучить код!!!!!
//        int s;
//        h = Int32.Parse(Console.ReadLine());

//            h /= 2;

//            h1 = h - (h - 1);
//            h2 = h;
//            h3 = h - (h - 1);
//            h4 = 2 * h;

//            s = h;
//            if (s == h) { h++; }

//            for (int c1 = 0; c1<h; c1++, h2--, h1 += 2)
//            {
//                for (int c2 = 0; c2<h2; c2++)
//                { Console.Write(" "); }
//for (int c3 = 0; c3 < h1; c3++)
//{ Console.Write("*"); }
//Console.WriteLine();
//            }
//            for (int c4 = 0; c4 < h; c4++, h3++, h4 -= 2)
//{
//    for (int c5 = 0; c5 < h3; c5++)
//    {
//        Console.Write(" ");
//    }
//    for (int c6 = 0; c6 < h4 - 1; c6++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}

//Console.Read();
//        }
//    }
//}

