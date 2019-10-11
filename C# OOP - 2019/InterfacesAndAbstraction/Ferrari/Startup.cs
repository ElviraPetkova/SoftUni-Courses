namespace Ferrari
{
    using System;

    public class Startup
    {
        static void Main(string[] args)
        {
            string driversName = Console.ReadLine();
            IDriveable car = new Ferrari(driversName);

            Console.WriteLine(car);
        }
    }
}
