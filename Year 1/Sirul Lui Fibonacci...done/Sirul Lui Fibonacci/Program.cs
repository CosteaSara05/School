using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Sirul_Lui_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int p;
            float a = 0, b = 1, x, i;
            Console.WriteLine("Introduceti Pozitia: ");
            p = Convert.ToInt32(Console.ReadLine());
            int[] v = new int[p];
            Stopwatch sw = new Stopwatch();
            sw.Start();
            if (a == 0 && b == 1)
            {
                for (i = 0; i < v.Length; i++)
                {
                    x = a + b;
                    a = b;
                    b = x;
                }
            }
            sw.Stop();
            if (p == 0) Console.WriteLine("Numarul de pe pozitia {0} este: {1}", p, a);
            else Console.WriteLine("Numarul de pe pozitia {0} este: {1}", p, b);
            Console.WriteLine("Elapsed Time: {0}", sw.Elapsed);
            
            Console.ReadKey();
        }
    }
}
