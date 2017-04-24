using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Simplu");
            comboBox1.Items.Add("Mediu");
            comboBox1.Items.Add("Extins");
        }

        private void Nume_TextChanged(object sender, EventArgs e)
        {
            string n = Nume.Text;
        }

        private void Prenume_TextChanged(object sender, EventArgs e)
        {
            string pn = Prenume.Text;
        }

        private void Mobil_TextChanged(object sender, EventArgs e)
        {
            long m = long.Parse(Mobil.Text);
        }

        private void Fix_TextChanged(object sender, EventArgs e)
        {
            long f = long.Parse(Fix.Text);
        }

        private void Varsta_TextChanged(object sender, EventArgs e)
        {
            long v = long.Parse(Varsta.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Simplu")
                panel1.Visible = true;
            if (comboBox1.Text == "Mediu")
            {
                panel1.Visible = true;
                panel2.Visible = true;
            }
            if (comboBox1.Text == "Extins")
            {
                panel1.Visible = true;
                panel2.Visible = true;
                panel3.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (comboBox1.Text == "Simplu")
            {
                Afisare.Items.Add("Nume: " + Nume.Text);
                Afisare.Items.Add("Prenume: " + Prenume.Text);
                Afisare.Items.Add("Mobil: " + Mobil.Text);
                
            }
            if (comboBox1.Text == "Mediu")
            {
                Afisare.Items.Add("Nume: " + Nume.Text);
                Afisare.Items.Add("Prenume: " + Prenume.Text);
                Afisare.Items.Add("Mobil: " + Mobil.Text);
                Afisare.Items.Add("Fix: " + Fix.Text);
            }
            if (comboBox1.Text == "Extins")
            {
                Afisare.Items.Add("Nume: " + Nume.Text);
                Afisare.Items.Add("Prenume: " + Prenume.Text);
                Afisare.Items.Add("Mobil: " + Mobil.Text);
                Afisare.Items.Add("Fix: " + Fix.Text);
                Afisare.Items.Add("Varsta: " + Varsta.Text);
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
