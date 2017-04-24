using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primalitate
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            n = extractint();

            if (prim(n))
            {
                Console.WriteLine("Numarul este prim");
            }
            else
            {
                Console.WriteLine("Numarul este neprim");
            }
            last();

        }
        public static int extractint()
        {

            Console.WriteLine("Introdu un numar");

            int n = 0;

            string line;
            line = Console.ReadLine();

            try
            {
                n = Int32.Parse(line);
            }
            catch (Exception)
            {
                Console.WriteLine("Oops, someting went wrong, we are working at this right now");
            }

            return n;
        }

        public static void last()
        {

            string last;
            last = Console.ReadLine();

        }

        public static bool prim(int n)
        {
        int c = 0, d = 2;

            if (n < 2)
            {
                return false;
            }

            if(n == 2)
            {
                return true;
            }


        do
        {
            if (n % d == 0)
            {
                c = c + 1;
            }
            d = d + 1;
        }
        while ((c == 0) && (d * d <= 0));

            if (c == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
