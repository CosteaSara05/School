using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AriaMinima
{
	public static class Engine
	{
		public static Random rnd = new Random();
		public static int n = 100;
		public static int resx;
		public static int resy;
		public static Bitmap bmp;
		public static Graphics g;
		public static List<PointF> points = new List<PointF>();
		public static List<Triangle> triangles = new List<Triangle>();
		public static void initSession()
		{
			for (int i = 0; i < n; i++)
			{
				float x = rnd.Next(resx);
				float y = rnd.Next(resy);
				points.Add(new PointF(x, y));
			}
		}
		public static void DrawMap()
		{
			foreach (PointF p in points)
			{
				g.DrawEllipse(Pens.Blue, p.X-2, p.Y-2,  4, 4);
			}
		}

		public static void DoMath()
		{
			for (int i1 = 0; i1 < n; i1++)
			{
				for (int i2 = 0; i2 < n; i2++)
				{
					for (int i3 = 0; i3 < n; i3++)
					{
						if (i1 != i2 && i1 != i3 && i2 != i3)
						{
							if (i1 < i2 && i2 < i3)
							{
								//solutie
								triangles.Add(new Triangle(points[i1], points[i2], points[i3]));
							}
						}
					}
				}
			}
			triangles.Sort(delegate(Triangle A, Triangle B) { return B.aria.CompareTo(A.aria); });
			triangles[0].Draw();
		}

		public static void Init(int x, int y)
		{
			resx = x;
			resy = y;
			bmp = new Bitmap(resx, resy);
			g = Graphics.FromImage(bmp);
		}
	}
}
