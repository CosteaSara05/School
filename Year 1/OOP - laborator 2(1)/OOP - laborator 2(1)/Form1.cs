using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP___laborator_2_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //se da un punct cu proprietatile x,y, viteza (s) float si directia (a) float
        //construieste urmatorul mecanism
        public Graphics g;
        public Bitmap b;
        List<Punct> myP = new List<Punct>();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            b = new Bitmap(pictureBox1.Width,pictureBox1.Height);
            g = Graphics.FromImage(b);
            //g.DrawLine(Pens.Red, 0, 0, 200, 200);

            for (int i = 0; i < 20; i++)
            {
                Punct T = new Punct(pictureBox1.Width, pictureBox1.Height);
                T.d = 10;
                myP.Add(T);
            }
            //foreach (Punct p in myP)
            //    p.Draw(g);
            //foreach (Punct p in myP)
            //    p.Update();
            //foreach (Punct p in myP)
            //    p.Draw(g);

            pictureBox1.Image = b;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Punct p in myP)
            {
                g.Clear(Color.Yellow);
                p.Update();
                p.Draw(g);
            }
            pictureBox1.Image = b;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
