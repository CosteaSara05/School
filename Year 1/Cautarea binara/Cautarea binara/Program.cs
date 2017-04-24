using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cautarea_binara
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Numarul pe care il cautati: ");
            int x = Convert.ToInt32(Console.ReadLine());

            bs(v, x, 0, n - 1);

            Console.WriteLine(bs(v, x, s, d) == true ? "Numarul {0} exista." : "Numarul {0} nu exista.", x);

            Console.ReadKey();

        }

        private static bool bs(int[] v, int x, int s, int d)
        {
            Console.Write(s + "" + d + " ");

            if (s <= d)
            {
                if (x < v[(s + d) / 2])
                    return bs(v, x, s, (s + d) / 2 - 1);
                else if (x > v[(s + d) / 2])
                    return bs(v, x, (s + d) / 2 + 1, d);
                else
                    return true;
            }
            else
                return false;
        }
    }
}
