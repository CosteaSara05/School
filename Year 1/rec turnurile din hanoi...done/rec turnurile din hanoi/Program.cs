using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rec_turnurile_din_hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cate dreptunghiuri introduceti: ");
            int n = Convert.ToInt32(Console.ReadLine());
            h(n, 'A', 'B', 'C');

            Console.ReadKey();

        }

        private static void h(int n, char A, char B, char C)
        {
            if (n == 1)
                Console.WriteLine("{0} -> {1}", A, C);
            else
            {
                h(n - 1, A, C, B);
                h(1, A, B, C);
                h(n - 1, B, A, C);
            }

        }
    }
}
