using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9th_Lab
{
	class Program
	{
		//dreapta de regresie
		//rezultat: a = 0.33, b = 1.41
		//intrare: n = 6, 
		//x = 1,3,4,6,8,9
		//y = 1,2,4,4,5,3
		static void Main(string[] args)
		{
			Console.Write("n = ");
			int n = Convert.ToInt32(Console.ReadLine());
			double[] x = new double[n];
			double[] y = new double[n];
			
			//pas 1
			for (int i = 0; i < x.Length; i++)
			{
				Console.Write("x[{0}] = ", i);
				x[i] = Convert.ToInt32(Console.ReadLine());
				Console.Write("y[{0}] = ", i);
				y[i] = Convert.ToInt32(Console.ReadLine());
			}

			//pas 2
			double s1 = 0, s2 = 0, s3 = 0, s4 = 0;
			for (int i = 0; i < x.Length; i++)
			{
				s1 += x[i];
				s2 += Math.Pow(x[i], 2);
				s3 += y[i];
				s4 += x[i] * y[i];
			}

			//pas 3
			double d, d1, d2, a, c;
			d = n * s2 - Math.Pow(s1, 2);
			d1 = n * s4 - s1 * s3;
			d2 = s2 * s3 - s1 * s4;
			a = d1 / d;
			c = d2 / d;

			//pas 4
			Console.WriteLine("a = {0}\nc = {1}",a ,c);
			Console.ReadKey();
		}
	}
}
