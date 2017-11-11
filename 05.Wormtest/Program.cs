using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            double lengthInMeters = double.Parse(Console.ReadLine());
            double widthInCentemeters = double.Parse(Console.ReadLine());

            double lenghtInCentimeters = lengthInMeters * 100;

            if (lenghtInCentimeters % widthInCentemeters == 0 || widthInCentemeters == 0)
            {
                double product = lenghtInCentimeters * widthInCentemeters;
                Console.WriteLine($"{product:f2}");
            }
            else
            {
                double percentage = (lenghtInCentimeters / widthInCentemeters) * 100;
                Console.WriteLine($"{percentage:f2}%");
            }
            
        }
    }
}
