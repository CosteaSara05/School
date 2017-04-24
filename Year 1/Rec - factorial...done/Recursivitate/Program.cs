using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursivitate
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 1)
                Console.WriteLine("Nu se poate face factorial");

            else
                Console.WriteLine("Factorialul este: " + factorial(n));

            Console.ReadKey();
        }

        private static int factorial(int n)
        {
            int t = n;

            if (n <= 1)
                return 1;

            if (n > 0)
               t = n * factorial(n - 1);
            return t;
        }
    }
}
