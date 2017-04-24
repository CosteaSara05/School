using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iesire_din_matrice
{
    class Program
    {
        public static int d;
        public static int n;
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("Dimensiunea matricei: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    a[i, j] = r.Next(0, 2);
            int t;
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

            Console.WriteLine("Iesire de la indicii: ");
            int g = Convert.ToInt32(Console.ReadLine());
            int f = Convert.ToInt32(Console.ReadLine());

                    t = a[g, f];
                    d = 0;
                    iesire(ref t, ref a, ref b, 0, g, f);
                
            Console.WriteLine(d != 0 ? "Exista iesire." : "Nu exista iesire");
            Console.ReadKey();
        }

        private static void iesire(ref int t, ref int[,] a, ref bool[,] b, int v, int i, int j)
        {
            while ((i >= 0) && (i < n) && (j >= 0) && (j < n) && (b[i, j] == false) && (t == a[i, j]))
            {
                Console.WriteLine(a[i, j]);
                b[i, j] = true;
                if ((v == i) && (t ==a[0, j]))
                    d++;
                else
                {
                    iesire(ref t, ref a, ref b, 0, i - 1, j);
                    iesire(ref t, ref a, ref b, 0, i + 1, j);
                    iesire(ref t, ref a, ref b, 0, i, j - 1);
                    iesire(ref t, ref a, ref b, 0, i, j + 1);
                }
            }
        }
    }
}
