using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Easter_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfEasterShoping = Console.ReadLine()
                .Split().ToList();

            int countOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfCommands; i++)
            {
                var input = Console.ReadLine().Split();
                string command = input[0];

                /*  •	"Include {shop}":
                        o	Add the shop at the end of your list.
                    •	"Visit {first/last} {numberOfShops}"
                        o	Remove either the "first" or the "last" number of shops from your list, 
                        depending on the input. If you have less shops on your list than the given number, skip this command.
                    •	"Prefer {shopIndex1} {shopIndex2}":
                        o	If both of the shop indexes exist in your list, take the shops that are on them and change their places. 
                    •	"Place {shop} {shopIndex}"
                        o	Insert the shop after the given index, only if the resulted index exists. */
                
                if(command == "Include")
                {
                    string shop = input[1];
                    listOfEasterShoping.Add(shop);
                }
                else if(command == "Visit")
                {
                    string direction = input[1];
                    int numberOfShop = int.Parse(input[2]);

                    if(numberOfShop <= listOfEasterShoping.Count)
                    {
                        if(direction == "first")
                        {
                            listOfEasterShoping.RemoveRange(0, numberOfShop);
                        }
                        else if(direction == "last")
                        {
                            listOfEasterShoping.Reverse();
                            listOfEasterShoping.RemoveRange(0, numberOfShop);
                            listOfEasterShoping.Reverse();
                        }
                    }
                }
                else if(command == "Prefer")
                {
                    int firstIndex = int.Parse(input[1]);
                    int secondIndex = int.Parse(input[2]);

                    if(firstIndex >= 0 && firstIndex < listOfEasterShoping.Count
                        && secondIndex >= 0 && secondIndex < listOfEasterShoping.Count)
                    {
                        string firstValue = listOfEasterShoping[firstIndex];
                        string secondValue = listOfEasterShoping[secondIndex];
                        listOfEasterShoping[firstIndex] = secondValue;
                        listOfEasterShoping[secondIndex] = firstValue;
                    }
                }
                else if(command == "Place")
                {
                    string shop = input[1];
                    int shopIndex = int.Parse(input[2]);

                    if(shopIndex >= 0 && shopIndex < listOfEasterShoping.Count)
                    {
                        listOfEasterShoping.Insert(shopIndex + 1, shop);
                    }
                }
            }

            Console.WriteLine("Shops left:");
            Console.WriteLine(string.Join(" ", listOfEasterShoping));
        }
    }
}
