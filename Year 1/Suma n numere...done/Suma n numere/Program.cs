using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma_n_numere
{
    class Program
    {
            static void Main(string[] args)
        {
                Console.WriteLine("Suma primelor n numere nenule.");
                P1();

                last();
            }

        public static void P1()
        {
            ulong a = 0;

            a = extractInt();

            Console.WriteLine("Suma numerelor de la 1 la {0} este {1}", a, a * (a + 1) / 2);
        }

        public static ulong extractInt()
        {

            Console.WriteLine("Introduceti un numar natural: ");

            string line;

            line = Console.ReadLine();

            ulong n = 0;

            try
            {
                n = ulong.Parse(line);
            }
            catch (Exception)
            {
                Console.WriteLine("Oops! Something went wrong...Our engineers are working at this error right now.");
            }
            return n;
        }
        public static void last()
        {
            string last;
            last = Console.ReadLine();
        }
    }
}
