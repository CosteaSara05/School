using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AriaMinima
{
	public class Triangle
	{
		public PointF A;
		public PointF B;
		public PointF C;
		public float aria;
		public float Aria(PointF A, PointF B, PointF C)
		{
			float d = A.X * B.Y + B.X * C.Y + A.Y * C.X - B.Y * C.X - B.X * A.Y - C.Y * A.X;
			float a = (1.0F / 2.0F) * Math.Abs(d);
			return a;
		}
		public Triangle(PointF A, PointF B, PointF C)
		{
			this.A = A;
			this.B = B;
			this.C = C;
			aria = Aria(A, B, C);
		}

		public void Draw()
		{
			Engine.g.DrawLine(Pens.Red, A, B);
			Engine.g.DrawLine(Pens.Red, A, C);
			Engine.g.DrawLine(Pens.Red, B, C);
		}

	}
}
