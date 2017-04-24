using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentele_programarii_1
{
    class Util
    {
        private static int ExtractInt()
        {
            Console.WriteLine("Introdu numarul: ");
            string line;
            line = Console.ReadLine();
            int n = 0;

            try
            {
                n = Int32.Parse(line);
            }
            catch (Exception)
            {
                Console.WriteLine("Oops! Sorry, something went wrong.");
            }
            return n;
        }
    }
}

