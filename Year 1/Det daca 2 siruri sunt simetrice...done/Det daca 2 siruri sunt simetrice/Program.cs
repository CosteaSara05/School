using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Det_daca_2_siruri_sunt_simetrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n, m, k;
            Console.WriteLine("Introduceti numarul elementelor din primul sir:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduceti elementele primului sir.");
            int[] sir1 = new int[n];
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} = ", i);
                sir1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Introduceti numarul elementelor din al doilea sir:");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introducti elementele celui de-al doilea sir.");
            int[] sir2 = new int[m];
            for (i = 0; i < m; i++)
            {
                Console.Write("{0} = ", i);
                sir2[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] sir3 = new int[n + m];
            for (i = j = k = 0; i < n && j < m;)
                if (sir1[i] < sir2[j])
                    sir3[k++] = sir1[i++];
                else
                    sir3[k++] = sir2[j++];
            for (; i < n;)
                sir3[k++] = sir1[i++];
            for (; j < m;)
                sir3[k++] = sir2[j++];

            Console.WriteLine("Elementele sirului rezultat sunt:");
            for (i = 0; i < m + n; i++)
                Console.Write("{0} ", sir3[i]);


            Console.ReadKey();
        }
    }
}
