using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP___laborator_2_1_
{
    class Punct
    {
        float x;
        float y;
        float speed;
        float alfa;
        Color fillColor;
        public int d;
        public Punct(int x, int y)
        {
            this.x = (float)Engine.r.Next(x);
            this.y = (float)Engine.r.Next(y);
            speed = (float)Engine.r.Next(10);
            alfa = (float)(Engine.r.NextDouble() * 6.293);
            this.fillColor = Color.FromArgb(Engine.r.Next(256), Engine.r.Next(256), Engine.r.Next(256));
        }
        public void Draw (Graphics g)
        {
            g.FillEllipse(new SolidBrush(fillColor), x - d, y - d, 2*d, 2*d);
            g.DrawEllipse(Pens.Black, x - d, y - d, 2*d, 2*d);
        }
        public void Update ()
        {
            x = x + (float)(speed * Math.Cos(alfa));
            y = y + (float)(speed * Math.Sin(alfa));
        }
    }
}
