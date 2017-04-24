using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DeseneGeometrice
{
    class Cerc
    {
        float x, y, l;


        public Cerc (float x, float y, float l)
        {
            this.x = x;
            this.y = y;
            this.l = l;
        }

        public void draw()
        {
            Engine.g.DrawEllipse(Pens.Red, x - l, y - l, l * 2, l * 2);
        }
    }
}
