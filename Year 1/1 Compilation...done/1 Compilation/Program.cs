using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tester_si_minuni
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("suma secventa");
            //P1();
            //Console.WriteLine("cal mai mare numar");
            //P2();
            //Console.WriteLine("Secventa crescatoare");
            //P3();
            
            Console.ReadKey();
            
        }

        private static void P3()
        {
            int min, c = 0, m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int[] v = new int[m];
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = n % 10;
                n /= 10;
            }
            for (int i = m - 1 ; i > 1; i--)
                for (int j = i - 1; j > 0; j--)
                {
                    min = v[i];
                    if (min < v[j])
                        min = v[j];
                    else
                        c++;
                }
            if (c > 0)
                Console.WriteLine("Secventa nu este crescatoare.");
            if(c == 0)
                Console.WriteLine("Secventa este crescatoare.");
        }

        private static void P2()
        {
            int n, max = int.MinValue;

            do
            {
                n = ExtractInt();
                if (n != 0)
                {
                    if (n > 0)
                    {
                        max = n;
                    }
                }
            }
            while (n != 0);
            Console.WriteLine("cel mai mare numar este {0}", max);
        }

        private static void P1()
        {
            int n, suma = 0;
            do
            {
                n = ExtractInt();
                if (n != 0)
                {
                    suma = suma + n;
                }
            }
            while (n != 0);
            Console.WriteLine("{0}", suma);
        }
        private static int ExtractInt()
        {
            Console.WriteLine("Introduceti numarul");
            string line;
            line = Console.ReadLine();
            int n = 0;

            try
            {
                n = Int32.Parse(line);
            }
            catch (Exception)
            {
                Console.WriteLine("OOps something went wrong...that's embarasing!!");
            }
            return n;
        }
    }
}
