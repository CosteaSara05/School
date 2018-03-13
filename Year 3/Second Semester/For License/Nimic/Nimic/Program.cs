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
        public static int[] v = new int[n];
        public static Random r = new Random();
        static void Main(string[] args)
        {
			xxx();
			//selectionSort();
			//permutari();
            Console.ReadKey();
        }

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
				generare();
				for (int i = 0; i < n; i++)
				{
					if (v[0] != v[i])
					{
						x = false;
					}
				}
			}
			afisare();
			Console.WriteLine(c);
		}

		private static void selectionSort()
		{
			generare();
			afisare();
			sortareSelection();
			afisare();
		}

		private static void afisare()
		{
			for (int i = 0; i < n; i++)
			{
				Console.Write(v[i] + " ");
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

		private static void generare()
		{
			for (int i = 0; i < n; i++)
			{
				v[i] = r.Next(20);
			}
		}
	}
}
