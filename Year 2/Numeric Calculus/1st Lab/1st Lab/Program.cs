using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st_Lab
{
	class Program
	{
		//a0 = -3;a1 = -1; a2 = 0, a3 = 1,a4 = 1,5
		//f(x) = 1/(1+x*x)
		//f0 = 0,1, f1 = 0.5, f2 = 1, f3 = 0.5, f4 = 0,307
		static void Main(string[] args)
		{
			Console.Write("M = ");
			int m = Convert.ToInt32(Console.ReadLine());
			int k, i;
			double[] a = new double[m];
			double[] f = new double[m];
			double[,] D = new double[m, m];

			for (i = 0; i < a.Length; i++)
			{
				Console.Write("a[{0}] = ", i);
				a[i] = Convert.ToDouble(Console.ReadLine());
			}
			for (i = 0; i < f.Length; i++)
			{
				Console.Write("f[{0}] = ", i);
				f[i] = Convert.ToDouble(Console.ReadLine());
			}

			//1
			for (i = 0; i < f.Length; i++)
				f[i] = 1 / (1 + f[i] * f[i]);

			for (i = 0; i < m; i++)
				D[0, i] = f[i];

			//2
			for (k = 1; k < m; k++)
			{
				for (i = 0; i < m-k; i++)
				{
					D[k, i] = (D[k - 1, i + 1] - D[k - 1, i]) / (a[i + k] - a[i]);
				}
			}
			//3
			for (k = 1; k < m; k++)
			{
				for (i = 0; i < m-k; i++)
				{
					Console.Write(" [" + k + "," + i + "] = " + D[k,i]);
				}
				Console.WriteLine();
			}
			Console.ReadKey();

		}
	}
}
