using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12th_Lab
{
	class Program
	{
		//metoda aproximarilor recursive
		//a = 1, epsilon = 10 la -4, 10 la -8, 10 la - 12
		//f(x) = math.pow(x + 1, 1 / 3)
		//acuatia lui kepler
		//a = 0,78
		//f(x) = 0,2 * sin x + 0,5
		//aproximatia radicalului
		//a = 2 ,3 ,5, 6, 10..etc
		//f(x) = 1/2 * (x + a/x);
		static void Main(string[] args)
		{
			Console.Write("a = ");
			double a = Convert.ToDouble(Console.ReadLine());
			Console.Write("epsilon = ");
			double epsilon = Convert.ToDouble(Console.ReadLine());
			Console.Write("n = ");
			int n = Convert.ToInt32(Console.ReadLine());
			double[] x = new double[n + 1];

			x[0] = a;
			x[1] = f(x[0], a);

			int i = 1;
			while (Math.Abs(x[i] - x[i - 1]) >= epsilon)
			{
				x[i + 1] = f(x[i], a);
				i++;
			}
			Console.WriteLine("n = " + n);
			for (int j = 0; j < i; j++)
			{
				Console.WriteLine("x[{0}] = {1}",j , x[j]);
			}

			Console.ReadKey();
		}

		private static double f(double x, double a)
		{
			return 1 / 2 * (x + a / x);
		}

		private static double f(double x)
		{
			//return Math.Pow(x + 1, 1.0 / 3.0);
			return 0.2 * Math.Sin(x) + 0.5;
		}
	}
}
