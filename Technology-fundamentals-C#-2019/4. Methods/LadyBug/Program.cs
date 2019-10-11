using System;
using System.Linq;

namespace P10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {

            int fieldSize = int.Parse(Console.ReadLine());

            int[] lbip = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] result = new int[fieldSize];

            for (int i = 0; i < lbip.Length; i++)
            {
                if (lbip[i] < 0 || lbip[i] > fieldSize - 1)
                {
                    continue;
                }
                result[lbip[i]] = 1;
            }

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] order = command.Split();

                int position = int.Parse(order[0]);
                string direction = order[1];
                int step = int.Parse(order[2]);

                if (!(position >= 0 && position <= result.Length - 1 && result[position] == 1))
                {
                    command = Console.ReadLine();
                    continue;
                }

                //if(step < 0)
                //{
                //    step *= (-1);
                //    switch (direction)
                //    {
                //        case "left": direction = "right"; break;
                //        case "right": direction = "left"; break;
                //    }
                //}

                result[position] = 0;
                int newPosition = position;

                if (direction == "right")
                {
                    newPosition += step;
                    try
                    {
                        while (result[newPosition] == 1)
                        {
                            newPosition += step;
                        }

                        result[newPosition] = 1;
                    }
                    catch (Exception)
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                }
                else if (direction == "left")
                {
                    newPosition -= step;
                    try
                    {
                        while (result[newPosition] == 1)
                        {
                            newPosition -= step;
                        }

                        result[newPosition] = 1;
                    }
                    catch (Exception)
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", result));

        }
    }
}
