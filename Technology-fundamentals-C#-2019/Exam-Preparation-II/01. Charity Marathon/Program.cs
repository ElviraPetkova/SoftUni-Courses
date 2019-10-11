using System;

namespace _01._Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            long counterOfDays = long.Parse(Console.ReadLine());
            long numberOfRunners = long.Parse(Console.ReadLine());
            long averageNumberOfLaps = long.Parse(Console.ReadLine());
            long lengthOfTheTrack = long.Parse(Console.ReadLine());
            long capacityOfTheTrack = long.Parse(Console.ReadLine());
            double moneyPerKilometer = double.Parse(Console.ReadLine());

            long maxRunners = capacityOfTheTrack * counterOfDays;

            if(numberOfRunners > maxRunners)
            {
                numberOfRunners = maxRunners;
            }

            long totalMeters = numberOfRunners * averageNumberOfLaps * lengthOfTheTrack;
            long totalKilometers = totalMeters / 1000;
            double totalMoney = totalKilometers * moneyPerKilometer;

            Console.WriteLine($"Money raised: {totalMoney:f2}");
        }
    }
}
