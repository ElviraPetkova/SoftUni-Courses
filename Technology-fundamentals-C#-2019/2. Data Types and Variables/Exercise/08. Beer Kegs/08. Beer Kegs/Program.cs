using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            double maxVolume = double.MinValue;
            string winnKegs = string.Empty;

            for (int i = 0; i < counter; i++)
            {
                string modelKegs = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volumeOfKegs = Math.PI * (Math.Pow(radius, 2)) * height;    //π * r^2 * h. 

                if (maxVolume < volumeOfKegs)
                {
                    maxVolume = volumeOfKegs;
                    winnKegs = modelKegs;
                }
            }

            Console.WriteLine(winnKegs);
        }
    }
}
