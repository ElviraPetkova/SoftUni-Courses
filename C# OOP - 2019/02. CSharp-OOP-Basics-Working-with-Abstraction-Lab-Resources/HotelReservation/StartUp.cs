namespace HotelReservation
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] information = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //"{pricePerDay} {numberOfDays} {season} {discountType}"
            decimal pricePerDay = decimal.Parse(information[0]);
            int numberOfDay = int.Parse(information[1]);
            Season season = Enum.Parse<Season>(information[2]);
            DiscountType discount = DiscountType.None;

            if (information.Length > 3)
            {
                discount = Enum.Parse<DiscountType>(information[3]);
            }

            PriceCalculator calculator = new PriceCalculator();
            Console.WriteLine($"{calculator.CalculatePrice(pricePerDay, numberOfDay, season, discount):f2}");
        }
    }
}
