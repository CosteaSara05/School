using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentele_programarii_Laborator_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a, b;
            int n, m, k;
            Console.WriteLine("Scrie gradul poligonului 1: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Scrie gradul poligonului 2: ");
            m = Convert.ToInt32(Console.ReadLine());
            a = new int[n + 1];
            b = new int[m + 1];
            for (int i = n; i >= 0; i--)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = m; i >= 0; i--)
            {
                Console.Write("b[{0}] = ", i);
                b[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] suma = new int[((m < n) ? n : m) + 1];
            for (int i = 0; i <= n; i++)
                suma[i] = a[i];
            for (int i = 0; i <= m; i++)
                suma[i] += b[i];
            for (int i = n; i > 0; i--)
                if (suma[i] != 0)
                {
                    Console.Write("{0}*x^{1} + ", suma[i], i);
                }
            Console.WriteLine(suma[0]);

            int[] produs = new int[n + m + 1];
            for (int i = 0; i <= n; i++)
                for (int j = 0; j <= m; j++)
                    produs[i + j] += a[i] * b[i];
            for (int i = m + n; i >0; i--)
                if (produs[i] != 0)
                {
                    Console.Write("{0}*x^{1} + ", produs[i], i);
                }
            Console.WriteLine(produs[0]);
            Console.ReadKey();


        }
    }
}
