using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritage_Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Engine.r.Next(50); i++)
                Engine.Autoturisme.Add(new Car(Car.loc, Car.totalval, Car.pasag));
            Engine.Autoturisme.Add(new Moto(Moto.loc, Moto.totalval, Moto.pasag));
        }
    }
}
