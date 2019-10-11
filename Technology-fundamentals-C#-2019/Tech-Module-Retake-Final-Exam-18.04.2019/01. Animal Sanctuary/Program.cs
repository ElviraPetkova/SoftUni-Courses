using System;
using System.Text.RegularExpressions;
using System.Text;

namespace _01._Animal_Sanctuary
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfInput = int.Parse(Console.ReadLine());

            string pattern = @"^n:(?<animalName>[^\;]+);t:(?<animalKind>[^\;]+);c--(?<animalCountry>[A-Za-z ]+)$";
            Regex regex = new Regex(pattern);

            int totalWeight = 0;

            for (int i = 0; i < countOfInput; i++)
            {
                string input = Console.ReadLine();
                if (regex.IsMatch(input))
                {
                    Match match = regex.Match(input);
                    string currentName = match.Groups["animalName"].Value;
                    string currentKind = match.Groups["animalKind"].Value;
                    string country = match.Groups["animalCountry"].Value;

                    string name = TakeOnlyLettersAndWhiteSpaces(currentName);
                    string kind = TakeOnlyLettersAndWhiteSpaces(currentKind);

                    Console.WriteLine($"{name} is a {kind} from {country}");

                    totalWeight += CurrentWeightFromOnlyDigits(currentName, currentKind);
                }
            }

            Console.WriteLine($"Total weight of animals: {totalWeight}KG");
        }

        private static int CurrentWeightFromOnlyDigits(string currentName, string currentKind)
        {
            int currentWeight = 0;

            for (int i = 0; i < currentName.Length; i++)
            {
                if (char.IsDigit(currentName[i]))
                {
                    currentWeight += int.Parse(currentName[i].ToString());
                }
            }

            for (int i = 0; i < currentKind.Length; i++)
            {
                if (char.IsDigit(currentKind[i]))
                {
                    currentWeight += int.Parse(currentKind[i].ToString());
                }
            }

            return currentWeight;
        }

        private static string TakeOnlyLettersAndWhiteSpaces(string currentValue)
        {
            StringBuilder newValue = new StringBuilder();
            for (int i = 0; i < currentValue.Length; i++)
            {
                if(char.IsLetter(currentValue[i]) || char.IsWhiteSpace(currentValue[i]))
                {
                    newValue.Append(currentValue[i]);
                }
            }

            return newValue.ToString();
        }
    }
}
