using System;

namespace _3.Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstLineX1 = double.Parse(Console.ReadLine());
            double firstLineY1 = double.Parse(Console.ReadLine());
            double firstLineX2 = double.Parse(Console.ReadLine());
            double firstLineY2 = double.Parse(Console.ReadLine());

            double secondLineX1 = double.Parse(Console.ReadLine());
            double secondLineY1 = double.Parse(Console.ReadLine());
            double secondLineX2 = double.Parse(Console.ReadLine());
            double secondLineY2 = double.Parse(Console.ReadLine());

            double lenghtOfFirstLine = LongerLine(firstLineX1, firstLineY1, firstLineX2, firstLineY2);
            double lenghtOfSecondLine = LongerLine(secondLineX1, secondLineY1, secondLineX2,secondLineY2);

            if(lenghtOfFirstLine >= lenghtOfSecondLine)
            {
                PrintLineBegginingOfSmallPOint(firstLineX1, firstLineY1, firstLineX2, firstLineY2);
            }
            else
            {
                PrintLineBegginingOfSmallPOint(secondLineX1, secondLineY1, secondLineX2, secondLineY2);
            }

        }

        private static void PrintLineBegginingOfSmallPOint(double x1, double y1, double x2, double y2)
        {
            double firstPoint = Math.Sqrt(Math.Pow(y1, 2) + Math.Pow(x1, 2));
            double secondPoint = Math.Sqrt(Math.Pow(y2, 2) + Math.Pow(x2, 2));

            if (firstPoint <= secondPoint)
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x2, y2);
            }
            else
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x2, y2, x1, y1);
            }
        }

        private static double LongerLine(double x1, double y1, double x2, double y2)
        {
            double lenght = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            return lenght;
        }
    }
}
