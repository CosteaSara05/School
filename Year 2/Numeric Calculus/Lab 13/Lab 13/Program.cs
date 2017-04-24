using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
	class Program
	{
		public static double f(double x)
		{
			return Math.Pow(x, 3) - x - 1;
		}
		public static double df(double x)
		{
			return 3 * Math.Pow(x, 2) - 1;
		}
		static void Main(string[] args)
		{
			List<double> x = new List<double>();
			x.Add(0);
			x.Add(0);
			double a, b, da, eps,d;
			Console.WriteLine("a");
			a = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("b");
			b = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("da");
			da = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("eps");
			eps = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("d");
			d = Convert.ToDouble(Console.ReadLine());

			if (f(a) * da > 0)
			{
				x[0] = a;
			}
			else
			{
				x[0] = b;
			}
			//x[1] = x[0] - f(x[0]) / df(x[0]);
			x[1] = x[0] - f(x[0]) / d;
			int lasti = 0;
			double lastx = 0;
			for (int i = 1; Math.Abs(x[i] - x[i - 1]) >= eps; i++)
			{
				//x.Add(x[i] - f(x[i]) / df(x[i]));
				x.Add(x[i] - f(x[i]) / d);
				lasti = i;
				lastx = x[i];
			}
			Console.WriteLine(lasti + " " + lastx);
			Console.ReadKey();
		}
	}
}
