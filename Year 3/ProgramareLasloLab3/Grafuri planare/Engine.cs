using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Grafuri_planare
{
    public static class Engine
    {
        public static int nod = 15;
        public static Random r = new Random();
        public static int[,] ma;
        public static int links = 20;
        public static void initSession()
        {
            ma = new int[nod, nod];
            for(int i=0; i<=links; i++)
            {
                int l = r.Next(nod);
                int c = r.Next(nod);
                if(l != c)
                {
                    ma[l, c] = 1;
                    ma[c, l] = 1;
                }
            }
        }
        public static int resx;
        public static int resy;
        public static Bitmap b;
        public static Graphics g;
        public static Color bkColor = Color.LightBlue;

        public static void initGraph(int x, int y)
        {
            resx = x;
            resy = y;
            b = new Bitmap(x, y);
            g = Graphics.FromImage(b);
            g.Clear(bkColor);
        }

        public static PointF rndPoint()
        {
            float x = (float)r.Next(resx);
            float y = (float)r.Next(resy);
            return new PointF(x, y);
        }

        public static PointF intersectie(PointF a, PointF b, PointF c, PointF d)
        {
            float t1 = b.X - a.X;
            float t2 = b.Y - a.Y;
            float t3 = d.X - c.X;
            float t4 = d.Y - c.Y;
            float d1 = t2 * a.X - t1 * a.Y;
            float d2 = t4 * c.X - t3 * c.Y;
            float ds = t4 * t1 - t2 * t3;
            float dx = d2 * t1 - d1 * t3;
            float dy = d2 * t2 - t4 * d1;
            if (ds != 0)
            {

                float xx = dx / ds;
                float xy = dy / ds;

                float minx1 = a.X;
                float maxx1 = a.X;
                if (b.X < minx1)
                    minx1 = b.X;
                if (b.X > maxx1)
                    maxx1 = b.X;

                float miny1 = a.Y;
                float maxy1 = a.Y;
                if (b.Y < miny1)
                    miny1 = b.Y;
                if (b.Y > maxy1)
                    maxy1 = b.Y;

                float minx2 = c.X;
                float maxx2 = c.X;
                if (d.X < minx2)
                    minx2 = d.X;
                if (d.X > maxx2)
                    maxx2 = d.X;

                float miny2 = c.Y;
                float maxy2 = c.Y;
                if (d.Y < miny2)
                    miny2 = d.Y;
                if (d.Y > maxy2)
                    maxy2 = d.Y;

                if (xx > minx1 && xx < maxx1 && xy > miny1 && xy < maxy1 && xx > minx2 && xx < maxx2 && xy > miny2 && xy < maxy2) 
                    return new PointF(dx / ds, dy / ds);
            }
            return PointF.Empty;
        }
    }
}
