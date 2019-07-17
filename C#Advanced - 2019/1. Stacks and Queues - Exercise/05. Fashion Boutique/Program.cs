using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var clothesInBox = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            Stack<int> stackOfClothes = new Stack<int>(clothesInBox);

            int capacityOfRack = int.Parse(Console.ReadLine());

            int numberOfRack = 1;
            int sum = 0;

            while (stackOfClothes.Count > 0)
            {
                int currentClothes = stackOfClothes.Peek();
                sum += currentClothes;

                if(sum < capacityOfRack)
                {
                    stackOfClothes.Pop();
                }
                else if(sum > capacityOfRack)
                {
                    numberOfRack++;
                    sum = 0;
                }
                else if(sum == capacityOfRack)
                {
                    stackOfClothes.Pop();
                    if(stackOfClothes.Count > 0)
                    {
                        numberOfRack++;
                    }
                    
                    sum = 0;
                }
               
            }

            Console.WriteLine(numberOfRack);
        }
    }
}
