using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What you want to do? [C]lear. [S]ee Resources. ");
            char what = Convert.ToChar(Console.ReadLine());
            if (what == 's' || what == 'S')
                Decision.SeeResourses();
            if (what == 'c' || what == 'C')
                Decision.ClearScreen();

            Console.ReadKey();
        }
    }
}
