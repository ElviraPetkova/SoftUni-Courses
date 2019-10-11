using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());

            int snowballSnowMax = int.MinValue;
            int snowballTimeMax = int.MinValue;
            int snowballQualityMax = int.MinValue;
            BigInteger snowballValueMax = 0;

            for (int i = 0; i < numberOfSnowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                int product = (int)Math.Floor((double)snowballSnow / snowballTime);
                BigInteger snowballValue = BigInteger.Pow(product, snowballQuality);

                if (snowballValueMax < snowballValue)
                {
                    snowballValueMax = snowballValue;
                    snowballSnowMax = snowballSnow;
                    snowballQualityMax = snowballQuality;
                    snowballTimeMax = snowballTime;
                }
            }

            Console.WriteLine($"{snowballSnowMax} : {snowballTimeMax} = {snowballValueMax} ({snowballQualityMax})");
        }
    }
}
