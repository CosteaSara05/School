using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afisare_cifre_numar_in_ordine_inversa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Scrie numarul");

            string line;
            line = Console.ReadLine();

            int a, nc, n;
            n = Int32.Parse(line);
            nc = 0;

            while (n > 0)
            {
                a = n % 10;
                nc = a + (nc * 10);
                n = n / 10;
            }
            Console.WriteLine("Numarul invers este {0}", nc);

            Console.WriteLine("Prevent not to close");
            last();
        }
        public static void last()
        {
            string last;
        last = Console.ReadLine();
        }
    }
}
