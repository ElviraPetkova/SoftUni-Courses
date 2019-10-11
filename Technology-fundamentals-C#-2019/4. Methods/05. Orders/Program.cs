using System;

namespace _05.Orders
{
    class Program
    {
        //Two types of solution; first - good, second - tricky
        public static void Main(string[] args)
        {
            string typeOfProduct = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            switch (typeOfProduct)
            {
                case "coffee": CalculateAndPrintPriceOfCoffee(quantity); break;
                case "water": CalculateAndPrintPriceOfWater(quantity); break;
                case "coke": CalculateAndPrintPriceOfCoke(quantity); break;
                case "snacks": CalculateAndPrintPriceOfSnacks(quantity); break;
            }
        }

        public static void CalculateAndPrintPriceOfCoffee(int quantity)
        {
            double price = 1.50 * quantity;
            Console.WriteLine($"{price:f2}");
        }

        public static void CalculateAndPrintPriceOfWater(int quantity)
        {
            double price = 1.00 * quantity;
            Console.WriteLine($"{price:f2}");
        }

        public static void CalculateAndPrintPriceOfCoke(int quantity)
        {
            double price = 1.40 * quantity;
            Console.WriteLine($"{price:f2}");
        }

        public static void CalculateAndPrintPriceOfSnacks(int quantity)
        {
            double price = 2.00 * quantity;
            Console.WriteLine($"{price:f2}");
        }

        //public static void Main(string[] args)
        //{
        //    string typeOfProduct = Console.ReadLine();
        //    int quantity = int.Parse(Console.ReadLine());

        //    PrintPrice(typeOfProduct, quantity);
        //}

        //public static void PrintPrice(string type, int quantity)
        //{
        //    double price = 0;
        //    switch (type)
        //    {
        //        case "coffee": price = CalculatePriceOfCoffee(quantity); break;
        //        case "water":  price = CalculatePriceOfWater(quantity); break;
        //        case "coke":  price = CalculatePriceOfCoke(quantity); break;
        //        case "snacks": price = CalculatePriceOfSnacks(quantity); break;
        //    }

        //    Console.WriteLine($"{price:f2}");
        //}

        //public static double CalculatePriceOfCoffee(int quantity)
        //{
        //    double price = 1.50 * quantity;
        //    return price;
        //}

        //public static double CalculatePriceOfWater(int quantity)
        //{
        //    double price = 1.00 * quantity;
        //    return price;
        //}

        //public static double CalculatePriceOfCoke(int quantity)
        //{
        //    double price = 1.40 * quantity;
        //    return price;
        //}

        //public static double CalculatePriceOfSnacks(int quantity)
        //{
        //    double price = 2.00 * quantity;
        //    return price;
        //}
    }
}
