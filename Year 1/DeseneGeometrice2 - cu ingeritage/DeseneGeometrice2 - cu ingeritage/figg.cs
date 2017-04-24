using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace DeseneGeometrice2___cu_ingeritage
{
      public abstract class Figg
    {
        public abstract void draw();
    }


    public class Cerc : Figg
    {
        float x, y, l;

        public Cerc(float x, float y, float l)
        {
            this.x = x;
            this.y = y;
            this.l = l;
        }

        public override void draw()
        {
            Engine.g.DrawEllipse(Pens.Red, x - l, y - l, l * 2, l * 2);
        }
    }
     public class Triunghi : Figg
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
        public override void draw()
        {
            Engine.g.DrawLine(Pens.Blue, x1, y1, x2, y2);
            Engine.g.DrawLine(Pens.Blue, x3, y3, x2, y2);
            Engine.g.DrawLine(Pens.Blue, x1, y1, x3, y3);
        }
    }

}
