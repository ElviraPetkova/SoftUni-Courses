using System;
using System.Globalization;

namespace _02._Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfOrders = int.Parse(Console.ReadLine());

            decimal totalPrice = 0M;

            for (int i = 0; i < countOfOrders; i++)
            {
                decimal pricePerCapsules = decimal.Parse(Console.ReadLine());
                DateTime dateOfInput = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsulesCount = long.Parse(Console.ReadLine());

                int mounth = dateOfInput.Month;
                int year = dateOfInput.Year;
                int dayOfMounth = DateTime.DaysInMonth(year, mounth);

                decimal price = (dayOfMounth * capsulesCount) * pricePerCapsules;
                totalPrice += price;

                Console.WriteLine($"The price for the coffee is: ${price:f2}");
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
