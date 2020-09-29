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
            Console.WriteLine("Rhombus");
            Console.Write("Input rhombus height (min value 3): ");
            int rhombusHeight = InputNumber();
            Rhombus(rhombusHeight);


            Console.ReadLine();

        }
        public static int InputNumber()
        {
            string userInput = Console.ReadLine();
            bool canParse = false;
            canParse = int.TryParse(userInput, out int parsedNumber);
            return parsedNumber;
        }
        public static void Rectangle(int sideA, int sideB)//прямоугольник
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
        public static void RightTriangle(int sideA, int sideB)//прямоугольный треугольник
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
        public static void EquilateralTriangle(int equilateralTriangleHeight)//равносторонний треугольник
        {
            for (int i = 1; i < equilateralTriangleHeight; i++)
            {
                for (int j = i; j < equilateralTriangleHeight; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        public static void Rhombus(int height)//ромб
        {
            int i;
            int j;
            int center = height / 2;
            for (i = 0; i < height; i++)
            {
                for (j = 0; j < height; j++)
                {
                    if (i <= center)
                    {
                        if (j >= center - i && j <= center + i)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    else
                    {
                        if (j >= center + i - height + 1 && j <= center - i + height - 1)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}


