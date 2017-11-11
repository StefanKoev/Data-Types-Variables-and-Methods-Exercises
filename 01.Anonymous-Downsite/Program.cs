using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.Anonymous_Dounsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWebsites = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());

            decimal totalLoss = 0.0m;
            for (int i = 0; i < numberOfWebsites; i++)
            {
                string[] websites = Console.ReadLine().Split();

                string siteName = websites[0];
                long siteVisit = long.Parse(websites[1]);
                decimal siteCommercialPricePerVisit = decimal.Parse(websites[2]);

                decimal siteLoss = siteVisit * siteCommercialPricePerVisit;

                totalLoss += siteLoss;

                Console.WriteLine(siteName);
            }
            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine($"Security Token: {BigInteger.Pow(securityKey, numberOfWebsites)}");
        }
    }
}
