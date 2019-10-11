using System;
using System.Globalization;

namespace _01._Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOrders = int.Parse(Console.ReadLine());

            decimal totalPrice = 0M;

            for (int i = 0; i < numberOfOrders; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsulesCount = long.Parse(Console.ReadLine());

                //price = (daysInMonth * capsulesCount) * pricePerCapsule

                int month = date.Month;
                int year = date.Year;
                int dayOfMonth = DateTime.DaysInMonth(year, month);

                decimal price = (dayOfMonth * capsulesCount) * pricePerCapsule;
                totalPrice += price;

                Console.WriteLine($"The price for the coffee is: ${price:f2}");
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
