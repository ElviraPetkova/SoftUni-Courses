using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Trophon_the_Grumpy_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> prices = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int position = int.Parse(Console.ReadLine());
            string typeElements = Console.ReadLine();
            string typeOfPrice = Console.ReadLine();

            long sumOfLeftPosition = GetLeftSum(prices, position, typeElements, typeOfPrice);

            long sumOfRightPOsition = GetRightSum(prices, position, typeElements, typeOfPrice);

            if(sumOfLeftPosition >= sumOfRightPOsition)
            {
                Console.WriteLine($"Left - {sumOfLeftPosition}");
            }
            else
            {
                Console.WriteLine($"Right - {sumOfRightPOsition}");
            }
        }

        private static long GetRightSum(List<int> prices, int position, string typeElements, string typeOfPrice)
        {
            int value = prices[position];

            long sumOfRightPOsition = 0;

            for (int i = position + 1; i < prices.Count; i++)
            {
                int price = prices[i];

                switch (typeElements)
                {
                    case "cheap":
                        if (price < value)
                        {
                            switch (typeOfPrice)
                            {
                                case "positive":
                                    if (price > 0)
                                    {
                                        sumOfRightPOsition += price;
                                    }
                                    break;
                                case "negative":
                                    if (price < 0)
                                    {
                                        sumOfRightPOsition += (price);
                                    }
                                    break;
                                case "all": sumOfRightPOsition += (price); break;
                            }
                        }
                        break;
                    case "expensive":
                        if (price >= value)
                        {
                            switch (typeOfPrice)
                            {
                                case "positive":
                                    if (price > 0)
                                    {
                                        sumOfRightPOsition += price;
                                    }
                                    break;
                                case "negative":
                                    if (price < 0)
                                    {
                                        sumOfRightPOsition += (price);
                                    }
                                    break;
                                case "all": sumOfRightPOsition += (price); break;
                            }
                        }
                        break;
                }
            }

            return sumOfRightPOsition;
        }

        private static long GetLeftSum(List<int> prices, int position, string typeElements, string typeOfPrice)
        {
            int value = prices[position];

            long sumOfLeftPosition = 0;

            for (int i = 0; i < position; i++)
            {
                int price = prices[i];

                switch (typeElements)
                {
                    case "cheap":
                        if (price < value)
                        {
                            switch (typeOfPrice)
                            {
                                case "positive":
                                    if (price > 0)
                                    {
                                        sumOfLeftPosition += price;
                                    }
                                    break;
                                case "negative":
                                    if (price < 0)
                                    {
                                        sumOfLeftPosition += (price);
                                    }
                                    break;
                                case "all": sumOfLeftPosition += (price); break;
                            }
                        }
                        break;
                    case "expensive":
                        if (price >= value)
                        {
                            switch (typeOfPrice)
                            {
                                case "positive":
                                    if (price > 0)
                                    {
                                        sumOfLeftPosition += price;
                                    }
                                    break;
                                case "negative":
                                    if (price < 0)
                                    {
                                        sumOfLeftPosition += (price);
                                    }
                                    break;
                                case "all": sumOfLeftPosition += (price); break;
                            }
                        }
                        break;
                }
            }

            return sumOfLeftPosition;
        }
    }
}
