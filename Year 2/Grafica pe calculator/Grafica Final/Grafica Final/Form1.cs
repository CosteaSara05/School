using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafica_Final
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form_Load(object sender, EventArgs e)
		{
			Engine.resx = pictureBox.Width;
			Engine.resy = pictureBox.Height;
			Engine.InitGraph();
			Engine.g.Clear(Color.ForestGreen);
			Engine.initPoint();
			Engine.draw();
			pictureBox.Image = Engine.b;
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			tbDrawX.Clear();
			tbDrawY.Clear();
			tbNewX.Clear();
			tbNewY.Clear();
			Engine.g.Clear(Color.ForestGreen);
		}

		private void btnInfo_Click(object sender, EventArgs e)
		{
			AvInfoPanel.Visible = true;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			AvInfoPanel.Visible = false;
		}

		private void btnGenTri_Click(object sender, EventArgs e)
		{
			
		}

		private void btnGenPat_Click(object sender, EventArgs e)
		{

		}

		private void btnGenDre_Click(object sender, EventArgs e)
		{

		}

		private void btnGenTranslatie_Click(object sender, EventArgs e)
		{

		}
	}
}
