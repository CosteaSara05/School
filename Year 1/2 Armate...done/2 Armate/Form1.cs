using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Armate
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
            Engine.g.Clear(Engine.bkColor);

            Engine.resx = pictureBox1.Width;
            Engine.resy = pictureBox1.Height;

            Unit.drawSize = 10;

            for (int i = 0; i < 10; i++)
                Engine.army1.Add(new Unit(10, 5, 3, 5, 10, Color.Red));

            for (int i = 0; i < 10; i++)
                Engine.army2.Add(new Unit(20, 20, 10, 20, 30, Color.Blue));

            foreach (Unit u in Engine.army1)
                u.draw();

            foreach (Unit u in Engine.army2)
                u.draw();

            pictureBox1.Image = Engine.b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Engine.g.Clear(Engine.bkColor);
            Engine.battleWave(Engine.army1, Engine.army2);
            Engine.battleWave(Engine.army2, Engine.army1);
            Engine.army1 = Engine.army1.FindAll(delegate (Unit u)
            {
                return u.isDead == false;
            });

           Engine.army2 = Engine.army2.FindAll(delegate (Unit u)
            {
                return u.isDead == false;
            });

            foreach (Unit u in Engine.army1)
                u.draw();

            foreach (Unit u in Engine.army2)
                u.draw();

            pictureBox1.Image = Engine.b;
        }
    }
}
