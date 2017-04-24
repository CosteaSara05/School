using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordoneaza_crescator_din_2_siruri
{
    class Program
    {
        static void Main(string[] args)
        {
            //se citesc 2 siruri de nr ordonate crescator. formeaza un al 3-lea sir din elementele celor 2 astfel incat sirul rezultat
            //sa fie tot crescator
            int i, j, n, m, k;
            Console.Write("Dimensiunea sirului A este:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.Write("Dimensiunea sirului B este:");
            m = Convert.ToInt32(Console.ReadLine());
            int[] b = new int[m];
            int[] c = new int[n + m];
            for (i = 0; i < a.Length; i++)
            {
                Console.Write("a[{0}]=", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            for (j = 0; j < b.Length; j++)
            {
                Console.Write("b[{0}]=", j);
                b[j] = int.Parse(Console.ReadLine());
            }
            i = j = k = 0;
            while (i < n && j < m)
            {
                if (a[i] < b[j]) c[k++] = a[i++];
                else c[k++] = b[j++];
            }
            while (i < n)
            {
                c[k++] = a[i++];
            }
            while (j < m)
            {
                c[k++] = b[j++];
            }

            for (k = 0; k < a.Length + b.Length; k++)
                Console.WriteLine("c[{0}]={1}", k, c[k]);
            Console.ReadKey();
        }
    }
}
