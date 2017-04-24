using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Computational_Geometry___Laszlo_Explain
{
    class Engine
    {
        public static Bitmap bmp;
        public static Graphics grp;
        public static int resx;
        public static int resy;
        public static void InitGraph()
        {
            bmp = new Bitmap(resx, resy);
            grp = Graphics.FromImage(bmp);
        }
        public static List<PointF> myPoint = new List<PointF>();
        public static int n = 25;
        public static Random r = new Random();
        public static void initPoint()
        {
            for (int i = 0; i < n; i++)
            {
                PointF New = new PointF(r.Next(resx), r.Next(resy));
                myPoint.Add(New);
            }
        }
        public static void draw()
        {
            foreach (PointF p in myPoint)
                grp.FillEllipse(Brushes.Black, p.X, p.Y, 4, 4);

            for (int i = 0; i < n - 1; i++)
                grp.DrawLine(Pens.Red, myPoint[i], myPoint[i + 1]);

            grp.DrawLine(Pens.Red, myPoint[0], myPoint[n - 1]);
        }
        public static float D(PointF A, PointF B, PointF C)
        {
            return A.X * B.Y + B.X * C.Y + A.Y * C.X - C.X * B.Y - B.X * A.Y - A.X * C.Y;
        }
        public static float doMath()
        {
            PointF baza = new PointF(r.Next(resx), r.Next(resy));
            float aria = 0;
            for (int i = 0; i < n - 1; i++)
                aria += D(myPoint[i + 1], myPoint[i + 1], baza);

            aria += D(myPoint[0], myPoint[n - 1], baza);
            return aria;
        }
    }
}
