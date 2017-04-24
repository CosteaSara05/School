using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmul_lui_Euclid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cel mai mare divizor comun a 2 numere.");
            P1();
            Console.ReadKey();
        }

        private static void P1()
        {
            int a, b, r, ca, cb;
            a = ExtractInt();
            b = ExtractInt();
            ca = a;
            cb = b;
            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            if (a == 0)
            {
            Console.WriteLine("Cel mai mare divizor comun al numarului {0} si {1}, nu exista.", ca, cb);
            }
            else
            Console.WriteLine("Cel mai mare divizor comun al numarului {0} si {1}, este {2}.",ca ,cb ,a);
        }
        private static int ExtractInt()
        {
            Console.WriteLine("Introdu numarul: ");
            string line = Console.ReadLine();
            int n = 0;

            try
            {
                n = Int32.Parse(line);
            }
            catch(Exception)
            {
                Console.WriteLine("Oops! Sorry, something went wrong.");
            }
            return n;
        }
    }
}
