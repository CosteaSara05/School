using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafuri_planare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Engine.initGraph(pictureBox1.Width, pictureBox1.Height);
            Engine.initSession();
            string t = "";
            for (int i = 0; i < Engine.nod; i++)
            {
                for (int j = 0; j < Engine.nod; j++)
                {
                    t += Engine.ma[i, j];
                }
                listBox1.Items.Add(t);
                t = "";
            }
            pictureBox1.Image = Engine.b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Engine.g.Clear(Engine.bkColor);
            Sol test = new Sol(true);
            test.draw();
            textBox1.Text = test.ni.ToString();
            pictureBox1.Image = Engine.b;
        }
    }
}
