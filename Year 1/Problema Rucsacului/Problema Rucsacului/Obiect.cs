using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_Rucsacului
{
	class Obiect
	{
		public int valoare;
		public int greutate;
		public bool isIn;

		public Obiect(int Valoare, int Greutate, bool IsIn)
		{
			valoare = Valoare;
			greutate = Greutate;
			isIn = IsIn;
		}
	}
}
