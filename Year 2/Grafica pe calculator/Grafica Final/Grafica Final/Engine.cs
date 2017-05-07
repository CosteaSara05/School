using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafica_Final
{
	public class Engine
	{
		public static Bitmap b;
		public static Graphics g;
		public static int resx;
		public static int resy;
		public static void InitGraph()
		{
			b = new Bitmap(resx, resy);
			g = Graphics.FromImage(b);
		}
		public static List<PointF> myPoint = new List<PointF>();
		public static int n = 25;
		public static Random r = new Random();
		public static void initPoint()
		{
				PointF New = new PointF(r.Next(resx), r.Next(resy));
				myPoint.Add(New);
		}
		public static void draw()
		{
			foreach (PointF p in myPoint)
				g.FillEllipse(Brushes.Black, p.X, p.Y, 4, 4);

			for (int i = 0; i < n - 1; i++)
				g.DrawLine(Pens.Red, myPoint[i], myPoint[i + 1]);

			g.DrawLine(Pens.Red, myPoint[0], myPoint[n - 1]);
		}
	}
}
