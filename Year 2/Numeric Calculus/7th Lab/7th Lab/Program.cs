using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7th_Lab
{
	class Program
	{
		//cuadratura trapezului perturbat (euler - mac laurin)
		//calcularea PI

		public static double f(double x)
		{
			return x = 4 / (1 + x * x);
		}

		static void Main(string[] args)
		{
			//a = 0, b = 1, n = 10, dfa = 0, dfb = - 2;
			Console.WriteLine("n = ");
			int n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("a = ");
			double a = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("b = ");
			double b = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("dfa = ");
			double dfa = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("dfb = ");
			double dfb = Convert.ToDouble(Console.ReadLine());
			double[] x = new double[n + 1];
			double s = 0;

			//pas 1
			for (int i = 0; i <= n; i++)
			{
				x[i] = a + i * (b - a) / n;
			}

			//pas 2
			double t = 0;
			for (int i = 1; i <= n; i++)
			{
				t = t + f(x[i - 1]) + f(x[i]);
			}

			//pas 3
			s = ((b - a) / (2 * n)) * t - (((b - a) * (b - a)) / (12 * n * n)) * (dfb - dfa);

			Console.WriteLine("s = " + s);
			Console.WriteLine(Math.PI);
			Console.ReadKey();
		}
	}
}
