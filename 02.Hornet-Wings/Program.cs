using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            long p = long.Parse(Console.ReadLine());

            var distance = (n / 1000) * m;
            var seconds = (n / 100) + ((n / p) * 5);

            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{seconds} s.");
        }
    }
}
