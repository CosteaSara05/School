using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazele
{
    class Program
    {
        static void Main(string[] args)
        {
            //din baza 10 in baza 16.
            int i = 0;
            Console.Write("Introduceti numarul in baza 10:");
            int b = Convert.ToInt32(Console.ReadLine());
            int n = b;
            Console.Write("In baza 16: ");
            int[] v = new int[64];
            char [] alf = { 'A','B','C','D','E','F' };
            //pentru a determina un caracter in ascii
            //char chr = 'A';
            //int aux = chr;
            //Console.WriteLine(aux);
            if (n == 0)
            {
                v[0] = 0;
                i++;
            }
            while (n > 0)
            {
                v[i] = n % 16;
                n /= 16;
                i++;
            }
            for (int j = i - 1; j >= 0; j--)
            {
                if (v[j] < 10)
                    Console.Write(v[j]);
                else
                    Console.Write(alf[v[j] - 10]);
                
            }
            Console.WriteLine();
            Console.Write("In baza 36: ");
            char[] alf2 = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            int f = b;
            i = 0;
            if (f == 0)
            {
                alf2[0] = '0';
            }
            while (f > 0)
            {
                v[i] = f % 36;
                f /= 36;
                i++;
            }
            for (int j = i - 1; j >= 0; j--)
                    Console.Write(alf2[v[j]]);

            //din baza 10 in baza 2.
            int x = b;
            i = 0;
            Console.WriteLine();
            Console.Write("In baza 2 : ");
            if (x == 0)
            {
                v[0] = 0;
                i++;
            }
            while (x > 0)
            {
                v[i] = x % 2;
                x /= 2;
                i++;
            }
            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write("{0}", v[j]);
            }
            Console.WriteLine();
            //numarul in baza 8 este
            Console.Write("In baza 8 : ");
            int o = b;
            i = 0;
            if (o == 0)
            {
                v[0] = 0;
                i++;
            }
            while (o > 0)
            {
                v[i] = o % 8;
                o /= 8;
                i++;
            }
            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write(v[j]);
            }


                Console.ReadKey();
        }
    }
}
