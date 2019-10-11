using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main()
        {
            int countOfLostGame = int.Parse(Console.ReadLine());
            double priceOfHeadset = double.Parse(Console.ReadLine());
            double priceOfMouse = double.Parse(Console.ReadLine());
            double priceOfKeyboard = double.Parse(Console.ReadLine());
            double priceOfDisplay = double.Parse(Console.ReadLine());

            double totalMoney = 0;

            for (int counter = 1; counter <= countOfLostGame; counter++)
            {
                if (counter % 12 == 0)
                {
                    totalMoney += priceOfDisplay;
                }
                if (counter % 6 == 0)
                {
                    totalMoney += priceOfKeyboard;
                }
                if (counter % 3 == 0)
                {
                    totalMoney += priceOfMouse;
                }
                if (counter % 2 == 0)
                {
                    totalMoney += priceOfHeadset;
                }
            }

            Console.WriteLine($"Rage expenses: {totalMoney:f2} lv.");
        }
    }
}
