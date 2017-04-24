using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_subsecventei_de_suma_maxima
{
	class Program
	{
		public static int n;
		public static Random r = new Random();
		static void Main(string[] args)
		{
			Console.WriteLine("Dimensiune: ");
			n = Convert.ToInt32(Console.ReadLine());
			int[] v = new int[n];

			for (int i = 0; i < n; i++)
			{
				//Console.Clear();
				//Console.WriteLine(i + "= ");
				v[i] = r.Next(-10, 11);
				Console.Write(v[i] + " ");
			}
			Console.WriteLine();

			int max = int.MinValue, sum, st = 0, dr = 0;

			for (int j = 0; j < n; j++)
				for (int k = n - 1 - j; k >= j; k--)
				{
					sum = 0;
						for (int i = j; i < k; i++)
						{
							sum += v[i];
							if (sum > max)
							{
								max = sum;
								st = j;
								dr = i;
							}
						}
				}
			Console.WriteLine("Subsecventa cu suma cea mai mare este ({0}, {1}) = {2}", st, dr, max);

			Console.ReadKey();
		}
	}
}
