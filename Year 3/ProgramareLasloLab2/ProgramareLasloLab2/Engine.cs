using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProgramareLasloLab2
{
	public static partial class Engine
	{
		public static int NOP = 10;
		public static int NOG = 20;
		public static Random r = new Random();
		public static int[,] MA;

		public static PointF intersectie(PointF a, PointF b, PointF c, PointF d)
		{
			float t1 = b.X - a.X;
			float t2 = b.Y - a.Y;
			float t3 = d.X - c.X;
			float t4 = d.Y - c.Y;
			float d1 = t2 * a.X - t1 * a.Y;
			float d2 = t4 * c.X - t3 * c.Y;
			float ds = t4 * t1 - t2 * t3;
			float dx = d2 * t1 - d1 * t3;
			float dy = d2 * t2 - t4 * d1;
			if (ds != 0)
			{
				return new PointF(dx / ds, dy / ds);
			}
			else
			{
				return PointF.Empty;
			}

		}

		public static void intSesion()
		{
			MA = new int[NOP, NOP];
			for (int i = 0; i < NOP; i++)
			{
				for (int j = 0; j < NOP; j++)
				{
					MA[i, j] = 0;
				}
			}

			for (int i = 0; i < NOG; i++)
			{
				int il = r.Next(NOP);
				int jl = r.Next(NOP);
				if (il != jl)
				{
					MA[il, jl] = 1;
					MA[jl, il] = 1;
				}
			}
		}

	}
}
