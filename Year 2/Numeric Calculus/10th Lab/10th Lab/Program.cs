using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10th_Lab
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("n = ");
			int n = Convert.ToInt32(Console.ReadLine());
			Console.Write("epsilon = ");
			double epsilon = Convert.ToDouble(Console.ReadLine());
			double[,] a = new double[n + 1, n + 1];
			double[,] beta = new double[n + 1, n + 1];
			double[,] x = new double[n + 1, n + 1];
			double[] b = new double[n + 1];
			double k = 0;

			//pas 1
			for (int i = 1; i <= n; i++)
			{
				for (int j = 0; j <= n; j++)
				{
					Console.WriteLine("a[{0},{1}] = ", i, j);
					a[i,j] = Convert.ToDouble(Console.ReadLine());
				}
				Console.WriteLine("b[{0}] = ", i);
				b[i] = Convert.ToDouble(Console.ReadLine());
			}

			//pas 2
			for (int i = 1; i <= n; i++)
			{
				b[i] = b[i] / a[i, i];
				x[0,i] = 

			}


		}
	}
}
