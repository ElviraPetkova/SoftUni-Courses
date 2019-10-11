using System;

namespace _01._Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            long wingFlaps = long.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            long endurance = long.Parse(Console.ReadLine());

            double distanceRezultInMeters = (wingFlaps / 1000.0) * distanceInMeters;
            long secounds = wingFlaps / 100;
            secounds += ((wingFlaps / endurance) * 5);
            Console.WriteLine($"{distanceRezultInMeters:F2} m.");
            Console.WriteLine($"{secounds} s.");
        }
    }
}
