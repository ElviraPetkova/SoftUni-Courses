using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfGuests = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>();

            for (int i = 0; i < countOfGuests; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];

                if (input.Contains("not") == false) //add guest ig don't exist
                {
                    if (guests.Contains(name)) //if existing this name
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else //if don't exist this name => add name in list
                    {
                        guests.Add(name);
                    }
                }
                else //remove guest if exist
                {
                    if (guests.Contains(name))
                    {
                        guests.Remove(name);
                    }
                    else //if don't exist this name
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, guests));
        }
    }
}
