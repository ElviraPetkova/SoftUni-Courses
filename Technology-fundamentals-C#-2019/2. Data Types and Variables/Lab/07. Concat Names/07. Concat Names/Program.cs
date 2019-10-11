using System;

namespace _07._Concat_Names
{
    class Program
    {
        static void Main()
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string delimiter = Console.ReadLine();

            string newString = firstName + "" + delimiter + "" + secondName;
            Console.WriteLine(newString);
        }
    }
}
