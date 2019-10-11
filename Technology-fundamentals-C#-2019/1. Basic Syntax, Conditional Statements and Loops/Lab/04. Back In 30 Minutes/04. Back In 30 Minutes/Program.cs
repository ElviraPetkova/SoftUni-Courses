using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            //first solution
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            var time = new TimeSpan(hours, minutes + 30, 0);
            Console.WriteLine($"{time:h\\:mm}");

            //second solution
            //int hours = int.Parse(Console.ReadLine());
            //int minutes = int.Parse(Console.ReadLine());

            //if (minutes >= 30)
            //{
            //    hours++;
            //    if (hours >= 24)
            //    {
            //        hours = 0;
            //    }

            //    minutes += 30;
            //    minutes -= 60;
            //}
            //else
            //{
            //    minutes += 30;
            //}

            //Console.WriteLine($"{hours}:{minutes:D2}");

        }
    }
}
