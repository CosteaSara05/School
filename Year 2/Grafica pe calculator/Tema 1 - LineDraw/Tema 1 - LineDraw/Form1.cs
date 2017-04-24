using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_1___LineDraw
{

	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void MidpointLine(int x0, int y0, int x1, int y1, int value)
		{
			int dx, dy, incrE, incrNE, d, x, y;
			dx = x1 - x0;
			dy = y1 - y0;
			d = dy * 2 - dx;
			incrE = dy * 2;
			incrNE = (dy - dx) * 2;
			x = x0;
			y = y0;
			WritePixel(x, y, value);
			while (x < x1)
			{
				if (d <= 0)
				{
					d += incrE;
					x++;
				}
				else
				{
					d += incrNE;
					x++;
					y++;
				}
				WritePixel(x, y, value);
			}
		}

		private void WritePixel(int x, int y, int value)
		{
			Engine.g.DrawEllipse(Engine.pen, x, y, 1, 1);
			pictureBox1.Image = Engine.b;
		}

		private void Line (int x0, int y0, int x1, int y1, int value)
		{
			int x;
			double dy, dx, y, m;
			dy = y1 - y0;
			dx = x1 - x0;
			m = dy / dx;
			y = y0;
			for (x = x0; x <= x1; x++)
			{
				WritePixel(x, (int)(y + 0.5), value);
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

		private void btnDraw_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(tbX1.Text) && String.IsNullOrEmpty(tbX2.Text)
				&& String.IsNullOrEmpty(tbY1.Text) && String.IsNullOrEmpty(tbY2.Text))
			{
				MessageBox.Show("Empty lines. Cannot proceed");
			}
			else
			{
				int x1 = Convert.ToInt32(tbX1.Text);
				int x2 = Convert.ToInt32(tbX2.Text);
				int y1 = Convert.ToInt32(tbY1.Text);
				int y2 = Convert.ToInt32(tbY2.Text);
				MidpointLine(x1,y1,x2, y2, 1);
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Engine.resx = pictureBox1.Width;
			Engine.resy = pictureBox1.Height;
			Engine.InitGraph();
			Engine.g.Clear(Color.ForestGreen);
			pictureBox1.Image = Engine.b;
		}

		private void tbX1_TextChanged(object sender, EventArgs e)
		{
			tbX1.Text = ValidateText(tbX1.Text);
		}

		private void tbX2_TextChanged(object sender, EventArgs e)
		{
			tbX2.Text = ValidateText(tbX2.Text);
		}

		private void tbY1_TextChanged(object sender, EventArgs e)
		{
			tbY1.Text = ValidateText(tbY1.Text);
		}

		private void tbY2_TextChanged(object sender, EventArgs e)
		{
			tbY2.Text = ValidateText(tbY2.Text);
		}

		private void btnRandomCoords_Click(object sender, EventArgs e)
		{
			tbX1.Text = Convert.ToString(Engine.r.Next(12, Engine.resx - 100));
			tbX2.Text = Convert.ToString(Engine.r.Next(12, Engine.resx - 100));
			tbY1.Text = Convert.ToString(Engine.r.Next(12, Engine.resy - 100));
			tbY2.Text = Convert.ToString(Engine.r.Next(12, Engine.resy - 100));
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			Engine.g.Clear(Color.ForestGreen);
			pictureBox1.Image = Engine.b;
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
