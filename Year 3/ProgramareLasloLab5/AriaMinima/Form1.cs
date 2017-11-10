using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AriaMinima
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		public void RefreshBitmap()
		{
			pictureBox1.Image = Engine.bmp;
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			Engine.Init(pictureBox1.Width, pictureBox1.Height);
			Engine.initSession();
			Engine.DrawMap();
			Engine.DoMath();
			RefreshBitmap();
		}
	}
}
