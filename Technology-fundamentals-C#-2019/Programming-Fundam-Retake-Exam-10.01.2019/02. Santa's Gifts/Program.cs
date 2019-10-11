using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Santa_s_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            List<int> houses = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int position = 0;

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                string command = tokens[0];

                /*  •	Forward {numberOfSteps}
                    •	Back {numberOfSteps}
                            o	When you receive the “Forward” or “Back” command, 
                            you move the given number of times in this direction and remove the house in this position from your list. 
                            Also, when you receive the next command, you continue from this position. 
                    •	Gift {index} {houseNumber}
                            o	Enter a new house number, which the dwarves have left out on purpose, 
                            at the given position and move to its position. 
                    •	Swap {indexOfFirst} {indexOfSecond}
                            o	Santa wants to rearrange his path and swap the order of two houses. 
                            You will receive the numbers of the houses, that need to be switched and he doesn’t need to move to fulfill this command.
                */

                if(command == "Forward")
                {
                    int numberOfSteps = int.Parse(tokens[1]);

                    if (numberOfSteps < 0 || numberOfSteps + position >= houses.Count)
                    {
                        continue;
                    }

                    position += numberOfSteps;

                    houses.RemoveAt(position);
                }
                else if(command == "Back")
                {
                    int numberOfSteps = int.Parse(tokens[1]);

                    if (position - numberOfSteps < 0)
                    {
                        continue;
                    }

                    position -= numberOfSteps;

                    houses.RemoveAt(position);
                }
                else if(command == "Gift")
                {
                    int index = int.Parse(tokens[1]);
                    int houseNumber = int.Parse(tokens[2]);

                    if (index < 0 || index >= houses.Count)
                    {
                        continue;
                    }

                    houses.Insert(index, houseNumber);

                    position = index;

                }
                else if(command == "Swap")
                {
                    int valueFirst = int.Parse(tokens[1]);
                    int valueSecond = int.Parse(tokens[2]);

                    if(houses.Contains(valueFirst) && houses.Contains(valueSecond))
                    {
                        int indexFirst = houses.IndexOf(valueFirst);
                        int indexSecond = houses.IndexOf(valueSecond);

                        houses[indexFirst] = valueSecond;
                        houses[indexSecond] = valueFirst;
                    }
                }
            }

            Console.WriteLine($"Position: {position}");
            Console.WriteLine(string.Join(", ", houses));
        }
    }
}
