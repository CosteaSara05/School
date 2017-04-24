using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentele_programarii_2
{
    class Util
    {
        private static int ExtractInt()
        {
            Console.WriteLine("Introdu numarul: ");
            string line = Console.ReadLine();
            int n = 0;
            try
            {
                n = Int32.Parse(line);
            }
            catch (Exception)
            {
                Console.WriteLine("Oops! Sorry, something went wrong.");
            }
            return n;
        }

        internal static void SelectionSort(int[] v)
        {
            int iMin, aux;
            for (int i = 0; i < v.Length; i++)
            {
                iMin = i;
                for (int j = i + 1; j < v.Length; j++)
                {
                    if (v[j] < v[iMin])
                    {
                        iMin = j;
                    }
                    if (iMin != i)
                    {
                        aux = v[iMin];
                        v[iMin] = v[i];
                        v[i] = aux;
                    }
                }
            }
        }
        private static int Swap(int aux)
        {
            aux = v[iMin];
            v[iMin] = v[i];
            v[i] = aux;
            return aux;
        }
        internal static void InsertionSort(int[] v)
        {
            int j;
            for (int i = 0; i < v.Length; i++)
            {
                j = i;
                while (j > 0 && v[j] < v[j - 1])
                {
                    Swap(v, j - 1, j);
                    j--;
                }

                
            }
        }

        /// <summary>
        /// Extrage un numar intreg de la tastatura
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static int ExtractInt(string p)
        
        {
            Console.WriteLine("Introduceti un numar intreg:");
            string line;
            line = Console.ReadLine();
            int n = 0;

            try
            {
                n = Int32.Parse(line);
            }
            catch (Exception)
            {
                Console.WriteLine("Oops! Sorry, something went wrong.");
            }
            return n;
        }
    }
    }

