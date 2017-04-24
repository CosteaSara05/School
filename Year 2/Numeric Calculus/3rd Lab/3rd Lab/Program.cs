using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_Lab
{
    class Program
    {
        //algoritmul spline patratic
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] x = new double[n];
            double[] y = new double[n];
            Console.Write("z = ");
            double z = Convert.ToDouble(Console.ReadLine()), s;
            double[] h = new double[n];
            double[] m = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("x[{0}] = ",i);
                x[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("y[{0}] = ", i);
                y[i] = Convert.ToDouble(Console.ReadLine());
            }

            //2
            for (int i = 1; i < n; i++)
                h[i] = x[i] - x[i - 1];
            //3
            m[0] = (1 / 2 * h[1]) * (-3 * y[0] + 4 * y[1] - y[2]);
            //4
            for (int i = 1; i < n; i++)
                m[i] = -m[i - 1] + (2 / h[i]) * (y[i] - y[i - 1]);
            //5
            for (int i = 1; i < n; i++)
                if (x[i - 1] <= z && z <= x[i])
                    s = (m[i] - m[i - 1]) * (z - x[i - 1]) * (z - x[i - 1]) * (1 / 2 * h[i]) + m[(i - 1)] * (z - x[i - 1]) + y[i - 1];
            //x 0   3   6   8.5 11  14  16.5    19
            //y 80  86  95  83  102 90  97      81
        }
    }
}
