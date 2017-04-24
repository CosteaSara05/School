using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2__Teritorii_1_si_2
{
    class Program
    {
        static int n = 15;
        static int[,] a = new int[n, n];
        static bool[,] b = new bool[n, n];
        static int[] v = new int[3];
        static int d = 0;
        static Random r = new Random();


        static void Main(string[] args)
        {
            int nrv1 = 0;
            int nrv2 = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    b[i, j] = false;
                }
            }
            //TextReader dl = new StreamReader(@"../../Resurse/matrice.txt");

            //string t = dl.ReadLine();
            //string[] p;
            //int l = 0, c = 0;


            //while (t != null)
            //{
            //    p = t.Split(' ');
            //    foreach (var item in p)
            //    {
            //        if (c < n)
            //        {
            //            a[l, c] = int.Parse(item);
            //            c++;
            //        }

            //    }
            //    l++;
            //    c = 0;
            //    t = dl.ReadLine();
            //}
            //dl.Close();

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    a[i,j] = r.Next(3);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {

                    v[1] = 0;
                    v[2] = 0;
                    d = 0;
                    rec(i, j);
                    if (v[1] != 0 && v[2] == 0)
                        nrv1 += d;
                    else
                        if (v[1] == 0 && v[2] != 0)
                            nrv2 += d;
                  

                }
            Console.WriteLine("Numarul teritoriilor lui 1 este:{0}, iar numarul teritoriilor lui 2 este:{1} ",nrv1,nrv2);
            
            Console.ReadKey();
        }
        private static void rec(int i, int j)
        {
            if (i >= 0 && j >= 0 && i < n && j < n && b[i, j] == false && a[i, j] == 0)
            {
               
                b[i, j] = true;
                d++;
                vecini(i, j);
                rec(i - 1, j);
                rec(i + 1, j);
                rec(i, j - 1);
                rec(i, j + 1);
            }
            
        }

        private static void vecini(int i, int j)
        {
            if (i >= 1)
                v[a[i - 1, j]]++;
            if (i < n - 1)
                v[a[i + 1, j]]++;
            if (j >= 1)
                v[a[i, j - 1]]++;
            if (j < n - 1)
                v[a[i, j + 1]]++;



        }
    }
}
