using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DeseneGeometrice
{
    class Triunghi
    {
        float x1, y1, x2, y2, x3, y3;
        public Triunghi(float x1, float y1, float x2, float y2, float x3, float y3)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
        }
        public void draw()
        {
            Engine.g.DrawLine(Pens.Blue, x1, y1, x2, y2);
            Engine.g.DrawLine(Pens.Blue, x3, y3, x2, y2);
            Engine.g.DrawLine(Pens.Blue, x1, y1, x3, y3);
        }
    }
}
