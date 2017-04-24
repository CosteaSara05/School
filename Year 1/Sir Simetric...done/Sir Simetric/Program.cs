using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sir_Simetric
{
    class Program
    {
        static void Main(string[] args)
        {
            int l, n, i;
            bool ok = true;

            Console.Write("Lungimea sirului = ");
            n = Convert.ToInt32(Console.ReadLine()); 
            int[] sir = new int[n];
            for (i = 0; i < n; i++)
            {
                Console.Write("sir[{0}]= ", i);
                sir[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                if (sir[i] == sir[n - 1 - i])
                {
                    ok = false;
                    break;
                }
            }
                Console.WriteLine("Sirul{0}e Simetric",(ok == false) ?" ":" nu ");

            Console.ReadKey();
        }
    }
}
