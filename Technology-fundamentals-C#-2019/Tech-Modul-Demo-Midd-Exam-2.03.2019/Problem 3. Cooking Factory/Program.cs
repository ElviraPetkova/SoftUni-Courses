using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3._Cooking_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> bestBreads = new List<int>();
            int maxTotalQuality = int.MinValue;
            int maxAverange = int.MinValue;
            int smallestLenght = int.MaxValue; //for best breats

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Bake It!")
                {
                    break;
                }

                List<int> breads = input.Split('#').Select(int.Parse).ToList();

                int totalQuality = breads.Sum();
                int averange = (int)breads.Average();
                int lenght = breads.Count;

                if(maxTotalQuality < totalQuality)
                {
                    maxTotalQuality = totalQuality;
                    maxAverange = averange;
                    smallestLenght = lenght;

                    bestBreads = breads;
                }
                else if(maxTotalQuality == totalQuality)
                {
                    if(maxAverange < averange)
                    {
                        maxTotalQuality = totalQuality;
                        maxAverange = averange;
                        smallestLenght = lenght;

                        bestBreads = breads;
                    }
                    else if(maxAverange == averange)
                    {
                        if(smallestLenght > lenght && lenght > 0)
                        {
                            maxTotalQuality = totalQuality;
                            maxAverange = averange;
                            smallestLenght = lenght;

                            bestBreads = breads;
                        }
                    }
                }
            }

            Console.WriteLine($"Best Batch quality: {maxTotalQuality}");
            Console.WriteLine(string.Join(" ", bestBreads));
        }
    }
}
