using System;
using System.Collections.Generic;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parking = new HashSet<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "END")
                {
                    break;
                }

                string[] tokens = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string direction = tokens[0];
                string car = tokens[1];

                if(direction == "IN")
                {
                    parking.Add(car);
                }
                else if(direction == "OUT")
                {
                    if (parking.Contains(car))
                    {
                        parking.Remove(car);
                    }
                }
            }

            if(parking.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, parking));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
