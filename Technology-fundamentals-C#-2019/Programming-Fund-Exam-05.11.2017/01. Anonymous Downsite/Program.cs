using System;
using System.Numerics;

namespace _01._Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfAffectedWebsites = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());

            BigInteger securityToken = BigInteger.Pow(securityKey, countOfAffectedWebsites);

            if(securityKey == 0 || countOfAffectedWebsites == 0)
            {
                securityToken = 0;
            }

            decimal totalLost = 0M;
            for (int i = 0; i < countOfAffectedWebsites; i++)
            {
                string[] infoPerWebsite = Console.ReadLine().Split(' ');

                string nameOfWebsite = infoPerWebsite[0];
                long visitisSite = long.Parse(infoPerWebsite[1]);
                decimal siteComersial = decimal.Parse(infoPerWebsite[2]);

                Console.WriteLine(nameOfWebsite);

                decimal lost = (decimal)visitisSite * siteComersial;
                totalLost += lost;
            }

            Console.WriteLine($"Total Loss: {totalLost:f20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
