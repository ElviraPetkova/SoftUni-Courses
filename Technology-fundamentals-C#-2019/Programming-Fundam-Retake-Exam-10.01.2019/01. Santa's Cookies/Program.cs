using System;

namespace _01._Santa_s_Cookies
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfBatches = int.Parse(Console.ReadLine());

            int box = 0;

            for (int i = 0; i < amountOfBatches; i++)
            {
                int amountOfFlourInGrams = int.Parse(Console.ReadLine());
                int amountOfSugarInGrams = int.Parse(Console.ReadLine());
                int amountOfCocoaInGrams = int.Parse(Console.ReadLine());

                //({cup} + {smallSpoon} + {bigSpoon}) * min from({flourCups}, {sugarSpoons}, {cocoaSpoons}) / singleCookieGrams

                int cupOfFlour = amountOfFlourInGrams / 140;
                int smallSpoon = amountOfCocoaInGrams / 10;
                int bigSpoon = amountOfSugarInGrams / 20;

                if(cupOfFlour == 0 || smallSpoon == 0 || bigSpoon == 0)
                {
                    Console.WriteLine("Ingredients are not enough for a box of cookies.");
                    continue;
                }

                int minOfThis = Math.Min(cupOfFlour, Math.Min(smallSpoon, bigSpoon));

                int cooks = ((140 + 10 + 20) * minOfThis) / 25; // becose one cookie = 25 grams

                int currentBox = (cooks / 5);
                box += currentBox;

                Console.WriteLine($"Boxes of cookies: {currentBox}");
            }

            Console.WriteLine($"Total boxes: {box}");
        }
    }
}
