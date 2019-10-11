namespace Telephony
{
    using System;

    public class Startup
    {
        static void Main(string[] args)
        {
            string[] telephoneNumbers = Console.ReadLine().Split(" ");
            string[] urlAdreses = Console.ReadLine().Split(" ");

            Smartphone smartphone = new Smartphone();

            foreach (string number in telephoneNumbers)
            {
                Console.WriteLine(smartphone.Call(number));
            }

            foreach (string url in urlAdreses)
            {
                Console.WriteLine(smartphone.Browse(url));
            }
        }
    }
}
