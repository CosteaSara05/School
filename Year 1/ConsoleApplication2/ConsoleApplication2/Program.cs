using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[,] v = new int[n,n];

			for (int i = 0; i < n; i++)
				for (int j = 0; j < n; j++)
					v[i, j] = 0;


			for (int i = 0; i < n / 2; i++)
				{
					v[n / 2 - i, n / 2 - i] = 1;
				}

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write(v[i, j] + " ");
				}
				Console.WriteLine();
			}

					Console.ReadKey();
		}
	}
}
