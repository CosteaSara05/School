using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suma_a_4_cifre_dintr_un_sir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul:");
            int c = 0, sum = 0, u = 0, n = Convert.ToInt32(Console.ReadLine()), n1 = n;

            while (n1 != 0)
            {
                c += 1;
                n1 /= 10;
            }

            int[] v = new int[c];
            for (int i = 0; i < c; i++)
            {
                u = n % 10;
                sum += u;
                n /= 10;
            }

            Console.WriteLine("Suma cifrelor numarului este {0}", sum);

            Console.ReadKey();
        }
    }
}
