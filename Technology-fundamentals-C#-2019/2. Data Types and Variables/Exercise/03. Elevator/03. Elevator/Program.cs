using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capasityInElevator = int.Parse(Console.ReadLine());

            int countOfTimes = (int)Math.Ceiling((double)numberOfPeople / capasityInElevator);
            Console.WriteLine(countOfTimes);
        }
    }
}
