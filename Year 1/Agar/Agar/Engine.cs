using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Agar
{
	class Engine : Form
	{
		public static Bitmap b;
		public static Graphics g;
		public static int resx;
		public static int resy;
		public static float speedx;
		public static float speedy;
		public static List<Dot> myPoint = new List<Dot>();
		public static int n = 3;
		public static Random r = new Random();

		public static void InitGraph()
		{
			b = new Bitmap(resx, resy);
			g = Graphics.FromImage(b);
		}

		public static void initPoint()
		{
			int initspeed = r.Next(1, 3);
			if (myPoint.Count == 0)
				n = 2;
			else
				n = r.Next(5, 10);
			for (int i = 0; i < n; i++)
			{
				int red = r.Next(0, byte.MaxValue + 1);
				int green = r.Next(0, byte.MaxValue + 1);
				int blue = r.Next(0, byte.MaxValue + 1);
				Brush brush = new SolidBrush(Color.FromArgb(red, green, blue));
				int dimension = r.Next(5, 15);
				speedx = r.Next(-initspeed, initspeed);
				while (speedx == 0)
					speedx = r.Next(-initspeed, initspeed);
				speedx *= 0.5f;
				speedy = r.Next(-initspeed, initspeed);
				while (speedy == 0)
					speedy = r.Next(-initspeed, initspeed);
				speedy *= 0.5f;
				float lastx = r.Next(-1, 1);
				while (lastx == 0)
					lastx = r.Next(-1, 1);
				float lasty = r.Next(-1, 1);
				while (lasty == 0)
					lasty = r.Next(-1, 1);
				Dot New = new Dot(brush, new PointF(r.Next(dimension, resx - dimension), r.Next(dimension, resy - dimension)), dimension, speedx, speedy, lastx, lasty);
				myPoint.Add(New);
			}
		}

		public static void NearEat(Dot item)
		{
			//shows the center
			//g.FillEllipse(Brushes.Black, item.Point.X, item.Point.Y, 3, 3);
			float x, y, distance, line = float.MaxValue;
			for (int i = myPoint.Count - 1; i > 0; i--)
			{
				//shows the center
				//g.FillEllipse(Brushes.Black, myPoint[i].Point.X, myPoint[i].Point.Y, 3, 3);
				x = item.Point.X - myPoint[i].Point.X;
				y = item.Point.Y - myPoint[i].Point.Y;
				distance = x * x + y * y;
				distance = (float)Math.Sqrt(distance);
				if (distance != 0)
				{
					if (item.dimension > myPoint[i].dimension)
						line = item.dimension + myPoint[i].dimension / 2;
					else if (item.dimension < myPoint[i].dimension)
						line = myPoint[i].dimension + item.dimension / 2;
					if (line >= distance)
					{
						if (item.dimension > myPoint[i].dimension + myPoint[i].dimension / 4)
						{
							item.dimension += myPoint[i].dimension / 10;
							myPoint.Remove(myPoint[i]);
						}
						else if (item.dimension + item.dimension / 4 < myPoint[i].dimension)
						{
							myPoint[i].dimension += item.dimension / 10;
							myPoint.Remove(item);
						}
					}
				}
			}

		}

		public static void Autocorect(Dot p)
		{
			if (p.Point.X < 0)
				p.Point.X = 1;
			else if (p.Point.Y < 0)
				p.Point.Y = 1;
			else if (p.Point.X > resx - p.dimension)
				p.Point.X = resx - p.dimension - 1;
			else if (p.Point.Y > resy - p.dimension)
				p.Point.Y = resy - p.dimension - 1;
		}

		public static void draw()
		{
			foreach (Dot p in myPoint)
				g.FillEllipse(p.brush, p.Point.X - p.dimension, p.Point.Y - p.dimension, p.dimension * 2, p.dimension * 2);
		}

		public static void update()
		{
			g.Clear(Color.Gray);
			for (int i = myPoint.Count - 1; i > 0; i--)
			{
				Autocorect(myPoint[i]);
				margin(myPoint[i]);
				NearEat(myPoint[i]);
				
			}
		}

		public static void margin(Dot p)
		{
			if (p.Point.X <= p.dimension)
			{
				p.lastx = -p.lastx;
				p.lasty = +p.lasty;
				p.Point.X = p.Point.X + (p.lastx * p.speedx);
				p.Point.Y = p.Point.Y + (p.lasty * p.speedy);
			}
			else if (p.Point.X >= resx - p.dimension)
			{
				p.lastx = -p.lastx;
				p.lasty = +p.lasty;
				p.Point.X = p.Point.X + (p.lastx * p.speedx);
				p.Point.Y = p.Point.Y + (p.lasty * p.speedy);
			}
			else if (p.Point.Y <= p.dimension)
			{
				p.lastx = +p.lastx;
				p.lasty = -p.lasty;
				p.Point.X = p.Point.X + (p.lastx * p.speedx);
				p.Point.Y = p.Point.Y + (p.lasty * p.speedy);
			}
			else if (p.Point.Y >= resy - p.dimension)
			{
				p.lastx = +p.lastx;
				p.lasty = -p.lasty;
				p.Point.X = p.Point.X + (p.lastx * p.speedx);
				p.Point.Y = p.Point.Y + (p.lasty * p.speedy);
			}
			else
			{
				p.Point.X = p.Point.X + (p.lastx * p.speedx);
				p.Point.Y = p.Point.Y + (p.lasty * p.speedy);
			}
			g.FillEllipse(p.brush, p.Point.X - p.dimension, p.Point.Y - p.dimension, p.dimension * 2, p.dimension * 2);
		}
	}

}
