using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int halfN = n / 2;
            int count = 0;
            while (n >= m)
            {
                n -= m;

                if (n == halfN)
                {
                    if (y > 0)
                    {
                        n /= y;
                    }

                }

                count++;
            }
            Console.WriteLine(n);
            Console.WriteLine(count);
        }
    }
}
