using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste_inlantuite
{
	class Program
	{
		static void Main(string[] args)
		{
			LinkedLista list = new LinkedLista();

			Console.Write("Numarul de elemente din lista:");

			int n = int.Parse(Console.ReadLine());

			for (int i = 1; i <= n; i++)
				list.Add(new Node("Node " + i));

			list.View();

			Console.ReadKey();
		}
	}
}
