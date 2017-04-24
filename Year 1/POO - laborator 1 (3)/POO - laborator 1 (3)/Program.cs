using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___laborator_1__3_
{
    class Program
    {
        static void Main(string[] args)
        {
            //se dau 2 puncte in plan. Construiti functiile pentru 2 puncte.
            //distanta dintre cele 2 puncte.
            //mijlocul segmentului de dreapta.
            //aria segmentului format de cele 3 puncte.
            //centru de greutate al celor 3 puncte.

            Point A = new Point();
            Point B = new Point();
            Point Mij = new Point();
            A.x = float.Parse(Console.ReadLine());
            A.y = float.Parse(Console.ReadLine());
            B.x = float.Parse(Console.ReadLine());
            B.y = float.Parse(Console.ReadLine());

            Console.WriteLine(d(A, B));//distanta
            Console.WriteLine(M(A, B));//mijlocul
            Console.WriteLine();//
            Console.ReadKey();

        }
        static Point M(Point A, Point B)
        {

             = (A.x + B.x) / 2;
            M. = (A.y + B.y) / 2;
            
            
            return ;

        }
        static float d (Point A, Point B)
        {
            float d = (float)Math.Pow((A.x - B.x), 2) + (float)Math.Pow((A.y - B.y), 2);
            d = (float)Math.Sqrt(d);
            return d;
        }
    }
}
