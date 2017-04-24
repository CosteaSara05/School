using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _6th_Lab
{
	public class Pair
	{
		public Point point1;
		public Point point2;
		public Point point3;
	}

	public class Engine
	{
		public static Bitmap b;
		public static Graphics g;
		public static int resx;
		public static int resy;
		public static int n = 10;
		public static List<Point> myPoints = new List<Point>();
		public static List<Pair> Pairs = new List<Pair>();
		public static List<Point> JRpoints = new List<Point>();
		public static Random r = new Random();
		public static void initPoint()
		{
			for (int i = 0; i < n; i++)
			{
				Point New = new Point(r.Next(resx), r.Next(resy));
				myPoints.Add(New);
			}
		}
		public static void drawPoint()
		{
			foreach (Point p in myPoints)
				g.FillEllipse(Brushes.Black, p.X, p.Y, 4, 4);
		}

		public static void drawPolygon()
		{
			Jarvis.Points = myPoints;
			Jarvis.ConvexHull(Jarvis.Points);
			foreach (Point point in Jarvis.ConvexHull(Jarvis.Points))
			{
				g.FillEllipse(Brushes.Red, point.X - 3, point.Y - 3, 6, 6);
				JRpoints.Add(point);
			}
			for (int i = 0; i < JRpoints.Count; i++)
			{
				if (JRpoints[JRpoints.Count - 1] == JRpoints[i])
				{
					g.DrawLine(Pens.Yellow, JRpoints[JRpoints.Count - 1], JRpoints[0]);
				}
				else
				{
					g.DrawLine(Pens.Yellow, JRpoints[i], JRpoints[i + 1]);
				}
			}
		}

		public static void Triangulation()
		{
			for (int i = 0; i < JRpoints.Count; i++)
			{
				for (int j = 0; j < JRpoints.Count + 1; j++)
				{
					for (int k = 0; k < JRpoints.Count + 2; k++)
					{
						if ((k == j + 1) && (j == i + 1))
						{
							int auxj = j;
							int auxk = k;
							Point[] pair = new Point[3];
							pair[0] = JRpoints[i];
							if (j == JRpoints.Count)
							{
								auxj = 0;
							}
							pair[1] = JRpoints[auxj];
							if (k == JRpoints.Count + 1)
							{
								auxk = 1;
							}
							if (k == JRpoints.Count)
							{
								auxk = 0;
							}
							pair[2] = JRpoints[auxk];
							g.DrawLines(Pens.Aqua, pair);
						}
					}
				}
			}
		}
	}
}
