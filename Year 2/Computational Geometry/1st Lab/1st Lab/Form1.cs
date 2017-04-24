using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1st_Lab

//se da o multime de puncte in plan,sa se determine: dreptunghiul de arie minima care sa contina toate punctele date
//se dau 2 multimi de puncte in plan, pt fiecare punct din prima multime, sa se gasesasca cel mai aproppiat punct din cea dea doua multime.
//se dau n puncte in plan,  pt un punct dat q, sa se determine cercul cu centrul in q si de raza maxima care sa nu contina nici un punct din multimea
//data
//se dau n puncte in plan, si o constanta d > 0, sa se determine toate punctele aflate la o dinstanta mai mica sau egala cu d, fata de un punct fixat q.
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}


		private void Form1_Load(object sender, EventArgs e)
		{
			Engine.b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			Engine.g = Graphics.FromImage(Engine.b);
			pictureBox1.Image = Engine.b;
		}


		private void button1_Click_1(object sender, EventArgs e)
		{
			Pen pen = new Pen(Color.Black, 5);
			Start();
			Engine.Points.Clear();
		}

		private void Start()
		{
			timer1.Enabled = !timer1.Enabled;
		}

		private void Draws()
		{
			for (int i = 0; i < Engine.r.Next(20,500); i++)
				Engine.Points.Add(new Point(Engine.r.Next(pictureBox1.Width), Engine.r.Next(pictureBox1.Height)));

			foreach (Point d in Engine.Points)
                Engine.g.FillRectangle(Brushes.Blue, d.X, d.Y, 5, 5);
            pictureBox1.Image = Engine.b;
			
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			Draws();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Engine.g.Clear(Color.ForestGreen);
			Engine.Points.Clear();
			Engine.ChosenPoints.Clear();
			Engine.Points21.Clear();
			pictureBox1.Image = Engine.b;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			float top = 0, left = 0, right = pictureBox1.Height, down = pictureBox1.Width;
			foreach (Point item in Engine.Points)
			{
				if (item.X >= top)
					top = item.X;
				if (item.X <= down)
					down = item.X;
				if (item.Y >= left)
					left = item.Y;
				if (item.Y <= right)
					right = item.Y;
			}
			Engine.g.DrawLine(new Pen(Color.Red), top, right, top, left);
			Engine.g.DrawLine(new Pen(Color.Red), top, left, down, left);
			Engine.g.DrawLine(new Pen(Color.Red), top, right, down, right);
			Engine.g.DrawLine(new Pen(Color.Red), down, left, down, right);
			pictureBox1.Image = Engine.b;
		}

		private void AddDots_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < Engine.r.Next(500); i++)
				Engine.Points.Add(new Point(Engine.r.Next(pictureBox1.Width), Engine.r.Next(pictureBox1.Height)));

			foreach (Point d in Engine.Points)
                Engine.g.FillRectangle(Brushes.Blue, d.X, d.Y, 5, 5);
            pictureBox1.Image = Engine.b;
		}

		public void button2_Click_1(object sender, EventArgs e)
		{
			float closest = float.MaxValue;
			float x, y;
			Engine.ChosenPoints.Clear();
			foreach (Point item in Engine.Points)
			{
				int c = 0;
                closest = float.MaxValue;
				foreach (Point near in Engine.Points21)
				{
					c++;
					x = item.X - near.X;
					y = item.Y - near.Y;

					float distance = x * x + y * y;

					if (distance <= closest)
					{
						closest = distance;
                        Engine.ChosenPoints.Clear();
						x = near.X;
						y = near.Y;
                        Engine.ChosenPoints.Add(new Point(near.X, near.Y));
                        Engine.ChosenPoints.Add(new Point(item.X, item.Y));
					}
				}
                Engine.g.DrawLine(Pens.White, Engine.ChosenPoints[0], Engine.ChosenPoints[1]);
			}

			pictureBox1.Image = Engine.b;
		}


		private void button3_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < Engine.r.Next(20,500); i++)
				Engine.Points21.Add(new Point(Engine.r.Next(pictureBox1.Width), Engine.r.Next(pictureBox1.Height)));
			foreach (Point d in Engine.Points21)
                Engine.g.FillRectangle(Brushes.Red, d.X, d.Y, 5, 5);
            pictureBox1.Image = Engine.b;
		}

        private void button4_Click(object sender, EventArgs e)
        {
            //problema 3  
            Point q = new Point(Engine.r.Next(pictureBox1.Width), Engine.r.Next(pictureBox1.Height));
            Engine.g.FillRectangle(Brushes.White, q.X, q.Y, 5, 5);
            float closest = float.MaxValue, radius = 10, x, y, X = 0, Y = 0;
            closest = float.MaxValue;
            foreach (Point item in Engine.Points)
            {
                x = item.X - q.X;
                y = item.Y - q.Y;

                float distance = x * x + y * y;

                if (distance < closest)
                {
                    closest = distance;
                    radius = (float)Math.Sqrt(closest) - 1;
                    X = item.X;
                    Y = item.Y;
                    Engine.ChosenPoints.Clear();
                    Engine.ChosenPoints.Add(new Point(q.X, q.Y));
                    Engine.ChosenPoints.Add(new Point(item.X, item.Y));
                }
            }
            Engine.g.DrawEllipse(Pens.White, q.X - radius, q.Y - radius, 2 * radius, 2 * radius);
            Engine.g.DrawLine(Pens.White, q.X, q.Y, X, Y);
            pictureBox1.Image = Engine.b;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //problema 4
            Engine.ChosenPoints.Clear();
            Point q = new Point(Engine.r.Next(pictureBox1.Width), Engine.r.Next(pictureBox1.Height));
            Engine.g.DrawRectangle(Pens.White, q.X, q.Y, 5, 5);
            float d = Convert.ToSingle(textBox1.Text);
            float x, y;
            d = d * d;
            foreach (Point item in Engine.Points)
            {
                x = item.X - q.X;
                y = item.Y - q.Y;
                double distance = x * x + y * y;     
                if (distance <= d)
                    Engine.ChosenPoints.Add(item);
            }
            foreach (Point item in Engine.ChosenPoints)
                Engine.g.DrawLine(Pens.White, q.X, q.Y, item.X, item.Y);
            pictureBox1.Image = Engine.b;
        }
    }
}
