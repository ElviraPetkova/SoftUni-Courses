using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main()
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int counterOfStudents = int.Parse(Console.ReadLine());
            double priceOfLightsabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            double moreLightsabers = Math.Ceiling(counterOfStudents * 0.1);
            double freeBelts = Math.Floor(counterOfStudents / 6.0);

            double moneyForLightsabers = priceOfLightsabers * (counterOfStudents + moreLightsabers);
            double moneyForRobes = counterOfStudents * priceOfRobes;
            double moneyForBelts = priceOfBelts * (counterOfStudents - freeBelts);

            double totalMoney = moneyForBelts + moneyForLightsabers + moneyForRobes;

            if (amountOfMoney >= totalMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(totalMoney - amountOfMoney):f2}lv more.");
            }
        }
    }
}
