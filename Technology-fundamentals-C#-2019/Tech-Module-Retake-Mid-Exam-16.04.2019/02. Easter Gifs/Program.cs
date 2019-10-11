using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Easter_Gifs
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfEasterGifs = Console.ReadLine().Split().ToArray();

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "No Money")
                {
                    var result = listOfEasterGifs.Where(x => x != "None").ToArray();
                    Console.WriteLine(string.Join(" ", result));
                    break;
                }

                var tokens = input.Split();

                /* OutOfStock {gift}"
                    o	Find the gifts with this name in your collection, if there are any, and change their values to "None".  
                •	"Required {gift} {index}"
                    o	Replace the value of the current gift on the given index with this gift, if the index is valid. 
                •	"JustInCase {gift}"
                    o	Replace the value of your last gift with this one. */

                string command = tokens[0];
                string gift = tokens[1];

                if(command == "OutOfStock")
                {
                    if (listOfEasterGifs.Contains(gift))
                    {
                        for (int i = 0; i < listOfEasterGifs.Length; i++)
                        {
                            if(listOfEasterGifs[i] == gift)
                            {
                                listOfEasterGifs[i] = "None";
                            }
                        }
                    }
                }
                else if(command == "Required")
                {
                    int index = int.Parse(tokens[2]);
                    if (index >= 0 && index < listOfEasterGifs.Length)
                    {
                        listOfEasterGifs[index] = gift;
                    }
                }
                else if(command == "JustInCase")
                {
                    listOfEasterGifs[listOfEasterGifs.Length - 1] = gift;
                }
            }
        }
    }
}
