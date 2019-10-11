using System;
using System.Text.RegularExpressions;

namespace _03._Chore_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternPerDishes = @"<([a-z0-9]+)>";
            Regex regexPerDiches = new Regex(patternPerDishes);

            string patternPerCleaning = @"[[]([A-Z0-9]+)]";
            Regex regexPerCleaning = new Regex(patternPerCleaning);

            string patternPerLaundry = @"{(.+)}";
            Regex regexPerLaundry = new Regex(patternPerLaundry);

            int dishesTime = 0;
            int cleaningTime = 0;
            int laundryTime = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "wife is happy")
                {
                    break;
                }

                if (regexPerDiches.IsMatch(input))
                {
                    Match matchDiches = regexPerDiches.Match(input);
                    string curentString = matchDiches.Groups[1].Value;
                    int currentTime = SumOfDigitsInString(curentString);

                    dishesTime += currentTime;
                }
                else if (regexPerCleaning.IsMatch(input))
                {
                    Match matchCleaning = regexPerCleaning.Match(input);
                    string currentString = matchCleaning.Groups[1].Value;
                    int currentTime = SumOfDigitsInString(currentString);

                    cleaningTime += currentTime;
                }
                else if (regexPerLaundry.IsMatch(input))
                {
                    Match matchLaundry = regexPerLaundry.Match(input);
                    string currentString = matchLaundry.Groups[1].Value;
                    int currentTime = SumOfDigitsInString(currentString);

                    laundryTime += currentTime;
                }
                else
                {
                    continue;
                }
            }

            int totalTime = dishesTime + cleaningTime + laundryTime;

            Console.WriteLine($"Doing the dishes - {dishesTime} min.");
            Console.WriteLine($"Cleaning the house - {cleaningTime} min.");
            Console.WriteLine($"Doing the laundry - {laundryTime} min.");
            Console.WriteLine($"Total - {totalTime} min.");
        }

        private static int SumOfDigitsInString(string input)
        {
            int time = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    time += int.Parse(input[i].ToString());
                }
            }

            return time;
        }
    }
}
