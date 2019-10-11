using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            List<int> barabans = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> copyBarabans = new List<int>();
            copyBarabans.AddRange(barabans);

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Hit it again, Gabsy!")
                {
                    Console.WriteLine(string.Join(" ", copyBarabans));
                    Console.WriteLine($"Gabsy has {money:f2}lv.");
                    break;
                }

                int power = int.Parse(input);

                for (int i = 0; i < copyBarabans.Count; i++)
                {
                    copyBarabans[i] -= power;

                    if (copyBarabans[i] <= 0)
                    {
                        double needMoney = barabans[i] * 3.00;
                        if (money >= needMoney)
                        {
                            money -= needMoney;
                            copyBarabans[i] = barabans[i];
                        }
                    }
                }

                for (int k = 0; k < copyBarabans.Count; k++)
                {
                    if (copyBarabans[k] <= 0)
                    {
                        copyBarabans.Remove(copyBarabans[k]);
                        barabans.Remove(barabans[k]);
                    }
                }

            }
        }
    }
}
