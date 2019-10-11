using System;

namespace _003._Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal firstNum = decimal.Parse(Console.ReadLine());
            decimal secondNum = decimal.Parse(Console.ReadLine());

            decimal diff = 0.000001M;
            decimal realDiff = Math.Abs(firstNum - secondNum);
            bool smallDiff = false;

            if (realDiff < diff)
            {
                smallDiff = true;
            }

            Console.WriteLine(smallDiff);
        }
    }
}
