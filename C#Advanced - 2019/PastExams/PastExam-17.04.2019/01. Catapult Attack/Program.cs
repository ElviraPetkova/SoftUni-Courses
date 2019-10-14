namespace _01._Catapult_Attack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            int numberOfPiles = int.Parse(Console.ReadLine());
            var walls = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Stack<int> rocks = new Stack<int>();

            for (int i = 1; i <= numberOfPiles; i++)
            {
                var rocksAsArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                rocks = new Stack<int>(rocksAsArray);

                if (i % 3 == 0)
                {
                    int extraLineByWalls = int.Parse(Console.ReadLine());
                    walls.Add(extraLineByWalls);
                }

                Attack(walls, rocks);

                if (!walls.Any())
                {
                    Console.WriteLine($"Rocks left: {string.Join(", ", rocks)}");
                    return;
                }
            }

            if (walls.Any())
            {
                Console.WriteLine($"Walls left: {string.Join(", ", walls)}");
            }
            else
            {
                Console.WriteLine($"Rocks left: {string.Join(", ", rocks)}");
            }
        }

        private static void Attack(List<int> walls, Stack<int> rocks)
        {
            while (rocks.Any() && walls.Any())
            {
                int wall = walls[0];
                int rock = rocks.Pop();

                if (rock > wall)
                {
                    rock -= wall;
                    rocks.Push(rock);
                    walls.RemoveAt(0);
                }
                else if (wall > rock)
                {
                    wall -= rock;
                    walls[0] = wall;
                }
                else //if wall == rock
                {
                    walls.RemoveAt(0);
                }
            }
        }
    }
}
