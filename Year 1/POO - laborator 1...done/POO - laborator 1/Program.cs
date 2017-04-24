using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___laborator_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //se dau 2 numere complexe. Sa afiseze suma.
            float a1 = float.Parse(Console.ReadLine());
            float a2 = float.Parse(Console.ReadLine());
            float b1 = float.Parse(Console.ReadLine());
            float b2 = float.Parse(Console.ReadLine());
            float a3 = a1 + a2;
            float b3 = b1 + b2;
            float a4 = a1 * a2 - b1 * b2;
            float b4 = a1 * b2 + b1 * a2;
            Console.WriteLine("( {0} + {1} )i + ( {2} + {3} )i = ({4} + {5} )i", a1, b1, a2, b2, a3, b3);
            Console.WriteLine("( {0} + {1} )i * ( {2} + {3} )i = ({4} * {5} )i", a1, b1, a2, b2, a3, b3);
            Console.ReadKey();

        }
    }
}
