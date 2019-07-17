using System;
using System.Collections.Generic;

namespace _06._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queueFromNames = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "End")
                {
                    Console.WriteLine($"{queueFromNames.Count} people remaining.");
                    break;
                }

                if(input == "Paid") //What happen if queue's count is zero?
                {
                    while (queueFromNames.Count != 0)
                    {
                        Console.WriteLine(queueFromNames.Dequeue());
                    }
                }
                else
                {
                    queueFromNames.Enqueue(input);
                }

            }
        }
    }
}
