using System;

namespace _01._Google_Searches
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalDays = int.Parse(Console.ReadLine());
            int numberOfUser = int.Parse(Console.ReadLine());
            double moneyPerSearch = double.Parse(Console.ReadLine());

            double totalMoney = 0;

            for (int i = 1; i <= numberOfUser; i++)
            {
                int word = int.Parse(Console.ReadLine());

                double money = 0;

                if(word == 1)
                {
                    money = (moneyPerSearch * 2);
                }
                else if(word > 1 && word <= 5)
                {
                    money = moneyPerSearch;
                }

                if(i % 3 == 0)
                {
                    money *= 3;
                }

                totalMoney += money;
            }

            totalMoney *= totalDays;
            Console.WriteLine($"Total money earned for {totalDays} days: {totalMoney:f2}");
        }
    }
}
