using System;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double budjet = double.Parse(Console.ReadLine()); //may be decimal
            int peopleInGroup = int.Parse(Console.ReadLine());
            double fuelPerKilometers = double.Parse(Console.ReadLine());
            double foodExpensesPerPerson = double.Parse(Console.ReadLine());
            double pricePerHotelForOnePerson = double.Parse(Console.ReadLine());

            double pricePerFood = days * peopleInGroup * foodExpensesPerPerson;
            double pricePerHotels = days * peopleInGroup * pricePerHotelForOnePerson;

            if(peopleInGroup > 10)
            {
                pricePerHotels -= (pricePerHotels * 0.25);
            }

            double currentExpensive = pricePerHotels + pricePerFood;

            bool haveMoney = true;

            for (int currentDay = 1; currentDay <= days; currentDay++)
            {
                double travelDistansePerOneDay = double.Parse(Console.ReadLine());

                double consumedFuel = travelDistansePerOneDay * fuelPerKilometers;

                currentExpensive += consumedFuel;

                if (currentDay % 7 == 0)
                {
                    currentExpensive -= (currentExpensive / peopleInGroup);
                }

                if (currentDay % 3 == 0 || currentDay % 5 == 0)
                {
                    currentExpensive += (currentExpensive *  0.4);
                }

                if (currentExpensive > budjet)
                {
                    Console.WriteLine($"Not enough money to continue the trip. You need {(currentExpensive - budjet):f2}$ more.");
                    haveMoney = false;
                    break;
                }
            }

            if (haveMoney && currentExpensive <= budjet)
            {
                Console.WriteLine($"You have reached the destination. You have {(budjet - currentExpensive):f2}$ budget left.");
            }
            else if(haveMoney && currentExpensive > budjet)
            {
                Console.WriteLine($"Not enough money to continue the trip. You need {(currentExpensive - budjet):f2}$ more.");
            }
        }
    }
}
