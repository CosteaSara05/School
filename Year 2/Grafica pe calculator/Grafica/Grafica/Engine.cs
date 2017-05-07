using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Grafica
{
	public class Engine
	{
		public static Bitmap b;
		public static Graphics g;
		public static int resx;
		public static int resy;
		public static void InitGraph()
		{
			b = new Bitmap(resx, resy);
			g = Graphics.FromImage(b);
		}
		public static List<PointF> myPoint = new List<PointF>();
		public static int n = 25;
		public static Random r = new Random();
	}
}
