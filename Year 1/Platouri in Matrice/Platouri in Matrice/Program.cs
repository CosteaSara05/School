using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platouri_in_Matrice
{
    class Program
    {
        public static int n;
        static void Main(string[] args)
        {
            int t;
            int d;
            int max = 0;
            Random r = new Random();
            n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    //Console.WriteLine("v[{0},{1}]", i, j);
                    a[i, j] = r.Next(9);
                    //v[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(a[i, j] + " ");
                Console.WriteLine();
            }

            bool[,] b = new bool[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    b[i, j] = false;

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    t = a[i, j];
                    d = 0;
                    rec( t, ref d, ref a, ref b, i, j);
                    if (d > max)
                        max = d;
                }
            Console.WriteLine();
            Console.WriteLine("Cel mai mare platou este de dimensiune: " + max);

            Console.ReadKey();
        }
        static void rec(int t, ref int d, ref int[,] a, ref bool[,] b, int i, int j)
        {
            if ((i >= 0) && (i < n) && (j >= 0) && (j < n) && (b[i, j] == false) && (a[i, j] == t))
            {
                //Console.WriteLine(a[i, j]);
                b[i, j] = true;
                d++;
                rec( t, ref d, ref a, ref b, i - 1, j);
                rec( t, ref d, ref a, ref b, i + 1, j);
                rec( t, ref  d, ref a, ref b, i, j - 1);
                rec( t, ref d, ref a, ref b, i, j + 1);
            }

        }
    }
}
