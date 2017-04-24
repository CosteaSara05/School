using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeseneGeometrice2___cu_ingeritage
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
            Engine.g.Clear(Color.Aqua);

            for (int i = 0; i < Engine.r.Next(1, 10); i++)
            {
                Engine.Figura.Add(new Cerc(Engine.r.Next(pictureBox1.Width), (Engine.r.Next(pictureBox1.Height)), (Engine.r.Next(0, 500))));
                Engine.Figura.Add(new Triunghi(Engine.r.Next(pictureBox1.Width), Engine.r.Next(pictureBox1.Height), Engine.r.Next(pictureBox1.Width), Engine.r.Next(pictureBox1.Height), Engine.r.Next(pictureBox1.Width), Engine.r.Next(pictureBox1.Width)));
            }

            foreach (Figg f in Engine.Figura)
                f.draw();

            pictureBox1.Image = Engine.b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Engine.Figura.Clear();
            Engine.g.Clear(Color.Aqua);
            for (int i = 0; i < Engine.r.Next(1, 10); i++)
            {
                Engine.Figura.Add(new Cerc(Engine.r.Next(pictureBox1.Width), (Engine.r.Next(pictureBox1.Height)), (Engine.r.Next(0, 500))));
                Engine.Figura.Add(new Triunghi(Engine.r.Next(pictureBox1.Width), Engine.r.Next(pictureBox1.Height), Engine.r.Next(pictureBox1.Width), Engine.r.Next(pictureBox1.Height), Engine.r.Next(pictureBox1.Width), Engine.r.Next(pictureBox1.Width)));
            }

            foreach (Figg f in Engine.Figura)
                f.draw();
            pictureBox1.Image = Engine.b;
        }
    }
}
