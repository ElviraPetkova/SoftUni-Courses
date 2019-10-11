using System;

namespace _01._Thea_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long numberOfPictures = long.Parse(Console.ReadLine());
            long amountOfTimeByFilter = long.Parse(Console.ReadLine());
            long filterFactorInPrecents = long.Parse(Console.ReadLine());
            long amountOfFilterFactor = long.Parse(Console.ReadLine());

            long picturesForFilter = (long)Math.Ceiling(numberOfPictures * (filterFactorInPrecents / 100.0));
            long secondsPerAllPictures = numberOfPictures * amountOfTimeByFilter;
            long secondsPErFilters = picturesForFilter * amountOfFilterFactor;
            long totalSeconds = secondsPerAllPictures + secondsPErFilters;

            TimeSpan time = TimeSpan.FromSeconds(totalSeconds);
            string date = time.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(date);
        }
    }
}
