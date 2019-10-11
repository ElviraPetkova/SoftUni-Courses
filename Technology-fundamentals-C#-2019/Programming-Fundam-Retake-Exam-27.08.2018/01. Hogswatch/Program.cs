using System;

namespace _01._Hogswatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int homesToVisit = int.Parse(Console.ReadLine());
            int numberOfPresents = int.Parse(Console.ReadLine());

            int presentsBegining = numberOfPresents;
            int backingCount = 0;
            int totalGiftPresents = 0;

            for (int i = 1; i <= homesToVisit; i++)
            {
                int numberOfChildrensInHome = int.Parse(Console.ReadLine());

                if(numberOfPresents >= numberOfChildrensInHome)
                {
                    numberOfPresents -= numberOfChildrensInHome;
                }
                else
                {
                    int needPresents = numberOfChildrensInHome - numberOfPresents;
                    
                    //int diff = numberOfChildrensInHome - needPresents;
                    //numberOfChildrensInHome -= diff;

                    backingCount++;

                    int homesMore = homesToVisit - i;
                    int giftPresents = ((presentsBegining / i) * homesMore) + needPresents;

                    numberOfPresents += giftPresents;
                    totalGiftPresents += giftPresents;
                    numberOfPresents -= numberOfChildrensInHome;
                }
            }

            if(backingCount == 0)
            {
                Console.WriteLine(numberOfPresents);
            }
            else
            {
                Console.WriteLine(backingCount);
                Console.WriteLine(totalGiftPresents);
            }
        }
    }
}
