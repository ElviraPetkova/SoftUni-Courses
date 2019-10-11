using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _7._Nether_Realms
{
    class Demon
    {
        public Demon(string name, int health, double damage)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
        }

        public string Name { get; set; }

        public int Health { get; set; }

        public double Damage { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] demons = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            SortedDictionary<string, Demon> informationForAllDemons = new SortedDictionary<string, Demon>();

            for (int i = 0; i < demons.Length; i++)
            {
                string infoForOneDemon = demons[i];
                string name = infoForOneDemon;
                int health = ReturnHealtForDemon(infoForOneDemon);
                double damage = ReturnDamageForDemon(infoForOneDemon);

                Demon currentDemon = new Demon(name, health, damage);
                informationForAllDemons.Add(infoForOneDemon, currentDemon);
            }

            PrintAllDemons(informationForAllDemons);
        }

        private static void PrintAllDemons(SortedDictionary<string, Demon> informationForAllDemons)
        {
            foreach (var kvp in informationForAllDemons)
            {
                Console.WriteLine($"{kvp.Value.Name} - {kvp.Value.Health} health, {kvp.Value.Damage:f2} damage ");
            }
        }

        private static double ReturnDamageForDemon(string infoForOneDemon)
        {
            double damage = 0;

            string pattern = @"[+-]*[\d]+[\.]*[\d]*";  //@"([+-])*([\d]+[\.]*[\d]*)"; 
            Regex regexPerDigit = new Regex(pattern);

            if (regexPerDigit.IsMatch(infoForOneDemon))
            {
                MatchCollection allDigits = regexPerDigit.Matches(infoForOneDemon);

                foreach (Match digit in allDigits)
                {
                    if (digit.Value.Contains('+') || digit.Value.Contains('-'))
                    {
                        string currentDigit = digit.Value.Substring(1);
                        if (digit.Value.Contains('-'))
                        {
                            damage -= double.Parse(currentDigit);
                        }
                        else
                        {
                            damage += double.Parse(currentDigit);
                        }
                        
                    }
                    else
                    {
                        damage += double.Parse(digit.Value);
                    }
                }
            }

            if (infoForOneDemon.Contains('*'))
            {
                int count = infoForOneDemon.Where(x => x == '*').Count();
                for (int i = 0; i < count; i++)
                {
                    damage *= 2;
                }
            }

            if (infoForOneDemon.Contains('/'))
            {
                int count = infoForOneDemon.Where(x => x == '/').Count();
                for (int i = 0; i < count; i++)
                {
                    damage /= 2.0;
                }
            }


            return damage;
        }

        private static int ReturnHealtForDemon(string infoForOneDemon)
        {
            int health = 0;

            string pattern = @"[^0-9+\-*/\.]";
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(infoForOneDemon))
            {
                MatchCollection matches = regex.Matches(infoForOneDemon);

                foreach (Match match in matches)
                {
                    char character = char.Parse(match.Value);
                    health += (int)character;
                }
            }

            return health;
        }
    }
}
