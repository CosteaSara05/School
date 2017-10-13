using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramareLasloLab2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		void ShowMatinList()
		{
			for (int i = 0; i < Engine.NOP; i++)
			{
				string t = "";
				for (int j = 0; j < Engine.NOP; j++)
				{
					t += Engine.MA[i, j] + " ";
				}
				listBox1.Items.Add(t);
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Engine.intSesion();
			ShowMatinList();
			Engine.initGraph(pictureBox1.Width, pictureBox1.Height);
			Sol test = new Sol();
			test.Draw();
			pictureBox1.Image = Engine.b;
		}
	}
}
