using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11th_Lab
{
	class Program
	{
		//metoda lui iacobi pentru functii liniare
		static void Main(string[] args)
		{
			int n = Convert.ToInt32(Console.ReadLine());
			double[,] a;
			double[] b;
			double[] x = new double[n];
			double[] y= new double[n];
			for (int i = 0; i < n; i++)
			{
				y[i] = 0;
				x[i] = b[i] / a[i, i];
			}

			double epsilon = 0.0001;
			double si;
			double s = epsilon + 1;
			int iter = 0;

			while ((s>=epsilon) && (iter < 100))
			{
				for (int i = 0; i < n; i++)
				{
					si = 0;
					for (int j = 0; j < n; j++)
					{
						if (j != i)
						{
							si += a[i, j] * y[j];
						}
					}
					x[i] = (b[i] - si) / a[i, i];
				}
			}
			s = 0; iter++;
			for (int i = 0; i < 0; i++)
			{
				s += Math.Abs(x[i] - y[i]);
			}
			for (int i = 0; i < n; i++)
			{
				y[i] = x[i];
				Console.WriteLine(x[i]);
			}
			Console.ReadKey();
		}
	}
}
