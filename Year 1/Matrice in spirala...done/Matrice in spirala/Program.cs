using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrice_in_spirala
{
    class Program
    {
        static void Main(string[] args)
        {
            int l;
            Console.Write("l= ");
            l = Int32.Parse(Console.ReadLine());
            
                int[,] M = new int[l, l];
                int cons = 0;
                int x = 0;
                while ((l / 2) > cons)
                {
                    for (int i = cons; i < l - cons - 1; i++)
                        M[cons, i] = x++;
                    for (int i = cons; i < l - cons - 1; i++)
                        M[i, l - cons - 1] = x++;
                    for (int i = l - cons - 1; i > cons; i--)
                        M[l - cons - 1, i] = x++;
                    for (int i = l - cons - 1; i > cons; i--)
                        M[i, cons] = x++;
                    cons++;
            }
                if (l % 2 == 1) M[l / 2, l / 2] = l * l - 1;
                for (int i = 0; i < l; i++)
                {
                    for (int j = 0; j < l; j++)
                    {
                        Console.Write("{0} ", M[i, j]);
                    }
                    Console.WriteLine();
                }
            
            Console.ReadKey();
        }
    }
}
