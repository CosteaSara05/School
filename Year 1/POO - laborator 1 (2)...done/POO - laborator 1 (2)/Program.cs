using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___laborator_1__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            cplx A = new cplx();
            cplx B = new cplx();
            A.a = float.Parse(Console.ReadLine());
            A.b = float.Parse(Console.ReadLine());
            B.a = float.Parse(Console.ReadLine());
            B.b = float.Parse(Console.ReadLine());
            cplx C = sum(A, B);
            cplx D = pro(A, B);
            //cplx C = new cplx();
            //C.a = A.a + B.a;
            //C.b = A.b + B.b;
            //cplx D = new cplx();
            //D.a = A.a * B.a;
            //D.b = A.b * B.b;
            Console.WriteLine("{0} + {1} = {2}", A.view(), B.view(), C.view());
            Console.WriteLine("{0} * {1} = {2}", A.view(), B.view(), D.view());
            Console.ReadKey();
        }
        static cplx sum(cplx A, cplx B)
        {
            cplx toR = new cplx();
            toR.a = A.a + B.a;
            toR.b = A.b + B.b;
            return toR;
        }
        static cplx pro(cplx A, cplx B)
        {
            cplx toR = new cplx();
            toR.a = A.a * B.a;
            toR.b = A.b * B.b;
            return toR;
        }
    }
}
