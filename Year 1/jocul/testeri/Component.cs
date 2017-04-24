using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeri
{
    class Magazie
    {
        public static int marime = 100;
    }
    class Resurse
    {
        public static int productie = 0;
        public static int Timeout = 3000;

        public static void Resursa()
        {
            if (Resurse.productie < Magazie.marime - 1)
                while (Resurse.productie < Magazie.marime)
                {
                    Resurse.productie++;
                    System.Threading.Thread.SpinWait(Resurse.Timeout);
                    Console.WriteLine("{0}", Resurse.productie);
                }
        }
    }
    class Decision
    {
        public static void SeeResourses()
        {
            Console.WriteLine(Resurse.productie);
        }
        public static void ClearScreen()
        {
            Console.Clear();
        }
    }

}
