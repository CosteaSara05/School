using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProgramareLasloLab2
{
	public class Sol
	{
		public PointF[] x;
		public int NOI;

		public Sol()
		{
			NOI = 0;
			x = new PointF[Engine.NOP];
			for (int i = 0; i < Engine.NOP; i++)
			{
				x[i].X = Engine.r.Next(Engine.maxX);
				x[i].Y = Engine.r.Next(Engine.maxY);
			}
		}

		public void Draw()
		{
			for (int i = 0; i < Engine.NOP; i++)
			{
				Engine.g.DrawEllipse(Pens.Black, x[i].X - 4, x[i].Y - 4, 8, 8);
			}
			for (int i = 0; i < Engine.NOP; i++)
			{
				for (int j = 0; j < Engine.NOP; j++)
				{
					if (Engine.MA[i,j] == 1)
					{
						Engine.g.DrawLine(Pens.Black, x[i], x[j]);
					}
				}
			}
		}

		public void CalculNOI()
		{
			NOI = 0;
			for (int i = 0; i < Engine.NOP; i++)
			{
				for (int j = 0; j < Engine.NOP; j++)
				{

				}
			}
		}
	}
}
