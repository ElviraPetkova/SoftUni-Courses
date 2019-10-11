using System;

namespace _002._English_Name_of_the_Last_Digit
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string englishName = EnglishNameFromLastDigit(number);
            Console.WriteLine(englishName);
        }

        private static string EnglishNameFromLastDigit(int number)
        {
            int lastDigit = number % 10;
            string name = string.Empty;
            switch (lastDigit)
            {
                case 0: name = "zero"; break;
                case 1: name = "one"; break;
                case 2: name = "two"; break;
                case 3: name = "three"; break;
                case 4: name = "four"; break;
                case 5: name = "five"; break;
                case 6: name = "six"; break;
                case 7: name = "seven"; break;
                case 8: name = "eight"; break;
                case 9: name = "nine"; break;
            }

            return name;
        }
    }
}
