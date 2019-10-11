using System;
using System.Text;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string oposideUser = ReverseText(user);
            string posibleUser = Console.ReadLine();
            int counter = 0;
            bool notBlocked = true;

            while (posibleUser != oposideUser)
            {
                counter++;
                if (counter == 4)
                {
                    Console.WriteLine("User {0} blocked!", user);
                    notBlocked = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }

                posibleUser = Console.ReadLine();
            }

            if (notBlocked)
            {
                Console.WriteLine("User {0} logged in.", user);
            }
        }

        public static string ReverseText(string text)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }
            return sb.ToString();
        }
    }
}

