using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafica
{
	public partial class Form1 : Form
	{
		public static string DrownForm;
		public static int drawX;
		public static int drawY;
		public enum Forms
		{
			None = 0,
			Triunghi = 1,
			Patrat = 2,
			Dreptunghi = 3
		}
		public Form1()
		{
			InitializeComponent();
		}

		public void Form1_Load(object sender, EventArgs e)
		{
			Engine.resx = pictureBox.Width;
			Engine.resy = pictureBox.Height;
			Engine.InitGraph();
			Engine.g.Clear(Color.ForestGreen);
			pictureBox.Image = Engine.b;
			DrownForm = Forms.None.ToString();
		}

		#region Butons

		public void btnClear_Click(object sender, EventArgs e)
		{
			Engine.g.Clear(Color.ForestGreen);
			pictureBox.Image = Engine.b;
			DrownForm = Forms.None.ToString();
			drawX = 0;
			drawY = 0;
		}

		public void btnInfo_Click(object sender, EventArgs e)
		{
			AvInfoPanel.Visible = true;
		}

		public void btnClose_Click(object sender, EventArgs e)
		{
			AvInfoPanel.Visible = false;
		}

		public void btnGenTri_Click(object sender, EventArgs e)
		{
			if (tbDrawX.Text != "" && tbDrawY.Text != "" && DrownForm == Forms.None.ToString())
			{
				drawTriunghi(Convert.ToInt32(tbDrawX.Text), Convert.ToInt32(tbDrawY.Text));
				DrownForm = Forms.Triunghi.ToString();
			}
			else
			{
				if (tbDrawX.Text == "")
				{
					MessageBox.Show("Introduce X");
				}
				else if (tbDrawY.Text == "")
				{
					MessageBox.Show("Introduce Y");
				}
				else if (DrownForm == Forms.None.ToString())
				{
					MessageBox.Show("Deseneaza o forma");
				}
			}
			pictureBox.Image = Engine.b;
		}

		public void btnGenPat_Click(object sender, EventArgs e)
		{
			if (tbDrawX.Text != "" && tbDrawY.Text != "" && DrownForm == Forms.None.ToString())
			{
				drawPatrat(Convert.ToInt32(tbDrawX.Text), Convert.ToInt32(tbDrawY.Text));
				DrownForm = Forms.Patrat.ToString();
			}
			else
			{
				if (tbDrawX.Text == "")
				{
					MessageBox.Show("Introduce X");
				}
				else if (tbDrawY.Text == "")
				{
					MessageBox.Show("Introduce Y");
				}
				else if (DrownForm == Forms.None.ToString())
				{
					MessageBox.Show("Deseneaza o forma");
				}
			}
			pictureBox.Image = Engine.b;
		}

		public void btnGenDre_Click(object sender, EventArgs e)
		{
			if (tbDrawX.Text != "" && tbDrawY.Text != "" && DrownForm == Forms.None.ToString())
			{
				drawDreptungi(Convert.ToInt32(tbDrawX.Text), Convert.ToInt32(tbDrawY.Text));
				DrownForm = Forms.Dreptunghi.ToString();
			}
			else
			{
				if (tbDrawX.Text == "")
				{
					MessageBox.Show("Introduce X");
				}
				else if (tbDrawY.Text == "")
				{
					MessageBox.Show("Introduce Y");
				}
				else if (DrownForm == Forms.None.ToString())
				{
					MessageBox.Show("Deseneaza o forma");
				}
			}
			pictureBox.Image = Engine.b;
		}

		public void btnGenTranslatie_Click(object sender, EventArgs e)
		{
			if (tbNewX.Text != "" && tbNewY.Text != "" && DrownForm != Forms.None.ToString())
			{
				if (DrownForm == Forms.Triunghi.ToString())
				{
					translatieTriunghi(Convert.ToInt32(tbNewX.Text), Convert.ToInt32(tbNewY.Text));
				}
				else if (DrownForm == Forms.Patrat.ToString())
				{
					translatiePatrat(Convert.ToInt32(tbNewX.Text), Convert.ToInt32(tbNewY.Text));
				}
				else if (DrownForm == Forms.Dreptunghi.ToString())
				{
					translatieDreptunghi(Convert.ToInt32(tbNewX.Text), Convert.ToInt32(tbNewY.Text));
				}
			}
			else
			{
				if (tbNewX.Text == "")
				{
					MessageBox.Show("Introduce X");
				}
				else if (tbNewY.Text == "")
				{
					MessageBox.Show("Introduce Y");
				}
				else if (DrownForm == Forms.None.ToString())
				{
					MessageBox.Show("Deseneaza o forma");
				}
			}
			pictureBox.Image = Engine.b;
		}

		public void btnScalar_Click(object sender, EventArgs e)
		{
			if (tbNewX.Text != "" && tbNewY.Text != "" && DrownForm != Forms.None.ToString())
			{
				if (DrownForm == Forms.Triunghi.ToString())
				{
					scalareTriunghi(drawX, drawY);
				}
				else if (DrownForm == Forms.Patrat.ToString())
				{
					scalarePatrat(drawX, drawY);
				}
				else if (DrownForm == Forms.Dreptunghi.ToString())
				{
					scalareDreptunghi(drawX, drawY);
				}
			}
			else
			{
				if (tbNewX.Text == "")
				{
					MessageBox.Show("Introduce Sx");
				}
				else if (tbNewY.Text == "")
				{
					MessageBox.Show("Introduce Sy");
				}
				else if (DrownForm == Forms.None.ToString())
				{
					MessageBox.Show("Deseneaza o forma");
				}
			}
			pictureBox.Image = Engine.b;
		}

		public void tabPage_Click(object sender, System.EventArgs e)
		{
			label3.Text = "Sy:";
			label4.Text = "Sx:";
			tbNewX.Clear();
			tbNewY.Clear();
		}

		public void tabPage2_Click(object sender, System.EventArgs e)
		{
			label3.Text = "Y:";
			label4.Text = "X";
			tbNewX.Clear();
			tbNewY.Clear();
		}

		#endregion

		public void scalareDreptunghi(double x, double y)
		{
			if (Convert.ToDouble(tbNewX.Text) > 2 && Convert.ToDouble(tbNewY.Text) > 2)
			{
				MessageBox.Show("Dimensiunea este prea mare");
			}
			else
			{
				Rectangle rect = new Rectangle((int)((x - 35)), (int)((y - 50)), (int)(50 * Convert.ToDouble(tbNewX.Text)), (int)(100 * Convert.ToDouble(tbNewY.Text)));
				SolidBrush semiTransBrush = new SolidBrush(Color.FromArgb(128, 215, 0, 0));
				Engine.g.FillRectangle(semiTransBrush, rect);
			}
		}

		public void scalarePatrat(double x, double y)
		{
			if (Convert.ToDouble(tbNewX.Text) > 2 && Convert.ToDouble(tbNewY.Text) > 2)
			{
				MessageBox.Show("Dimensiunea este prea mare");
			}
			else
			{
				Rectangle rect = new Rectangle((int)((x - 40)), (int)((y - 40)), (int)(75 * Convert.ToDouble(tbNewX.Text)), (int)(75 * Convert.ToDouble(tbNewY.Text)));
				SolidBrush semiTransBrush = new SolidBrush(Color.FromArgb(128, 215, 0, 0));
				Engine.g.FillRectangle(semiTransBrush, rect);
			}
		}

		public void scalareTriunghi(double x, double y)
		{
			if (Convert.ToDouble(tbNewX.Text) > 2 && Convert.ToDouble(tbNewY.Text) > 2)
			{
				MessageBox.Show("Dimensiunea este prea mare");
			}
			else
			{
				Point AB = new Point((int)((x + 50) * Convert.ToDouble(tbNewX.Text)), (int)((y - 50)));
				Point AC = new Point((int)((x - 50) * Convert.ToDouble(tbNewX.Text)), (int)(y - 50));
				Point BC = new Point((int)((x + 50) * Convert.ToDouble(tbNewX.Text)), (int)((y + 50)));
				PointF[] curvePoints = { AB, AC, BC };
				SolidBrush semiTransBrush = new SolidBrush(Color.FromArgb(128, 215, 0, 0));
				Engine.g.FillPolygon(semiTransBrush, curvePoints);
			}
		}

		public void translatieTriunghi (int x, int y)
		{
			Point AB = new Point((x + 50), (y - 50));
			Point AC = new Point((x - 50), (y - 50));
			Point BC = new Point((x + 50), (y + 50));
			PointF[] curvePoints = { AB, AC, BC };
			SolidBrush redBrush = new SolidBrush(Color.Red);
			Engine.g.FillPolygon(redBrush, curvePoints);
		}

		public void translatiePatrat(int x, int y)
		{
			Rectangle rect = new Rectangle(x - 40, y - 40, 75, 75);
			SolidBrush redBrush = new SolidBrush(Color.Red);
			Engine.g.FillRectangle(redBrush, rect);
		}

		public void translatieDreptunghi(int x, int y)
		{
			Rectangle rect = new Rectangle(x - 35, y - 50, 50, 100);
			SolidBrush redBrush = new SolidBrush(Color.Red);
			Engine.g.FillRectangle(redBrush, rect);

		}

		public void drawTriunghi(int x, int y)
		{
			Point AB = new Point((x + 50), (y - 50));
			Point AC = new Point((x - 50), (y - 50));
			Point BC = new Point((x + 50), (y + 50));
			PointF[] curvePoints = { AB, AC, BC };
			SolidBrush blueBrush = new SolidBrush(Color.Blue);
			Engine.g.FillPolygon(blueBrush, curvePoints);
			drawX = x;
			drawY = y;
		}

		public void drawPatrat(int x, int y)
		{
			Rectangle rect = new Rectangle(x - 40,y - 40, 75, 75);
			SolidBrush blueBrush = new SolidBrush(Color.Blue);
			Engine.g.FillRectangle(blueBrush, rect);
			drawX = x;
			drawY = y;
		}

		public void drawDreptungi(int x, int y)
		{
			Rectangle rect = new Rectangle(x - 35, y - 50, 50, 100);
			SolidBrush blueBrush = new SolidBrush(Color.Blue);
			Engine.g.FillRectangle(blueBrush, rect);
			drawX = x;
			drawY = y;
		}

	}
}
