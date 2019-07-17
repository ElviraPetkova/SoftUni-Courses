using System;
using System.Collections.Generic;

namespace _08._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();
            int count = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "end")
                {
                    Console.WriteLine($"{count} cars passed the crossroads.");
                    break;
                }

                if(input == "green")
                {
                    int currentNumber = numberOfCars;
                    if (currentNumber > queue.Count)
                    {
                        currentNumber = queue.Count;
                    }

                    for (int i = 0; i < currentNumber; i++)
                    {
                        string car = queue.Dequeue();
                        Console.WriteLine($"{car} passed!");
                        count++;
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
            }
        }
    }
}
