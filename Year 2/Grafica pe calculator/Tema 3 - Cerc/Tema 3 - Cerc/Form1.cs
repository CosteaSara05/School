using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_3___Cerc
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private void MidpointCircle(int radius, int value)
		{
			int x, y;
			double d;
			x = 0;
			y = radius;
			d = 5.0 / 4 - radius;
			CirclePoints(x,y,value);
			while (y > x)
			{
				if (d < 0)
				{
					d += x * 2.0 + 3;
					x++;
				}
				else
				{
					d += (x - y) * 2.0 + 5;
					x++;
					y--;
				}
				CirclePoints(x, y, value);
			}
		}

		private void CirclePoints(float x, float y, int value)
		{
			WritePixel(x, y, value);
			WritePixel(y, x, value);
			WritePixel(y, -x, value);
			WritePixel(x, -y, value);
			WritePixel(-x, -y, value);
			WritePixel(-y, -x, value);
			WritePixel(-y, x, value);
			WritePixel(-x, y, value);
		}

		private void WritePixel(float x, float y, int value)
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

		private void btnClear_Click(object sender, EventArgs e)
		{
			Engine.g.Clear(Color.ForestGreen);
			pictureBox1.Image = Engine.b;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			tbRadius.Text = ValidateText(tbRadius.Text);
		}

		private void tbX_TextChanged(object sender, EventArgs e)
		{
			tbX.Text = ValidateText(tbX.Text);
		}

		private void tbY_TextChanged(object sender, EventArgs e)
		{
			tbY.Text = ValidateText(tbY.Text);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(tbRadius.Text) && String.IsNullOrEmpty(tbX.Text) && String.IsNullOrEmpty(tbY.Text))
			{
				MessageBox.Show("Empty lines. Cannot proceed");
			}
			else
			{
				int radius = Convert.ToInt32(tbRadius.Text);
				MidpointCircle(radius, 1);
			}
		}

		private void btnRandomCoords_Click(object sender, EventArgs e)
		{
			tbRadius.Text = Convert.ToString(Engine.r.Next(1, 75));
			tbX.Text = Convert.ToString(Engine.r.Next(12, Engine.resx - 100));
			tbY.Text = Convert.ToString(Engine.r.Next(12, Engine.resy - 100));
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Engine.resx = pictureBox1.Width;
			Engine.resy = pictureBox1.Height;
			Engine.InitGraph();
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
