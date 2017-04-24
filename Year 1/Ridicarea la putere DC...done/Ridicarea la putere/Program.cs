using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ridicarea_la_putere
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numarul care doriti sa il ridicati la putere: ");
            ulong n = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("Exponentul numarului: ");
            ulong e = Convert.ToUInt64(Console.ReadLine());

            Console.WriteLine("Rezultatul: " + putere(n, e));
            Console.ReadKey();
        }

        private static ulong putere(ulong n, ulong e)
        {
            if (e == 0)
                return 1;
            else
                return n * putere(n, e - 1);

        }
    }
}
