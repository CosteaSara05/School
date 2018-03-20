using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nimic
{
	class Program
	{
		public static int n = 8;
		public static int k;
		public static int p;
		public static Random r = new Random();
		public static int[] v = new int[n];
		public static int[] sol;
		public static bool[] fol;
		static void Main(string[] args)
		{
			//xxx();
			//selectionSort();
			//permutari();
			//combinari();
			insertionSort();
			Console.ReadKey();
		}

		private static void insertionSort()
		{
			GenerareV();
			afisareV();

			for (int i = 2; i < n; i++)
			{
				int t = v[i];
				int j = i - 1;
				bool ok;
				do
				{
					ok = false;
					v[j] = v[j - 1];
					j++;
					if ((j <= 0) || (v[j] > t))
						ok = true;
					Console.Write("*");
				}
				while (ok);
				//todo
				//v[j] = t;
				afisareV();
			}
		}
		
		private static void combinari()
		{
			n = Convert.ToInt32(Console.ReadLine());
			
			p = Convert.ToInt32(Console.ReadLine());
			fol = new bool[n];
			sol = new int[n];
			for (int i = 0; i < fol.Length; i++)
			{
				fol[i] = false;
			}
			GenerareSol();
			combinari(1, n, sol, fol, p);
			afisareSol();
		}

		private static void combinari(int k, int n, int[] sol, bool[] fol, int p)
		{
			if (k > p /*|| ok (sol)*/)
			{
				for (int i = 1; i <= p; i++)
				{
					Console.Write(sol[i] + " ");
				}
				Console.WriteLine();
			}
			else
			{
				for (int i = sol[k - 1]; i < n; i++)
				{
					if (fol[i] == false)
					{
						sol[k] = i;
						fol[i] = true;
						combinari(k + 1, n, sol, fol, p);
						fol[i] = false;
					}
				}
			}
		}

		//private static bool ok (int[] a)
		//{
		//	for (int i = 0; i < a.Length; i++)
		//	{
		//		if (a[i] > a[i + 1])
		//		{
		//			return false;
		//		}
		//	}
		//	return true;
		//}

		private static void permutari()
		{

		}

		private static void xxx()
		{
			int c = 0;
			bool x = false;
			while (!x)
			{
				c++;
				x = true;
				GenerareV();
				for (int i = 0; i < n; i++)
				{
					if (v[0] != v[i])
					{
						x = false;
					}
				}
			}
			afisareV();
			Console.WriteLine(c);
		}

		private static void selectionSort()
		{
			GenerareV();
			afisareV();
			sortareSelection();
			afisareV();
		}

		private static void afisareV()
		{
			for (int i = 0; i < v.Length; i++)
			{
				Console.Write(v[i] + " ");
			}
			Console.WriteLine();
			Console.WriteLine();
		}

		private static void afisareSol()
		{
			for (int i = 0; i < sol.Length; i++)
			{
				Console.Write(sol[i] + " ");
			}
			Console.WriteLine();
			Console.WriteLine();
		}

		private static void sortareSelection()
		{
			for (int j = 0; j < n - 1; j++)
			{
				int min = v[j];
				int poz = j;
				for (int i = j + 1; i < n; i++)
				{
					if (v[i] < min)
					{
						min = v[i];
						poz = i;
					}
				}
				int aux = v[j];
				v[j] = v[poz];
				v[poz] = aux;
			}
		}

		private static void GenerareV()
		{
			for (int i = 0; i < v.Length; i++)
			{
				v[i] = r.Next(20);
			}
		}

		private static void GenerareSol()
		{
			for (int i = 0; i < sol.Length; i++)
			{
				sol[i] = r.Next(20);
			}
		}
	}
}
