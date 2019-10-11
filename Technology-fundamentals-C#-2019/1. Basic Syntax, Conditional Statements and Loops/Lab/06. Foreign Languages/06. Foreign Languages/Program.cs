using System;

namespace _06._Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfContry = Console.ReadLine();

            if (nameOfContry == "USA" || nameOfContry == "England")
            {
                Console.WriteLine("English"); //language = "English";
            }
            else if (nameOfContry == "Spain" || nameOfContry == "Argentina" || nameOfContry == "Mexico")
            {
                Console.WriteLine("Spanish"); //language = "Spanish";
            }
            else
            {
                Console.WriteLine("unknown"); //language = "unknow";
            }
        }
    }
}
