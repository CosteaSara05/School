using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_2___Draw_Forms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		//private void MidpointLine(int x0, int y0, int x1, int y1, int value)
		//{
		//	int dx, dy, incrE, incrNE, d, x, y;
		//	dx = x1 - x0;
		//	dy = y1 - y0;
		//	d = dy * 2 - dx;
		//	incrE = dy * 2;
		//	incrNE = (dy - dx) * 2;
		//	x = x0;
		//	y = y0;
		//	WritePixel(x, y, value);
		//	while (x < x1)
		//	{
		//		if (d <= 0)
		//		{
		//			d += incrE;
		//			x++;
		//		}
		//		else
		//		{
		//			d += incrNE;
		//			x++;
		//			y++;
		//		}
		//		WritePixel(x, y, value);
		//	}
		//}

		private void DoubleStep(int x0, int y0, int x1, int y1)
		{
			int current_x, incr_1, incr_2, cond, dx, dy, d;
			dx = x1 - x0;
			dy = y1 - y0;
			current_x = x0;
			incr_1 = 4 * dy;
			incr_2 = 4 * dy - 2 * dx;
			cond = 2 * dy;
			d = 4 * dy - dx;
			while (current_x < x1)
			{
				if (d < 0)
				{
					DrawPixels(Pattern_1, current_x);
					d += incr_1;
				}
				else
				{
					if (d < cond)
					{
						DrawPixels(Pattern_2, current_x);
					}
					else
					{
						DrawPixels(Pattern_3, current_x);
						d += incr_2;
					}
				}
				current_x += 2;
			}
		}

		private void DrawPixels(int x, int y, int value)
		{
			Engine.g.DrawEllipse(Engine.pen, x, y, 1, 1);
			pictureBox1.Image = Engine.b;
		}

		private void Line(int x0, int y0, int x1, int y1, int value)
		{
			int x;
			double dy, dx, y, m;
			dy = y1 - y0;
			dx = x1 - x0;
			m = dy / dx;
			y = y0;
			for (x = x0; x <= x1; x++)
			{
				DrawPixels(x, (int)(y + 0.5), value);
			}
		}

		private string ValidateText(string text)
		{
			string aux = "";
			foreach (char item in text)
			{
				if (item == '0' ||
					item == '1' ||
					item == '2' ||
					item == '3' ||
					item == '4' ||
					item == '5' ||
					item == '6' ||
					item == '7' ||
					item == '8' ||
					item == '9')
				{
					aux += item;
				}
			}
			return text = aux;
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			Engine.g.Clear(Color.ForestGreen);
		}
	}

	class Engine
	{
		public static Bitmap b;
		public static Graphics g;
		public static int resx;
		public static int resy;
		public static Pen pen = new Pen(Color.Red, 2);
		public static void InitGraph()
		{
			b = new Bitmap(resx, resy);
			g = Graphics.FromImage(b);
		}
		public static Random r = new Random();
	}
}
