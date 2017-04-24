using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Speeds
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}


		public void Go(string c)
		{
			double speed = 0;
			while (c == "W" || c == "w")
			{
				Speedlbl.Text = speed.ToString();
				speed += 1.1;
				c = Convert.ToString(Console.ReadKey());
			}
			while (c == "S" || c == "s")
			{
				Speedlbl.Text = speed.ToString();
				speed -= 3.4;
				c = Convert.ToString(Console.ReadKey());
			}
			while (c == null)
			{
				Speedlbl.Text = speed.ToString();
				speed -= 0.6;
				c = Convert.ToString(Console.ReadKey());
			}
		}

		public void StartBtn_Click(object sender, EventArgs e)
		{
			Speedlbl.Visible = true;
			label1.Visible = true;
			StartBtn.Visible = false;
			string c = Convert.ToString(Console.ReadKey());
			while (c != "cvbrty34e g")
			{
				Go(c);
				if (c == Keys.Escape.ToString())
				{
					Speedlbl.Visible = false;
					label1.Visible = false;
					StartBtn.Visible = true;
				}
			}
		}
	}
}
