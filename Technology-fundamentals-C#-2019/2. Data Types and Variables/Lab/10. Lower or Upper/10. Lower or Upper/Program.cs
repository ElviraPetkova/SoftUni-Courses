using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main()
        {
            char character = char.Parse(Console.ReadLine());

            if (char.IsLower(character))
            {
                Console.WriteLine("lower-case");
            }
            else if (char.IsUpper(character))
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
