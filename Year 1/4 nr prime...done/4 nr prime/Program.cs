using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_nr_prime
{
    class Program
    {
        static void Main(string[] args)
        {   //aflam 4 numere prime dupa n 
            int x, a, b, c, d;
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numerele prime dupa {0} sunt: ", x);
            
            a = Calculation(x);
            Console.Write("{0} ", a);
            x = a;
            b = Calculation(x);
            Console.Write("{0} ", b);
            x = b;
            c = Calculation(x);
            x = c;
            Console.Write("{0} ", c);
            d = Calculation(x);
            Console.Write("{0} ", d);

            Console.ReadKey();
        }

        private static int Calculation(int x)
        {
            while (true)
            {
                bool isPrime = true;
                    x++;
                int sq = (int)Math.Sqrt(x);
                for (int i = 2; i <= sq; i++)
                {
                    if (x % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime)
                    return x;
            }
        }
    }
}
