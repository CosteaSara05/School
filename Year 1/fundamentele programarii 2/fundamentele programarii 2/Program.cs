using System;
using System.Collections.Generic;

namespace fundamentele_programarii_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v;

            int n;

            n = Util.ExtractInt("introduceti dimensiunea vectorului");

            v = new int[n]; // toate elementele se initializeaza la 0.


            //initializare explicita.
            Random rnd = new Random();
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = rnd.Next(100);
            }
            PrintArray(v, " Elementele generate: ");

            //Array.Sort(v);
            Util.SelectionSort(v);
            Util.InsertionSort();
            PrintArray(v, " Elementele dupa sortare: ");


            foreach (var item in v)
            {
                Console.Write("vectorul generat:");
            }

            Console.ReadKey();
        }
            private static void PrintArray(int[] v, string s)
        {
            Console.WriteLine(s);
            foreach (var item in v)
            {
                Console.Write(item);
            }
        }
        }
    }

