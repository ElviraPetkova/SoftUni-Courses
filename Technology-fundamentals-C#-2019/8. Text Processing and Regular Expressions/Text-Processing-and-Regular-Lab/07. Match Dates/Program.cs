using System;
using System.Text.RegularExpressions;

namespace _07._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"\b(\d{2})([-.\/])([A-Z][a-z]{2})(\2)(\d{4})\b";

            Regex regex = new Regex(pattern);

            MatchCollection matchDates = regex.Matches(text);

            //Day: 13, Month: Jul, Year: 1928

            foreach (Match match in matchDates)
            {
                Console.WriteLine($"Day: {match.Groups[1].Value}, Month: {match.Groups[3].Value}, Year: {match.Groups[5].Value}");
            }
        }
    }
}
