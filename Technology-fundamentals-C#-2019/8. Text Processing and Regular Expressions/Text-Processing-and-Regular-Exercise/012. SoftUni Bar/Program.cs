using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _012._SoftUni_Bar
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^%([A-Z][a-z]+)%[^%|\.|$]*<(\w+)>[^%|\.|$]*[|](\d+)[|]([^%|\.|$]*|\d+\.\d+)[$]";

            Regex regex = new Regex(pattern);

            string patternForOnlyDigits = @"[\d]+[\.\d+]*";
            Regex regexForDigits = new Regex(patternForOnlyDigits);

            List<string> listOfResults = new List<string>();
            double total = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "end of shift")
                {
                    break;
                }

                if (regex.IsMatch(input))
                {
                    Match info = regex.Match(input);

                    string name = info.Groups[1].Value;
                    string product = info.Groups[2].Value;

                    string countInString = info.Groups[3].Value;
                    string priceInString = info.Groups[4].Value;

                    Match matchForCount = regexForDigits.Match(countInString);
                    int count = int.Parse(matchForCount.Value);

                    Match matchForPrice = regexForDigits.Match(priceInString);
                    double price = double.Parse(matchForPrice.Value);

                    price *= count;
                    total += price;

                    //"{customerName}: {product} - {totalPrice}"
                    string result = $"{name}: {product} - {price:f2}";
                    listOfResults.Add(result);
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, listOfResults));
            Console.WriteLine($"Total income: {total:f2}");
        }
    }
}
