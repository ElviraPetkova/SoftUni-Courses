using System;

namespace _01._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGameCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double sum = 0;

            for (int counter = 1; counter <= lostGameCount; counter++)
            {
                if(counter % 2 == 0)
                {
                    sum += headsetPrice;
                }

                if(counter % 3 == 0)
                {
                    sum += mousePrice;
                }

                if(counter % 6 == 0)
                {
                    sum += keyboardPrice;
                }

                if(counter % 12 == 0)
                {
                    sum += displayPrice;
                }
            }

            Console.WriteLine($"Rage expenses: {sum:f2} lv.");
        }
    }
}
