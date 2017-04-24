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

namespace nfm
{
    public partial class Form1 : Form
    {
        static Random rnd = new Random();
        List<UINTL> T = new List<UINTL>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            for (int i = 0 ; i < 10 ; i ++)
            {
                UINTL tmp = new UINTL();
                for (int j = 0; j < rnd.Next(50); j++)
                    tmp.ADD((byte)rnd.Next(10));
                T.Add(tmp);
            }

            foreach (UINTL U in T)
            {
                listBox1.Items.Add (U.view());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextWriter dataSave = new StreamWriter(@"..\..\data.txt");
            foreach (UINTL U in T)
            {
                dataSave.WriteLine(U.view());
            }



            dataSave.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextReader dataLoad = new StreamReader(@"..\..\data.txt");
            string s;
            while ((s = dataLoad.ReadLine()) != null)
            {
                T.Add(new UINTL(s));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            foreach (UINTL U in T)
            {
                listBox2.Items.Add(U.view());
            }
        }
    }
}
