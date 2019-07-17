using System;
using System.Collections.Generic;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "PARTY")
                {
                    break;
                }

                char[] guest = input.ToCharArray();

                if (char.IsDigit(guest[0]))
                {
                    vipGuests.Add(input);
                }
                else
                {
                    regularGuests.Add(input);
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                if (vipGuests.Contains(input))
                {
                    vipGuests.Remove(input);
                }
                else if (regularGuests.Contains(input))
                {
                    regularGuests.Remove(input);
                }
            }

            Console.WriteLine(vipGuests.Count + regularGuests.Count);

            if(vipGuests.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, vipGuests));
            }

            if(regularGuests.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, regularGuests));
            }
        }
    }
}
