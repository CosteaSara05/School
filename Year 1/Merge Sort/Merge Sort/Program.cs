using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Sort
{
    class Program
    {

        static void view(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write("{0} ", a[i]);
            Console.WriteLine();
        }
        static Random r = new Random();
        static void Main(string[] args)
        {
            
            int n = Convert.ToInt32(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = Convert.ToInt32(Console.ReadLine());
            int[] v3 = new int[n];
            v3 = merge(v, 0, n - 1);

            for (int i = 0; i < n; i++)
                Console.Write(v3[i] + " ");
            
            Console.ReadKey();
        }

        private static int[] merge(int[] v, int s, int d)
        {
            if (s < d)
            {
                int[] v1 = merge(v, s, (s + d) / 2);
                int[] v2 = merge(v, (s + d) / 2 + 1, d);
                return interclasare(v1, v2);
            }
            return new int[] {v[s]};



        }

        private static int[] interclasare( int[] v1, int[] v2)
        {
            int k1 = 0, k2 = 0, k3 = 0, n1 = v1.Length, n2 = v2.Length;
            int[] v3 = new int[n1 + n2];
            do
            {
                if (v1[k1] < v2[k2])
                {
                    v3[k3] = v1[k1];
                    k1++;
                    k3++;
                }
                else
                {
                    v3[k3] = v2[k2];
                    k2++;
                    k3++;
                }
            } while ((k1 < n1) && (k2 < n2));

            while (k1 < n1)
            {
                v3[k3] = v1[k1];
                k1++;
                k3++;
            }
            while (k2 < n2)
            {
                v3[k3] = v2[k2];
                k2++;
                k3++;
            }

            return v3;
        }
    }
}
