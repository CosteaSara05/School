using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Compilation
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Numarul de elemente din multimea A: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Numarul de elemente din multimea B: ");
            b = Int32.Parse(Console.ReadLine());
            int[] x = new int[a];
            int[] y = new int[b];
            Console.WriteLine("Prima multime");
            for (int i = 0; i < a; i++)
            {
                Console.Write("1.{0} = ", i + 1);
                x[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("A doua multime");
            for (int i = 0; i < b; i++)
            {
                Console.Write("2.{0} = ", i + 1);
                y[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Intersectia lor este: ");
            int k = 0;
            int[] intersectie = new int[(a < b) ? a : b];
            for (int i = 0; i < a; i++)
                for (int j = 0; j < b; j++)
                    if (x[i] == y[j])
                    {
                        intersectie[k++] = x[i];
                        break;
                    }
            for (int i = 0; i < k; i++)
                if(k != 0)
            Console.Write("{0} ", intersectie[i]);
            if(k == 0)
                Console.Write("Multimea vida");
            Console.WriteLine();

            Console.WriteLine("Reuniunea lor este: ");
            k = 0;
            int[] reuniune = new int[a + b];
            for (int i = 0; i < a; i++)
            {
                reuniune[k++] = x[i];
            }
            for (int j = 0; j < b; j++)
            {
                reuniune[k++] = y[j];
            }
            for (int i = 0; i < k; i++)
            if (k != 0)
                Console.Write("{0} ", reuniune[i]);
            if (k == 0)
                Console.Write("Multimea vida");
            Console.WriteLine();

            Console.WriteLine("A - B: ");
            k = 0;
            bool ok = true;
            int[] adb = new int[a];
            for (int i = 0; i < a; i++)
                {     ok = true;
                for (int j = 0; j < b; j++)
                    if (x[i] == y[j])
                    {
                        ok = false;
                        break;
                    }
                    if (ok == true) adb[k++] = x[i];
                }   

            for (int i = 0; i < k; i++) Console.Write("{0} ",adb[i]);
                if (k == 0) Console.Write("Multimea vida");
            Console.WriteLine();

            Console.WriteLine("B - A: ");
            k = 0;
            ok = true;
            int[] bda = new int[b];
            for (int i = 0; i < b; i++)
            {
                ok = true;
                for (int j = 0; j < a; j++)
                    if (y[i] == x[j])
                    {
                        ok = false;
                        break;
                    }
                    if (ok == true) bda[k++] = y[i];
            }

            for (int i = 0; i < k; i++) Console.Write("{0} ", bda[i]);
                if (k == 0) Console.Write("Multimea vida");
            Console.WriteLine();

            Console.WriteLine("Produs cartezian: ");
            for (int i = 0; i < x.Length; i++)
                for (int j = 0; j < y.Length; j++)
                    Console.Write("({0},{1}) ", x[i], y[j]);

            Console.ReadKey();
        }
    }
}
