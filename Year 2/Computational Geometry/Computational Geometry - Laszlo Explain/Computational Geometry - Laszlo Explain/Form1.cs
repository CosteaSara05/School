using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computational_Geometry___Laszlo_Explain
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
            Engine.grp.Clear(Color.ForestGreen);
            Pen cr02 = new Pen(Color.Red, 2);
            Engine.initPoint();
            Engine.draw();
            pictureBox1.Image = Engine.bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Engine.grp.Clear(Color.ForestGreen);
            Engine.myPoint.Clear();
            Engine.initPoint();
            Engine.draw();
            pictureBox1.Image = Engine.bmp;
        }
    }
}
