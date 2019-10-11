using System;

namespace Problem_1._Cooking_Masterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  •	budget – floating-point number in range [0.00…1,000.00]
                •	students – integer in range [0…100]
                •	price of flour for a package – floating-point number in range [0.00…100.00]
                •	price of egg for a single egg – floating-point number in range [0.00…100.00]
                •	price of apron for a single apron – floating-point number in range [0.00…100.00] */

            double budjed = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double pricePerFlour = double.Parse(Console.ReadLine());
            double pricePerOneEgg = double.Parse(Console.ReadLine());
            double pricePerApron = double.Parse(Console.ReadLine());

            //for one student consists of 1 package of flour, 10 eggs and an apron. 
            //Because the aprons get dirty often, George should buy 20% more, rounded up to the next integer. 
            //Also, every fifth package of flour is free. 

            int capacityPerApron = (int)(countOfStudents + (Math.Ceiling(countOfStudents * 0.2)));
            int freeNumberOFFlour = countOfStudents / 5;
            int needFlour = countOfStudents - freeNumberOFFlour;

            double needMoney = (needFlour * pricePerFlour) + (countOfStudents * (pricePerOneEgg * 10)) + (capacityPerApron * pricePerApron);

            if(budjed >= needMoney)
            {
                Console.WriteLine($"Items purchased for {needMoney:f2}$.");
            }
            else
            {
                Console.WriteLine($"{(needMoney - budjed):f2}$ more needed.");
            }

        }
    }
}
