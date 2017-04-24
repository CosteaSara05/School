using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Agar
{
	class Dot
	{
		public PointF Point;
		public Brush brush;
		public float dimension;
		public float speedx;
		public float speedy;
		public float lastx;
		public float lasty;

		public Dot(Brush brush, PointF Point, float dimension, float speedx, float speedy, float lastx, float lasty)
		{
			this.brush = brush;
			this.Point = Point;
			this.dimension = dimension;
			this.speedx = speedx;
			this.speedy = speedy;
			this.lastx = lastx;
			this.lasty = lasty;
		}

	}
}
