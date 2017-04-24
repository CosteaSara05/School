using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, nc, ni = 0;

            Console.WriteLine("Scrieti numarul");

            string line;
            line = Console.ReadLine();
            n = Int32.Parse(line);
            nc = n;

            while (nc > 0)
            {
                ni = ni * 10 + nc % 10;
                nc = nc / 10;
            }

            if (ni == n)
            {
                Console.WriteLine("Numarul e palindrom");
            }
            else
                Console.WriteLine("Numarul nu e palindrom");
            string last;
            last = Console.ReadLine();
        }
    }
}
