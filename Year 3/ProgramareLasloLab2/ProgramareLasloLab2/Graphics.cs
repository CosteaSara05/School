using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProgramareLasloLab2
{
	public static partial class Engine
	{
		public static Graphics g;
		public static Bitmap b;
		public static int maxX;
		public static int maxY;
		public static Color backColor = Color.FromArgb(200, 200, 200);

		public static void initGraph(int x, int y)
		{
			maxX = x;
			maxY = y;
			b = new Bitmap(x, y);
			g = Graphics.FromImage(b);
			g.Clear(backColor);

		}

	}
}
