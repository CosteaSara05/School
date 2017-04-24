using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int i,j;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            label1.Text = i.ToString();
            label2.Text = j.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                        timer1.Enabled = true;
            timer2.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            i = 0;
            j = 0;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            j++;
            label1.Text = i.ToString();
            label2.Text = j.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
