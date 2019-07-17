using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());

            var orders = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            Queue<int> queueOfOrders = new Queue<int>(orders);

            int maxOrder = queueOfOrders.Max();
            if (queueOfOrders.Count > 0)
            {
               maxOrder = queueOfOrders.Max();
            }

            bool left = false;

            while (queueOfOrders.Count > 0)
            {
                int oneOrder = queueOfOrders.Peek();

                if (quantityOfFood >= oneOrder)
                {
                    quantityOfFood -= oneOrder;
                    queueOfOrders.Dequeue();
                }
                else
                {
                    //queueOfOrders.Enqueue(oneOrder);
                    left = true;
                    break;
                }
            }

            Console.WriteLine(maxOrder);
            if (left)
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queueOfOrders)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
