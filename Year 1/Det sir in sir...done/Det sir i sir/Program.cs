using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Det_sir_i_sir
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b;
            Console.Write("Primul sir:");
            a = Console.ReadLine();
            Console.Write("Al doilea sir:");
            b = Console.ReadLine();

            int ok = 0;

            for (int i = 0; i <= a.Length - b.Length; i++)
            {
                if (a[i] == b[0])
                {
                    ok = 1;
                    for (int j = 1; j <= b.Length; j++)
                    {
                        if (b[j] != a[i + j])
                        {
                            ok = 0;
                            break;
                        }
                        if (ok == 1) Console.WriteLine("Subsirul incepe la pozitia {0}", i);
                        break;
                    }
                }
            }
            if (ok == 0) Console.WriteLine("Subsirul nu este in sir.");
            Console.ReadKey();
        }
        
    }
}
