namespace TheGarden
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            char[][] garden = CompleteGarden(numberOfRows);

            string input = string.Empty;
            int countOfHarmed = 0;
            Dictionary<string, int> harvestVegetables = new Dictionary<string, int>
            {
                ["Carrots"] = 0,
                ["Potatoes"] = 0,
                ["Lettuce"] = 0
            };

            while ((input = Console.ReadLine()) != "End of Harvest")
            {
                string[] commands = input.Split();
                string command = commands[0];
                int row = int.Parse(commands[1]);
                int col = int.Parse(commands[2]);

                if (row < 0 || row >= garden.GetLength(0) || col < 0 || col >= garden[row].Length)
                {
                    continue;
                }

                if (command == "Harvest")
                {
                    char vegetable = garden[row][col];
                    if (!char.IsWhiteSpace(vegetable))
                    {
                        string currentVegetable = harvestVegetables.FirstOrDefault(v => v.Key.StartsWith(vegetable)).Key;
                        harvestVegetables[currentVegetable]++;

                        garden[row][col] = ' ';
                    }
                    
                }
                else if(command == "Mole")
                {
                    string direction = commands[3].ToLower();

                    switch (direction)
                    {
                        case "up":
                            for (int i = row; i >= 0; i -= 2)
                            {
                                if (!char.IsWhiteSpace(garden[i][col]))
                                {
                                    garden[i][col] = ' ';
                                    countOfHarmed++;
                                }
                            }
                            break;
                        case "down":
                            for (int i = row; i < garden.GetLength(0); i += 2)
                            {
                                if (!char.IsWhiteSpace(garden[i][col]))
                                {
                                    garden[i][col] = ' ';
                                    countOfHarmed++;
                                }
                            }
                            break;
                        case "right":
                            for(int i = row; i < row + 1; i++)
                            {
                                for (int j = col; j < garden[i].Length; j += 2)
                                {
                                    if (!char.IsWhiteSpace(garden[i][j]))
                                    {
                                        garden[i][j] = ' ';
                                        countOfHarmed++;
                                    }
                                }
                            }
                            break;
                        case "left":
                            for (int i = row; i < row + 1; i++)
                            {
                                for (int j = col; j >= 0; j -= 2)
                                {
                                    if (!char.IsWhiteSpace(garden[i][j]))
                                    {
                                        garden[i][j] = ' ';
                                        countOfHarmed++;
                                    }
                                }
                            }
                            break;
                        default:
                            break;
                    }
                }
            }

            foreach (var row in garden)
            {
                Console.WriteLine(string.Join(" ", row));
            }

            foreach (var kvp in harvestVegetables)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            Console.WriteLine($"Harmed vegetables: {countOfHarmed}");
        }

        private static char[][] CompleteGarden(int numberOfRows)
        {
            char[][] garden = new char[numberOfRows][];

            for (int row = 0; row < numberOfRows; row++)
            {
                garden[row] = Console.ReadLine().Split().Select(char.Parse).ToArray();
            }

            return garden;
        }
    }
}
