using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6th_Lab
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Engine.resx = pictureBox1.Width;
			Engine.resy = pictureBox1.Height;
			Engine.b = new Bitmap(Engine.resx, Engine.resy);
			Engine.g = Graphics.FromImage(Engine.b);
			Engine.g.Clear(Color.ForestGreen);
			pictureBox1.Image = Engine.b;
		}

		private void BtnAddPoints_Click(object sender, EventArgs e)
		{
			Engine.g.Clear(Color.ForestGreen);
			Engine.initPoint();
			Engine.drawPoint();
			pictureBox1.Image = Engine.b;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Engine.g.Clear(Color.ForestGreen);
			Engine.drawPolygon();
			Engine.myPoints.Clear();
			pictureBox1.Image = Engine.b;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Engine.Triangulation();//not running

			pictureBox1.Image = Engine.b;
		}
	}
}
