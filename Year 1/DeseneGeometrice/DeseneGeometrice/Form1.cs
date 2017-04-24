using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeseneGeometrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //construieste fig geom dupa 3 coordonate (x,y,l) - cerc sau 6 coord x1,y1,x2,y2,x3,y3 - triunghi
            Engine.b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Engine.g = Graphics.FromImage(Engine.b);
            Engine.g.Clear(Color.Aqua);

            pictureBox1.Image = Engine.b;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Engine.g.Clear(Color.Aqua);
            Engine.Ce.Clear();
            Engine.Tr.Clear();

            for (int i = 0; i < Engine.r.Next(1, 20); i++)
            {
                Engine.Ce.Add(new Cerc(Engine.r.Next(pictureBox1.Width), (Engine.r.Next(pictureBox1.Height)), (Engine.r.Next(0, 500))));
                Engine.Tr.Add(new Triunghi(Engine.r.Next(pictureBox1.Width), Engine.r.Next(pictureBox1.Height), Engine.r.Next(pictureBox1.Width), Engine.r.Next(pictureBox1.Height), Engine.r.Next(pictureBox1.Width), Engine.r.Next(pictureBox1.Width)));
            }

            foreach (Cerc c in Engine.Ce)
                c.draw();

            foreach (Triunghi t in Engine.Tr)
                t.draw();

            pictureBox1.Image = Engine.b;
        }
    }
}
