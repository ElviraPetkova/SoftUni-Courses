using System;

namespace _06.Calculate_Rectangle_Area
{
    class Program
    {
        public static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double rectangleArea = CalculateRectangleArea(width, height);
            Console.WriteLine(rectangleArea);
        }

        public static double CalculateRectangleArea(double width, double height)
        {
            double rectangleArea = width * height;
            return rectangleArea;
        }
    }
}
