using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agar
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
			Engine.InitGraph();
			Engine.g.Clear(Color.Gray);
			Pen cr02 = new Pen(Color.Red, 2);
			Engine.initPoint();
			pictureBox1.Image = Engine.b;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			timer1.Enabled = !timer1.Enabled;
			if (timer1.Enabled == true)
			{
				button1.Text = "STOP";
				button1.BackColor = Color.Red;
				button3.Visible = true;
			}
			else
			{
				button1.Text = "START";
				button1.BackColor = Color.Green;
				button3.Visible = true;
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			pictureBox1.Image = Engine.b;
			for (int i = 0; i < 10; i++)
				Engine.update();
			pictureBox1.Image = Engine.b;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			pictureBox1.Image = Engine.b;
			Engine.initPoint();
			Engine.draw();
			pictureBox1.Image = Engine.b;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Engine.myPoint.Clear();
			Engine.g.Clear(Color.Gray);
			button1.Text = "START";
			button1.BackColor = Color.Green;
			timer1.Enabled = false;
			Engine.initPoint();
			Engine.update();
			pictureBox1.Image = Engine.b;
			button3.Visible = false;
		}
	}
}
