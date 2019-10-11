using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalMoney = 0;

            string pattern = @"%([A-Z][a-z]+)%[^\$|\%|\.\|]*?<(\w+)>[^\$|\%|\.\|]*?\|(\d+)\|[^\$|\%|\.\|]*?(\d+\.*\d+)\$";
            Regex regex = new Regex(pattern);

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "end of shift")
                {
                    break;
                }

                if (regex.IsMatch(input))
                {
                    Match match = regex.Match(input);
                    string nameOfCustomer = match.Groups[1].Value;
                    string product = match.Groups[2].Value;
                    int count = int.Parse(match.Groups[3].Value);
                    double price = double.Parse(match.Groups[4].Value);

                    price *= count;
                    totalMoney += price;

                    string result = $"{nameOfCustomer}: {product} - {price:f2}";
                    Console.WriteLine(result);
                }
            }

            Console.WriteLine($"Total income: {totalMoney:f2}");
        }
    }
}
