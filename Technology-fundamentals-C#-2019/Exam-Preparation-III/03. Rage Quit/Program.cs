using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace _03._Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            string pattern = @"(\D+)(\d+)";
            Regex regex = new Regex(pattern);

            StringBuilder resultText = new StringBuilder();

            if (regex.IsMatch(line))
            {
                MatchCollection matches = regex.Matches(line);

                foreach (Match item in matches)
                {
                    string currentText = item.Groups[1].Value.ToUpper();
                    int digit = int.Parse(item.Groups[2].Value);

                    string newCurrentText = RepeatText(currentText, digit);
                    resultText.Append(newCurrentText);
                }
            }

            var uniqueSymbols = resultText.ToString().Distinct().ToList();
            int lenght = uniqueSymbols.Count;

            Console.WriteLine($"Unique symbols used: {lenght}");
            Console.WriteLine(resultText);
        }

        private static string RepeatText(string currentText, int digit)
        {
            StringBuilder newText = new StringBuilder();

            for (int i = 0; i < digit; i++)
            {
                newText.Append(currentText);
            }

            return newText.ToString();
        }
    }
}
