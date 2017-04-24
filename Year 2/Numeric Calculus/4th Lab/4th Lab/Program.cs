using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4th_Lab
{
    class Program
    {
		//algoritmul lui Akima
		//date de intrare
		//x 0,5 3,5 6   8,5 11  14  17  20
		//y 130 121 128 96  122 138 114 90
		//n = 7
		// alfa = 10;
        static void Main(string[] args)
        {
			Console.WriteLine("n = ");
			int n = Convert.ToInt32(Console.ReadLine());
			double[] x = new double[n + 1];
			double[] y = new double[n + 1];
			double[] h = new double[n];
			double[] p = new double[n + 4];
			double[] m = new double[n + 1];
			double s = 0;
			Console.WriteLine("alfa = ");
			double alfa = Convert.ToDouble(Console.ReadLine());

			for (int i = 0; i < n + 1; i++)
			{
				Console.WriteLine("x[{0}] = ", i);
				x[i] = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("y[{0}] = ", i);
				y[i] = Convert.ToDouble(Console.ReadLine());
			}

			//pas 1
			for (int i = 1; i < n; i++)
			{
				h[i] = x[i] - x[i - 1];
			}

			//pas 2
			for (int i = 0; i < n - 1; i++)
			{
				p[i + 2] = (y[i + 1] - y[i]) / (x[i + 1] - x[i]);
			}
			p[1] = 2 * p[2] - p[3];
			p[0] = 3 * p[2] - 2 * p[3];
			p[n + 2] = 2 * p[n + 1] - p[n];
			p[n + 3] = 3 * p[n + 1] - 2 * p[n];

			//pas 3
			for (int i = 0; i < n; i++)
			{
				m[i] = (Math.Abs(p[i + 3] - p[i + 2]) * p[i + 1] + Math.Abs(p[i + 1] - p[i]) * p[i + 2]) / (Math.Abs(p[i + 3] - p[i + 2]) + Math.Abs(p[i + 1] - p[i]));
			}
			//pas 4
			for (int i = 1; i < n; i++)
			{
				if ((x[i- 1] <= alfa) && (alfa <= x[i]))
				{
					s = ((x[i] - alfa) * (x[i] - alfa) * (2 * (alfa - x[i - 1]) + h[i]) 
						/ Math.Pow(h[i], 3) * y[i - 1] + (((alfa - x[i - 1])*(alfa - x[i-1])
						*(2*(x[i] - alfa) + h[i])) / Math.Pow(h[i], 3) * y[i] + ((x[i] - alfa) 
						* x[i] - alfa) * (alfa - x[i - 1]))) / (h[i]* h[i]) * m[i - 1] - 
						((alfa - x[i - 1]) * (alfa - x[i - 1]) * (x[i] - alfa)) / (h[i]
						*h[i]) * m[i];
					Console.WriteLine(s);
				}
			}
			Console.ReadKey();
		}
    }
}
