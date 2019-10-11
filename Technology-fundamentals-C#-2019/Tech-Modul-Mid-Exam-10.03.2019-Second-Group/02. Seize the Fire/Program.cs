using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Seize_the_Fire
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] levelOfFire = Console.ReadLine().Split('#').ToArray();
            int waterInLiters = int.Parse(Console.ReadLine());
            double totalEffort = 0;

            List<int> listOfCells = new List<int>();

            for (int i = 0; i < levelOfFire.Length; i++)
            {
                string[] info = levelOfFire[i].Split(" = ");
                string level = info[0];
                int cells = int.Parse(info[1]);

                bool fire = true;

                switch (level)
                {
                    case "High":
                        if(cells < 81 || cells > 125 || waterInLiters < cells)
                        {
                            fire = false;
                        }
                        break;
                    case "Medium":
                        if(cells < 51 || cells > 80 || waterInLiters < cells)
                        {
                            fire = false;
                        }
                        break;
                    case "Low":
                        if(cells < 1 || cells > 50 || waterInLiters < cells)
                        {
                            fire = false;
                        }
                        break;
                    default: fire = false; break;
                }

                if (fire)
                {
                    waterInLiters -= cells;
                    listOfCells.Add(cells);

                    double currentEffort = cells * 0.25;
                    totalEffort += currentEffort;
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine("Cells:");
            foreach (int cell in listOfCells)
            {
                Console.WriteLine($"- {cell}");
            }
            Console.WriteLine($"Effort: {totalEffort:f2}");
            Console.WriteLine($"Total Fire: {listOfCells.Sum()}");
        }
    }
}
