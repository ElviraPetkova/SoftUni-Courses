using System;

namespace _01._Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal amountOfMoney = decimal.Parse(Console.ReadLine());
            int numberOfGuests = int.Parse(Console.ReadLine());
            decimal priceOfBanana = decimal.Parse(Console.ReadLine()); //all prices per single item
            decimal priceOfEgg = decimal.Parse(Console.ReadLine());
            decimal priceOfBerry = decimal.Parse(Console.ReadLine());

            //For a set of 6 she needs 2 bananas, 4 eggs and 0.2 kilos berries.

            int countOfPortions = (int)Math.Ceiling(numberOfGuests / 6.0);

            decimal cost = (countOfPortions * (priceOfBanana * 2)) + (countOfPortions * (priceOfEgg * 4)) +
                (countOfPortions * (priceOfBerry * 0.2M));

            if(amountOfMoney >= cost)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {cost:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(cost - amountOfMoney):f2}lv more.");
            }
        }
    }
}
