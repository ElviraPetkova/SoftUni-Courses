using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfTimes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            double timePerLeftCar = 0;
            double timePerRightCar = 0;

            for (int i = 0; i < arrayOfTimes.Length / 2; i++)
            {
                int firstCar = arrayOfTimes[i];
                int secondCar = arrayOfTimes[arrayOfTimes.Length - 1 - i];

                if(firstCar != 0)
                {
                    timePerLeftCar += firstCar;
                }
                else
                {
                    timePerLeftCar *= 0.80;
                }

                if(secondCar != 0)
                {
                    timePerRightCar += secondCar;
                }
                else
                {
                    timePerRightCar *= 0.80;
                }
            }

            if(timePerLeftCar < timePerRightCar)
            {
                Console.WriteLine($"The winner is left with total time: {timePerLeftCar}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {timePerRightCar}");
            }
        }
    }
}
