using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5th_Lab
{
	class Program
	{
		//spline cubic (interpolare)
		//date de intrare
		//x 0,5 3,5 6   8,5 11  14  17  20
		//y 130 121 128 96  122 138 114 90
		//n = 8
		// alfa = 5,7,16 sau 19;
		static void Main(string[] args)
		{
			Console.Write("n = ");
			int n = Convert.ToInt32(Console.ReadLine());
			double[] x = new double[n];
			double[] y = new double[n];
			double[] h = new double[n];
			double[] a = new double[n + 1];
			double[] b = new double[n + 1];
			double[] c = new double[n];
			double[] d = new double[n + 1];
			double[] w = new double[n];
			double[] z = new double[n + 1];
			double[] m = new double[n + 1];
			double[] u = new double[n];
			double[] alfa = new double[4];
			double s = 0;

			for (int i = 0; i < 4; i++)
			{
				Console.Write("alfa[{0}] = ", i);
				alfa[i] = Convert.ToDouble(Console.ReadLine());
			}

			for (int i = 0; i < n; i++)
			{
				Console.Write("x[{0}] = ", i);
				x[i] = Convert.ToDouble(Console.ReadLine());
				Console.Write("y[{0}] = ", i);
				y[i] = Convert.ToDouble(Console.ReadLine());
			}

			//pas 1
			for (int i = 1; i < n; i++)
			{
				h[i] = x[i] - x[i - 1];
				a[i] = 2;
			}
			
			//pas 2
			a[0] = 2;
			c[0] = 1;
			b[n] = 1;
			d[0] = (3 / h[1]) * (y[1] - y[0]);
			d[n] = (3 / h[n]) * (y[n] - y[n - 1]);

			//pas 3
			for (int i = 1; i < n - 1; i++)
			{
				b[i] = h[i + 1] / (h[i] + h[i + 1]);
				c[i] = 1 - b[i];
				d[i] = ((3 * h[i] + 1 * (y[i] - y[i - 1])) / (h[i] * (h[i] + h[i + 1])))
					+ ((3 * h[i] * (y[i + 1] - y[i])) / (h[i + 1] * (h[i] + h[i + 1])));
			}

			//pas 4
			u[0] = c[0] / a[0];
			for (int i = 1; i < n - 1; i++)
			{
				w[i] = a[i] - b[i] * m[i - 1];
				u[i] = c[i] / w[i];
			}
			u[n] = a[n] - b[n] * u[n - 1];

			//pas 5
			z[0] = d[0] / 2;
			for (int i = 1; i < n; i++)
			{
				z[i] = (d[i] - b[i] * z[i - 1]) / w[i];
			}

			//pas 6
			m[n] = z[n];
			for (int i = n - 1; i >= 0; i--)
			{
				m[i] = z[i] - u[i] * m[i + 1];
			}

			//pas 7
			for (int j = 0; j < 4; j++)
			{
				for (int i = 1; i < n; i++)
				{
					if ((x[i - 1] <= alfa[j]) && (alfa[j] <= x[i]))
					{
						s = ((x[i] - alfa[j]) * (x[i] - alfa[j]) * (2 * (alfa[j] - x[i - 1]) + h[i])
							/ Math.Pow(h[i], 3) * y[i - 1] + (((alfa[j] - x[i - 1]) * (alfa[j] - x[i - 1])
							* (2 * (x[i] - alfa[j]) + h[i])) / Math.Pow(h[i], 3) * y[i] + ((x[i] - alfa[j])
							* x[i] - alfa[j]) * (alfa[j] - x[i - 1]))) / (h[i] * h[i]) * m[i - 1] -
							((alfa[j] - x[i - 1]) * (alfa[j] - x[i - 1]) * (x[i] - alfa[j])) / (h[i]
							* h[i]) * m[i];
						Console.WriteLine(s);
					}
				}
			}
			Console.ReadKey();
		}
	}
}
