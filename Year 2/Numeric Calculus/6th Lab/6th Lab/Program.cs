using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6th_Lab
{
	class Program
	{

		//circumferinta pamantului
		//private static double f1(double x)
		//{
		//	double c = 149.6;
		//	double e = 0.016729;
		//	return x = 4 * c * Math.Sqrt(1 - Math.Pow(e, 2) * Math.Sin(x) * Math.Sin(x));
		//}

		//private static double f1(double x)
		//{
		//	return x = 1 / (Math.Pow(x, 2) + 1);
		//}

		private static double f1(double x)
		{
			return 1 / (x + 1);
		}

		static void Main(string[] args)
		{
			//pas 1
			Console.WriteLine("n = ");
			int n = Convert.ToInt32(Console.ReadLine());
			Console.Write("a = ");
			double a = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine(a);
			Console.Write("b = ");
			double b = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine(b);
			double t = 0;
				double[] x = new double[n];
				double s = 0;
				t = 0;

				//pas 2
				for (int i = 0; i < n; i++)
				{
					x[i] = a + i * (b - a) / n;
				}

				//pas 3
				for (int i = 1; i < n; i++)
				{
					s = s + f1(x[i - 1]) + f1(x[i]);
				}

				//pas 4
				t = ((b - a) / (2 * n)) * s;
			Console.WriteLine("Rezultat: " + t);
			Console.ReadKey();
		}
	}
}
