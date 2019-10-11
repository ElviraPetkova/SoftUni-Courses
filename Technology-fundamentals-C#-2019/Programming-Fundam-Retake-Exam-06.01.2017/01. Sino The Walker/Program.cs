using System;

namespace _01._Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeOfInput = Console.ReadLine().Split(':');
            int numberOfSteps = int.Parse(Console.ReadLine()) % 86400; //becose one day = 24h = 86400 s.
            int timeInSecondsPErOneStep = int.Parse(Console.ReadLine()) % 86400;

            int totalSeconds = numberOfSteps * timeInSecondsPErOneStep;
            int hours = int.Parse(timeOfInput[0]);
            int minutes = int.Parse(timeOfInput[1]);
            int seconds = int.Parse(timeOfInput[2]);

            var time = new TimeSpan(hours, minutes, seconds + totalSeconds);
            Console.WriteLine($"Time Arrival: {time:hh\\:mm\\:ss}");
        }
    }
}
