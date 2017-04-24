using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

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
        int tick;
        public static Random r = new Random();
        public static string asd = "";
        public static List<int> lst = new List<int>(4);
        public static int incercari = 0;
        public static int c = 0;
        public static int po = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public string nc()
        {
            for (int i = 0; i < 4; i++)
            {
                int number;
                do number = r.Next(1,10);
                while (lst.Contains(number));
                lst.Add(number);
            }
            string n = "";
            foreach (var item in lst)
                n += item;

            return n;
        }

        public int ceul_bot(int m)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int[] ncal = new int[4];
            int[] nutil = new int[4];
            for (int i = ncal.Length - 1; i >= 0; i--)
            {
                ncal[i] = n % 10;
                n /= 10;
                nutil[i] = m % 10;
                m /= 10;
            }
            c = 0;
            for (int i = 0; i < 4; i++)
            {
                    for (int j = 0; j < 4; j++)
                            if ((ncal[i] == nutil[j]) && (j != i))
                                c++;
            }
            return c;
        }
        public int peul_bot(int ms)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int[] ncal = new int[4];
            int[] nutil = new int[4];
            for (int i = ncal.Length - 1; i >= 0; i--)
            {
                ncal[i] = n % 10;
                n = n / 10;
                nutil[i] = ms % 10;
                ms = ms / 10;
            }
            po = 0;
            for (int i = 0; i < 4; i++)
                if (ncal[i] == nutil[i])
                    po++;

            return po;
        }
        public void bot()
        {
            int[] actual = new int[] {0,0,0,0};
            int i = 0;
            int maxp = peul_bot(actual[0] * 1000 + actual[1] * 100 + actual[2] * 10 + actual[3]);
            if (maxp!=4)
            {
                while (maxp != 4)
                            {                
                                int j_schimbat = 0;
                                for (int j = 1; j < 11; j++)
                                {
                                    incercari++;
                                    if (j == 10)
                                        j = 0;
                                    actual[i] = j;
                        textBoxNumarGata.Clear();
                        textBoxNumarGata.Text = (actual[0] * 1000 + actual[1] * 100 + actual[2] * 10 + actual[3]).ToString();
                        textBoxNumarGata.Refresh();
                        textBoxTurn.Text = incercari.ToString();
                        textBoxc.Text = ceul_bot(actual[0] * 1000 + actual[1] * 100 + actual[2] * 10 + actual[3]).ToString();
                        textBoxTurn.Refresh();
                        textBoxp.Text = po.ToString();
                        textBoxp.Refresh();
                        listBox1.Items.Add("c: " + textBoxc.Text);
                        listBox1.Items.Add("p: " + textBoxp.Text);
                        listBox1.Items.Add(textBoxNumarGata.Text);
                        listBox1.Items.Add("--------------");
                        //System.Threading.Thread.Sleep(100);
                        if ((peul_bot(actual[0] * 1000 + actual[1] * 100 + actual[2] * 10 + actual[3]) > maxp) || (j == 0))
                                    {
                            j_schimbat = j;
                            if (j != 0)
                                        maxp++;
                                        break;
                                    }    
                                }
                    actual[i] = j_schimbat;
                                i++;
                    /*if (i == 4)
                        i = 0;*/
                            }
            }

            if (textBox1.Text == textBoxNumarGata.Text)
            {
                numargasit.Visible = true;
                textBox1.Visible = true;
                textBoxc.Text = "0";
                textBoxc.Refresh();
                textBoxp.Text = "4";
                textBoxp.Refresh();
                timer1.Enabled = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tick = 0;
            textBox1.Text = nc().ToString();
            textBox1.Visible = false;
            numargasit.Visible = false;
            textBoxTurn.Text = incercari.ToString();
        }

        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxp_TextChanged(object sender, EventArgs e)
        {

        }

        private void Verificare_Click(object sender, EventArgs e)
        {
            incercari = 0;
            timer1.Enabled = true;
            bot();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tick++;
            labelCeas.Text = tick.ToString();
        }
    }
}
