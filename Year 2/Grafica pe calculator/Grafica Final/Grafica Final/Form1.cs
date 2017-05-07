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

		public void drawTriunghi(int x, int y)
		{
			Point AB = new Point((x + 50 / 2), (y - 50 / 2));
			Point AC = new Point((x - 50 / 2), (y - 50 / 2));
			Point BC = new Point((x + 50 / 2), (y + 50 / 2));
			PointF[] curvePoints = { AB, AC, BC };
			System.Drawing.Drawing2D.FillMode newFillMode = System.Drawing.Drawing2D.FillMode.Winding;
			SolidBrush blueBrush = new SolidBrush(Color.Blue);
			Engine.g.FillPolygon(blueBrush, curvePoints, newFillMode);
		}
	}
}
