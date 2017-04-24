using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duloc
{
    class Program
    {
        static void Main(string[] args)
        {
            // =p1= din baza 10 in baza 2.
            // =p2= se da un sir de n nr intregi sa se afiseze sirul in secventa 0 - n, 1 - n-1.
            // =p3= det daca un sir este simetric.
            // =p4= det daca un sir este format doar din nr pare.
            // =p5= det daca un sir este format doar din divizori ai unui nr citit x.
            // =p6= n de la tastatura, se va stoca intr-un sir de nr format din cifrele lui.
            //      avand un sir de cifre sa se formeze numarul.

            p1();
            p2(); // nu merge decat cu sir par.
            p3();
            p4();
            p5();
            p6();

            Console.ReadKey();

        }

        private static void p6()
        {
            Console.WriteLine("n de la tastatura, se va stoca intr-un sir de nr format din cifrele lui, avand un sir de cifre sa se formeze numarul.");
            Console.WriteLine("Numarul este: ");
            int a = Convert.ToInt32(Console.ReadLine());
            short[] cifre = new short[10];
            int x = 0;
            while (a > 0)
            {
                cifre[x++] = (short)(a % 10);
                a = a / 10;
            }
            int nrcifre = x;
            for (x = nrcifre - 1; x >= 0; x--)
            {
                Console.Write("{0} ", cifre[x]);
            }
        }

        private static void p5()
        {
            Console.WriteLine("det daca un sir este format doar din divizori ai unui nr citit x.");
            Console.WriteLine("Lungimea sirului: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] n = new int[a];
            Console.WriteLine("Divizorul este: ");
            int x = Convert.ToInt32(Console.ReadLine());
            bool ok = true;
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("n[{0}] = ", i);
                n[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < a; i++)
            {
                if (n[i] % x != 0)
                {
                    ok = false;
                    break;
                }

            }
            if (ok == false)
            {
                Console.WriteLine("Nu este divizibil cu x");
            }
            else
            {
                Console.WriteLine("Este divizibil cu x");
            }
        }


        private static void p4()
        {
            Console.WriteLine("det daca un sir este format doar din nr pare.");
            Console.WriteLine("Lungimea sirului ");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] n = new int[a];
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("n[{0}] = ", i);
                n[i] = Convert.ToInt32(Console.ReadLine());
            }
            bool ok = true;
            for (int i = 0; i < a; i++)
            {
                if (n[i] % 2 == 1)
                {
                    ok = false;
                    break;
                }

            }
            if (ok == false)
            {
                Console.WriteLine("Sirul are un numar impar.");


            }
            else
            {
                Console.WriteLine("Sirul este format din numere pare.");
            }
        }

        private static void p3()
        {
            Console.WriteLine("det daca un sir este simetric.");
            int n;
            bool ok = true;
            Console.WriteLine("Lungimea sirului:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("v[{0}] = ", i);
                v[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (v[i] == v[n - 1 - i])
                {
                    ok = false;
                    break;
                }
            }
            Console.WriteLine("Sirul{0}este Simetric", (ok == false) ? " " : " nu ");

        }

        private static void p2()
        {
            Console.WriteLine("se da un sir de n nr intregi sa se afiseze sirul in secventa 0 - n, 1 - n-1.");
            Console.WriteLine("Lungimea sirului: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduceti numarul: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = n;
            int[] v = new int[k];
            for (int i = 0; i < k; i++)
            {
                int nc = m % 10;
                m = m / 10;
                v[i] = nc;
            }
            for (int i = 0; i < k / 2; i++)
            {
                Console.Write("{0}{1} ", v[k - 1 - i], v[i]);
            }
            
        }

        private static void p1()
        {
            Console.WriteLine("din baza 10 in baza 2.");
            int i = 0;
            Console.WriteLine("Introduceti numarul in baza 10.");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numarul in baza 2 este: ");
            int[] v = new int[62];
            while (n != 0)
            {
                v[i] = n % 2;
                n = n / 2;
                i++;
            }

            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write("{0}", v[j]);
            }
        }
    }
}