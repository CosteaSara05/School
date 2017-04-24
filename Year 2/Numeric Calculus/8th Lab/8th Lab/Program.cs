using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8th_Lab
{
	class Program
	{
		//simpson
		//1.a = 0, b = 1, n = 10
		//2.a = 0, b = 1, n = 10
		//newton
		//1.
		public static double f(double x)
		{
			//1.
			return 4/(x*x + 1);

			//2.
			//return 1/ (x + 1);
		}

		static void Main(string[] args)
		{
			//simpson
			//pas 1
			Console.WriteLine("Simpson");
			Console.Write("a1 = ");
			double a1 = Convert.ToDouble(Console.ReadLine());
			Console.Write("b1 = ");
			double b1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("n = ");
			int n = Convert.ToInt32(Console.ReadLine());
			double s1 = 0, t1 = 0;
			double[] x1 = new double[n + 1];
			
			//pas 2
			for (int i = 0; i <= n; i++)
			{
				x1[i] = a1 + (i * (b1 - a1))/n;
			}

			//pas 3
			for (int i = 1; i <= n; i++)
			{
				t1 += f(x1[i - 1]) + 4 * f((x1[i - 1] + x1[i]) / 2) + f(x1[i]);
			}

			//pas 4
			s1 = ((b1 - a1) / (6 * n)) * t1;


			//2.newton
			//pas 1
			Console.WriteLine("Newton");
			Console.Write("a2 = ");
			double a2 = Convert.ToDouble(Console.ReadLine());
			Console.Write("b2 = ");
			double b2 = Convert.ToDouble(Console.ReadLine());
			double s2 = 0, t2 = 0, h = 0;
			double[] x2 = new double[n + 1];

			//pas 2
			h = (b2 - a2) / n;

			for (int i = 0; i <= n; i++)
			{
				x2[i] = a2 + i * h;
			}

			//pas 3

			for (int i = 1; i <= n; i++)
			{
				t2 += f(x2[i - 1]) + 3 * f(x2[i - 1] + h / 3) + 3 * f(x2[i - 1] + 2 * h / 3) + f(x2[i]);
			}

			//pas 4
			s2 = ((b2 - a2) / (8 * n)) * t2;

			Console.WriteLine("Simpson = " + s1);
			Console.WriteLine("Newton  = " + s2);
			Console.ReadKey();
		}
	}
}
