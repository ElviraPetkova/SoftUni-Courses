using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main()
        {
            int meters = int.Parse(Console.ReadLine());
            decimal kilimeters = meters / 1000M;
            Console.WriteLine($"{kilimeters:f2}");
        }
    }
}
