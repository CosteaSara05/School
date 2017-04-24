using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3rdLab
{
    public partial class Form1 : Form
    {
        //5.se da o multime de puncte in plan. sa se determine aria minima a triunghiului. afisare triunghi
        //aria = 1/2 * |triunghi|
        //6.se dau 2n puncte in plan. sa se urneasca 2 cate 2, a.i distanta sa fie minima
        //7.se da o multime de puncte in plan. se cere sa se determine cercul de raza minima, care sa contina toate punctele multimii date.
        public static Rectangle rectangle;
        public static Point center;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //populate
            for (int i = 0; i < 2 * Engine.r.Next(5, 25); i++)
            {
                int width = Engine.r.Next(pictureBox1.Width);
                int height = Engine.r.Next(pictureBox1.Height);
                Engine.Points.Add(new Point(width, height));
                Engine.Dots.Add(new Dot(false, Engine.Points[Engine.Points.Count - 1]));
            }
            foreach (Point item in Engine.Points)
                Engine.g.FillEllipse(Brushes.Blue, item.X, item.Y, 5, 5);
            pictureBox1.Image = Engine.b;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Engine.b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Engine.g = Graphics.FromImage(Engine.b);
            Engine.g.Clear(Color.ForestGreen);
            pictureBox1.Image = Engine.b;
        }

        public static double Distance(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //problema 5
            double smallest = double.MaxValue, aria = 0;
            for (int i = 0; i < Engine.Points.Count; i++)
                for (int j = 0; j < Engine.Points.Count; j++)
                    for (int k = 0; k < Engine.Points.Count; k++)
                    {
                        double a = Distance(Engine.Points[i], Engine.Points[j]);
                        double b = Distance(Engine.Points[i], Engine.Points[k]);
                        double c = Distance(Engine.Points[j], Engine.Points[k]);
                        double p = (a + b + c) / 2;
                        aria = Math.Sqrt(p*(p - a)*(p-b)*(p-c));
                        if (aria < smallest && aria > 10000)
                        {
                            Engine.choosenPoints.Clear();
                            Engine.choosenPoints.Add(Engine.Points[i]);
                            Engine.choosenPoints.Add(Engine.Points[j]);
                            Engine.choosenPoints.Add(Engine.Points[k]);
                            smallest = aria;
                        }
                    }
            if (Engine.choosenPoints.Count == 3)
            TriangleDraw(Engine.choosenPoints[0], Engine.choosenPoints[1], Engine.choosenPoints[2]);
            pictureBox1.Image = Engine.b;
        }

        public static void TriangleDraw(Point dot1, Point dot2, Point dot3)
        {
            Engine.g.DrawLine(Pens.Yellow, dot1.X, dot1.Y, dot2.X, dot2.Y);
            Engine.g.DrawLine(Pens.Yellow, dot1.X, dot1.Y, dot3.X, dot3.Y);
            Engine.g.DrawLine(Pens.Yellow, dot3.X, dot3.Y, dot2.X, dot2.Y);
        }

        public static void LineDraw(Point dot1, Point dot2, Pen pen)
        {
            Engine.g.DrawLine(pen, dot1.X, dot1.Y, dot2.X, dot2.Y);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Engine.Points.Clear();
            Engine.choosenPoints.Clear();Engine.choosenDots.Clear();
            Engine.Dots.Clear();
            Engine.g.Clear(Color.ForestGreen);
            pictureBox1.Image = Engine.b;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //problema 6
            for (int i = 0; i < Engine.Dots.Count; i++)
            {
                double distance = double.MaxValue;
                for (int j = 0; j < Engine.Dots.Count; j++)
                {
                    double length = Distance(Engine.Dots[i].Point, Engine.Dots[j].Point);
                    if (length < distance && length > 0 && Engine.Dots[i].IsDrew == false && Engine.Dots[j].IsDrew == false)
                    {
                        distance = length;
                        Engine.choosenDots.Clear();
                        Engine.choosenDots.Add(Engine.Dots[i]);
                        Engine.choosenDots.Add(Engine.Dots[j]);
                    }
                }
                LineDraw(Engine.choosenDots[0].Point, Engine.choosenDots[1].Point, Pens.Red);
                foreach (Dot item in Engine.Dots)
                    if (item == Engine.choosenDots[0] || item == Engine.choosenDots[1])
                        item.IsDrew = true;
            }
            pictureBox1.Image = Engine.b;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //problema 7
            Engine.choosenPoints.Clear();
            Engine.choosenDots.Clear();
            //float down = 0, right = 0, top = pictureBox1.Height, left = pictureBox1.Width;
            //foreach (Point item in Engine.Points)
            //{
            //    if (item.X >= down)
            //        down = item.X;
            //    if (item.X <= top)
            //        top = item.X;
            //    if (item.Y >= right)
            //        right = item.Y;
            //    if (item.Y <= left)
            //        left = item.Y;
            //}
            //center.X = (int)(down - (down - top) / 2);
            //center.Y = (int)(right - (right - left) / 2);
            //float radius = Math.Abs((int)(Math.Sqrt(Math.Pow(center.X - top, 2) + Math.Pow(center.Y - left, 2))));
            //Engine.g.DrawEllipse(Pens.White, center.X - radius, center.Y - radius, 2 * radius, 2 * radius); 
            pictureBox1.Image = Engine.b;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //populate with many points
            for (int i = 0; i < 2 * Engine.r.Next(25, 100); i++)
            {
                int width = Engine.r.Next(pictureBox1.Width);
                int height = Engine.r.Next(pictureBox1.Height);
                Engine.Points.Add(new Point(width, height));
                Engine.Dots.Add(new Dot(false, Engine.Points[Engine.Points.Count - 1]));
            }
            foreach (Point item in Engine.Points)
                Engine.g.FillEllipse(Brushes.Blue, item.X, item.Y, 5, 5);
            pictureBox1.Image = Engine.b;
        }
    }
}
