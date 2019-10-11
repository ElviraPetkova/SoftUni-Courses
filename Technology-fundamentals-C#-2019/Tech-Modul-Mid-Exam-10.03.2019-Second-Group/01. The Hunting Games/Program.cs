using System;

namespace _01._The_Hunting_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int countOfPlayers = int.Parse(Console.ReadLine());
            double groupsEnergy = double.Parse(Console.ReadLine());
            double waterPerDayForOnePerson = double.Parse(Console.ReadLine());
            double foodPerDayForOnePerson = double.Parse(Console.ReadLine());

            double totalWater = (double)days * (double)countOfPlayers * waterPerDayForOnePerson;
            double totalFood = (double)days * (double)countOfPlayers * foodPerDayForOnePerson;

            for (int count = 1; count <= days; count++)
            {
                double energyLost = double.Parse(Console.ReadLine());
                groupsEnergy -= energyLost;

                if (groupsEnergy <= 0)
                {
                    break;
                }

                if (count % 2 == 0)
                {
                    double cuurentEnergy = groupsEnergy * 0.05;
                    groupsEnergy += cuurentEnergy;

                    double currentWater = totalWater * 0.3;
                    totalWater -= currentWater;
                }

                if(count % 3 == 0)
                {
                    double cuurentEnergy = groupsEnergy * 0.1;
                    groupsEnergy += cuurentEnergy;

                    double currentFood = totalFood / countOfPlayers;
                    totalFood -= currentFood;
                }
            }

            if(groupsEnergy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupsEnergy:f2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWater:f2} water.");
            }
        }
    }
}
