using System;

namespace _02._Pounds_to_Dollars
{
    class Program
    {
        static void Main()
        {
            //1 British Pound = 1.31 Dollars

            decimal pound = decimal.Parse(Console.ReadLine());
            decimal dollars = pound * 1.31M;
            Console.WriteLine($"{dollars:f3}");
        }
    }
}
