using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._11._2017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Engine.Init(pictureBox1.Width, pictureBox1.Height);
            Engine.InitSession(20);
            Engine.DrawMap();
            RefreshBitmap();
        }

        private void RefreshBitmap()
        {
            pictureBox1.Image = Engine.bmp;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Engine.Time();
            Engine.DrawMap();
            RefreshBitmap();
            textBox1.Text = Engine.Particles.Count.ToString();
            textBox2.Text = Engine.Pradatorii.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
