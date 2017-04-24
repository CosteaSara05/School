using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_de_parietate
{
    class Program
    {
        private static object int32;

        static void Main(string[] args)
        {
            Console.WriteLine("Test de paritate");
            P1();
            last();
        }

        public static void P1()
        {
            int n = 0;

            n = ExtractInt();

            if (n % 2 == 0)
            {
                Console.WriteLine("Numarul {0} este par.", n);
            }
            else
            {
                Console.WriteLine("Numarul {0} este impar.", n);
            }
        }

        public static int ExtractInt()
        {
            int n = 0;

            Console.WriteLine("Adauga numarul: ");

            string line;

            line = Console.ReadLine();

            n = int.Parse(line);

            return n;

        }
        public static void last()
        {
            string last;
            last = Console.ReadLine();
        }
    }
}
