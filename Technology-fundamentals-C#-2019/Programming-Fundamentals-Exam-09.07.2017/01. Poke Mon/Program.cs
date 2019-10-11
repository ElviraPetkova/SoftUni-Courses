using System;

namespace _01._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine()); //N
            int distance = int.Parse(Console.ReadLine()); //M
            int exhaustionFactor = int.Parse(Console.ReadLine()); //Y

            int halfPower = power / 2;
            int counter = 0;

            while (true)
            {
                if (power < distance)
                {
                    Console.WriteLine(power);
                    Console.WriteLine(counter);
                    break;
                }

                power -= distance;

                if (power == halfPower && exhaustionFactor > 0)
                {
                    power /= exhaustionFactor;
                }
                counter++;

            }

        }
    }
}
