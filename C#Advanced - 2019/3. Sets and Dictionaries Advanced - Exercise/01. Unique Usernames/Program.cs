using System;
using System.Collections.Generic;

namespace _01._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            HashSet<string> userNames = new HashSet<string>();

            for (int i = 0; i < count; i++)
            {
                string name = Console.ReadLine();

                userNames.Add(name);
            }

            Console.WriteLine(string.Join(Environment.NewLine, userNames));
        }
    }
}
