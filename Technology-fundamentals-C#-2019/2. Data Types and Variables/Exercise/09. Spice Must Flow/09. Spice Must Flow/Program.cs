using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            int days = 0;
            int total = 0;

            if (startingYield >= 100)
            {
                while (true)
                {
                    total += (startingYield - 26);
                    startingYield -= 10;
                    days++;

                    if (startingYield < 100)
                    {
                        break;
                    }
                }
            }

            if (total >= 26)
            {
                total -= 26;
            }

            Console.WriteLine(days);
            Console.WriteLine(total);
        }
    }
}
