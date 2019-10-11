using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _03._Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var demonsAndHealth = new SortedDictionary<string, int>();
            var demonsAndDamage = new SortedDictionary<string, double>();

            string pattern = @"[\-]*?\d+\.*\d*";
            Regex regex = new Regex(pattern);

            for (int i = 0; i < input.Length; i++)
            {
                string demon = input[i];
                int health = 0;

                for (int j = 0; j < demon.Length; j++)
                {
                    char oneCharacter = demon[j];
                    if (oneCharacter != '+' && oneCharacter != '-' && oneCharacter != '*' && oneCharacter != '/'
                        && oneCharacter != '.' && char.IsDigit(oneCharacter) == false)
                    {
                        health += oneCharacter;
                    }
                }

                if(demonsAndHealth.ContainsKey(demon) == false)
                {
                    demonsAndHealth.Add(demon, health);
                }

                double damage = 0;
                if (regex.IsMatch(demon))
                {
                    MatchCollection matches = regex.Matches(demon);

                    foreach (Match item in matches)
                    {
                        var value = item.Value;
                        damage += (double.Parse(value));
                    }
                }

                for (int j = 0; j < demon.Length; j++)
                {
                    if(demon[j] == '*')
                    {
                        damage *= 2;
                    }
                    else if(demon[j] == '/')
                    {
                        damage /= 2;
                    }
                }

                if(demonsAndDamage.ContainsKey(demon) == false)
                {
                    demonsAndDamage.Add(demon, damage);
                }
            }

            foreach (var kvp in demonsAndHealth)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} health, {demonsAndDamage[kvp.Key]:f2} damage");
            }
        }
    }
}
