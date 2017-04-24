using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plata_unei_sume
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Introduceti suma de plata: ");
			int s = int.Parse(Console.ReadLine());
			int[] v = new int[4];
			v[0] = 25;
			v[1] = 10;
			v[2] = 5;
			v[3] = 1;
			int[] k = new int[4];
			int i = 0;
			do
			{
				k[i] = s / v[i];
				s = s % v[i];
				i++;
				//Console.WriteLine("{0}, {1}, {2}", v[i], s, k[i]);
			} while (s > 0);

			Console.WriteLine("25 -> {0}", k[0]);
			Console.WriteLine("10 -> {0}", k[1]);
			Console.WriteLine("5 -> {0}", k[2]);
			Console.WriteLine("1 -> {0}", k[3]);
			Console.ReadKey();
		}
	}
}
