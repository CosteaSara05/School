using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_strangeri_de_mana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdu numarul de oameni: ");
            int n = 0, o = Int32.Parse(Console.ReadLine()), o1 = o - 1;
            if (o != 1 && o != 0)
            {
                while (o1 != 0)
                {
                    n += o1;
                    o1 -= 1;
                }
                Console.WriteLine("{0} oameni dau mana intre ei, in total fiind {1} strangeri de maini", o, n);
            }
                Console.ReadKey();
        }
    }
}
