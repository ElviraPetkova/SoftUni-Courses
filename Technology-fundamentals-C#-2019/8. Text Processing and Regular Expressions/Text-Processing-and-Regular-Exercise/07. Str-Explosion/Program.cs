using System;

namespace _07._Str_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            string newString = StringExplosion(line);

            Console.WriteLine(newString);
        }

        private static string StringExplosion(string line)
        {
            int lastPower = 0;

            for (int i = 0; i < line.Length; i++)
            {
                if(line[i] == '>')
                {
                    int power = int.Parse(line[i + 1].ToString());

                    if(lastPower > 0)
                    {
                        power += lastPower;
                        lastPower = 0;
                    }

                    if(power > line.Length - 1 - i)
                    {
                        power = line.Length - 1 - i;
                    }

                    string currentString = line.Substring(i + 1, power);

                    int indexOfSymbol = currentString.IndexOf('>');
                    if (indexOfSymbol != -1)
                    {
                        
                        lastPower = power - indexOfSymbol;
                        power = indexOfSymbol;
                    }

                    line = line.Remove(i + 1, power);
                }
            }

            return line;
        }
    }
}
