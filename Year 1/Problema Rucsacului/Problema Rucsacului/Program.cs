using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_Rucsacului
{
	class Program
	{
		public static Random r = new Random();
		public static int i;
		static void Main(string[] args)
		{
			bool ok;
			Console.Write("Introduceti greutatea maxima a rucsacului: ");
			int rucsac = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Introduceti numarul de obiecte: ");
			int m = Convert.ToInt32(Console.ReadLine());

			List<Obiect> obj = new List<Obiect>();

			float[] indice = new float[m];

			for (i = 0; i < m; i++)
			{
				Console.Clear();
				Console.Write("Greutatea obiectului {0} : ", i);
				//int gre = Convert.ToInt32(Console.ReadLine());
				int gre = r.Next(1,30);
				Console.Write("Valoarea obiectului {0} : ", i);
				//int val = Convert.ToInt32(Console.ReadLine());
				int val = r.Next(1,5000);
				obj.Add(new Obiect(val, gre, false));
			}

			Console.Clear();
			Console.WriteLine("(valoare, greutate).");
			//foreach (Obiect item in obj)
			//	Console.WriteLine("(" + item.valoare + "," + item.greutate + ")");

			for (i = 0; i < m; i++)
				indice[i] = obj[i].valoare / obj[i].greutate;

			do
			{
				ok = true;
				for (i = 0; i < m - 1; i++)
					if (indice[i] > indice[i + 1])
					{
						float t = indice[i];
						indice[i] = indice[i + 1];
						indice[i + 1] = t;

						Obiect o = obj[i];
						obj[i] = obj[i + 1];
						obj[i + 1] = o;

						ok = false;
					}
			} while (!ok);

			Console.WriteLine("Sortat: ");

			for (i = 0; i < m; i++)
			Console.WriteLine("(" + obj[i].valoare + "," + obj[i].greutate + ") - " + indice[i]);

			Console.WriteLine("In rucsac: ");
			int n = rucsac;
			for (i = m - 1; i > 0; i--)
				if (rucsac > 0)
					if ((indice[i] >= indice[i - 1]) && (rucsac >= obj[i].greutate) && (obj[i].isIn == false))
					{
						obj[i].isIn = true;
						Console.WriteLine("(" + obj[i].valoare + "," + obj[i].greutate + ") - " + indice[i]);
						rucsac -= obj[i].greutate;
					}
					else 
					{
						if ((rucsac >= obj[i - 1].greutate) && (obj[i].isIn == false))
						{
							obj[i].isIn = true;
							Console.WriteLine("(" + obj[i - 1].valoare + "," + obj[i - 1].greutate + ") - " + indice[i - 1]);
							rucsac -= obj[i - 1].greutate;
						}
					}

			n -= rucsac;
			Console.WriteLine("Greutatea in rucsac: {0}", n);



			Console.ReadKey();
		}
	}
}
