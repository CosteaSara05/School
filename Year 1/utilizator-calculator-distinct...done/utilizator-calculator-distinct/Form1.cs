using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace utilizator_calculator_distinct
{//calculatorul genereaza un numar de 4 cifre distincte(nc)
 //utilizatorul introduce un numar de 4 cifre distincte(nu)
 //(se forteaza un numar corect definit)
 //se afiseaza valorile p si c astfel
 //p -> reprezinta totalitatea cifrelor distincte
 //intre nu si nc pe pozitii diferite
 //c-> analog(pe pozitii identice)
 //ex nc = 2963
 //   nu = 2619
 //numarul nc este invizibil si utilizatorul introduce numere nu pana cand se ajunge la nc
    public partial class Form1 : Form
    {
        public static Random r = new Random();
        public static string asd = "";
        public static List<int> lst = new List<int>(4);
        public static int click = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public string nc()
        {
            for (int i = 0; i < 4; i++)
            {
                int number;
                do number = r.Next(10);
                while (lst.Contains(number));
                lst.Add(number);
            }
            string n = "";
            foreach (var item in lst)
                n += item;

            return n;
        }

        public int peul()
        {
            int n = Convert.ToInt32(textBox1.Text);
            int m = Convert.ToInt32(textBox2.Text);
            int[] ncal = new int[4];
            int[] nutil = new int[4];
            for (int i = ncal.Length - 1; i >= 0; i--)
            {
                ncal[i] = n % 10;
                n = n / 10;
                nutil[i] = m % 10;
                m = m / 10;
            }
            int p = 0;
            for (int i = 0; i < 4; i++)
                if (ncal[i] == nutil[i])
                    p++;
            return p;
        }
        public int ceul()
        {
            int n = Convert.ToInt32(textBox1.Text);
            int m = Convert.ToInt32(textBox2.Text);
            int[] ncal = new int[4];
            int[] nutil = new int[4];
            for (int i = ncal.Length - 1; i >= 0; i--)
            {
                ncal[i] = n % 10;
                n = n / 10;
                nutil[i] = m % 10;
                m = m / 10;
            }
            int c = 0;
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    if ((ncal[i] == nutil[j]) && (i != j))
                        c++;
            return c;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = nc().ToString();
            textBox1.Visible = false;
            numargasit.Visible = false;
            textBoxTurn.Text = click.ToString();
        }

        #region cifrele
        private void cifra1_Click(object sender, EventArgs e)
        {
            if (asd.Length < 4)
            {
                asd = asd + "1";
                textBox2.Text = asd.ToString();
                cifra1.Enabled = false;
            }
        }

        private void cifra2_Click(object sender, EventArgs e)
        {
            if (asd.Length < 4)
            {
                asd = asd + "2";
                textBox2.Text = asd.ToString();
                cifra2.Enabled = false;
            }
        }

        private void cifra3_Click(object sender, EventArgs e)
        {
            if (asd.Length < 4)
            {
                asd = asd + "3";
                textBox2.Text = asd.ToString();
                cifra3.Enabled = false;
            }
        }

        private void cifra4_Click(object sender, EventArgs e)
        {
            if (asd.Length < 4)
            {
                asd = asd + "4";
                textBox2.Text = asd.ToString();
                cifra4.Enabled = false;
            }
        }

        private void cifra5_Click(object sender, EventArgs e)
        {
            if (asd.Length < 4)
            {
                asd = asd + "5";
                textBox2.Text = asd.ToString();
                cifra5.Enabled = false;
            }
        }

        private void cifra6_Click(object sender, EventArgs e)
        {
            if (asd.Length < 4)
            {
                asd = asd + "6";
                textBox2.Text = asd.ToString();
                cifra6.Enabled = false;
            }
        }

        private void cifra7_Click(object sender, EventArgs e)
        {
            if (asd.Length < 4)
            {
                asd = asd + "7";
                textBox2.Text = asd.ToString();
                cifra7.Enabled = false;
            }
        }

        private void cifra8_Click(object sender, EventArgs e)
        {
            if (asd.Length < 4)
            {
                asd = asd + "8";
                textBox2.Text = asd.ToString();
                cifra8.Enabled = false;
            }
        }

        private void cifra9_Click(object sender, EventArgs e)
        {
            if (asd.Length < 4)
            {
                asd = asd + "9";
                textBox2.Text = asd.ToString();
                cifra9.Enabled = false;
            }
        }

        private void cifra0_Click(object sender, EventArgs e)
        {
            if (asd.Length < 4)
            {
                asd = asd + "0";
                textBox2.Text = asd.ToString();
                cifra0.Enabled = false;
            }
        }
        #endregion

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                numargasit.Visible = true;
                textBox1.Visible = true;
            }
            click++;
            textBoxTurn.Text = click.ToString();
            textBoxp.Clear();
            textBoxp.Text = peul().ToString();
            textBoxc.Clear();
            textBoxc.Text = ceul().ToString();
            listBox1.Items.Add("--------------------------------------");
            listBox1.Items.Add(asd);
            listBox1.Items.Add(textBoxp.Text);
            listBox1.Items.Add(textBoxc.Text);
            textBox2.Clear();
            asd = "";
            cifra0.Enabled = true;
            cifra1.Enabled = true;
            cifra2.Enabled = true;
            cifra3.Enabled = true;
            cifra4.Enabled = true;
            cifra5.Enabled = true;
            cifra6.Enabled = true;
            cifra7.Enabled = true;
            cifra8.Enabled = true;
            cifra9.Enabled = true;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
