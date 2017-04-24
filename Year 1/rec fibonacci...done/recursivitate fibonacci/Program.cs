using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursivitate_fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti pozitia pana la care sa se genereze sirul: ");
            int p = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sirul la pozitia " + p + " este:");
            Console.WriteLine("Loading...");
            Console.WriteLine(fibonacci(p));

            Console.ReadKey();
            
                
        }

        private static ulong fibonacci(int p)
        {
            if (p == 0)
                return 0;

            if (p == 1)
                return 1;

            return fibonacci(p - 1) + fibonacci(p - 2);

        }
    }
}
