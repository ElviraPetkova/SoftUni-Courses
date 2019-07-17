using System;
using System.Collections.Generic;

namespace _07._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            var childrens = new Queue<string>(Console.ReadLine().Split());
            int count = int.Parse(Console.ReadLine());

            while (childrens.Count != 1)
            {
                for (int i = 1; i < count; i++)
                {
                    childrens.Enqueue(childrens.Dequeue());
                }

                Console.WriteLine($"Removed {childrens.Dequeue()}");
            }

            Console.WriteLine($"Last is {childrens.Dequeue()}");
        }
    }
}
