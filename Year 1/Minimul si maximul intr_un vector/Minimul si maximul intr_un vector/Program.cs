using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimul_si_maximul_intr_un_vector
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int n = Convert.ToInt32(Console.ReadLine());
            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                v[i] = r.Next(1000);
                Console.Write(v[i] + " ");
            }
            int min = int.MaxValue;
            int max = int.MinValue;

            minmax(v, 0, n - 1, out min, out max);
            Console.WriteLine();
            Console.WriteLine(min);
            Console.WriteLine(max);

            Console.ReadKey();
        }

        static void minmax(int[] v, int s, int d, out int min, out int max)
        {
            if (s == d) min = max = v[s];
            else
            {
                int a, b, x, y;
                minmax(v, s, (s + d) / 2, out a, out x);
                minmax(v, (s + d) / 2 + 1, d, out b, out y);
                if (a < b) min = a;
                else min = b;
                if (x > y) max = x;
                else max = y;
            }
        }
        
    }
}
