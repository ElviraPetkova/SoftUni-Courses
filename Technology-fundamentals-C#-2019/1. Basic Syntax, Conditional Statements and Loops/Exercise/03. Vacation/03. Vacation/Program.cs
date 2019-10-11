using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            string typeOfGrup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            decimal price = 0M;
            decimal middPrice = 0M;

            switch (typeOfGrup)
            {
                case "Students":

                    switch (dayOfWeek)
                    {
                        case "Friday": price = 8.45M; break;
                        case "Saturday": price = 9.80M; break;
                        case "Sunday": price = 10.46M; break;
                    }

                    price *= (decimal)numberOfPeople;

                    if (numberOfPeople >= 30)
                    {
                        price = price - (price * 0.15M);
                    }

                    break;

                case "Business":
                    switch (dayOfWeek)
                    {
                        case "Friday": price = 10.90M; break;
                        case "Saturday": price = 15.60M; break;
                        case "Sunday": price = 16.00M; break;
                    }

                    if (numberOfPeople >= 100)
                    {
                        middPrice = price * 10m;
                        price *= (decimal)numberOfPeople;
                        price -= middPrice;
                    }
                    else
                    {
                        price *= (decimal)numberOfPeople;
                    }

                    break;
                case "Regular":

                    switch (dayOfWeek)
                    {
                        case "Friday": price = 15.00M; break;
                        case "Saturday": price = 20.00M; break;
                        case "Sunday": price = 22.50M; break;
                    }

                    price *= (decimal)numberOfPeople;

                    if (numberOfPeople >= 10 & numberOfPeople <= 20)
                    {
                        price = price - (price * 0.05M);
                    }

                    break;
            }

            Console.WriteLine($"Total price: {price:f2}");

        }
    }
}
