using System;

namespace _01._Easter_Cozonacs
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budjet = decimal.Parse(Console.ReadLine());
            decimal priceForOneKgFloor = decimal.Parse(Console.ReadLine());

            decimal priceForOnePacketEggs = priceForOneKgFloor * 0.75M;
            decimal priceForOneLiterMilk = priceForOneKgFloor + (priceForOneKgFloor * 0.25M);

            decimal priceFor250MlMilk = priceForOneLiterMilk / 4.0M;

            decimal pricePerOneCozonacs = priceForOneKgFloor + priceForOnePacketEggs + priceFor250MlMilk;

            int numberOfCozunacs = (int)(budjet / pricePerOneCozonacs);
            decimal leftMoney = budjet - (numberOfCozunacs * pricePerOneCozonacs);

            int coloredEggs = 0;

            for (int i = 1; i <= numberOfCozunacs; i++)
            {
                coloredEggs += 3;
                if(i % 3 == 0)
                {
                    coloredEggs -= (i - 2);
                }
            }

            Console.WriteLine($"You made {numberOfCozunacs} cozonacs! Now you have {coloredEggs} eggs and {leftMoney:f2}BGN left.");
        }
    }
}
